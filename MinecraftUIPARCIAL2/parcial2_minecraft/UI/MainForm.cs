using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MinecraftManager.UI
{
    public partial class MainForm : Form
    {
        private int accionActual = 0;
        private int accionActualBloque = 0;
        private int accionActualInventario = 0;
        private int contadorClicks = 0;// 0 significa ninguna acción seleccionada
        private readonly JugadorService jugadorService; // Servicio para manejar jugadores
        private readonly BloqueService bloqueService; // Servicio para manejar bloques
        private readonly InventarioService inventarioService;


        public MainForm()
        {
            InitializeComponent();
            jugadorService = new JugadorService(new DatabaseManager()); // Inicialización del servicio
            bloqueService = new BloqueService(new DatabaseManager());
            inventarioService = new InventarioService(new DatabaseManager(), jugadorService, bloqueService);


            comboBoxTipoBloque.Items.AddRange(new string[] { "Madera", "Mineral" });
            comboBoxRarezaBloque.Items.AddRange(new string[] { "Común", "Raro", "Épico" });
            LlenarComboBoxJugadores();
            LlenarComboBoxBloques();
        }

        private void JugadorForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            accionActual = 1; // Registrar
            ConfigurarControles();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            accionActual = 2; // Buscar
            ConfigurarControles();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            accionActual = 3; // Actualizar
            ConfigurarControles();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            accionActual = 4; // Eliminar
            ConfigurarControles();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            accionActual = 5; // Listar
            ConfigurarControles();
            ListarJugadores();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case 1: 
                    RegistrarJugador();
                    break;

                case 2: 
                    BuscarJugador();
                    break;

                case 3: 
                    ActualizarJugador();
                    break;

                case 4: 
                    ManejarEliminarJugador();
                    break;

                default:
                    MessageBox.Show("Seleccione una acción antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void RegistrarJugador()
        {
            var jugador = new Jugador
            {
                Nombre = textBoxNombre.Text,
                Nivel = (int)numericUpDownNivel.Value,
                FechaCreacion = DateTime.Now // Fecha actual generada automáticamente
            };

            jugadorService.Crear(jugador);

            // Mostrar el ID generado en el campo ID
            textBoxId.Text = jugador.Id.ToString();

            MessageBox.Show("¡Jugador registrado con éxito!");
            LimpiarCampos();
            ListarJugadores();
            LlenarComboBoxJugadores();
        }
        private void BuscarJugador()
        {
            if (!int.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jugador = jugadorService.ObtenerPorId(id);

            if (jugador != null)
            {
                textBoxNombre.Text = jugador.Nombre;
                numericUpDownNivel.Value = jugador.Nivel;
                textBoxFechaCreacion.Text = jugador.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");

                // Mostrar en el DataGridView
                dataGridViewJugadores.DataSource = new List<Jugador> { jugador };
            }
            else
            {
                MessageBox.Show("Jugador no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarJugador()
        {
            if (!int.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jugador = jugadorService.ObtenerPorId(id);

            if (jugador != null)
            {
                jugador.Nombre = textBoxNombre.Text;
                jugador.Nivel = (int)numericUpDownNivel.Value;
                jugadorService.Actualizar(jugador);

                MessageBox.Show("¡Jugador actualizado con éxito!");
                LimpiarCampos();
                ListarJugadores();
            }
            else
            {
                MessageBox.Show("Jugador no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ManejarEliminarJugador()
        {
            contadorClicks++; // Incrementar el contador de clics

            if (contadorClicks == 1)
            {
                // Primer clic: buscar al jugador y confirmar
                BuscarJugador(); // Reutilizar el método BuscarJugador

                if (!string.IsNullOrEmpty(textBoxNombre.Text)) // Verificar si se encontró un jugador
                {
                    MessageBox.Show("Jugador encontrado. Presione 'Guardar' nuevamente para confirmar la eliminación.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    contadorClicks = 0; // Reiniciar el contador si no se encuentra el jugador
                }
            }
            else if (contadorClicks == 2)
            {
                // Segundo clic: eliminar al jugador
                if (!int.TryParse(textBoxId.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contadorClicks = 0; // Reiniciar el contador si hay un error
                    return;
                }

                jugadorService.Eliminar(id);

                MessageBox.Show("¡Jugador eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ListarJugadores();

                contadorClicks = 0; // Reiniciar el contador después de eliminar
            }
        }

        private void ListarJugadores()
        {
            var jugadores = jugadorService.ObtenerTodos();

            dataGridViewJugadores.DataSource = null;
            dataGridViewJugadores.DataSource = jugadores;
        }

        private void LimpiarCampos()
        {
            textBoxId.Clear(); // Limpiar ID
            textBoxNombre.Clear(); // Limpiar Nombre
            numericUpDownNivel.Value = 1; // Restablecer Nivel al valor mínimo
            textBoxFechaCreacion.Clear(); // Limpiar el campo "Creado"
        }

        private void ConfigurarControles()
        {
            // Deshabilitar todos los campos por defecto
            textBoxId.Enabled = false; // ID siempre deshabilitado
            textBoxNombre.Enabled = false;
            numericUpDownNivel.Enabled = false;
            textBoxFechaCreacion.Enabled = false; // Creado siempre deshabilitado

            // Habilitar campos según la acción seleccionada
            switch (accionActual)
            {
                case 1: // Registrar
                    textBoxNombre.Enabled = true;
                    numericUpDownNivel.Enabled = true;
                    break;

                case 2: // Buscar
                    textBoxId.Enabled = true; // Solo se habilita el ID para buscar
                    break;

                case 3: // Actualizar
                    textBoxId.Enabled = true; // ID para buscar, pero no editable
                    textBoxNombre.Enabled = true;
                    numericUpDownNivel.Enabled = true;
                    break;

                case 4: // Eliminar
                    textBoxId.Enabled = true; // Solo se habilita el ID para eliminar
                    break;

                case 5: // Listar
                        // No se habilitan campos, solo se muestra la lista
                    break;
            }
        }

        private void buttonRegistrarBloque_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActualBloque = 1; // Registrar
            ConfigurarControlesBloque();
        }

        private void buttonBuscarIdBloque_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActualBloque = 2; // Buscar por ID
            ConfigurarControlesBloque();
        }

        private void buttonBuscarTipoBloque_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActualBloque = 3; // Buscar por Tipo
            ConfigurarControlesBloque();
        }

        private void buttonBuscarRarezaBloque_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActualBloque = 4; // Buscar por Rareza
            ConfigurarControlesBloque();
        }

        private void buttonActualizarBloque_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActualBloque = 5; // Actualizar
            ConfigurarControlesBloque();
        }

        private void buttonEliminarBloque_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActualBloque = 6; // Eliminar
            ConfigurarControlesBloque();
        }

        private void buttonListarBloques_Click(object sender, EventArgs e)
        {
            LimpiarCamposBloque(); // Limpia los campos del formulario
            accionActual = 7; // Listar
            ConfigurarControlesBloque(); // Configura los controles para la acción de listar
            ListarBloques(); // Llama a la función para listar los bloques
        }
        private void RegistrarBloque()
        {
            if (string.IsNullOrEmpty(textBoxNombreBloque.Text))
            {
                MessageBox.Show("El nombre del bloque no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxTipoBloque.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxRarezaBloque.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una rareza válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bloque = new Bloque
            {
                Nombre = textBoxNombreBloque.Text,
                Tipo = comboBoxTipoBloque.SelectedItem?.ToString() ?? string.Empty,
                Rareza = comboBoxRarezaBloque.SelectedItem?.ToString() ?? string.Empty,
            };

            bloqueService.Crear(bloque);

            MessageBox.Show("¡Bloque registrado con éxito!");
            LimpiarCamposBloque();
            LlenarComboBoxBloques();
        }

        private void BuscarBloquePorId()
        {
            if (!int.TryParse(textBoxIdBloque.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bloque = bloqueService.ObtenerPorId(id);

            if (bloque != null)
            {
                // Completar los campos del formulario
                textBoxIdBloque.Text = bloque.Id.ToString(); // Asegurarse de que el ID esté en el campo
                textBoxNombreBloque.Text = bloque.Nombre;

                // Asignar el tipo al ComboBox
                if (comboBoxTipoBloque.Items.Contains(bloque.Tipo))
                {
                    comboBoxTipoBloque.SelectedItem = bloque.Tipo;
                }
                else
                {
                    comboBoxTipoBloque.SelectedIndex = -1; // Limpiar selección si no coincide
                }

                // Asignar la rareza al ComboBox
                if (comboBoxRarezaBloque.Items.Contains(bloque.Rareza))
                {
                    comboBoxRarezaBloque.SelectedItem = bloque.Rareza;
                }
                else
                {
                    comboBoxRarezaBloque.SelectedIndex = -1; // Limpiar selección si no coincide
                }

                // Mostrar la imagen correspondiente
                pictureBoxBloque.Image = ObtenerImagenPorNombre(bloque.Nombre);
                dataGridViewBloques.DataSource = new List<Bloque> { bloque };
            }
            else
            {
                MessageBox.Show("Bloque no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposBloque(); // Limpiar los campos si no se encuentra el bloque
            }
        }
        private void BuscarBloquesPorTipo()
        {
            var tipo = comboBoxTipoBloque.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Seleccione un tipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bloques = bloqueService.BuscarPorTipo(tipo);

            if (bloques.Any())
            {
                // Mostrar los bloques en el DataGridView
                dataGridViewBloques.DataSource = null;
                dataGridViewBloques.DataSource = bloques;

                MessageBox.Show($"Se encontraron {bloques.Count} bloques del tipo '{tipo}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron bloques del tipo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewBloques.DataSource = null;
            }
        }

        private void BuscarBloquesPorRareza()
        {
            var rareza = comboBoxRarezaBloque.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(rareza))
            {
                MessageBox.Show("Seleccione una rareza válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bloques = bloqueService.BuscarPorRareza(rareza);

            if (bloques.Any())
            {
                // Mostrar los bloques en el DataGridView
                dataGridViewBloques.DataSource = null;
                dataGridViewBloques.DataSource = bloques;

                MessageBox.Show($"Se encontraron {bloques.Count} bloques con la rareza '{rareza}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Limpiar el DataGridView si no se encuentran bloques
                dataGridViewBloques.DataSource = null;

                MessageBox.Show("No se encontraron bloques con la rareza seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarBloque()
        {
            if (!int.TryParse(textBoxIdBloque.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bloque = bloqueService.ObtenerPorId(id);

            if (bloque != null)
            {
                if (string.IsNullOrEmpty(textBoxNombreBloque.Text))
                {
                    MessageBox.Show("El nombre del bloque no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxTipoBloque.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxRarezaBloque.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una rareza válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar los datos del bloque
                bloque.Nombre = textBoxNombreBloque.Text;
                bloque.Tipo = comboBoxTipoBloque.SelectedItem?.ToString() ?? string.Empty;
                bloque.Rareza = comboBoxRarezaBloque.SelectedItem?.ToString() ?? string.Empty;

                bloqueService.Actualizar(bloque);

                MessageBox.Show("¡Bloque actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario
                LimpiarCamposBloque();

                // Actualizar el DataGridView con el bloque actualizado
                dataGridViewBloques.DataSource = null;
                dataGridViewBloques.DataSource = new List<Bloque> { bloque };
            }
            else
            {
                MessageBox.Show("Bloque no encontrado. Verifique el ID ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ManejarEliminarBloque()
        {
            contadorClicks++; // Incrementar el contador de clics

            if (contadorClicks == 1)
            {
                // Primer clic: buscar el bloque y confirmar
                BuscarBloquePorId(); // Reutilizar el método BuscarBloquePorId

                if (!string.IsNullOrEmpty(textBoxNombreBloque.Text)) // Verificar si se encontró un bloque
                {
                    MessageBox.Show("Bloque encontrado. Presione 'Guardar' nuevamente para confirmar la eliminación.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún bloque con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contadorClicks = 0; // Reiniciar el contador si no se encuentra el bloque
                }
            }
            else if (contadorClicks == 2)
            {
                // Segundo clic: eliminar el bloque
                if (string.IsNullOrEmpty(textBoxIdBloque.Text) || !int.TryParse(textBoxIdBloque.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contadorClicks = 0; // Reiniciar el contador si hay un error
                    return;
                }

                // Verificar si el bloque existe antes de eliminar
                var bloque = bloqueService.ObtenerPorId(id);
                if (bloque == null)
                {
                    MessageBox.Show("El bloque con el ID especificado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contadorClicks = 0; // Reiniciar el contador si no se encuentra el bloque
                    return;
                }

                // Eliminar el bloque
                try
                {
                    bloqueService.Eliminar(id);
                    MessageBox.Show("¡Bloque eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposBloque();
                    ListarBloques(); // Actualizar la lista de bloques
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                contadorClicks = 0; // Reiniciar el contador después de eliminar
            }
        }

        private void ListarBloques()
        {
            var bloques = bloqueService.ObtenerTodos();

            if (bloques.Any())
            {
                // Mostrar todos los bloques en el DataGridView
                dataGridViewBloques.DataSource = null;
                dataGridViewBloques.DataSource = bloques;

                MessageBox.Show($"Se encontraron {bloques.Count} bloques en total.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron bloques.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewBloques.DataSource = null;
            }
        }

        private void LimpiarCamposBloque()
        {
            textBoxIdBloque.Clear(); // Limpiar ID
            textBoxNombreBloque.Clear(); // Limpiar Nombre
            comboBoxTipoBloque.SelectedIndex = -1; // Restablecer selección de Tipo
            comboBoxRarezaBloque.SelectedIndex = -1; // Restablecer selección de Rareza
            pictureBoxBloque.Image = null; // Limpiar la imagen del PictureBox
        }

        private void ConfigurarControlesBloque()
        {
            // Deshabilitar todos los campos por defecto
            textBoxIdBloque.Enabled = false; // ID siempre deshabilitado
            textBoxNombreBloque.Enabled = false;
            comboBoxTipoBloque.Enabled = false;
            comboBoxRarezaBloque.Enabled = false;

            // Habilitar campos según la acción seleccionada
            switch (accionActualBloque)
            {
                case 1: // Registrar
                    textBoxNombreBloque.Enabled = true;
                    comboBoxTipoBloque.Enabled = true;
                    comboBoxRarezaBloque.Enabled = true;
                    break;

                case 2: // Buscar por ID
                    textBoxIdBloque.Enabled = true; // Solo se habilita el ID para buscar
                    break;

                case 3: // Buscar por Tipo
                    comboBoxTipoBloque.Enabled = true;
                    // Solo se habilita el ComboBox de Tipo
                    break;

                case 4: // Buscar por Rareza
                    comboBoxRarezaBloque.Enabled = true; // Solo se habilita el ComboBox de Rareza
                    break;

                case 5: // Actualizar
                    textBoxIdBloque.Enabled = true; // ID para buscar, pero no editable
                    textBoxNombreBloque.Enabled = true;
                    comboBoxTipoBloque.Enabled = true;
                    comboBoxRarezaBloque.Enabled = true;
                    break;

                case 6: // Eliminar
                    textBoxIdBloque.Enabled = true; // Solo se habilita el ID para eliminar
                    break;

                case 7: // Listar
                        // No se habilitan campos, solo se muestra la lista
                    break;
            }
        }

        private Image ObtenerImagenPorNombre(string nombre)
        {
            pictureBoxBloque.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                switch (nombre)
                {
                    case "Madera de roble":
                        return Properties.Resources.Madera;
                    case "Diamante":
                        return Properties.Resources.Diamante;
                    case "Oro":
                        return Properties.Resources.Oro;
                    case "Hierro":
                        return Properties.Resources.Hierro;
                    case "Lapislázuli":
                        return Properties.Resources.Lapislázuli;
                    case "Netherita":
                        return Properties.Resources.Netherita;
                    case "Obsidiana":
                        return Properties.Resources.Obsidiana;
                    case "Piedra":
                        return Properties.Resources.Piedra;
                    case "Redstone":
                        return Properties.Resources.Redstone;
                    case "Esmeralda":
                        return Properties.Resources.Esmeralda;
                    default:
                        MessageBox.Show($"No se encontró la imagen para el bloque '{nombre}'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        private void buttonGuardarBloque_Click(object sender, EventArgs e)
        {
            switch (accionActualBloque)
            {
                case 1: // Registrar
                    RegistrarBloque();
                    break;
                case 2: // Buscar por ID
                    BuscarBloquePorId();
                    break;
                case 3: // Buscar por Tipo
                    BuscarBloquesPorTipo();
                    break;
                case 4: // Buscar por Rareza
                    BuscarBloquesPorRareza();
                    break;
                case 5: // Actualizar
                    ActualizarBloque();
                    break;
                case 6: // Eliminar
                    ManejarEliminarBloque();
                    break;
                case 7: // Listar
                    ListarBloques();
                    break;
                default:
                    MessageBox.Show("Seleccione una acción antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            
        }

        private void buttonAgregarInventario_Click(object sender, EventArgs e)
        {
            LimpiarCamposInventario();
            accionActualInventario = 1; // Agregar bloques al inventario
            ConfigurarControlesInventario();
        }

        private void buttonListarInventario_Click(object sender, EventArgs e)
        {
            LimpiarCamposInventario();
            accionActualInventario = 2; // Listar todo el inventario
            ConfigurarControlesInventario();
            ListarInventario();
        }

        private void buttonVerInventarioJugador_Click(object sender, EventArgs e)
        {
            LimpiarCamposInventario();
            accionActualInventario = 3; // Ver inventario de un jugador
            ConfigurarControlesInventario();
        }

        private void buttonActualizarInventario_Click(object sender, EventArgs e)
        {
            LimpiarCamposInventario();
            accionActualInventario = 4; // Actualizar cantidad en inventario
            ConfigurarControlesInventario();
        }

        private void buttonEliminarInventario_Click(object sender, EventArgs e)
        {
            LimpiarCamposInventario();
            accionActualInventario = 5; // Exportar inventario a CSV
            ConfigurarControlesInventario();
        }

        private void buttonExportarInventario_Click(object sender, EventArgs e)
        {
            LimpiarCamposInventario();
            accionActualInventario = 6; // Exportar inventario a CSV
            ConfigurarControlesInventario();
            ExportarInventarioACSV();
        }
        private void buttonGuardarInventario_Click(object sender, EventArgs e)
        {
            switch (accionActualInventario)
            {
                case 1: // Agregar bloques al inventario
                    AgregarInventario();
                    break;

                case 2: // Listar todo el inventario
                    ListarInventario();
                    break;

                case 3: // Ver inventario de un jugador
                    VerInventarioJugador();
                    break;

                case 4: // Actualizar cantidad en inventario
                    ActualizarInventario();
                    break;

                case 5: // Eliminar elemento del inventario
                    EliminarInventario();
                    break;

                case 6: // Exportar inventario a CSV
                    ExportarInventarioACSV();
                    break;

                default:
                    MessageBox.Show("Seleccione una acción antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        private void LlenarComboBoxJugadores()
        {
            var jugadores = jugadorService.ObtenerTodos();
            comboBoxJugadorInventario.Items.Clear();
            foreach (var jugador in jugadores)
            {
                comboBoxJugadorInventario.Items.Add(jugador);
            }
            comboBoxJugadorInventario.DisplayMember = "Nombre"; // Mostrar el nombre del jugador
            comboBoxJugadorInventario.ValueMember = "Id"; // Usar el ID como valor
        }

        private void LlenarComboBoxBloques()
        {
            var bloques = bloqueService.ObtenerTodos();
            comboBoxBloqueInventario.Items.Clear();
            foreach (var bloque in bloques)
            {
                comboBoxBloqueInventario.Items.Add(bloque);
            }
            comboBoxBloqueInventario.DisplayMember = "Nombre"; // Mostrar el nombre del bloque
            comboBoxBloqueInventario.ValueMember = "Id"; // Usar el ID como valor
        }
        private void LimpiarCamposInventario()
        {
            textBoxIdInventario.Clear();
            comboBoxJugadorInventario.SelectedIndex = -1;
            comboBoxBloqueInventario.SelectedIndex = -1;
            numericUpDownCantidadInventario.Value = 1;
        }
        private void ConfigurarControlesInventario()
        {
            // Deshabilitar todos los campos por defecto
            textBoxIdInventario.Enabled = false;
            comboBoxJugadorInventario.Enabled = false;
            comboBoxBloqueInventario.Enabled = false;
            numericUpDownCantidadInventario.Enabled = false;

            // Habilitar campos según la acción seleccionada
            switch (accionActualInventario)
            {
                case 1: // Agregar bloques al inventario
                    comboBoxJugadorInventario.Enabled = true;
                    comboBoxBloqueInventario.Enabled = true;
                    numericUpDownCantidadInventario.Enabled = true;
                    break;

                case 2: // Listar todo el inventario
                        // No se habilitan campos, solo se muestra la lista
                    break;

                case 3: // Ver inventario de un jugador
                    comboBoxJugadorInventario.Enabled = true;
                    break;

                case 4: // Actualizar cantidad en inventario
                    textBoxIdInventario.Enabled = true;
                    numericUpDownCantidadInventario.Enabled = true;
                    break;

                case 5: // Eliminar elemento del inventario
                    textBoxIdInventario.Enabled = true; // Habilitar el campo ID para eliminar
                    break;

                case 6: // Exportar inventario a CSV
                        // No se habilitan campos
                    break;
            }
        }

        private void AgregarInventario()
        {
            if (comboBoxJugadorInventario.SelectedItem == null || comboBoxBloqueInventario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un jugador y un bloque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jugadorId = ((Jugador)comboBoxJugadorInventario.SelectedItem).Id;
            var bloqueId = ((Bloque)comboBoxBloqueInventario.SelectedItem).Id;
            var cantidad = (int)numericUpDownCantidadInventario.Value;

            var inventario = new Inventario
            {
                JugadorId = jugadorId,
                BloqueId = bloqueId,
                Cantidad = cantidad
            };

            inventarioService.Agregar(inventario);

            MessageBox.Show("¡Bloques agregados al inventario con éxito!");
            LimpiarCamposInventario();
            ListarInventario();
        }

        private void ListarInventario()
        {
            var inventarios = inventarioService.ObtenerTodos();

            if (!inventarios.Any())
            {
                MessageBox.Show("No hay elementos en el inventario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear una lista personalizada con el ID del inventario, jugador, bloque y cantidad
            var inventariosSimplificados = inventarios.Select(i => new
            {
                IdInventario = i.Id, // ID del inventario (registro)
                IdJugador = i.JugadorId,
                Jugador = i.NombreJugador, // Nombre del jugador
                Bloque = i.NombreBloque, // Nombre del bloque
                Cantidad = i.Cantidad // Cantidad del bloque
            }).ToList();

            // Asignar la lista personalizada al DataGridView
            dataGridViewInventario.DataSource = null;
            dataGridViewInventario.DataSource = inventariosSimplificados;
        }

        private void ActualizarInventario()
        {
            // Validar que se haya ingresado un ID
            if (string.IsNullOrEmpty(textBoxIdInventario.Text) || !int.TryParse(textBoxIdInventario.Text, out int id))
            {
                MessageBox.Show("Debe ingresar un ID válido para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya seleccionado un jugador y un bloque
            if (comboBoxJugadorInventario.SelectedItem == null || comboBoxBloqueInventario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un jugador y un bloque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los datos del formulario
            var jugadorId = ((Jugador)comboBoxJugadorInventario.SelectedItem).Id;
            var bloqueId = ((Bloque)comboBoxBloqueInventario.SelectedItem).Id;
            var nuevaCantidad = (int)numericUpDownCantidadInventario.Value;

            // Validar que la cantidad sea positiva
            if (nuevaCantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un valor positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear un objeto Inventario con los datos actualizados
                var inventarioActualizado = new Inventario
                {
                    Id = id,
                    JugadorId = jugadorId,
                    BloqueId = bloqueId,
                    Cantidad = nuevaCantidad
                };

                // Llamar al método Actualizar del servicio
                inventarioService.Actualizar(inventarioActualizado);

                MessageBox.Show("¡Inventario actualizado con éxito!");
                LimpiarCamposInventario();
                ListarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarInventario()
        {
            // Validar que se haya ingresado un ID válido
            if (!int.TryParse(textBoxIdInventario.Text, out int id))
            {
                MessageBox.Show("Debe ingresar un ID válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Intentar eliminar el registro
                inventarioService.Eliminar(id);

                MessageBox.Show("¡Elemento eliminado del inventario con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos y actualizar la lista
                LimpiarCamposInventario();
                ListarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarInventarioACSV()
        {
            var inventarios = inventarioService.ObtenerTodos();

            if (!inventarios.Any())
            {
                MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Exportar Inventario a CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Id,Jugador,Bloque,Cantidad");

                        foreach (var inventario in inventarios)
                        {
                            writer.WriteLine($"{inventario.Id},{inventario.NombreJugador},{inventario.NombreBloque},{inventario.Cantidad}");
                        }
                    }

                    MessageBox.Show("¡Inventario exportado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void VerInventarioJugador()
        {
            // Validar que se haya seleccionado un jugador
            if (comboBoxJugadorInventario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un jugador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID del jugador seleccionado
            var jugadorId = ((Jugador)comboBoxJugadorInventario.SelectedItem).Id;

            // Obtener el inventario del jugador
            var inventarios = inventarioService.ObtenerPorJugador(jugadorId);

            if (!inventarios.Any())
            {
                MessageBox.Show("El jugador no tiene elementos en su inventario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear una lista personalizada con el ID del jugador, bloque y cantidad
            var inventariosSimplificados = inventarios.Select(i => new
            {
                IdJugador = i.JugadorId, // ID del jugador
                Bloque = i.NombreBloque, // Nombre del bloque
                Cantidad = i.Cantidad // Cantidad del bloque
            }).ToList();

            // Asignar la lista personalizada al DataGridView
            dataGridViewInventario.DataSource = null;
            dataGridViewInventario.DataSource = inventariosSimplificados;
        }

        private void dataGridViewInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}