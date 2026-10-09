using Sistema_Hospitalario.Sistema_Hospitalario;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Hospitalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Conectar los botones sin duplicar estos eventos.
            btnInicio.Click -= btnInicio_Click;
            btnInicio.Click += btnInicio_Click;

            btnPacientes.Click -= button1_Click;
            btnPacientes.Click += button1_Click;

            btnMedicos.Click -= btnMedicos_Click;
            btnMedicos.Click += btnMedicos_Click;

            btnEspecialidades.Click -= btnEspecialidades_Click;
            btnEspecialidades.Click += btnEspecialidades_Click;

            btnCitas.Click -= btnCitas_Click;
            btnCitas.Click += btnCitas_Click;

            btnExpedientes.Click -= btnExpedientes_Click;
            btnExpedientes.Click += btnExpedientes_Click;

            btnSalir.Click -= btnSalir_Click;
            btnSalir.Click += btnSalir_Click;

            btnRegistrarPaciente.Click -= btnRegistrarPaciente_Click;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;

            btnConsultarExpediente.Click -= btnConsultarExpediente_Click;
            btnConsultarExpediente.Click += btnConsultarExpediente_Click;

            btnNuevaCita.Click -= btnNuevaCita_Click;
            btnNuevaCita.Click += btnNuevaCita_Click;

            Load -= Form1_Load;
            Load += Form1_Load;

            SeleccionarMenu(btnInicio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarInicio();
        }

        private void SeleccionarMenu(Button seleccionado)
        {
            Color colorNormal = Color.FromArgb(15, 42, 68);
            Color colorSeleccionado = Color.FromArgb(0, 166, 180);

            btnInicio.BackColor = colorNormal;
            btnPacientes.BackColor = colorNormal;
            btnMedicos.BackColor = colorNormal;
            btnEspecialidades.BackColor = colorNormal;
            btnCitas.BackColor = colorNormal;
            btnExpedientes.BackColor = colorNormal;

            seleccionado.BackColor = colorSeleccionado;
        }

        private void ActualizarInicio()
        {
            try
            {
                RepositorioJson repositorio = new RepositorioJson();
                DatosHospital datos = repositorio.Cargar();

                DateTime ahora = DateTime.Now;
                DateTime hoy = ahora.Date;

                // Pacientes registrados: incluye activos e inactivos.
                lblTotalPacientes.Text =
                    datos.Pacientes.Count.ToString();

                lblTotalMedicos.Text =
                    datos.Medicos.Count(m => m.Activo).ToString();

                // Citas de hoy: incluye atendidas, excluye canceladas.
                lblTotalCitas.Text = datos.Citas.Count(
                    c => c.Inicio.Date == hoy &&
                        c.Estado != "Cancelada"
                ).ToString();

                dgvProximasCitas.Rows.Clear();

                var proximasCitas = datos.Citas
                    .Where(c =>
                        c.Inicio >= ahora &&
                        (c.Estado == "Programada" ||
                         c.Estado == "Confirmada"))
                    .OrderBy(c => c.Inicio)
                    .Take(10);

                foreach (Cita cita in proximasCitas)
                {
                    Paciente? paciente = datos.Pacientes.Find(
                        p => p.Id == cita.PacienteId
                    );

                    Medico? medico = datos.Medicos.Find(
                        m => m.Id == cita.MedicoId
                    );

                    Especialidad? especialidad = medico == null
                        ? null
                        : datos.Especialidades.Find(
                            esp => esp.Id == medico.EspecialidadId
                        );

                    dgvProximasCitas.Rows.Add(
                        cita.Inicio.ToString("dd/MM HH:mm"),
                        paciente?.Nombre ?? "No encontrado",
                        medico?.Nombre ?? "No encontrado",
                        especialidad?.Nombre ?? "Sin especialidad",
                        cita.Estado
                    );
                }
            }
            catch (Exception ex)
            {
                // Evitar mostrar cifras anteriores como actuales.
                lblTotalPacientes.Text = "—";
                lblTotalMedicos.Text = "—";
                lblTotalCitas.Text = "—";
                dgvProximasCitas.Rows.Clear();

                MessageBox.Show(
                    "No se pudo actualizar el inicio:\n" + ex.Message,
                    "Error al cargar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AbrirVentana(Form ventana, Button botonMenu)
        {
            SeleccionarMenu(botonMenu);

            try
            {
                using (ventana)
                {
                    ventana.ShowDialog(this);
                }
            }
            finally
            {
                SeleccionarMenu(btnInicio);
                ActualizarInicio();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            SeleccionarMenu(btnInicio);
            ActualizarInicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Form2(), btnPacientes);
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FrmMedicos(), btnMedicos);
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FrmEspecialidades(), btnEspecialidades);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FrmCitas(), btnCitas);
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            // Elegir un paciente y usar Ver expediente.
            AbrirVentana(new Form2(), btnExpedientes);
        }

        private void btnRegistrarPaciente_Click(
            object sender, EventArgs e)
        {
            btnPacientes.PerformClick();
        }

        private void btnConsultarExpediente_Click(
            object sender, EventArgs e)
        {
            btnExpedientes.PerformClick();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            btnCitas.PerformClick();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}