using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Hospitalario
{
    public class ConsultaClinica
    {
        public int Id { get; set; }
        public int ExpedienteId { get; set; }
        public int? CitaId { get; set; }
        public DateTime Fecha { get; set; }

        public string Diagnostico { get; set; } = "";
        public string Medicamentos { get; set; } = "";
        public string Resultados { get; set; } = "";
        public string Tratamiento { get; set; } = "";
        public string Observaciones { get; set; } = "";
    }
}
