using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sistema_Hospitalario
{
    public partial class Form2 : Form
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private int siguienteId = 1;
        private RepositorioJson repositorio = new RepositorioJson();
        private DatosHospital datos = new DatosHospital();

        public Form2()
        {
            InitializeComponent();
            try
            {
                datos = repositorio.Cargar();
                pacientes = datos.Pacientes;

                int siguienteIdExpediente = 1;

                foreach (Expediente expediente in datos.Expedientes)
                {
                    if (expediente.Id >= siguienteIdExpediente)
                        siguienteIdExpediente = expediente.Id + 1;
                }

                bool seCrearonExpedientes = false;

                foreach (Paciente paciente in pacientes)
                {
                    bool tieneExpediente = datos.Expedientes.Exists(
                        expediente => expediente.PacienteId == paciente.Id
                    );

                    if (!tieneExpediente)
                    {
                        datos.Expedientes.Add(
                            new Expediente(siguienteIdExpediente, paciente.Id)
                        );

                        siguienteIdExpediente++;
                        seCrearonExpedientes = true;
                    }
                }

                if (seCrearonExpedientes)
                {
                    repositorio.Guardar(datos);
                }

                dgvPacientes.Rows.Clear();

                foreach (Paciente paciente in pacientes)
                {
                    // Continuar los códigos después del mayor registrado.
                    if (paciente.Id >= siguienteId)
                        siguienteId = paciente.Id + 1;

                    dgvPacientes.Rows.Add(
                        paciente.Id,
                        paciente.Nombre,
                        paciente.Documento,
                        paciente.FechaNacimiento.ToString("dd/MM/yyyy"),
                        paciente.Contacto,
                        paciente.Activo ? "Activo" : "Inactivo"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos:\n" + ex.Message,
                    "Error al cargar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                btnGuardarPaciente.Enabled = false;
                btnDesactivarPaciente.Enabled = false;
            }
        }

        private void btnVolverPacientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            txtIdPaciente.Clear();
            txtNombrePaciente.Clear();
            txtDocumentoPaciente.Clear();
            dtpNacimientoPaciente.Value = DateTime.Today;
            txtContactoPaciente.Clear();
            txtAntecedentesPaciente.Clear();

            txtNombrePaciente.Focus();
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdPaciente.Text))
                {
                    // Registrar un paciente nuevo.
                    Paciente paciente = new Paciente(
                        siguienteId,
                        txtNombrePaciente.Text,
                        txtDocumentoPaciente.Text,
                        dtpNacimientoPaciente.Value,
                        txtContactoPaciente.Text,
                        txtAntecedentesPaciente.Text
                    );

                    // Obtener un código disponible para el expediente.
                    int idExpediente = 1;

                    foreach (Expediente expediente in datos.Expedientes)
                    {
                        if (expediente.Id >= idExpediente)
                            idExpediente = expediente.Id + 1;
                    }

                    // Crear el expediente del paciente nuevo.
                    Expediente nuevoExpediente = new Expediente(
                        idExpediente,
                        paciente.Id
                    );

                    pacientes.Add(paciente);
                    datos.Expedientes.Add(nuevoExpediente);
                    siguienteId++;
                }
                else
                {
                    // Actualizar el paciente seleccionado.
                    int id = int.Parse(txtIdPaciente.Text);
                    Paciente? paciente = pacientes.Find(p => p.Id == id);

                    if (paciente == null)
                    {
                        MessageBox.Show("No se encontró el paciente.");
                        return;
                    }

                    paciente.ActualizarDatos(
                        txtNombrePaciente.Text,
                        txtDocumentoPaciente.Text,
                        dtpNacimientoPaciente.Value,
                        txtContactoPaciente.Text,
                        txtAntecedentesPaciente.Text
                    );
                }

                repositorio.Guardar(datos);
                // Refrescar la tabla.
                dgvPacientes.Rows.Clear();

                foreach (Paciente paciente in pacientes)
                {
                    dgvPacientes.Rows.Add(
                        paciente.Id,
                        paciente.Nombre,
                        paciente.Documento,
                        paciente.FechaNacimiento.ToString("dd/MM/yyyy"),
                        paciente.Contacto,
                        paciente.Activo ? "Activo" : "Inactivo"
                    );
                }

                btnNuevoPaciente.PerformClick();

                MessageBox.Show(
                    "Datos guardados correctamente.",
                    "Pacientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Revisá los datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];

            int id = Convert.ToInt32(
                fila.Cells["colIdPaciente"].Value
            );

            Paciente? paciente = pacientes.Find(p => p.Id == id);

            if (paciente == null)
                return;

            txtIdPaciente.Text = paciente.Id.ToString();
            txtNombrePaciente.Text = paciente.Nombre;
            txtDocumentoPaciente.Text = paciente.Documento;
            dtpNacimientoPaciente.Value = paciente.FechaNacimiento;
            txtContactoPaciente.Text = paciente.Contacto;
            txtAntecedentesPaciente.Text = paciente.Antecedentes;
        }

        private void btnDesactivarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPaciente.Text))
            {
                MessageBox.Show("Seleccioná un paciente de la tabla.");
                return;
            }

            int id = int.Parse(txtIdPaciente.Text);
            Paciente? paciente = pacientes.Find(p => p.Id == id);

            if (paciente == null)
            {
                MessageBox.Show("No se encontró el paciente.");
                return;
            }

            if (!paciente.Activo)
            {
                MessageBox.Show("Este paciente ya está inactivo.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Querés desactivar a " + paciente.Nombre + "?",
                "Desactivar paciente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            paciente.Desactivar();

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                // Recuperar el estado anterior si falla el guardado.
                paciente.Activo = true;

                MessageBox.Show(
                    "No se pudo guardar la desactivación:\n" + ex.Message,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Actualizar el estado en la tabla.
            foreach (DataGridViewRow fila in dgvPacientes.Rows)
            {
                if (Convert.ToInt32(fila.Cells["colIdPaciente"].Value) == id)
                {
                    fila.Cells["colEstadoPaciente"].Value = "Inactivo";
                    break;
                }
            }

            btnNuevoPaciente.PerformClick();

            MessageBox.Show("Paciente desactivado correctamente.");
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarPaciente.Text.Trim();

            dgvPacientes.Rows.Clear();

            foreach (Paciente paciente in pacientes)
            {
                bool coincide =
                    string.IsNullOrEmpty(busqueda) ||
                    paciente.Id.ToString() == busqueda ||
                    paciente.Nombre.IndexOf(
                        busqueda, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    paciente.Documento.IndexOf(
                        busqueda, StringComparison.OrdinalIgnoreCase) >= 0;

                if (coincide)
                {
                    dgvPacientes.Rows.Add(
                        paciente.Id,
                        paciente.Nombre,
                        paciente.Documento,
                        paciente.FechaNacimiento.ToString("dd/MM/yyyy"),
                        paciente.Contacto,
                        paciente.Activo ? "Activo" : "Inactivo"
                    );
                }
            }

            // Limpiar los campos del paciente seleccionado.
            btnNuevoPaciente.PerformClick();

            if (dgvPacientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron pacientes.");
            }
        }

        private void btnMostrarTodosPacientes_Click(object sender, EventArgs e)
        {
            txtBuscarPaciente.Clear();
            btnBuscarPaciente.PerformClick();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnVerExpediente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPaciente.Text))
            {
                MessageBox.Show("Seleccioná un paciente de la tabla.");
                return;
            }

            int id = int.Parse(txtIdPaciente.Text);

            Paciente? paciente = pacientes.Find(p => p.Id == id);

            Expediente? expediente = datos.Expedientes.Find(
                exp => exp.PacienteId == id
            );

            if (paciente == null || expediente == null)
            {
                MessageBox.Show(
                    "No se encontró el paciente o su expediente.");
                return;
            }

            using (Form3 ventana = new Form3(paciente, expediente, datos))
            {
                ventana.ShowDialog(this);
            }
        }
    }
}
