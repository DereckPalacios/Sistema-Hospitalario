using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Hospitalario
{
    public class Expediente
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Expediente()
        {
            FechaCreacion = DateTime.Now;
        }

        public Expediente(int id, int pacienteId) : this()
        {
            Id = id;
            PacienteId = pacienteId;
        }
    }
}
