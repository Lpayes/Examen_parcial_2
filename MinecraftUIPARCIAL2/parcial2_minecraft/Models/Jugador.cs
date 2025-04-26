using System;

namespace MinecraftManager.Models 
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Inicializado como cadena vacía
        public int Nivel { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now; // Inicializado con la fecha actual

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Nivel: {Nivel}, Creado: {FechaCreacion.ToShortDateString()}";
        }
    }
}