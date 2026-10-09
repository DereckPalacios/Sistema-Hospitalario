namespace Sistema_Hospitalario
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDatosPaciente = new Panel();
            txtAntecedentesPaciente = new TextBox();
            txtContactoPaciente = new TextBox();
            dtpNacimientoPaciente = new DateTimePicker();
            txtDocumentoPaciente = new TextBox();
            txtNombrePaciente = new TextBox();
            txtIdPaciente = new TextBox();
            lblAntecedentesPaciente = new Label();
            lblContactoPaciente = new Label();
            lblNacimientoPaciente = new Label();
            lblDocumentoPaciente = new Label();
            lblNombrePaciente = new Label();
            lblIdPaciente = new Label();
            lblDatosPaciente = new Label();
            pnlAccionesPacientes = new Panel();
            btnVolverPacientes = new Button();
            btnVerExpediente = new Button();
            btnDesactivarPaciente = new Button();
            btnGuardarPaciente = new Button();
            btnNuevoPaciente = new Button();
            pnlListaPacientes = new Panel();
            dgvPacientes = new DataGridView();
            colIdPaciente = new DataGridViewTextBoxColumn();
            colNombrePaciente = new DataGridViewTextBoxColumn();
            colDocumentoPaciente = new DataGridViewTextBoxColumn();
            colNacimientoPaciente = new DataGridViewTextBoxColumn();
            colContactoPaciente = new DataGridViewTextBoxColumn();
            colEstadoPaciente = new DataGridViewTextBoxColumn();
            btnMostrarTodosPacientes = new Button();
            btnBuscarPaciente = new Button();
            txtBuscarPaciente = new TextBox();
            lblBuscarPaciente = new Label();
            pnlDatosPaciente.SuspendLayout();
            pnlAccionesPacientes.SuspendLayout();
            pnlListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // pnlDatosPaciente
            // 
            pnlDatosPaciente.BackColor = Color.White;
            pnlDatosPaciente.BorderStyle = BorderStyle.FixedSingle;
            pnlDatosPaciente.Controls.Add(txtAntecedentesPaciente);
            pnlDatosPaciente.Controls.Add(txtContactoPaciente);
            pnlDatosPaciente.Controls.Add(dtpNacimientoPaciente);
            pnlDatosPaciente.Controls.Add(txtDocumentoPaciente);
            pnlDatosPaciente.Controls.Add(txtNombrePaciente);
            pnlDatosPaciente.Controls.Add(txtIdPaciente);
            pnlDatosPaciente.Controls.Add(lblAntecedentesPaciente);
            pnlDatosPaciente.Controls.Add(lblContactoPaciente);
            pnlDatosPaciente.Controls.Add(lblNacimientoPaciente);
            pnlDatosPaciente.Controls.Add(lblDocumentoPaciente);
            pnlDatosPaciente.Controls.Add(lblNombrePaciente);
            pnlDatosPaciente.Controls.Add(lblIdPaciente);
            pnlDatosPaciente.Controls.Add(lblDatosPaciente);
            pnlDatosPaciente.Location = new Point(20, 20);
            pnlDatosPaciente.Name = "pnlDatosPaciente";
            pnlDatosPaciente.Size = new Size(940, 290);
            pnlDatosPaciente.TabIndex = 0;
            // 
            // txtAntecedentesPaciente
            // 
            txtAntecedentesPaciente.Font = new Font("Segoe UI", 11F);
            txtAntecedentesPaciente.Location = new Point(20, 240);
            txtAntecedentesPaciente.Multiline = true;
            txtAntecedentesPaciente.Name = "txtAntecedentesPaciente";
            txtAntecedentesPaciente.ScrollBars = ScrollBars.Vertical;
            txtAntecedentesPaciente.Size = new Size(890, 35);
            txtAntecedentesPaciente.TabIndex = 12;
            // 
            // txtContactoPaciente
            // 
            txtContactoPaciente.Font = new Font("Segoe UI", 11F);
            txtContactoPaciente.Location = new Point(300, 165);
            txtContactoPaciente.Name = "txtContactoPaciente";
            txtContactoPaciente.Size = new Size(610, 27);
            txtContactoPaciente.TabIndex = 11;
            // 
            // dtpNacimientoPaciente
            // 
            dtpNacimientoPaciente.Format = DateTimePickerFormat.Short;
            dtpNacimientoPaciente.Location = new Point(20, 165);
            dtpNacimientoPaciente.Name = "dtpNacimientoPaciente";
            dtpNacimientoPaciente.Size = new Size(250, 23);
            dtpNacimientoPaciente.TabIndex = 10;
            // 
            // txtDocumentoPaciente
            // 
            txtDocumentoPaciente.Font = new Font("Segoe UI", 11F);
            txtDocumentoPaciente.Location = new Point(620, 90);
            txtDocumentoPaciente.Name = "txtDocumentoPaciente";
            txtDocumentoPaciente.Size = new Size(290, 27);
            txtDocumentoPaciente.TabIndex = 9;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Font = new Font("Segoe UI", 11F);
            txtNombrePaciente.Location = new Point(180, 90);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(410, 27);
            txtNombrePaciente.TabIndex = 8;
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Font = new Font("Segoe UI", 11F);
            txtIdPaciente.Location = new Point(20, 90);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.ReadOnly = true;
            txtIdPaciente.Size = new Size(130, 27);
            txtIdPaciente.TabIndex = 7;
            // 
            // lblAntecedentesPaciente
            // 
            lblAntecedentesPaciente.AutoSize = true;
            lblAntecedentesPaciente.Font = new Font("Segoe UI", 10F);
            lblAntecedentesPaciente.Location = new Point(20, 215);
            lblAntecedentesPaciente.Name = "lblAntecedentesPaciente";
            lblAntecedentesPaciente.Size = new Size(146, 19);
            lblAntecedentesPaciente.TabIndex = 6;
            lblAntecedentesPaciente.Text = "Antecedentes médicos";
            // 
            // lblContactoPaciente
            // 
            lblContactoPaciente.AutoSize = true;
            lblContactoPaciente.Font = new Font("Segoe UI", 10F);
            lblContactoPaciente.Location = new Point(300, 140);
            lblContactoPaciente.Name = "lblContactoPaciente";
            lblContactoPaciente.Size = new Size(65, 19);
            lblContactoPaciente.TabIndex = 5;
            lblContactoPaciente.Text = "Contacto";
            // 
            // lblNacimientoPaciente
            // 
            lblNacimientoPaciente.AutoSize = true;
            lblNacimientoPaciente.Font = new Font("Segoe UI", 10F);
            lblNacimientoPaciente.Location = new Point(20, 140);
            lblNacimientoPaciente.Name = "lblNacimientoPaciente";
            lblNacimientoPaciente.Size = new Size(134, 19);
            lblNacimientoPaciente.TabIndex = 4;
            lblNacimientoPaciente.Text = "Fecha de nacimiento";
            // 
            // lblDocumentoPaciente
            // 
            lblDocumentoPaciente.AutoSize = true;
            lblDocumentoPaciente.Font = new Font("Segoe UI", 10F);
            lblDocumentoPaciente.Location = new Point(620, 65);
            lblDocumentoPaciente.Name = "lblDocumentoPaciente";
            lblDocumentoPaciente.Size = new Size(81, 19);
            lblDocumentoPaciente.TabIndex = 3;
            lblDocumentoPaciente.Text = "Documento";
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Font = new Font("Segoe UI", 10F);
            lblNombrePaciente.Location = new Point(180, 65);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(120, 19);
            lblNombrePaciente.TabIndex = 2;
            lblNombrePaciente.Text = "Nombre completo";
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Font = new Font("Segoe UI", 10F);
            lblIdPaciente.Location = new Point(20, 65);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(53, 19);
            lblIdPaciente.TabIndex = 1;
            lblIdPaciente.Text = "Código";
            // 
            // lblDatosPaciente
            // 
            lblDatosPaciente.AutoSize = true;
            lblDatosPaciente.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDatosPaciente.ForeColor = Color.FromArgb(15, 42, 68);
            lblDatosPaciente.Location = new Point(20, 15);
            lblDatosPaciente.Name = "lblDatosPaciente";
            lblDatosPaciente.Size = new Size(206, 30);
            lblDatosPaciente.TabIndex = 0;
            lblDatosPaciente.Text = "Datos del paciente";
            // 
            // pnlAccionesPacientes
            // 
            pnlAccionesPacientes.BackColor = Color.White;
            pnlAccionesPacientes.Controls.Add(btnVolverPacientes);
            pnlAccionesPacientes.Controls.Add(btnVerExpediente);
            pnlAccionesPacientes.Controls.Add(btnDesactivarPaciente);
            pnlAccionesPacientes.Controls.Add(btnGuardarPaciente);
            pnlAccionesPacientes.Controls.Add(btnNuevoPaciente);
            pnlAccionesPacientes.Location = new Point(20, 320);
            pnlAccionesPacientes.Name = "pnlAccionesPacientes";
            pnlAccionesPacientes.Size = new Size(940, 60);
            pnlAccionesPacientes.TabIndex = 1;
            // 
            // btnVolverPacientes
            // 
            btnVolverPacientes.BackColor = Color.FromArgb(100, 110, 120);
            btnVolverPacientes.Cursor = Cursors.Hand;
            btnVolverPacientes.FlatAppearance.BorderSize = 0;
            btnVolverPacientes.FlatStyle = FlatStyle.Flat;
            btnVolverPacientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolverPacientes.ForeColor = Color.White;
            btnVolverPacientes.Location = new Point(790, 10);
            btnVolverPacientes.Name = "btnVolverPacientes";
            btnVolverPacientes.Size = new Size(140, 40);
            btnVolverPacientes.TabIndex = 4;
            btnVolverPacientes.Text = "Volver";
            btnVolverPacientes.UseVisualStyleBackColor = false;
            btnVolverPacientes.Click += btnVolverPacientes_Click;
            // 
            // btnVerExpediente
            // 
            btnVerExpediente.BackColor = Color.FromArgb(40, 120, 230);
            btnVerExpediente.Cursor = Cursors.Hand;
            btnVerExpediente.FlatAppearance.BorderSize = 0;
            btnVerExpediente.FlatStyle = FlatStyle.Flat;
            btnVerExpediente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerExpediente.ForeColor = Color.White;
            btnVerExpediente.Location = new Point(460, 10);
            btnVerExpediente.Name = "btnVerExpediente";
            btnVerExpediente.Size = new Size(140, 40);
            btnVerExpediente.TabIndex = 3;
            btnVerExpediente.Text = "Ver expediente";
            btnVerExpediente.UseVisualStyleBackColor = false;
            btnVerExpediente.Click += btnVerExpediente_Click;
            // 
            // btnDesactivarPaciente
            // 
            btnDesactivarPaciente.BackColor = Color.FromArgb(190, 65, 65);
            btnDesactivarPaciente.Cursor = Cursors.Hand;
            btnDesactivarPaciente.FlatAppearance.BorderSize = 0;
            btnDesactivarPaciente.FlatStyle = FlatStyle.Flat;
            btnDesactivarPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDesactivarPaciente.ForeColor = Color.White;
            btnDesactivarPaciente.Location = new Point(310, 10);
            btnDesactivarPaciente.Name = "btnDesactivarPaciente";
            btnDesactivarPaciente.Size = new Size(140, 40);
            btnDesactivarPaciente.TabIndex = 2;
            btnDesactivarPaciente.Text = "Desactivar";
            btnDesactivarPaciente.UseVisualStyleBackColor = false;
            btnDesactivarPaciente.Click += btnDesactivarPaciente_Click;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.BackColor = Color.FromArgb(0, 166, 180);
            btnGuardarPaciente.Cursor = Cursors.Hand;
            btnGuardarPaciente.FlatAppearance.BorderSize = 0;
            btnGuardarPaciente.FlatStyle = FlatStyle.Flat;
            btnGuardarPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarPaciente.ForeColor = Color.White;
            btnGuardarPaciente.Location = new Point(160, 10);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(140, 40);
            btnGuardarPaciente.TabIndex = 1;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = false;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.BackColor = Color.FromArgb(15, 42, 68);
            btnNuevoPaciente.Cursor = Cursors.Hand;
            btnNuevoPaciente.FlatAppearance.BorderSize = 0;
            btnNuevoPaciente.FlatStyle = FlatStyle.Flat;
            btnNuevoPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoPaciente.ForeColor = Color.White;
            btnNuevoPaciente.Location = new Point(10, 10);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(140, 40);
            btnNuevoPaciente.TabIndex = 0;
            btnNuevoPaciente.Text = "Nuevo";
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            btnNuevoPaciente.Click += btnNuevoPaciente_Click;
            // 
            // pnlListaPacientes
            // 
            pnlListaPacientes.BackColor = Color.White;
            pnlListaPacientes.BorderStyle = BorderStyle.FixedSingle;
            pnlListaPacientes.Controls.Add(dgvPacientes);
            pnlListaPacientes.Controls.Add(btnMostrarTodosPacientes);
            pnlListaPacientes.Controls.Add(btnBuscarPaciente);
            pnlListaPacientes.Controls.Add(txtBuscarPaciente);
            pnlListaPacientes.Controls.Add(lblBuscarPaciente);
            pnlListaPacientes.Location = new Point(20, 390);
            pnlListaPacientes.Name = "pnlListaPacientes";
            pnlListaPacientes.Size = new Size(940, 210);
            pnlListaPacientes.TabIndex = 2;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { colIdPaciente, colNombrePaciente, colDocumentoPaciente, colNacimientoPaciente, colContactoPaciente, colEstadoPaciente });
            dgvPacientes.Location = new Point(15, 65);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(910, 130);
            dgvPacientes.TabIndex = 4;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            // 
            // colIdPaciente
            // 
            colIdPaciente.HeaderText = "Código";
            colIdPaciente.Name = "colIdPaciente";
            colIdPaciente.ReadOnly = true;
            // 
            // colNombrePaciente
            // 
            colNombrePaciente.HeaderText = "Nombre completo";
            colNombrePaciente.Name = "colNombrePaciente";
            colNombrePaciente.ReadOnly = true;
            // 
            // colDocumentoPaciente
            // 
            colDocumentoPaciente.HeaderText = "Documento";
            colDocumentoPaciente.Name = "colDocumentoPaciente";
            colDocumentoPaciente.ReadOnly = true;
            // 
            // colNacimientoPaciente
            // 
            colNacimientoPaciente.HeaderText = "Fecha de nacimiento";
            colNacimientoPaciente.Name = "colNacimientoPaciente";
            colNacimientoPaciente.ReadOnly = true;
            // 
            // colContactoPaciente
            // 
            colContactoPaciente.HeaderText = "Contacto";
            colContactoPaciente.Name = "colContactoPaciente";
            colContactoPaciente.ReadOnly = true;
            // 
            // colEstadoPaciente
            // 
            colEstadoPaciente.HeaderText = "Estado";
            colEstadoPaciente.Name = "colEstadoPaciente";
            colEstadoPaciente.ReadOnly = true;
            // 
            // btnMostrarTodosPacientes
            // 
            btnMostrarTodosPacientes.BackColor = Color.FromArgb(15, 42, 68);
            btnMostrarTodosPacientes.Cursor = Cursors.Hand;
            btnMostrarTodosPacientes.FlatAppearance.BorderSize = 0;
            btnMostrarTodosPacientes.FlatStyle = FlatStyle.Flat;
            btnMostrarTodosPacientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMostrarTodosPacientes.ForeColor = Color.White;
            btnMostrarTodosPacientes.Location = new Point(775, 10);
            btnMostrarTodosPacientes.Name = "btnMostrarTodosPacientes";
            btnMostrarTodosPacientes.Size = new Size(150, 40);
            btnMostrarTodosPacientes.TabIndex = 3;
            btnMostrarTodosPacientes.Text = "Mostrar todos";
            btnMostrarTodosPacientes.UseVisualStyleBackColor = false;
            btnMostrarTodosPacientes.Click += btnMostrarTodosPacientes_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(15, 42, 68);
            btnBuscarPaciente.Cursor = Cursors.Hand;
            btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarPaciente.ForeColor = Color.White;
            btnBuscarPaciente.Location = new Point(605, 10);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(140, 40);
            btnBuscarPaciente.TabIndex = 2;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Font = new Font("Segoe UI", 10F);
            txtBuscarPaciente.Location = new Point(150, 15);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(440, 25);
            txtBuscarPaciente.TabIndex = 1;
            // 
            // lblBuscarPaciente
            // 
            lblBuscarPaciente.AutoSize = true;
            lblBuscarPaciente.Font = new Font("Segoe UI", 10F);
            lblBuscarPaciente.Location = new Point(15, 18);
            lblBuscarPaciente.Name = "lblBuscarPaciente";
            lblBuscarPaciente.Size = new Size(104, 19);
            lblBuscarPaciente.TabIndex = 0;
            lblBuscarPaciente.Text = "Buscar paciente";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(984, 611);
            Controls.Add(pnlListaPacientes);
            Controls.Add(pnlAccionesPacientes);
            Controls.Add(pnlDatosPaciente);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de pacientes";
            Load += Form2_Load;
            pnlDatosPaciente.ResumeLayout(false);
            pnlDatosPaciente.PerformLayout();
            pnlAccionesPacientes.ResumeLayout(false);
            pnlListaPacientes.ResumeLayout(false);
            pnlListaPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatosPaciente;
        private Label lblContactoPaciente;
        private Label lblNacimientoPaciente;
        private Label lblDocumentoPaciente;
        private Label lblNombrePaciente;
        private Label lblIdPaciente;
        private Label lblDatosPaciente;
        private DateTimePicker dtpNacimientoPaciente;
        private TextBox txtDocumentoPaciente;
        private TextBox txtNombrePaciente;
        private TextBox txtIdPaciente;
        private Label lblAntecedentesPaciente;
        private TextBox txtAntecedentesPaciente;
        private TextBox txtContactoPaciente;
        private Panel pnlAccionesPacientes;
        private Button btnVolverPacientes;
        private Button btnVerExpediente;
        private Button btnDesactivarPaciente;
        private Button btnGuardarPaciente;
        private Button btnNuevoPaciente;
        private Panel pnlListaPacientes;
        private DataGridView dgvPacientes;
        private Button btnMostrarTodosPacientes;
        private Button btnBuscarPaciente;
        private TextBox txtBuscarPaciente;
        private Label lblBuscarPaciente;
        private DataGridViewTextBoxColumn colIdPaciente;
        private DataGridViewTextBoxColumn colNombrePaciente;
        private DataGridViewTextBoxColumn colDocumentoPaciente;
        private DataGridViewTextBoxColumn colNacimientoPaciente;
        private DataGridViewTextBoxColumn colContactoPaciente;
        private DataGridViewTextBoxColumn colEstadoPaciente;
    }
}