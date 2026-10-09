using Sistema_Hospitalario.Sistema_Hospitalario;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Hospitalario
{
    public partial class FrmMedicos : Form
    {
        private DatosHospital datos = new DatosHospital();
        private RepositorioJson repositorio = new RepositorioJson();

        public FrmMedicos()
        {
            InitializeComponent();

            // Conectar los eventos evitando duplicar los habituales.
            btnGuardarMedico.Click -= btnGuardarMedico_Click;
            btnGuardarMedico.Click += btnGuardarMedico_Click;

            btnDesactivarMedico.Click -= btnDesactivarMedico_Click;
            btnDesactivarMedico.Click += btnDesactivarMedico_Click;

            btnBuscarMedico.Click -= btnBuscarMedico_Click;
            btnBuscarMedico.Click += btnBuscarMedico_Click;

            btnMostrarTodosMedicos.Click -= btnMostrarTodosMedicos_Click;
            btnMostrarTodosMedicos.Click += btnMostrarTodosMedicos_Click;

            btnHorariosMedico.Click -= btnHorariosMedico_Click;
            btnHorariosMedico.Click += btnHorariosMedico_Click;

            btnVolverMedicos.Click -= btnVolverMedicos_Click;
            btnVolverMedicos.Click += btnVolverMedicos_Click;

            dgvMedicos.CellClick -= dgvMedicos_CellClick;
            dgvMedicos.CellClick += dgvMedicos_CellClick;

            // Nuevo conserva el evento button1_Click que ya tenías.
            try
            {
                datos = repositorio.Cargar();

                cmbEspecialidadMedico.DisplayMember = "Nombre";
                cmbEspecialidadMedico.ValueMember = "Id";
                cmbEspecialidadMedico.DataSource = datos.Especialidades;

                LimpiarCampos();
                MostrarMedicos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                btnGuardarMedico.Enabled = false;
                btnDesactivarMedico.Enabled = false;
                btnHorariosMedico.Enabled = false;
            }
        }

        private void LimpiarCampos()
        {
            txtIdMedico.Clear();
            txtNombreMedico.Clear();
            txtColegiadoMedico.Clear();
            cmbEspecialidadMedico.SelectedIndex = -1;
            dgvMedicos.ClearSelection();
            txtNombreMedico.Focus();
        }

        private void MostrarMedicos(string busqueda)
        {
            dgvMedicos.Rows.Clear();

            foreach (Medico medico in datos.Medicos)
            {
                Especialidad? especialidad = datos.Especialidades.Find(
                    esp => esp.Id == medico.EspecialidadId
                );

                string nombreEspecialidad =
                    especialidad?.Nombre ?? "Sin especialidad";

                bool coincide =
                    string.IsNullOrWhiteSpace(busqueda) ||
                    medico.Id.ToString() == busqueda ||
                    medico.Nombre.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    medico.Colegiado.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    nombreEspecialidad.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0;

                if (coincide)
                {
                    dgvMedicos.Rows.Add(
                        medico.Id,
                        medico.Nombre,
                        medico.Colegiado,
                        nombreEspecialidad,
                        medico.Activo ? "Activo" : "Inactivo"
                    );
                }
            }
        }

        private Medico? ObtenerMedicoSeleccionado()
        {
            if (!int.TryParse(txtIdMedico.Text, out int id))
                return null;

            return datos.Medicos.Find(m => m.Id == id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMedico.Text.Trim();
            string colegiado = txtColegiadoMedico.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresá el nombre del médico.");
                txtNombreMedico.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(colegiado))
            {
                MessageBox.Show("Ingresá el número de colegiado.");
                txtColegiadoMedico.Focus();
                return;
            }

            if (cmbEspecialidadMedico.SelectedItem
                is not Especialidad especialidad)
            {
                MessageBox.Show("Seleccioná una especialidad.");
                return;
            }

            bool esNuevo = string.IsNullOrWhiteSpace(txtIdMedico.Text);
            Medico? seleccionado = ObtenerMedicoSeleccionado();

            if (!esNuevo && seleccionado == null)
            {
                MessageBox.Show("No se encontró el médico.");
                return;
            }

            int idActual = seleccionado?.Id ?? 0;

            bool repetido = datos.Medicos.Exists(
                m => m.Id != idActual &&
                    string.Equals(
                        m.Colegiado,
                        colegiado,
                        StringComparison.OrdinalIgnoreCase)
            );

            if (repetido)
            {
                MessageBox.Show(
                    "Ya existe un médico con ese colegiado.");
                return;
            }

            Medico medicoGuardar = seleccionado ?? new Medico
            {
                Id = datos.Medicos.Count == 0
                    ? 1
                    : datos.Medicos.Max(m => m.Id) + 1
            };

            string nombreAnterior = medicoGuardar.Nombre;
            string colegiadoAnterior = medicoGuardar.Colegiado;
            int especialidadAnterior = medicoGuardar.EspecialidadId;

            medicoGuardar.Nombre = nombre;
            medicoGuardar.Colegiado = colegiado;
            medicoGuardar.EspecialidadId = especialidad.Id;

            if (esNuevo)
                datos.Medicos.Add(medicoGuardar);

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                if (esNuevo)
                {
                    datos.Medicos.Remove(medicoGuardar);
                }
                else
                {
                    medicoGuardar.Nombre = nombreAnterior;
                    medicoGuardar.Colegiado = colegiadoAnterior;
                    medicoGuardar.EspecialidadId = especialidadAnterior;
                }

                MessageBox.Show(
                    "No se pudo guardar el médico:\n" + ex.Message);
                return;
            }

            txtBuscarMedico.Clear();
            MostrarMedicos("");
            LimpiarCampos();

            MessageBox.Show("Médico guardado correctamente.");
        }

        private void dgvMedicos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvMedicos.Rows[e.RowIndex]
                    .Cells["colIdMedico"].Value
            );

            Medico? medico = datos.Medicos.Find(m => m.Id == id);

            if (medico == null)
                return;

            txtIdMedico.Text = medico.Id.ToString();
            txtNombreMedico.Text = medico.Nombre;
            txtColegiadoMedico.Text = medico.Colegiado;
            cmbEspecialidadMedico.SelectedValue = medico.EspecialidadId;
        }

        private void btnDesactivarMedico_Click(
            object sender, EventArgs e)
        {
            Medico? medico = ObtenerMedicoSeleccionado();

            if (medico == null)
            {
                MessageBox.Show("Seleccioná un médico de la tabla.");
                return;
            }

            if (!medico.Activo)
            {
                MessageBox.Show("Este médico ya está inactivo.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Querés desactivar a " + medico.Nombre + "?",
                "Desactivar médico",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            medico.Desactivar();

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                medico.Activo = true;

                MessageBox.Show(
                    "No se pudo guardar la desactivación:\n" + ex.Message);
                return;
            }

            MostrarMedicos(txtBuscarMedico.Text.Trim());
            LimpiarCampos();

            MessageBox.Show("Médico desactivado correctamente.");
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            MostrarMedicos(txtBuscarMedico.Text.Trim());
            LimpiarCampos();

            if (dgvMedicos.Rows.Count == 0)
                MessageBox.Show("No se encontraron médicos.");
        }

        private void btnMostrarTodosMedicos_Click(
            object sender, EventArgs e)
        {
            txtBuscarMedico.Clear();
            MostrarMedicos("");
            LimpiarCampos();
        }

        private void btnVolverMedicos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHorariosMedico_Click(object sender, EventArgs e)
        {
            Medico? medico = ObtenerMedicoSeleccionado();

            if (medico == null)
            {
                MessageBox.Show("Seleccioná un médico de la tabla.");
                return;
            }

            if (!medico.Activo)
            {
                MessageBox.Show(
                    "Seleccioná un médico activo para configurar horarios.");
                return;
            }

            using (Form ventana = new Form())
            {
                ventana.Text = "Horarios de " + medico.Nombre;
                ventana.ClientSize = new System.Drawing.Size(650, 410);
                ventana.StartPosition = FormStartPosition.CenterParent;

                Label instrucciones = new Label
                {
                    Text = "Ingresá horas en formato 24 horas: 08:00, 14:30."
                         + "\nPara quitar un horario, seleccioná su fila y presioná Supr.",
                    AutoSize = true,
                    Location = new System.Drawing.Point(15, 15)
                };

                DataGridView tabla = new DataGridView
                {
                    Location = new System.Drawing.Point(15, 65),
                    Size = new System.Drawing.Size(620, 280),
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    AllowUserToAddRows = true,
                    AllowUserToDeleteRows = true,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    MultiSelect = false
                };

                string[] dias =
                {
                    "Domingo", "Lunes", "Martes", "Miércoles",
                    "Jueves", "Viernes", "Sábado"
                };

                DataGridViewComboBoxColumn columnaDia =
                    new DataGridViewComboBoxColumn
                    {
                        Name = "Dia",
                        HeaderText = "Día"
                    };

                columnaDia.Items.AddRange(dias);
                tabla.Columns.Add(columnaDia);
                tabla.Columns.Add("Inicio", "Hora de inicio");
                tabla.Columns.Add("Fin", "Hora de fin");

                foreach (HorarioMedico horario in datos.Horarios)
                {
                    if (horario.MedicoId == medico.Id)
                    {
                        int fila = tabla.Rows.Add(
                            dias[(int)horario.Dia],
                            horario.HoraInicio.ToString(@"hh\:mm"),
                            horario.HoraFin.ToString(@"hh\:mm")
                        );

                        tabla.Rows[fila].Tag = horario.Id;
                    }
                }

                Button guardar = new Button
                {
                    Text = "Guardar horarios",
                    Location = new System.Drawing.Point(15, 360),
                    Size = new System.Drawing.Size(170, 35)
                };

                Button volver = new Button
                {
                    Text = "Volver",
                    Location = new System.Drawing.Point(515, 360),
                    Size = new System.Drawing.Size(120, 35)
                };

                volver.Click += (s, args) => ventana.Close();

                guardar.Click += (s, args) =>
                {
                    tabla.EndEdit();

                    List<HorarioMedico> nuevos = new List<HorarioMedico>();

                    int siguienteId = datos.Horarios.Count == 0
                        ? 1
                        : datos.Horarios.Max(h => h.Id) + 1;

                    foreach (DataGridViewRow fila in tabla.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        string diaTexto =
                            Convert.ToString(fila.Cells["Dia"].Value) ?? "";

                        string inicioTexto =
                            Convert.ToString(fila.Cells["Inicio"].Value) ?? "";

                        string finTexto =
                            Convert.ToString(fila.Cells["Fin"].Value) ?? "";

                        int dia = Array.IndexOf(dias, diaTexto);

                        bool inicioValido = TimeSpan.TryParseExact(
                            inicioTexto.Trim(),
                            @"hh\:mm",
                            CultureInfo.InvariantCulture,
                            out TimeSpan inicio
                        );

                        bool finValido = TimeSpan.TryParseExact(
                            finTexto.Trim(),
                            @"hh\:mm",
                            CultureInfo.InvariantCulture,
                            out TimeSpan fin
                        );

                        if (dia < 0 || !inicioValido || !finValido ||
                            inicio < TimeSpan.Zero ||
                            fin >= TimeSpan.FromDays(1) ||
                            inicio >= fin)
                        {
                            MessageBox.Show(
                                "Revisá la fila " + (fila.Index + 1) +
                                ": elegí un día y horas válidas en formato HH:mm."
                                + "\nLa hora de fin debe ser posterior al inicio.");
                            return;
                        }

                        bool seCruza = nuevos.Exists(
                            h => h.Dia == (DayOfWeek)dia &&
                                inicio < h.HoraFin &&
                                fin > h.HoraInicio
                        );

                        if (seCruza)
                        {
                            MessageBox.Show(
                                "Hay horarios superpuestos el " + diaTexto + ".");
                            return;
                        }

                        int idHorario;

                        if (fila.Tag is int idExistente)
                            idHorario = idExistente;
                        else
                            idHorario = siguienteId++;

                        nuevos.Add(new HorarioMedico
                        {
                            Id = idHorario,
                            MedicoId = medico.Id,
                            Dia = (DayOfWeek)dia,
                            HoraInicio = inicio,
                            HoraFin = fin
                        });
                    }

                    List<HorarioMedico> anteriores = datos.Horarios;

                    datos.Horarios = anteriores
                        .Where(h => h.MedicoId != medico.Id)
                        .ToList();

                    datos.Horarios.AddRange(nuevos);

                    try
                    {
                        repositorio.Guardar(datos);
                    }
                    catch (Exception ex)
                    {
                        datos.Horarios = anteriores;

                        MessageBox.Show(
                            "No se pudieron guardar los horarios:\n" + ex.Message);
                        return;
                    }

                    MessageBox.Show("Horarios guardados correctamente.");
                    ventana.Close();
                };

                ventana.Controls.Add(instrucciones);
                ventana.Controls.Add(tabla);
                ventana.Controls.Add(guardar);
                ventana.Controls.Add(volver);

                ventana.ShowDialog(this);
            }
        }

        // Conservar eventos que ya estaban conectados en el diseñador.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
        }
    }
}