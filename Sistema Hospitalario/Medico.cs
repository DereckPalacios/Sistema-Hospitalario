using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Hospitalario
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Colegiado { get; set; } = "";
        public int EspecialidadId { get; set; }
        public bool Activo { get; set; } = true;

        public void Desactivar()
        {
            Activo = false;
        }
    }
}
