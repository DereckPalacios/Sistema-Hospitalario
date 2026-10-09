using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Hospitalario
{
    using System;

    namespace Sistema_Hospitalario
    {
        public class Cita
        {
            public int Id { get; set; }
            public int PacienteId { get; set; }
            public int MedicoId { get; set; }

            public DateTime Inicio { get; set; }
            public DateTime Fin { get; set; }

            public string Estado { get; set; } = "Programada";
            public string Motivo { get; set; } = "";
        }
    }
}
