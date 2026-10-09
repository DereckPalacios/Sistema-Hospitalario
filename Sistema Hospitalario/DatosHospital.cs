using Sistema_Hospitalario.Sistema_Hospitalario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Hospitalario
{
    public class DatosHospital
    {
        public int VersionEsquema { get; set; } = 1;

        public List<Paciente> Pacientes { get; set; }
            = new List<Paciente>();

        public List<Expediente> Expedientes { get; set; }
            = new List<Expediente>();

        public List<ConsultaClinica> Consultas { get; set; }
            = new List<ConsultaClinica>();

        public List<Especialidad> Especialidades { get; set; }
            = new List<Especialidad>();

        public List<Medico> Medicos { get; set; }
            = new List<Medico>();

        public List<HorarioMedico> Horarios { get; set; }
            = new List<HorarioMedico>();

        public List<Cita> Citas { get; set; }
            = new List<Cita>();
    }
}
