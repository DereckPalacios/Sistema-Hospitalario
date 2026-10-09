using System;
using System.Windows.Forms;

namespace Sistema_Hospitalario
{
    public partial class FrmEspecialidades : Form
    {
        private DatosHospital datos = new DatosHospital();
        private RepositorioJson repositorio = new RepositorioJson();

        public FrmEspecialidades()
        {
            InitializeComponent();

            try
            {
                datos = repositorio.Cargar();
                MostrarEspecialidades("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos:\n" + ex.Message,
                    "Error al cargar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                btnGuardarEspecialidad.Enabled = false;
            }
        }

        private void MostrarEspecialidades(string busqueda)
        {
            dgvEspecialidades.Rows.Clear();

            foreach (Especialidad especialidad in datos.Especialidades)
            {
                bool coincide =
                    string.IsNullOrWhiteSpace(busqueda) ||
                    especialidad.Id.ToString() == busqueda ||
                    especialidad.Nombre.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    especialidad.Clasificacion.IndexOf(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) >= 0;

                if (coincide)
                {
                    dgvEspecialidades.Rows.Add(
                        especialidad.Id,
                        especialidad.Nombre,
                        especialidad.Clasificacion
                    );
                }
            }
        }

        private void btnNuevaEspecialidad_Click(
            object sender, EventArgs e)
        {
            txtIdEspecialidad.Clear();
            txtNombreEspecialidad.Clear();
            cmbClasificacionEspecialidad.SelectedIndex = -1;

            txtNombreEspecialidad.Focus();
        }

        private void btnVolverEspecialidades_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEspecialidad_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEspecialidad.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresá el nombre de la especialidad.");
                txtNombreEspecialidad.Focus();
                return;
            }

            if (cmbClasificacionEspecialidad.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná una clasificación.");
                return;
            }

            string clasificacion = cmbClasificacionEspecialidad.Text;
            int idActual = 0;

            if (!string.IsNullOrWhiteSpace(txtIdEspecialidad.Text))
            {
                if (!int.TryParse(txtIdEspecialidad.Text, out idActual))
                {
                    MessageBox.Show("El código de la especialidad no es válido.");
                    return;
                }
            }

            // Evitar nombres repetidos.
            bool repetida = datos.Especialidades.Exists(
                especialidad =>
                    especialidad.Id != idActual &&
                    string.Equals(
                        especialidad.Nombre,
                        nombre,
                        StringComparison.OrdinalIgnoreCase)
            );

            if (repetida)
            {
                MessageBox.Show("Ya existe una especialidad con ese nombre.");
                return;
            }

            Especialidad especialidadGuardar;
            bool esNueva = idActual == 0;
            string nombreAnterior = "";
            string clasificacionAnterior = "";

            if (esNueva)
            {
                int siguienteId = 1;

                foreach (Especialidad especialidad in datos.Especialidades)
                {
                    if (especialidad.Id >= siguienteId)
                        siguienteId = especialidad.Id + 1;
                }

                especialidadGuardar = new Especialidad
                {
                    Id = siguienteId,
                    Nombre = nombre,
                    Clasificacion = clasificacion
                };

                datos.Especialidades.Add(especialidadGuardar);
            }
            else
            {
                Especialidad? encontrada = datos.Especialidades.Find(
                    especialidad => especialidad.Id == idActual
                );

                if (encontrada == null)
                {
                    MessageBox.Show("No se encontró la especialidad.");
                    return;
                }

                especialidadGuardar = encontrada;
                nombreAnterior = encontrada.Nombre;
                clasificacionAnterior = encontrada.Clasificacion;

                encontrada.Nombre = nombre;
                encontrada.Clasificacion = clasificacion;
            }

            try
            {
                repositorio.Guardar(datos);
            }
            catch (Exception ex)
            {
                // Revertir el cambio si falla el guardado.
                if (esNueva)
                {
                    datos.Especialidades.Remove(especialidadGuardar);
                }
                else
                {
                    especialidadGuardar.Nombre = nombreAnterior;
                    especialidadGuardar.Clasificacion = clasificacionAnterior;
                }

                MessageBox.Show(
                    "No se pudo guardar:\n" + ex.Message,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            MostrarEspecialidades("");
            txtBuscarEspecialidad.Clear();
            btnNuevaEspecialidad.PerformClick();

            MessageBox.Show("Especialidad guardada correctamente.");
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dgvEspecialidades.Rows[e.RowIndex]
                    .Cells["colIdEspecialidad"].Value
            );

            Especialidad? especialidad = datos.Especialidades.Find(
                especialidad => especialidad.Id == id
            );

            if (especialidad == null)
                return;

            txtIdEspecialidad.Text = especialidad.Id.ToString();
            txtNombreEspecialidad.Text = especialidad.Nombre;
            cmbClasificacionEspecialidad.SelectedItem =
                especialidad.Clasificacion;
        }

        private void btnBuscarEspecialidad_Click(object sender, EventArgs e)
        {
            MostrarEspecialidades(txtBuscarEspecialidad.Text.Trim());
            btnNuevaEspecialidad.PerformClick();

            if (dgvEspecialidades.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron especialidades.");
            }
        }

        private void btnMostrarTodasEspecialidades_Click(object sender, EventArgs e)
        {
            txtBuscarEspecialidad.Clear();
            MostrarEspecialidades("");
            btnNuevaEspecialidad.PerformClick();
        }
    }
}