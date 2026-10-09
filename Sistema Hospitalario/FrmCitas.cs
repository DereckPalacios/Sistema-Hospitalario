using Sistema_Hospitalario.Sistema_Hospitalario;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Hospitalario
{
    public partial class FrmCitas : Form
    {
        private DatosHospital datos = new DatosHospital();
        private RepositorioJson repositorio = new RepositorioJson();

        public FrmCitas()
        {
            InitializeComponent();

            btnNuevaCita.Click -= btnNuevaCita_Click;
            btnNuevaCita.Click += btnNuevaCita_Click;

            btnGuardarCita.Click -= btnGuardarCita_Click;
            btnGuardarCita.Click += btnGuardarCita_Click;

            btnCancelarCita.Click -= btnCancelarCita_Click;
            btnCancelarCita.Click += btnCancelarCita_Click;

            btnVerExpedienteCita.Click -= btnVerExpedienteCita_Click;
            btnVerExpedienteCita.Click += btnVerExpedienteCita_Click;

            btnBuscarCita.Click -= btnBuscarCita_Click;
            btnBuscarCita.Click += btnBuscarCita_Click;

            btnMostrarTodasCitas.Click -= btnMostrarTodasCitas_Click;
            btnMostrarTodasCitas.Click += btnMostrarTodasCitas_Click;

            btnVolverCitas.Click -= btnVolverCitas_Click;
            btnVolverCitas.Click += btnVolverCitas_Click;

            dgvCitas.CellClick -= dgvCitas_CellClick;
            dgvCitas.CellClick += dgvCitas_CellClick;

            cmbEstadoCita.Items.Clear();
            cmbEstadoCita.Items.AddRange(new object[]
            {
                "Programada", "Confirmada", "Cancelada", "Atendida"
            });

            try
            {
                datos = repositorio.Cargar();
                LimpiarCampos();
                MostrarCitas("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                btnNuevaCita.Enabled = false;
                btnGuardarCita.Enabled = false;
                btnCancelarCita.Enabled = false;
                btnVerExpedienteCita.Enabled = false;
            }
        }

        private void CargarCombos(
            int pacienteSeleccionado = 0,
            int medicoSeleccionado = 0)
        {
            // Incluir los inactivos solamente cuando pertenecen
            // a una cita seleccionada, para poder mostrarla.
            cmbPacienteCita.DisplayMember = "Nombre";
            cmbPacienteCita.ValueMember = "Id";
            cmbPacienteCita.DataSource = datos.Pacientes
                .Where(p => p.Activo || p.Id == pacienteSeleccionado)
                .ToList();

            cmbMedicoCita.DisplayMember = "Nombre";
            cmbMedicoCita.ValueMember = "Id";
            cmbMedicoCita.DataSource = datos.Medicos
                .Where(m => m.Activo || m.Id == medicoSeleccionado)
                .ToList();

            cmbPacienteCita.SelectedIndex = -1;
            cmbMedicoCita.SelectedIndex = -1;

            if (pacienteSeleccionado > 0)
                cmbPacienteCita.SelectedValue = pacienteSeleccionado;

            if (medicoSeleccionado > 0)
                cmbMedicoCita.SelectedValue = medicoSeleccionado;
        }

        private void LimpiarCampos()
        {
            txtIdCita.Clear();
            txtMotivoCita.Clear();

            CargarCombos();

            cmbEstadoCita.SelectedItem = "Programada";
            dtpFechaCita.Value = DateTime.Today;
            dtpInicioCita.Value = DateTime.Today.AddHours(9);
            dtpFinCita.Value = DateTime.Today.AddHours(9).AddMinutes(30);

            dgvCitas.ClearSelection();
        }

        private void MostrarCitas(string busqueda)
        {
            dgvCitas.Rows.Clear();

            foreach (Cita cita in datos.Citas.OrderBy(c => c.Inicio))
            {
                Paciente? paciente = datos.Pacientes.Find(
                    p => p.Id == cita.PacienteId);

                Medico? medico = datos.Medicos.Find(
                    m => m.Id == cita.MedicoId);

                string nombrePaciente =
                    paciente?.Nombre ?? "No encontrado";

                string nombreMedico =
                    medico?.Nombre ?? "No encontrado";

                string fecha = cita.Inicio.ToString("dd/MM/yyyy");

                bool coincide =
                    string.IsNullOrWhiteSpace(busqueda) ||
                    cita.Id.ToString() == busqueda ||
                    nombrePaciente.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    nombreMedico.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    cita.Estado.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    cita.Motivo.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    fecha.Contains(busqueda);

                if (coincide)
                {
                    dgvCitas.Rows.Add(
                        cita.Id,
                        nombrePaciente,
                        nombreMedico,
                        fecha,
                        cita.Inicio.ToString("HH:mm"),
                        cita.Fin.ToString("HH:mm"),
                        cita.Estado,
                        cita.Motivo
                    );
                }
            }
        }

        private Cita? ObtenerCitaSeleccionada()
        {
            if (!int.TryParse(txtIdCita.Text, out int id))
                return null;

            return datos.Citas.Find(c => c.Id == id);
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (cmbPacienteCita.SelectedItem is not Paciente paciente)
            {
                MessageBox.Show("Seleccioná un paciente.");
                return;
            }

            if (cmbMedicoCita.SelectedItem is not Medico medico)
            {
                MessageBox.Show("Seleccioná un médico.");
                return;
            }

            if (cmbEstadoCita.SelectedItem is not string estado)
            {
                MessageBox.Show("Seleccioná un estado.");
                return;
            }

            string motivo = txtMotivoCita.Text.Trim();

            if (string.IsNullOrWhiteSpace(motivo))
            {
                MessageBox.Show("Ingresá el motivo de la cita.");
                return;
            }

            // Usar la fecha elegida y las horas, sin segundos.
            DateTime inicio = dtpFechaCita.Value.Date
                .AddHours(dtpInicioCita.Value.Hour)
                .AddMinutes(dtpInicioCita.Value.Minute);

            DateTime fin = dtpFechaCita.Value.Date
                .AddHours(dtpFinCita.Value.Hour)
                .AddMinutes(dtpFinCita.Value.Minute);

            if (fin <= inicio)
            {
                MessageBox.Show(
                    "La hora de fin debe ser posterior al inicio."
                    + "\nLa cita debe terminar el mismo día.");
                return;
            }

            bool esNueva = string.IsNullOrWhiteSpace(txtIdCita.Text);
            Cita? anterior = ObtenerCitaSeleccionada();

            if (!esNueva && anterior == null)
            {
                MessageBox.Show("No se encontró la cita.");
                return;
            }

            if (esNueva && estado != "Programada")
            {
                MessageBox.Show(
                    "Una cita nueva debe comenzar como Programada.");
                return;
            }

            // Una cita atendida conserva sus datos históricos.
            if (anterior != null && anterior.Estado == "Atendida")
            {
                MessageBox.Show(
                    "Una cita atendida no puede modificarse.");
                return;
            }

            bool cambioAgenda =
                esNueva ||
                anterior!.PacienteId != paciente.Id ||
                anterior.MedicoId != medico.Id ||
                anterior.Inicio != inicio ||
                anterior.Fin != fin;

            bool reservaHorario =
                estado == "Programada" || estado == "Confirmada";

            if (reservaHorario)
            {
                if (!paciente.Activo || !medico.Activo)
                {
                    MessageBox.Show(
                        "El paciente y el médico deben estar activos.");
                    return;
                }

                if (inicio < DateTime.Now)
                {
                    MessageBox.Show(
                        "Una cita programada o confirmada"
                        + " debe tener una fecha y hora futura.");
                    return;
                }
            }

            // Revisar el horario al reservar o cambiar la agenda.
            if (reservaHorario || cambioAgenda)
            {
                bool dentroDelHorario = datos.Horarios.Any(
                    h => h.MedicoId == medico.Id &&
                        h.Dia == inicio.DayOfWeek &&
                        inicio.TimeOfDay >= h.HoraInicio &&
                        fin.TimeOfDay <= h.HoraFin
                );

                if (!dentroDelHorario)
                {
                    MessageBox.Show(
                        "La cita está fuera del horario del médico."
                        + "\nRevisá sus días y horas en Médicos → Horarios.");
                    return;
                }
            }

            if (estado == "Atendida")
            {
                if (esNueva || cambioAgenda)
                {
                    MessageBox.Show(
                        "Para marcar Atendida, conservá el paciente,"
                        + " médico y horario de la cita registrada.");
                    return;
                }

                if (inicio > DateTime.Now)
                {
                    MessageBox.Show(
                        "Todavía no ha llegado la hora de esta cita.");
                    return;
                }
            }

            int idActual = anterior?.Id ?? 0;

            // Las canceladas no ocupan horario.
            if (estado != "Cancelada")
            {
                bool cruceMedico = datos.Citas.Any(
                    c => c.Id != idActual &&
                        c.Estado != "Cancelada" &&
                        c.MedicoId == medico.Id &&
                        inicio < c.Fin &&
                        fin > c.Inicio
                );

                if (cruceMedico)
                {
                    MessageBox.Show(
                        "El médico tiene otra cita en ese horario.");
                    return;
                }

                bool crucePaciente = datos.Citas.Any(
                    c => c.Id != idActual &&
                        c.Estado != "Cancelada" &&
                        c.PacienteId == paciente.Id &&
                        inicio < c.Fin &&
                        fin > c.Inicio
                );

                if (crucePaciente)
                {
                    MessageBox.Show(
                        "El paciente tiene otra cita en ese horario.");
                    return;
                }
            }

            Cita nuevaVersion = new Cita
            {
                Id = anterior?.Id ?? (
                    datos.Citas.Count == 0
                        ? 1
                        : datos.Citas.Max(c => c.Id) + 1),
                PacienteId = paciente.Id,
                MedicoId = medico.Id,
                Inicio = inicio,
                Fin = fin,
                Estado = estado,
                Motivo = motivo
            };

            int posicion = anterior == null
                ? -1
                : datos.Citas.IndexOf(anterior);

            if (esNueva)
                datos.Citas.Add(nuevaVersion);
            else
                datos.Citas[posicion] = nuevaVersion;

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                if (esNueva)
                    datos.Citas.Remove(nuevaVersion);
                else
                    datos.Citas[posicion] = anterior!;

                MessageBox.Show(
                    "No se pudo guardar la cita:\n" + ex.Message);
                return;
            }

            txtBuscarCita.Clear();
            MostrarCitas("");
            LimpiarCampos();

            MessageBox.Show("Cita guardada correctamente.");
        }

        private void dgvCitas_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvCitas.Rows[e.RowIndex].Cells["colIdCita"].Value);

            Cita? cita = datos.Citas.Find(c => c.Id == id);

            if (cita == null)
                return;

            CargarCombos(cita.PacienteId, cita.MedicoId);

            txtIdCita.Text = cita.Id.ToString();
            dtpFechaCita.Value = cita.Inicio.Date;
            dtpInicioCita.Value = cita.Inicio;
            dtpFinCita.Value = cita.Fin;
            cmbEstadoCita.SelectedItem = cita.Estado;
            txtMotivoCita.Text = cita.Motivo;
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            Cita? cita = ObtenerCitaSeleccionada();

            if (cita == null)
            {
                MessageBox.Show("Seleccioná una cita de la tabla.");
                return;
            }

            if (cita.Estado == "Cancelada")
            {
                MessageBox.Show("Esta cita ya está cancelada.");
                return;
            }

            if (cita.Estado == "Atendida")
            {
                MessageBox.Show(
                    "Una cita atendida no puede cancelarse.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Querés cancelar esta cita?",
                "Cancelar cita",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            string estadoAnterior = cita.Estado;
            cita.Estado = "Cancelada";

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                cita.Estado = estadoAnterior;

                MessageBox.Show(
                    "No se pudo cancelar la cita:\n" + ex.Message);
                return;
            }

            MostrarCitas(txtBuscarCita.Text.Trim());
            LimpiarCampos();

            MessageBox.Show("Cita cancelada correctamente.");
        }

        private void btnVerExpedienteCita_Click(
            object sender, EventArgs e)
        {
            if (cmbPacienteCita.SelectedItem is not Paciente paciente)
            {
                MessageBox.Show(
                    "Seleccioná una cita o elegí un paciente.");
                return;
            }

            Expediente? expediente = datos.Expedientes.Find(
                exp => exp.PacienteId == paciente.Id);

            if (expediente == null)
            {
                MessageBox.Show(
                    "El paciente no tiene un expediente registrado."
                    + "\nAbrí Pacientes para crear los expedientes faltantes.");
                return;
            }

            using (Form3 ventana = new Form3(
                paciente, expediente, datos))
            {
                ventana.ShowDialog(this);
            }
        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            MostrarCitas(txtBuscarCita.Text.Trim());
            LimpiarCampos();

            if (dgvCitas.Rows.Count == 0)
                MessageBox.Show("No se encontraron citas.");
        }

        private void btnMostrarTodasCitas_Click(
            object sender, EventArgs e)
        {
            txtBuscarCita.Clear();
            MostrarCitas("");
            LimpiarCampos();
        }

        private void btnVolverCitas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Conservar el evento que ya tenías en el diseñador.
        private void comboBox3_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }
    }
}