using System;
using System.Windows.Forms;

namespace Sistema_Hospitalario
{
    public partial class Form3 : Form
    {
        private DatosHospital datos = new DatosHospital();
        private RepositorioJson repositorio = new RepositorioJson();
        private int expedienteId;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(
            Paciente paciente,
            Expediente expediente,
            DatosHospital datosHospital) : this()
        {
            datos = datosHospital;
            expedienteId = expediente.Id;

            lblPacienteExpediente.Text =
                "Paciente: " + paciente.Nombre;

            lblCodigoExpediente.Text =
                "Expediente: " + expediente.Id;

            lblDocumentoExpediente.Text =
                "Documento: " + paciente.Documento;

            lblNacimientoExpediente.Text =
                "Nacimiento: " +
                paciente.FechaNacimiento.ToString("dd/MM/yyyy");

            lblContactoExpediente.Text =
                "Contacto: " + paciente.Contacto;

            lblFechaCreacionExpediente.Text =
                "Fecha de creación: " +
                expediente.FechaCreacion.ToString("dd/MM/yyyy");

            lblEstadoPacienteExpediente.Text =
                "Estado del paciente: " +
                (paciente.Activo ? "Activo" : "Inactivo");

            CargarHistorial();
        }

        private void CargarHistorial()
        {
            dgvHistorialConsultas.Rows.Clear();

            foreach (ConsultaClinica consulta in datos.Consultas)
            {
                if (consulta.ExpedienteId == expedienteId)
                {
                    dgvHistorialConsultas.Rows.Add(
                        consulta.Id,
                        consulta.Fecha.ToString("dd/MM/yyyy HH:mm"),
                        consulta.Diagnostico,
                        consulta.Medicamentos,
                        consulta.Resultados,
                        consulta.Tratamiento,
                        consulta.Observaciones
                    );
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVolverExpediente_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            dtpFechaConsulta.Value = DateTime.Now;
            txtDiagnosticoConsulta.Clear();
            txtMedicamentosConsulta.Clear();
            txtResultadosConsulta.Clear();
            txtTratamientoConsulta.Clear();
            txtObservacionesConsulta.Clear();

            txtDiagnosticoConsulta.Focus();
        }

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            if (expedienteId <= 0)
            {
                MessageBox.Show("Abrí el expediente desde un paciente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnosticoConsulta.Text))
            {
                MessageBox.Show("Ingresá el diagnóstico.");
                txtDiagnosticoConsulta.Focus();
                return;
            }

            if (dtpFechaConsulta.Value > DateTime.Now)
            {
                MessageBox.Show("La consulta no puede tener una fecha futura.");
                return;
            }

            // Obtener un código disponible.
            int siguienteIdConsulta = 1;

            foreach (ConsultaClinica consulta in datos.Consultas)
            {
                if (consulta.Id >= siguienteIdConsulta)
                    siguienteIdConsulta = consulta.Id + 1;
            }

            ConsultaClinica nuevaConsulta = new ConsultaClinica
            {
                Id = siguienteIdConsulta,
                ExpedienteId = expedienteId,
                Fecha = dtpFechaConsulta.Value,
                Diagnostico = txtDiagnosticoConsulta.Text.Trim(),
                Medicamentos = txtMedicamentosConsulta.Text.Trim(),
                Resultados = txtResultadosConsulta.Text.Trim(),
                Tratamiento = txtTratamientoConsulta.Text.Trim(),
                Observaciones = txtObservacionesConsulta.Text.Trim()
            };

            datos.Consultas.Add(nuevaConsulta);

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                // Retirar la consulta si no se pudo guardar.
                datos.Consultas.Remove(nuevaConsulta);

                MessageBox.Show(
                    "No se pudo guardar la consulta:\n" + ex.Message,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            CargarHistorial();
            btnNuevaConsulta.PerformClick();

            MessageBox.Show(
                "Consulta guardada correctamente.",
                "Expediente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}