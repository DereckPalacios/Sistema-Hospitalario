namespace Sistema_Hospitalario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInicio = new Button();
            btnSalir = new Button();
            lblLogo = new Label();
            btnPacientes = new Button();
            btnMedicos = new Button();
            btnEspecialidades = new Button();
            btnCitas = new Button();
            btnExpedientes = new Button();
            pnlMenu = new Panel();
            lblPanelPrincipal = new Label();
            lblDescripcion = new Label();
            pnlTarjetaPacientes = new Panel();
            lblTotalPacientes = new Label();
            lblTituloPacientes = new Label();
            pnlTarjetaMedicos = new Panel();
            lblTotalMedicos = new Label();
            lblTituloMedicos = new Label();
            pnlTarjetaCitas = new Panel();
            lblTotalCitas = new Label();
            lblTituloCitas = new Label();
            pnlProximasCitas = new Panel();
            dgvProximasCitas = new DataGridView();
            colHora = new DataGridViewTextBoxColumn();
            colPaciente = new DataGridViewTextBoxColumn();
            colMedico = new DataGridViewTextBoxColumn();
            colEspecialidad = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnNuevaCita = new Button();
            lblProximasCitas = new Label();
            pnlAccesoPacientes = new Panel();
            btnRegistrarPaciente = new Button();
            lblDetallePacientes = new Label();
            lblAccesoPacientes = new Label();
            pnlAccesoExpedientes = new Panel();
            btnConsultarExpediente = new Button();
            lblDetalleExpedientes = new Label();
            lblAccesoExpedientes = new Label();
            pnlMenu.SuspendLayout();
            pnlTarjetaPacientes.SuspendLayout();
            pnlTarjetaMedicos.SuspendLayout();
            pnlTarjetaCitas.SuspendLayout();
            pnlProximasCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProximasCitas).BeginInit();
            pnlAccesoPacientes.SuspendLayout();
            pnlAccesoExpedientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(0, 166, 180);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(10, 110);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(200, 50);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalir.BackColor = Color.FromArgb(15, 42, 68);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(10, 620);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 50);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(10, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(233, 25);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "SISTEMA HOSPITALARIO";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.FromArgb(15, 42, 68);
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 12F);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(10, 170);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(200, 50);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += button1_Click;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.FromArgb(15, 42, 68);
            btnMedicos.Cursor = Cursors.Hand;
            btnMedicos.FlatAppearance.BorderSize = 0;
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Segoe UI", 12F);
            btnMedicos.ForeColor = Color.White;
            btnMedicos.Location = new Point(10, 230);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(200, 50);
            btnMedicos.TabIndex = 3;
            btnMedicos.Text = "Médicos";
            btnMedicos.TextAlign = ContentAlignment.MiddleLeft;
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.BackColor = Color.FromArgb(15, 42, 68);
            btnEspecialidades.Cursor = Cursors.Hand;
            btnEspecialidades.FlatAppearance.BorderSize = 0;
            btnEspecialidades.FlatStyle = FlatStyle.Flat;
            btnEspecialidades.Font = new Font("Segoe UI", 12F);
            btnEspecialidades.ForeColor = Color.White;
            btnEspecialidades.Location = new Point(10, 290);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new Size(200, 50);
            btnEspecialidades.TabIndex = 4;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.TextAlign = ContentAlignment.MiddleLeft;
            btnEspecialidades.UseVisualStyleBackColor = false;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(15, 42, 68);
            btnCitas.Cursor = Cursors.Hand;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Segoe UI", 12F);
            btnCitas.ForeColor = Color.White;
            btnCitas.Location = new Point(10, 350);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(200, 50);
            btnCitas.TabIndex = 5;
            btnCitas.Text = "Citas";
            btnCitas.TextAlign = ContentAlignment.MiddleLeft;
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnExpedientes
            // 
            btnExpedientes.BackColor = Color.FromArgb(15, 42, 68);
            btnExpedientes.Cursor = Cursors.Hand;
            btnExpedientes.FlatAppearance.BorderSize = 0;
            btnExpedientes.FlatStyle = FlatStyle.Flat;
            btnExpedientes.Font = new Font("Segoe UI", 12F);
            btnExpedientes.ForeColor = Color.White;
            btnExpedientes.Location = new Point(10, 410);
            btnExpedientes.Name = "btnExpedientes";
            btnExpedientes.Size = new Size(200, 50);
            btnExpedientes.TabIndex = 7;
            btnExpedientes.Text = "Expedientes";
            btnExpedientes.TextAlign = ContentAlignment.MiddleLeft;
            btnExpedientes.UseVisualStyleBackColor = false;
            btnExpedientes.Click += btnExpedientes_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(15, 42, 68);
            pnlMenu.Controls.Add(btnExpedientes);
            pnlMenu.Controls.Add(btnCitas);
            pnlMenu.Controls.Add(btnEspecialidades);
            pnlMenu.Controls.Add(btnMedicos);
            pnlMenu.Controls.Add(btnPacientes);
            pnlMenu.Controls.Add(lblLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(245, 711);
            pnlMenu.TabIndex = 0;
            // 
            // lblPanelPrincipal
            // 
            lblPanelPrincipal.AutoSize = true;
            lblPanelPrincipal.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblPanelPrincipal.ForeColor = Color.FromArgb(15, 42, 68);
            lblPanelPrincipal.Location = new Point(250, 30);
            lblPanelPrincipal.Name = "lblPanelPrincipal";
            lblPanelPrincipal.Size = new Size(265, 47);
            lblPanelPrincipal.TabIndex = 3;
            lblPanelPrincipal.Text = "Panel principal";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F);
            lblDescripcion.ForeColor = Color.FromArgb(100, 110, 120);
            lblDescripcion.Location = new Point(250, 85);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(260, 21);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Resumen de la atención hospitalaria";
            // 
            // pnlTarjetaPacientes
            // 
            pnlTarjetaPacientes.BackColor = Color.White;
            pnlTarjetaPacientes.BorderStyle = BorderStyle.FixedSingle;
            pnlTarjetaPacientes.Controls.Add(lblTotalPacientes);
            pnlTarjetaPacientes.Controls.Add(lblTituloPacientes);
            pnlTarjetaPacientes.Location = new Point(250, 140);
            pnlTarjetaPacientes.Name = "pnlTarjetaPacientes";
            pnlTarjetaPacientes.Size = new Size(280, 120);
            pnlTarjetaPacientes.TabIndex = 5;
            // 
            // lblTotalPacientes
            // 
            lblTotalPacientes.AutoSize = true;
            lblTotalPacientes.BackColor = Color.Transparent;
            lblTotalPacientes.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTotalPacientes.ForeColor = Color.FromArgb(0, 166, 180);
            lblTotalPacientes.Location = new Point(20, 45);
            lblTotalPacientes.Name = "lblTotalPacientes";
            lblTotalPacientes.Size = new Size(46, 54);
            lblTotalPacientes.TabIndex = 1;
            lblTotalPacientes.Text = "0";
            // 
            // lblTituloPacientes
            // 
            lblTituloPacientes.AutoSize = true;
            lblTituloPacientes.BackColor = Color.Transparent;
            lblTituloPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloPacientes.ForeColor = Color.FromArgb(15, 42, 68);
            lblTituloPacientes.Location = new Point(20, 15);
            lblTituloPacientes.Name = "lblTituloPacientes";
            lblTituloPacientes.Size = new Size(172, 21);
            lblTituloPacientes.TabIndex = 0;
            lblTituloPacientes.Text = "Pacientes registrados";
            // 
            // pnlTarjetaMedicos
            // 
            pnlTarjetaMedicos.BackColor = Color.White;
            pnlTarjetaMedicos.BorderStyle = BorderStyle.FixedSingle;
            pnlTarjetaMedicos.Controls.Add(lblTotalMedicos);
            pnlTarjetaMedicos.Controls.Add(lblTituloMedicos);
            pnlTarjetaMedicos.Location = new Point(550, 140);
            pnlTarjetaMedicos.Name = "pnlTarjetaMedicos";
            pnlTarjetaMedicos.Size = new Size(280, 120);
            pnlTarjetaMedicos.TabIndex = 6;
            // 
            // lblTotalMedicos
            // 
            lblTotalMedicos.AutoSize = true;
            lblTotalMedicos.BackColor = Color.Transparent;
            lblTotalMedicos.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTotalMedicos.ForeColor = Color.FromArgb(0, 166, 180);
            lblTotalMedicos.Location = new Point(20, 45);
            lblTotalMedicos.Name = "lblTotalMedicos";
            lblTotalMedicos.Size = new Size(46, 54);
            lblTotalMedicos.TabIndex = 1;
            lblTotalMedicos.Text = "0";
            // 
            // lblTituloMedicos
            // 
            lblTituloMedicos.AutoSize = true;
            lblTituloMedicos.BackColor = Color.Transparent;
            lblTituloMedicos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloMedicos.ForeColor = Color.FromArgb(15, 42, 68);
            lblTituloMedicos.Location = new Point(20, 15);
            lblTituloMedicos.Name = "lblTituloMedicos";
            lblTituloMedicos.Size = new Size(132, 21);
            lblTituloMedicos.TabIndex = 0;
            lblTituloMedicos.Text = "Médicos activos";
            // 
            // pnlTarjetaCitas
            // 
            pnlTarjetaCitas.BackColor = Color.White;
            pnlTarjetaCitas.BorderStyle = BorderStyle.FixedSingle;
            pnlTarjetaCitas.Controls.Add(lblTotalCitas);
            pnlTarjetaCitas.Controls.Add(lblTituloCitas);
            pnlTarjetaCitas.Location = new Point(850, 140);
            pnlTarjetaCitas.Name = "pnlTarjetaCitas";
            pnlTarjetaCitas.Size = new Size(280, 120);
            pnlTarjetaCitas.TabIndex = 7;
            // 
            // lblTotalCitas
            // 
            lblTotalCitas.AutoSize = true;
            lblTotalCitas.BackColor = Color.Transparent;
            lblTotalCitas.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTotalCitas.ForeColor = Color.FromArgb(0, 166, 180);
            lblTotalCitas.Location = new Point(20, 45);
            lblTotalCitas.Name = "lblTotalCitas";
            lblTotalCitas.Size = new Size(46, 54);
            lblTotalCitas.TabIndex = 1;
            lblTotalCitas.Text = "0";
            // 
            // lblTituloCitas
            // 
            lblTituloCitas.AutoSize = true;
            lblTituloCitas.BackColor = Color.Transparent;
            lblTituloCitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloCitas.ForeColor = Color.FromArgb(15, 42, 68);
            lblTituloCitas.Location = new Point(20, 15);
            lblTituloCitas.Name = "lblTituloCitas";
            lblTituloCitas.Size = new Size(107, 21);
            lblTituloCitas.TabIndex = 0;
            lblTituloCitas.Text = "Citas de hoy ";
            // 
            // pnlProximasCitas
            // 
            pnlProximasCitas.BackColor = Color.White;
            pnlProximasCitas.BorderStyle = BorderStyle.FixedSingle;
            pnlProximasCitas.Controls.Add(dgvProximasCitas);
            pnlProximasCitas.Controls.Add(btnNuevaCita);
            pnlProximasCitas.Controls.Add(lblProximasCitas);
            pnlProximasCitas.Location = new Point(250, 290);
            pnlProximasCitas.Name = "pnlProximasCitas";
            pnlProximasCitas.Size = new Size(880, 300);
            pnlProximasCitas.TabIndex = 8;
            // 
            // dgvProximasCitas
            // 
            dgvProximasCitas.AllowUserToAddRows = false;
            dgvProximasCitas.AllowUserToDeleteRows = false;
            dgvProximasCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProximasCitas.BackgroundColor = Color.White;
            dgvProximasCitas.BorderStyle = BorderStyle.None;
            dgvProximasCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProximasCitas.Columns.AddRange(new DataGridViewColumn[] { colHora, colPaciente, colMedico, colEspecialidad, colEstado });
            dgvProximasCitas.Location = new Point(20, 75);
            dgvProximasCitas.MultiSelect = false;
            dgvProximasCitas.Name = "dgvProximasCitas";
            dgvProximasCitas.ReadOnly = true;
            dgvProximasCitas.RowHeadersVisible = false;
            dgvProximasCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProximasCitas.Size = new Size(840, 200);
            dgvProximasCitas.TabIndex = 2;
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colMedico
            // 
            colMedico.HeaderText = "Médico";
            colMedico.Name = "colMedico";
            colMedico.ReadOnly = true;
            // 
            // colEspecialidad
            // 
            colEspecialidad.HeaderText = "Especialidad";
            colEspecialidad.Name = "colEspecialidad";
            colEspecialidad.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // btnNuevaCita
            // 
            btnNuevaCita.BackColor = Color.FromArgb(0, 166, 180);
            btnNuevaCita.Cursor = Cursors.Hand;
            btnNuevaCita.FlatAppearance.BorderSize = 0;
            btnNuevaCita.FlatStyle = FlatStyle.Flat;
            btnNuevaCita.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNuevaCita.ForeColor = Color.White;
            btnNuevaCita.Location = new Point(690, 15);
            btnNuevaCita.Name = "btnNuevaCita";
            btnNuevaCita.Size = new Size(170, 40);
            btnNuevaCita.TabIndex = 1;
            btnNuevaCita.Text = "+ Nueva cita";
            btnNuevaCita.UseVisualStyleBackColor = false;
            btnNuevaCita.Click += btnNuevaCita_Click;
            // 
            // lblProximasCitas
            // 
            lblProximasCitas.AutoSize = true;
            lblProximasCitas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProximasCitas.ForeColor = Color.FromArgb(15, 42, 68);
            lblProximasCitas.Location = new Point(20, 20);
            lblProximasCitas.Name = "lblProximasCitas";
            lblProximasCitas.Size = new Size(163, 30);
            lblProximasCitas.TabIndex = 0;
            lblProximasCitas.Text = "Próximas citas";
            // 
            // pnlAccesoPacientes
            // 
            pnlAccesoPacientes.BackColor = Color.FromArgb(225, 247, 249);
            pnlAccesoPacientes.BorderStyle = BorderStyle.FixedSingle;
            pnlAccesoPacientes.Controls.Add(btnRegistrarPaciente);
            pnlAccesoPacientes.Controls.Add(lblDetallePacientes);
            pnlAccesoPacientes.Controls.Add(lblAccesoPacientes);
            pnlAccesoPacientes.Location = new Point(250, 610);
            pnlAccesoPacientes.Name = "pnlAccesoPacientes";
            pnlAccesoPacientes.Size = new Size(430, 85);
            pnlAccesoPacientes.TabIndex = 9;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.BackColor = Color.FromArgb(0, 166, 180);
            btnRegistrarPaciente.Cursor = Cursors.Hand;
            btnRegistrarPaciente.FlatAppearance.BorderSize = 0;
            btnRegistrarPaciente.FlatStyle = FlatStyle.Flat;
            btnRegistrarPaciente.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            btnRegistrarPaciente.ForeColor = Color.White;
            btnRegistrarPaciente.Location = new Point(355, 17);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(55, 50);
            btnRegistrarPaciente.TabIndex = 2;
            btnRegistrarPaciente.Text = "+";
            btnRegistrarPaciente.UseVisualStyleBackColor = false;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // lblDetallePacientes
            // 
            lblDetallePacientes.AutoSize = true;
            lblDetallePacientes.BackColor = Color.Transparent;
            lblDetallePacientes.Font = new Font("Segoe UI", 10F);
            lblDetallePacientes.ForeColor = Color.FromArgb(100, 110, 120);
            lblDetallePacientes.Location = new Point(15, 45);
            lblDetallePacientes.Name = "lblDetallePacientes";
            lblDetallePacientes.Size = new Size(175, 19);
            lblDetallePacientes.TabIndex = 1;
            lblDetallePacientes.Text = "Agregar un nuevo paciente";
            // 
            // lblAccesoPacientes
            // 
            lblAccesoPacientes.AutoSize = true;
            lblAccesoPacientes.BackColor = Color.Transparent;
            lblAccesoPacientes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAccesoPacientes.ForeColor = Color.FromArgb(15, 42, 68);
            lblAccesoPacientes.Location = new Point(15, 12);
            lblAccesoPacientes.Name = "lblAccesoPacientes";
            lblAccesoPacientes.Size = new Size(172, 25);
            lblAccesoPacientes.TabIndex = 0;
            lblAccesoPacientes.Text = "Registrar paciente";
            // 
            // pnlAccesoExpedientes
            // 
            pnlAccesoExpedientes.BackColor = Color.FromArgb(230, 240, 255);
            pnlAccesoExpedientes.BorderStyle = BorderStyle.FixedSingle;
            pnlAccesoExpedientes.Controls.Add(btnConsultarExpediente);
            pnlAccesoExpedientes.Controls.Add(lblDetalleExpedientes);
            pnlAccesoExpedientes.Controls.Add(lblAccesoExpedientes);
            pnlAccesoExpedientes.Location = new Point(700, 610);
            pnlAccesoExpedientes.Name = "pnlAccesoExpedientes";
            pnlAccesoExpedientes.Size = new Size(430, 85);
            pnlAccesoExpedientes.TabIndex = 10;
            // 
            // btnConsultarExpediente
            // 
            btnConsultarExpediente.BackColor = Color.FromArgb(40, 120, 230);
            btnConsultarExpediente.Cursor = Cursors.Hand;
            btnConsultarExpediente.FlatAppearance.BorderSize = 0;
            btnConsultarExpediente.FlatStyle = FlatStyle.Flat;
            btnConsultarExpediente.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            btnConsultarExpediente.ForeColor = Color.White;
            btnConsultarExpediente.Location = new Point(355, 17);
            btnConsultarExpediente.Name = "btnConsultarExpediente";
            btnConsultarExpediente.Size = new Size(55, 50);
            btnConsultarExpediente.TabIndex = 2;
            btnConsultarExpediente.Text = ">";
            btnConsultarExpediente.UseVisualStyleBackColor = false;
            btnConsultarExpediente.Click += btnConsultarExpediente_Click;
            // 
            // lblDetalleExpedientes
            // 
            lblDetalleExpedientes.AutoSize = true;
            lblDetalleExpedientes.BackColor = Color.Transparent;
            lblDetalleExpedientes.Font = new Font("Segoe UI", 10F);
            lblDetalleExpedientes.ForeColor = Color.FromArgb(100, 110, 120);
            lblDetalleExpedientes.Location = new Point(15, 45);
            lblDetalleExpedientes.Name = "lblDetalleExpedientes";
            lblDetalleExpedientes.Size = new Size(159, 19);
            lblDetalleExpedientes.TabIndex = 1;
            lblDetalleExpedientes.Text = "Revisar el historial clínico";
            // 
            // lblAccesoExpedientes
            // 
            lblAccesoExpedientes.AutoSize = true;
            lblAccesoExpedientes.BackColor = Color.Transparent;
            lblAccesoExpedientes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAccesoExpedientes.ForeColor = Color.FromArgb(15, 42, 68);
            lblAccesoExpedientes.Location = new Point(15, 12);
            lblAccesoExpedientes.Name = "lblAccesoExpedientes";
            lblAccesoExpedientes.Size = new Size(202, 25);
            lblAccesoExpedientes.TabIndex = 0;
            lblAccesoExpedientes.Text = "Consultar expediente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1184, 711);
            Controls.Add(pnlAccesoExpedientes);
            Controls.Add(pnlAccesoPacientes);
            Controls.Add(pnlProximasCitas);
            Controls.Add(pnlTarjetaCitas);
            Controls.Add(pnlTarjetaMedicos);
            Controls.Add(pnlTarjetaPacientes);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPanelPrincipal);
            Controls.Add(btnSalir);
            Controls.Add(btnInicio);
            Controls.Add(pnlMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Hospitalario";
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlTarjetaPacientes.ResumeLayout(false);
            pnlTarjetaPacientes.PerformLayout();
            pnlTarjetaMedicos.ResumeLayout(false);
            pnlTarjetaMedicos.PerformLayout();
            pnlTarjetaCitas.ResumeLayout(false);
            pnlTarjetaCitas.PerformLayout();
            pnlProximasCitas.ResumeLayout(false);
            pnlProximasCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProximasCitas).EndInit();
            pnlAccesoPacientes.ResumeLayout(false);
            pnlAccesoPacientes.PerformLayout();
            pnlAccesoExpedientes.ResumeLayout(false);
            pnlAccesoExpedientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInicio;
        private Button btnSalir;
        private Label lblLogo;
        private Button btnPacientes;
        private Button btnMedicos;
        private Button btnEspecialidades;
        private Button btnCitas;
        private Button btnExpedientes;
        private Panel pnlMenu;
        private Label lblPanelPrincipal;
        private Label lblDescripcion;
        private Panel pnlTarjetaPacientes;
        private Label lblTituloPacientes;
        private Label lblTotalPacientes;
        private Panel pnlTarjetaMedicos;
        private Label lblTotalMedicos;
        private Label lblTituloMedicos;
        private Panel pnlTarjetaCitas;
        private Label lblTotalCitas;
        private Label lblTituloCitas;
        private Panel pnlProximasCitas;
        private DataGridView dgvProximasCitas;
        private Button btnNuevaCita;
        private Label lblProximasCitas;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colMedico;
        private DataGridViewTextBoxColumn colEspecialidad;
        private DataGridViewTextBoxColumn colEstado;
        private Panel pnlAccesoPacientes;
        private Label lblDetallePacientes;
        private Label lblAccesoPacientes;
        private Button btnRegistrarPaciente;
        private Panel pnlAccesoExpedientes;
        private Label lblDetalleExpedientes;
        private Label lblAccesoExpedientes;
        private Button btnConsultarExpediente;
    }
}
