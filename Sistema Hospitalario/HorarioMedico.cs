using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Hospitalario
{
    using System;

    namespace Sistema_Hospitalario
    {
        public class HorarioMedico
        {
            public int Id { get; set; }
            public int MedicoId { get; set; }
            public DayOfWeek Dia { get; set; }
            public TimeSpan HoraInicio { get; set; }
            public TimeSpan HoraFin { get; set; }
        }
    }
}
