using System;

namespace MinecraftManager.Models 
{
    public class Bloque
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Rareza { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Tipo: {Tipo}, Rareza: {Rareza}";
        }
    }
}