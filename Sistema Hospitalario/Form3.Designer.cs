namespace Sistema_Hospitalario
{
    partial class Form3
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
            pnlResumenExpediente = new Panel();
            lblEstadoPacienteExpediente = new Label();
            lblFechaCreacionExpediente = new Label();
            lblContactoExpediente = new Label();
            lblNacimientoExpediente = new Label();
            lblDocumentoExpediente = new Label();
            lblCodigoExpediente = new Label();
            lblPacienteExpediente = new Label();
            lblTituloExpediente = new Label();
            pnlConsultaClinica = new Panel();
            txtTratamientoConsulta = new TextBox();
            txtObservacionesConsulta = new TextBox();
            txtResultadosConsulta = new TextBox();
            txtMedicamentosConsulta = new TextBox();
            txtDiagnosticoConsulta = new TextBox();
            lblObservacionesConsulta = new Label();
            lblTratamientoConsulta = new Label();
            lblResultadosConsulta = new Label();
            lblMedicamentosConsulta = new Label();
            lblDiagnosticoConsulta = new Label();
            lblFechaConsulta = new Label();
            lblTituloConsulta = new Label();
            pnlAccionesExpediente = new Panel();
            btnVolverExpediente = new Button();
            btnGuardarConsulta = new Button();
            btnNuevaConsulta = new Button();
            pnlHistorialConsultas = new Panel();
            dgvHistorialConsultas = new DataGridView();
            colIdConsulta = new DataGridViewTextBoxColumn();
            colFechaConsulta = new DataGridViewTextBoxColumn();
            colDiagnosticoConsulta = new DataGridViewTextBoxColumn();
            colMedicamentosConsulta = new DataGridViewTextBoxColumn();
            colResultadosConsulta = new DataGridViewTextBoxColumn();
            colTratamientoConsulta = new DataGridViewTextBoxColumn();
            colObservacionesConsulta = new DataGridViewTextBoxColumn();
            lblHistorialConsultas = new Label();
            dtpFechaConsulta = new DateTimePicker();
            pnlResumenExpediente.SuspendLayout();
            pnlConsultaClinica.SuspendLayout();
            pnlAccionesExpediente.SuspendLayout();
            pnlHistorialConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialConsultas).BeginInit();
            SuspendLayout();
            // 
            // pnlResumenExpediente
            // 
            pnlResumenExpediente.BackColor = Color.White;
            pnlResumenExpediente.BorderStyle = BorderStyle.FixedSingle;
            pnlResumenExpediente.Controls.Add(lblEstadoPacienteExpediente);
            pnlResumenExpediente.Controls.Add(lblFechaCreacionExpediente);
            pnlResumenExpediente.Controls.Add(lblContactoExpediente);
            pnlResumenExpediente.Controls.Add(lblNacimientoExpediente);
            pnlResumenExpediente.Controls.Add(lblDocumentoExpediente);
            pnlResumenExpediente.Controls.Add(lblCodigoExpediente);
            pnlResumenExpediente.Controls.Add(lblPacienteExpediente);
            pnlResumenExpediente.Controls.Add(lblTituloExpediente);
            pnlResumenExpediente.Location = new Point(20, 20);
            pnlResumenExpediente.Name = "pnlResumenExpediente";
            pnlResumenExpediente.Size = new Size(1040, 180);
            pnlResumenExpediente.TabIndex = 0;
            // 
            // lblEstadoPacienteExpediente
            // 
            lblEstadoPacienteExpediente.AutoSize = true;
            lblEstadoPacienteExpediente.BackColor = Color.Transparent;
            lblEstadoPacienteExpediente.Font = new Font("Segoe UI", 11F);
            lblEstadoPacienteExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblEstadoPacienteExpediente.Location = new Point(650, 140);
            lblEstadoPacienteExpediente.Name = "lblEstadoPacienteExpediente";
            lblEstadoPacienteExpediente.Size = new Size(162, 20);
            lblEstadoPacienteExpediente.TabIndex = 7;
            lblEstadoPacienteExpediente.Text = "Estado del paciente: —";
            // 
            // lblFechaCreacionExpediente
            // 
            lblFechaCreacionExpediente.AutoSize = true;
            lblFechaCreacionExpediente.BackColor = Color.Transparent;
            lblFechaCreacionExpediente.Font = new Font("Segoe UI", 11F);
            lblFechaCreacionExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblFechaCreacionExpediente.Location = new Point(20, 140);
            lblFechaCreacionExpediente.Name = "lblFechaCreacionExpediente";
            lblFechaCreacionExpediente.Size = new Size(150, 20);
            lblFechaCreacionExpediente.TabIndex = 6;
            lblFechaCreacionExpediente.Text = "Fecha de creación: —";
            // 
            // lblContactoExpediente
            // 
            lblContactoExpediente.AutoSize = true;
            lblContactoExpediente.BackColor = Color.Transparent;
            lblContactoExpediente.Font = new Font("Segoe UI", 11F);
            lblContactoExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblContactoExpediente.Location = new Point(650, 100);
            lblContactoExpediente.Name = "lblContactoExpediente";
            lblContactoExpediente.Size = new Size(91, 20);
            lblContactoExpediente.TabIndex = 5;
            lblContactoExpediente.Text = "Contacto: —";
            // 
            // lblNacimientoExpediente
            // 
            lblNacimientoExpediente.AutoSize = true;
            lblNacimientoExpediente.BackColor = Color.Transparent;
            lblNacimientoExpediente.Font = new Font("Segoe UI", 11F);
            lblNacimientoExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblNacimientoExpediente.Location = new Point(350, 100);
            lblNacimientoExpediente.Name = "lblNacimientoExpediente";
            lblNacimientoExpediente.Size = new Size(108, 20);
            lblNacimientoExpediente.TabIndex = 4;
            lblNacimientoExpediente.Text = "Nacimiento: —";
            // 
            // lblDocumentoExpediente
            // 
            lblDocumentoExpediente.AutoSize = true;
            lblDocumentoExpediente.BackColor = Color.Transparent;
            lblDocumentoExpediente.Font = new Font("Segoe UI", 11F);
            lblDocumentoExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblDocumentoExpediente.Location = new Point(20, 100);
            lblDocumentoExpediente.Name = "lblDocumentoExpediente";
            lblDocumentoExpediente.Size = new Size(109, 20);
            lblDocumentoExpediente.TabIndex = 3;
            lblDocumentoExpediente.Text = "Documento: —";
            // 
            // lblCodigoExpediente
            // 
            lblCodigoExpediente.AutoSize = true;
            lblCodigoExpediente.BackColor = Color.Transparent;
            lblCodigoExpediente.Font = new Font("Segoe UI", 11F);
            lblCodigoExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblCodigoExpediente.Location = new Point(650, 60);
            lblCodigoExpediente.Name = "lblCodigoExpediente";
            lblCodigoExpediente.Size = new Size(105, 20);
            lblCodigoExpediente.TabIndex = 2;
            lblCodigoExpediente.Text = "Expediente: —";
            // 
            // lblPacienteExpediente
            // 
            lblPacienteExpediente.AutoSize = true;
            lblPacienteExpediente.BackColor = Color.Transparent;
            lblPacienteExpediente.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPacienteExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblPacienteExpediente.Location = new Point(20, 60);
            lblPacienteExpediente.Name = "lblPacienteExpediente";
            lblPacienteExpediente.Size = new Size(113, 25);
            lblPacienteExpediente.TabIndex = 1;
            lblPacienteExpediente.Text = "Paciente: —";
            // 
            // lblTituloExpediente
            // 
            lblTituloExpediente.AutoSize = true;
            lblTituloExpediente.BackColor = Color.Transparent;
            lblTituloExpediente.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloExpediente.ForeColor = Color.FromArgb(15, 42, 68);
            lblTituloExpediente.Location = new Point(20, 15);
            lblTituloExpediente.Name = "lblTituloExpediente";
            lblTituloExpediente.Size = new Size(222, 32);
            lblTituloExpediente.TabIndex = 0;
            lblTituloExpediente.Text = "Expediente clínico";
            // 
            // pnlConsultaClinica
            // 
            pnlConsultaClinica.BackColor = Color.White;
            pnlConsultaClinica.BorderStyle = BorderStyle.FixedSingle;
            pnlConsultaClinica.Controls.Add(dtpFechaConsulta);
            pnlConsultaClinica.Controls.Add(txtTratamientoConsulta);
            pnlConsultaClinica.Controls.Add(txtObservacionesConsulta);
            pnlConsultaClinica.Controls.Add(txtResultadosConsulta);
            pnlConsultaClinica.Controls.Add(txtMedicamentosConsulta);
            pnlConsultaClinica.Controls.Add(txtDiagnosticoConsulta);
            pnlConsultaClinica.Controls.Add(lblObservacionesConsulta);
            pnlConsultaClinica.Controls.Add(lblTratamientoConsulta);
            pnlConsultaClinica.Controls.Add(lblResultadosConsulta);
            pnlConsultaClinica.Controls.Add(lblMedicamentosConsulta);
            pnlConsultaClinica.Controls.Add(lblDiagnosticoConsulta);
            pnlConsultaClinica.Controls.Add(lblFechaConsulta);
            pnlConsultaClinica.Controls.Add(lblTituloConsulta);
            pnlConsultaClinica.Location = new Point(20, 215);
            pnlConsultaClinica.Name = "pnlConsultaClinica";
            pnlConsultaClinica.Size = new Size(1040, 270);
            pnlConsultaClinica.TabIndex = 1;
            // 
            // txtTratamientoConsulta
            // 
            txtTratamientoConsulta.Location = new Point(20, 215);
            txtTratamientoConsulta.Multiline = true;
            txtTratamientoConsulta.Name = "txtTratamientoConsulta";
            txtTratamientoConsulta.ScrollBars = ScrollBars.Vertical;
            txtTratamientoConsulta.Size = new Size(480, 40);
            txtTratamientoConsulta.TabIndex = 11;
            txtTratamientoConsulta.TextChanged += textBox5_TextChanged;
            // 
            // txtObservacionesConsulta
            // 
            txtObservacionesConsulta.Location = new Point(530, 215);
            txtObservacionesConsulta.Multiline = true;
            txtObservacionesConsulta.Name = "txtObservacionesConsulta";
            txtObservacionesConsulta.ScrollBars = ScrollBars.Vertical;
            txtObservacionesConsulta.Size = new Size(480, 40);
            txtObservacionesConsulta.TabIndex = 10;
            // 
            // txtResultadosConsulta
            // 
            txtResultadosConsulta.Location = new Point(530, 145);
            txtResultadosConsulta.Multiline = true;
            txtResultadosConsulta.Name = "txtResultadosConsulta";
            txtResultadosConsulta.ScrollBars = ScrollBars.Vertical;
            txtResultadosConsulta.Size = new Size(480, 40);
            txtResultadosConsulta.TabIndex = 9;
            // 
            // txtMedicamentosConsulta
            // 
            txtMedicamentosConsulta.Location = new Point(20, 145);
            txtMedicamentosConsulta.Multiline = true;
            txtMedicamentosConsulta.Name = "txtMedicamentosConsulta";
            txtMedicamentosConsulta.ScrollBars = ScrollBars.Vertical;
            txtMedicamentosConsulta.Size = new Size(480, 40);
            txtMedicamentosConsulta.TabIndex = 8;
            // 
            // txtDiagnosticoConsulta
            // 
            txtDiagnosticoConsulta.Font = new Font("Segoe UI", 11F);
            txtDiagnosticoConsulta.Location = new Point(300, 80);
            txtDiagnosticoConsulta.Name = "txtDiagnosticoConsulta";
            txtDiagnosticoConsulta.Size = new Size(710, 27);
            txtDiagnosticoConsulta.TabIndex = 7;
            // 
            // lblObservacionesConsulta
            // 
            lblObservacionesConsulta.AutoSize = true;
            lblObservacionesConsulta.BackColor = Color.Transparent;
            lblObservacionesConsulta.Location = new Point(530, 190);
            lblObservacionesConsulta.Name = "lblObservacionesConsulta";
            lblObservacionesConsulta.Size = new Size(84, 15);
            lblObservacionesConsulta.TabIndex = 6;
            lblObservacionesConsulta.Text = "Observaciones";
            // 
            // lblTratamientoConsulta
            // 
            lblTratamientoConsulta.AutoSize = true;
            lblTratamientoConsulta.BackColor = Color.Transparent;
            lblTratamientoConsulta.Location = new Point(20, 190);
            lblTratamientoConsulta.Name = "lblTratamientoConsulta";
            lblTratamientoConsulta.Size = new Size(71, 15);
            lblTratamientoConsulta.TabIndex = 5;
            lblTratamientoConsulta.Text = "Tratamiento";
            // 
            // lblResultadosConsulta
            // 
            lblResultadosConsulta.AutoSize = true;
            lblResultadosConsulta.BackColor = Color.Transparent;
            lblResultadosConsulta.Location = new Point(530, 120);
            lblResultadosConsulta.Name = "lblResultadosConsulta";
            lblResultadosConsulta.Size = new Size(135, 15);
            lblResultadosConsulta.TabIndex = 4;
            lblResultadosConsulta.Text = "Resultados de exámenes";
            // 
            // lblMedicamentosConsulta
            // 
            lblMedicamentosConsulta.AutoSize = true;
            lblMedicamentosConsulta.BackColor = Color.Transparent;
            lblMedicamentosConsulta.Location = new Point(20, 120);
            lblMedicamentosConsulta.Name = "lblMedicamentosConsulta";
            lblMedicamentosConsulta.Size = new Size(86, 15);
            lblMedicamentosConsulta.TabIndex = 3;
            lblMedicamentosConsulta.Text = "Medicamentos";
            // 
            // lblDiagnosticoConsulta
            // 
            lblDiagnosticoConsulta.AutoSize = true;
            lblDiagnosticoConsulta.BackColor = Color.Transparent;
            lblDiagnosticoConsulta.Location = new Point(300, 55);
            lblDiagnosticoConsulta.Name = "lblDiagnosticoConsulta";
            lblDiagnosticoConsulta.Size = new Size(70, 15);
            lblDiagnosticoConsulta.TabIndex = 2;
            lblDiagnosticoConsulta.Text = "Diagnóstico";
            // 
            // lblFechaConsulta
            // 
            lblFechaConsulta.AutoSize = true;
            lblFechaConsulta.BackColor = Color.Transparent;
            lblFechaConsulta.Location = new Point(20, 55);
            lblFechaConsulta.Name = "lblFechaConsulta";
            lblFechaConsulta.Size = new Size(102, 15);
            lblFechaConsulta.TabIndex = 1;
            lblFechaConsulta.Text = "Fecha de consulta";
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.BackColor = Color.Transparent;
            lblTituloConsulta.Location = new Point(20, 15);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(89, 15);
            lblTituloConsulta.TabIndex = 0;
            lblTituloConsulta.Text = "Nueva consulta";
            // 
            // pnlAccionesExpediente
            // 
            pnlAccionesExpediente.BackColor = Color.White;
            pnlAccionesExpediente.Controls.Add(btnVolverExpediente);
            pnlAccionesExpediente.Controls.Add(btnGuardarConsulta);
            pnlAccionesExpediente.Controls.Add(btnNuevaConsulta);
            pnlAccionesExpediente.Location = new Point(20, 495);
            pnlAccionesExpediente.Name = "pnlAccionesExpediente";
            pnlAccionesExpediente.Size = new Size(1040, 60);
            pnlAccionesExpediente.TabIndex = 2;
            // 
            // btnVolverExpediente
            // 
            btnVolverExpediente.BackColor = Color.FromArgb(100, 110, 120);
            btnVolverExpediente.Cursor = Cursors.Hand;
            btnVolverExpediente.FlatAppearance.BorderSize = 0;
            btnVolverExpediente.FlatStyle = FlatStyle.Flat;
            btnVolverExpediente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolverExpediente.ForeColor = Color.White;
            btnVolverExpediente.Location = new Point(865, 10);
            btnVolverExpediente.Name = "btnVolverExpediente";
            btnVolverExpediente.Size = new Size(160, 40);
            btnVolverExpediente.TabIndex = 2;
            btnVolverExpediente.Text = "Volver";
            btnVolverExpediente.UseVisualStyleBackColor = false;
            btnVolverExpediente.Click += btnVolverExpediente_Click;
            // 
            // btnGuardarConsulta
            // 
            btnGuardarConsulta.BackColor = Color.FromArgb(0, 166, 180);
            btnGuardarConsulta.Cursor = Cursors.Hand;
            btnGuardarConsulta.FlatAppearance.BorderSize = 0;
            btnGuardarConsulta.FlatStyle = FlatStyle.Flat;
            btnGuardarConsulta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarConsulta.ForeColor = Color.White;
            btnGuardarConsulta.Location = new Point(200, 10);
            btnGuardarConsulta.Name = "btnGuardarConsulta";
            btnGuardarConsulta.Size = new Size(180, 40);
            btnGuardarConsulta.TabIndex = 1;
            btnGuardarConsulta.Text = "Guardar consulta";
            btnGuardarConsulta.UseVisualStyleBackColor = false;
            btnGuardarConsulta.Click += btnGuardarConsulta_Click;
            // 
            // btnNuevaConsulta
            // 
            btnNuevaConsulta.BackColor = Color.FromArgb(15, 42, 68);
            btnNuevaConsulta.Cursor = Cursors.Hand;
            btnNuevaConsulta.FlatAppearance.BorderSize = 0;
            btnNuevaConsulta.FlatStyle = FlatStyle.Flat;
            btnNuevaConsulta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaConsulta.ForeColor = Color.White;
            btnNuevaConsulta.Location = new Point(15, 10);
            btnNuevaConsulta.Name = "btnNuevaConsulta";
            btnNuevaConsulta.Size = new Size(170, 40);
            btnNuevaConsulta.TabIndex = 0;
            btnNuevaConsulta.Text = "Nueva consulta";
            btnNuevaConsulta.UseVisualStyleBackColor = false;
            btnNuevaConsulta.Click += btnNuevaConsulta_Click;
            // 
            // pnlHistorialConsultas
            // 
            pnlHistorialConsultas.BackColor = Color.White;
            pnlHistorialConsultas.BorderStyle = BorderStyle.FixedSingle;
            pnlHistorialConsultas.Controls.Add(dgvHistorialConsultas);
            pnlHistorialConsultas.Controls.Add(lblHistorialConsultas);
            pnlHistorialConsultas.Location = new Point(20, 565);
            pnlHistorialConsultas.Name = "pnlHistorialConsultas";
            pnlHistorialConsultas.Size = new Size(1040, 140);
            pnlHistorialConsultas.TabIndex = 3;
            // 
            // dgvHistorialConsultas
            // 
            dgvHistorialConsultas.AllowUserToAddRows = false;
            dgvHistorialConsultas.AllowUserToDeleteRows = false;
            dgvHistorialConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialConsultas.BackgroundColor = Color.White;
            dgvHistorialConsultas.BorderStyle = BorderStyle.None;
            dgvHistorialConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialConsultas.Columns.AddRange(new DataGridViewColumn[] { colIdConsulta, colFechaConsulta, colDiagnosticoConsulta, colMedicamentosConsulta, colResultadosConsulta, colTratamientoConsulta, colObservacionesConsulta });
            dgvHistorialConsultas.Location = new Point(15, 40);
            dgvHistorialConsultas.MultiSelect = false;
            dgvHistorialConsultas.Name = "dgvHistorialConsultas";
            dgvHistorialConsultas.ReadOnly = true;
            dgvHistorialConsultas.RowHeadersVisible = false;
            dgvHistorialConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialConsultas.Size = new Size(1010, 85);
            dgvHistorialConsultas.TabIndex = 1;
            // 
            // colIdConsulta
            // 
            colIdConsulta.HeaderText = "Código";
            colIdConsulta.Name = "colIdConsulta";
            colIdConsulta.ReadOnly = true;
            // 
            // colFechaConsulta
            // 
            colFechaConsulta.HeaderText = "Fecha";
            colFechaConsulta.Name = "colFechaConsulta";
            colFechaConsulta.ReadOnly = true;
            // 
            // colDiagnosticoConsulta
            // 
            colDiagnosticoConsulta.HeaderText = "Diagnóstico";
            colDiagnosticoConsulta.Name = "colDiagnosticoConsulta";
            colDiagnosticoConsulta.ReadOnly = true;
            // 
            // colMedicamentosConsulta
            // 
            colMedicamentosConsulta.HeaderText = "Medicamentos";
            colMedicamentosConsulta.Name = "colMedicamentosConsulta";
            colMedicamentosConsulta.ReadOnly = true;
            // 
            // colResultadosConsulta
            // 
            colResultadosConsulta.HeaderText = "Resultados";
            colResultadosConsulta.Name = "colResultadosConsulta";
            colResultadosConsulta.ReadOnly = true;
            // 
            // colTratamientoConsulta
            // 
            colTratamientoConsulta.HeaderText = "Tratamiento";
            colTratamientoConsulta.Name = "colTratamientoConsulta";
            colTratamientoConsulta.ReadOnly = true;
            // 
            // colObservacionesConsulta
            // 
            colObservacionesConsulta.HeaderText = "Observaciones";
            colObservacionesConsulta.Name = "colObservacionesConsulta";
            colObservacionesConsulta.ReadOnly = true;
            // 
            // lblHistorialConsultas
            // 
            lblHistorialConsultas.AutoSize = true;
            lblHistorialConsultas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistorialConsultas.Location = new Point(15, 10);
            lblHistorialConsultas.Name = "lblHistorialConsultas";
            lblHistorialConsultas.Size = new Size(202, 25);
            lblHistorialConsultas.TabIndex = 0;
            lblHistorialConsultas.Text = "Historial de consultas";
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaConsulta.Font = new Font("Segoe UI", 11F);
            dtpFechaConsulta.Format = DateTimePickerFormat.Custom;
            dtpFechaConsulta.Location = new Point(20, 80);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(250, 27);
            dtpFechaConsulta.TabIndex = 12;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1084, 711);
            Controls.Add(pnlHistorialConsultas);
            Controls.Add(pnlAccionesExpediente);
            Controls.Add(pnlConsultaClinica);
            Controls.Add(pnlResumenExpediente);
            ForeColor = Color.FromArgb(15, 42, 68);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Expediente clínico";
            Load += Form3_Load;
            pnlResumenExpediente.ResumeLayout(false);
            pnlResumenExpediente.PerformLayout();
            pnlConsultaClinica.ResumeLayout(false);
            pnlConsultaClinica.PerformLayout();
            pnlAccionesExpediente.ResumeLayout(false);
            pnlHistorialConsultas.ResumeLayout(false);
            pnlHistorialConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlResumenExpediente;
        private Label lblEstadoPacienteExpediente;
        private Label lblFechaCreacionExpediente;
        private Label lblContactoExpediente;
        private Label lblNacimientoExpediente;
        private Label lblDocumentoExpediente;
        private Label lblCodigoExpediente;
        private Label lblPacienteExpediente;
        private Label lblTituloExpediente;
        private Panel pnlConsultaClinica;
        private Label lblObservacionesConsulta;
        private Label lblTratamientoConsulta;
        private Label lblResultadosConsulta;
        private Label lblMedicamentosConsulta;
        private Label lblDiagnosticoConsulta;
        private Label lblFechaConsulta;
        private Label lblTituloConsulta;
        private TextBox txtTratamientoConsulta;
        private TextBox txtObservacionesConsulta;
        private TextBox txtResultadosConsulta;
        private TextBox txtMedicamentosConsulta;
        private TextBox txtDiagnosticoConsulta;
        private Panel pnlAccionesExpediente;
        private Button btnVolverExpediente;
        private Button btnGuardarConsulta;
        private Button btnNuevaConsulta;
        private Panel pnlHistorialConsultas;
        private Label lblHistorialConsultas;
        private DataGridView dgvHistorialConsultas;
        private DataGridViewTextBoxColumn colIdConsulta;
        private DataGridViewTextBoxColumn colFechaConsulta;
        private DataGridViewTextBoxColumn colDiagnosticoConsulta;
        private DataGridViewTextBoxColumn colMedicamentosConsulta;
        private DataGridViewTextBoxColumn colResultadosConsulta;
        private DataGridViewTextBoxColumn colTratamientoConsulta;
        private DataGridViewTextBoxColumn colObservacionesConsulta;
        private DateTimePicker dtpFechaConsulta;
    }
}