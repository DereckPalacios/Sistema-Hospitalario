namespace Sistema_Hospitalario
{
    partial class FrmCitas
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
            pnlDatosCita = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtIdCita = new TextBox();
            cmbPacienteCita = new ComboBox();
            cmbEstadoCita = new ComboBox();
            dtpFechaCita = new DateTimePicker();
            dtpFinCita = new DateTimePicker();
            dtpInicioCita = new DateTimePicker();
            cmbMedicoCita = new ComboBox();
            txtMotivoCita = new TextBox();
            pnlAccionesCitas = new Panel();
            btnNuevaCita = new Button();
            btnGuardarCita = new Button();
            btnCancelarCita = new Button();
            btnVerExpedienteCita = new Button();
            btnVolverCitas = new Button();
            pnlListaCitas = new Panel();
            lblBuscarCita = new Label();
            txtBuscarCita = new TextBox();
            btnBuscarCita = new Button();
            btnMostrarTodasCitas = new Button();
            dgvCitas = new DataGridView();
            colIdCita = new DataGridViewTextBoxColumn();
            colPacienteCita = new DataGridViewTextBoxColumn();
            colMedicoCita = new DataGridViewTextBoxColumn();
            colFechaCita = new DataGridViewTextBoxColumn();
            colInicioCita = new DataGridViewTextBoxColumn();
            colFinCita = new DataGridViewTextBoxColumn();
            colEstadoCita = new DataGridViewTextBoxColumn();
            colMotivoCita = new DataGridViewTextBoxColumn();
            pnlDatosCita.SuspendLayout();
            pnlAccionesCitas.SuspendLayout();
            pnlListaCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // pnlDatosCita
            // 
            pnlDatosCita.BackColor = Color.White;
            pnlDatosCita.BorderStyle = BorderStyle.FixedSingle;
            pnlDatosCita.Controls.Add(txtMotivoCita);
            pnlDatosCita.Controls.Add(cmbMedicoCita);
            pnlDatosCita.Controls.Add(dtpInicioCita);
            pnlDatosCita.Controls.Add(dtpFinCita);
            pnlDatosCita.Controls.Add(dtpFechaCita);
            pnlDatosCita.Controls.Add(cmbEstadoCita);
            pnlDatosCita.Controls.Add(cmbPacienteCita);
            pnlDatosCita.Controls.Add(txtIdCita);
            pnlDatosCita.Controls.Add(label9);
            pnlDatosCita.Controls.Add(label8);
            pnlDatosCita.Controls.Add(label7);
            pnlDatosCita.Controls.Add(label6);
            pnlDatosCita.Controls.Add(label5);
            pnlDatosCita.Controls.Add(label4);
            pnlDatosCita.Controls.Add(label3);
            pnlDatosCita.Controls.Add(label2);
            pnlDatosCita.Controls.Add(label1);
            pnlDatosCita.Location = new Point(20, 20);
            pnlDatosCita.Name = "pnlDatosCita";
            pnlDatosCita.Size = new Size(1040, 260);
            pnlDatosCita.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 42, 68);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "Datos de la cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(15, 42, 68);
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(15, 42, 68);
            label3.Location = new Point(180, 65);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 2;
            label3.Text = "Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 42, 68);
            label4.Location = new Point(600, 65);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Médico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(15, 42, 68);
            label5.Location = new Point(20, 130);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 4;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(15, 42, 68);
            label6.Location = new Point(300, 130);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 5;
            label6.Text = "Hora de inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(15, 42, 68);
            label7.Location = new Point(20, 195);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 6;
            label7.Text = "Motivo de la cita";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(15, 42, 68);
            label8.Location = new Point(530, 130);
            label8.Name = "label8";
            label8.Size = new Size(77, 19);
            label8.TabIndex = 7;
            label8.Text = "Hora de fin";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(15, 42, 68);
            label9.Location = new Point(760, 130);
            label9.Name = "label9";
            label9.Size = new Size(50, 19);
            label9.TabIndex = 8;
            label9.Text = "Estado";
            // 
            // txtIdCita
            // 
            txtIdCita.Location = new Point(20, 90);
            txtIdCita.Name = "txtIdCita";
            txtIdCita.ReadOnly = true;
            txtIdCita.Size = new Size(130, 23);
            txtIdCita.TabIndex = 9;
            // 
            // cmbPacienteCita
            // 
            cmbPacienteCita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPacienteCita.FormattingEnabled = true;
            cmbPacienteCita.Location = new Point(180, 90);
            cmbPacienteCita.Name = "cmbPacienteCita";
            cmbPacienteCita.Size = new Size(390, 23);
            cmbPacienteCita.TabIndex = 10;
            // 
            // cmbEstadoCita
            // 
            cmbEstadoCita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCita.FormattingEnabled = true;
            cmbEstadoCita.Items.AddRange(new object[] { "Programada", "Confirmada", "Cancelada", "Atendida" });
            cmbEstadoCita.Location = new Point(760, 155);
            cmbEstadoCita.Name = "cmbEstadoCita";
            cmbEstadoCita.Size = new Size(250, 23);
            cmbEstadoCita.TabIndex = 11;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(20, 155);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(250, 23);
            dtpFechaCita.TabIndex = 12;
            // 
            // dtpFinCita
            // 
            dtpFinCita.CustomFormat = "HH:mm";
            dtpFinCita.Format = DateTimePickerFormat.Custom;
            dtpFinCita.Location = new Point(530, 155);
            dtpFinCita.Name = "dtpFinCita";
            dtpFinCita.ShowUpDown = true;
            dtpFinCita.Size = new Size(200, 23);
            dtpFinCita.TabIndex = 13;
            // 
            // dtpInicioCita
            // 
            dtpInicioCita.CustomFormat = "HH:mm";
            dtpInicioCita.Format = DateTimePickerFormat.Custom;
            dtpInicioCita.Location = new Point(300, 155);
            dtpInicioCita.Name = "dtpInicioCita";
            dtpInicioCita.ShowUpDown = true;
            dtpInicioCita.Size = new Size(200, 23);
            dtpInicioCita.TabIndex = 14;
            // 
            // cmbMedicoCita
            // 
            cmbMedicoCita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicoCita.FormattingEnabled = true;
            cmbMedicoCita.Location = new Point(600, 90);
            cmbMedicoCita.Name = "cmbMedicoCita";
            cmbMedicoCita.Size = new Size(410, 23);
            cmbMedicoCita.TabIndex = 15;
            cmbMedicoCita.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(20, 220);
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(990, 23);
            txtMotivoCita.TabIndex = 16;
            // 
            // pnlAccionesCitas
            // 
            pnlAccionesCitas.BackColor = Color.White;
            pnlAccionesCitas.Controls.Add(btnVolverCitas);
            pnlAccionesCitas.Controls.Add(btnVerExpedienteCita);
            pnlAccionesCitas.Controls.Add(btnCancelarCita);
            pnlAccionesCitas.Controls.Add(btnGuardarCita);
            pnlAccionesCitas.Controls.Add(btnNuevaCita);
            pnlAccionesCitas.Location = new Point(20, 295);
            pnlAccionesCitas.Name = "pnlAccionesCitas";
            pnlAccionesCitas.Size = new Size(1040, 60);
            pnlAccionesCitas.TabIndex = 1;
            // 
            // btnNuevaCita
            // 
            btnNuevaCita.BackColor = Color.FromArgb(15, 42, 68);
            btnNuevaCita.Cursor = Cursors.Hand;
            btnNuevaCita.FlatAppearance.BorderSize = 0;
            btnNuevaCita.FlatStyle = FlatStyle.Flat;
            btnNuevaCita.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaCita.ForeColor = Color.White;
            btnNuevaCita.Location = new Point(15, 10);
            btnNuevaCita.Name = "btnNuevaCita";
            btnNuevaCita.Size = new Size(150, 40);
            btnNuevaCita.TabIndex = 0;
            btnNuevaCita.Text = "Nueva";
            btnNuevaCita.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.BackColor = Color.FromArgb(0, 166, 180);
            btnGuardarCita.Cursor = Cursors.Hand;
            btnGuardarCita.FlatAppearance.BorderSize = 0;
            btnGuardarCita.FlatStyle = FlatStyle.Flat;
            btnGuardarCita.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarCita.ForeColor = Color.White;
            btnGuardarCita.Location = new Point(180, 10);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(150, 40);
            btnGuardarCita.TabIndex = 1;
            btnGuardarCita.Text = "Guardar";
            btnGuardarCita.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.BackColor = Color.FromArgb(190, 65, 65);
            btnCancelarCita.Cursor = Cursors.Hand;
            btnCancelarCita.FlatAppearance.BorderSize = 0;
            btnCancelarCita.FlatStyle = FlatStyle.Flat;
            btnCancelarCita.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelarCita.ForeColor = Color.White;
            btnCancelarCita.Location = new Point(345, 10);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(160, 40);
            btnCancelarCita.TabIndex = 2;
            btnCancelarCita.Text = "Cancelar cita";
            btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // btnVerExpedienteCita
            // 
            btnVerExpedienteCita.BackColor = Color.FromArgb(40, 120, 230);
            btnVerExpedienteCita.Cursor = Cursors.Hand;
            btnVerExpedienteCita.FlatAppearance.BorderSize = 0;
            btnVerExpedienteCita.FlatStyle = FlatStyle.Flat;
            btnVerExpedienteCita.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerExpedienteCita.ForeColor = Color.White;
            btnVerExpedienteCita.Location = new Point(520, 10);
            btnVerExpedienteCita.Name = "btnVerExpedienteCita";
            btnVerExpedienteCita.Size = new Size(170, 40);
            btnVerExpedienteCita.TabIndex = 3;
            btnVerExpedienteCita.Text = "Ver expediente";
            btnVerExpedienteCita.UseVisualStyleBackColor = false;
            // 
            // btnVolverCitas
            // 
            btnVolverCitas.BackColor = Color.FromArgb(100, 110, 120);
            btnVolverCitas.Cursor = Cursors.Hand;
            btnVolverCitas.FlatAppearance.BorderSize = 0;
            btnVolverCitas.FlatStyle = FlatStyle.Flat;
            btnVolverCitas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolverCitas.ForeColor = Color.White;
            btnVolverCitas.Location = new Point(875, 10);
            btnVolverCitas.Name = "btnVolverCitas";
            btnVolverCitas.Size = new Size(150, 40);
            btnVolverCitas.TabIndex = 4;
            btnVolverCitas.Text = "Volver";
            btnVolverCitas.UseVisualStyleBackColor = false;
            btnVolverCitas.Click += btnVolverCitas_Click;
            // 
            // pnlListaCitas
            // 
            pnlListaCitas.BackColor = Color.White;
            pnlListaCitas.BorderStyle = BorderStyle.FixedSingle;
            pnlListaCitas.Controls.Add(dgvCitas);
            pnlListaCitas.Controls.Add(btnMostrarTodasCitas);
            pnlListaCitas.Controls.Add(btnBuscarCita);
            pnlListaCitas.Controls.Add(txtBuscarCita);
            pnlListaCitas.Controls.Add(lblBuscarCita);
            pnlListaCitas.Location = new Point(20, 370);
            pnlListaCitas.Name = "pnlListaCitas";
            pnlListaCitas.Size = new Size(1040, 335);
            pnlListaCitas.TabIndex = 2;
            // 
            // lblBuscarCita
            // 
            lblBuscarCita.AutoSize = true;
            lblBuscarCita.Font = new Font("Segoe UI", 10F);
            lblBuscarCita.Location = new Point(15, 20);
            lblBuscarCita.Name = "lblBuscarCita";
            lblBuscarCita.Size = new Size(74, 19);
            lblBuscarCita.TabIndex = 0;
            lblBuscarCita.Text = "Buscar cita";
            // 
            // txtBuscarCita
            // 
            txtBuscarCita.Font = new Font("Segoe UI", 10F);
            txtBuscarCita.Location = new Point(120, 15);
            txtBuscarCita.Name = "txtBuscarCita";
            txtBuscarCita.Size = new Size(500, 25);
            txtBuscarCita.TabIndex = 1;
            // 
            // btnBuscarCita
            // 
            btnBuscarCita.BackColor = Color.FromArgb(15, 42, 68);
            btnBuscarCita.Cursor = Cursors.Hand;
            btnBuscarCita.FlatAppearance.BorderSize = 0;
            btnBuscarCita.FlatStyle = FlatStyle.Flat;
            btnBuscarCita.Font = new Font("Segoe UI", 10F);
            btnBuscarCita.ForeColor = Color.White;
            btnBuscarCita.Location = new Point(635, 10);
            btnBuscarCita.Name = "btnBuscarCita";
            btnBuscarCita.Size = new Size(150, 40);
            btnBuscarCita.TabIndex = 2;
            btnBuscarCita.Text = "Buscar";
            btnBuscarCita.UseVisualStyleBackColor = false;
            // 
            // btnMostrarTodasCitas
            // 
            btnMostrarTodasCitas.BackColor = Color.FromArgb(15, 42, 68);
            btnMostrarTodasCitas.Cursor = Cursors.Hand;
            btnMostrarTodasCitas.FlatAppearance.BorderSize = 0;
            btnMostrarTodasCitas.FlatStyle = FlatStyle.Flat;
            btnMostrarTodasCitas.Font = new Font("Segoe UI", 10F);
            btnMostrarTodasCitas.ForeColor = Color.White;
            btnMostrarTodasCitas.Location = new Point(800, 10);
            btnMostrarTodasCitas.Name = "btnMostrarTodasCitas";
            btnMostrarTodasCitas.Size = new Size(225, 40);
            btnMostrarTodasCitas.TabIndex = 3;
            btnMostrarTodasCitas.Text = "Mostrar todas";
            btnMostrarTodasCitas.UseVisualStyleBackColor = false;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.BorderStyle = BorderStyle.None;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { colIdCita, colPacienteCita, colMedicoCita, colFechaCita, colInicioCita, colFinCita, colEstadoCita, colMotivoCita });
            dgvCitas.Location = new Point(15, 65);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(1010, 250);
            dgvCitas.TabIndex = 5;
            // 
            // colIdCita
            // 
            colIdCita.HeaderText = "Código";
            colIdCita.Name = "colIdCita";
            colIdCita.ReadOnly = true;
            // 
            // colPacienteCita
            // 
            colPacienteCita.HeaderText = "Paciente";
            colPacienteCita.Name = "colPacienteCita";
            colPacienteCita.ReadOnly = true;
            // 
            // colMedicoCita
            // 
            colMedicoCita.HeaderText = "Médico";
            colMedicoCita.Name = "colMedicoCita";
            colMedicoCita.ReadOnly = true;
            // 
            // colFechaCita
            // 
            colFechaCita.HeaderText = "Fecha";
            colFechaCita.Name = "colFechaCita";
            colFechaCita.ReadOnly = true;
            // 
            // colInicioCita
            // 
            colInicioCita.HeaderText = "Inicio";
            colInicioCita.Name = "colInicioCita";
            colInicioCita.ReadOnly = true;
            // 
            // colFinCita
            // 
            colFinCita.HeaderText = "Fin";
            colFinCita.Name = "colFinCita";
            colFinCita.ReadOnly = true;
            // 
            // colEstadoCita
            // 
            colEstadoCita.HeaderText = "Estado";
            colEstadoCita.Name = "colEstadoCita";
            colEstadoCita.ReadOnly = true;
            // 
            // colMotivoCita
            // 
            colMotivoCita.HeaderText = "Motivo";
            colMotivoCita.Name = "colMotivoCita";
            colMotivoCita.ReadOnly = true;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1084, 711);
            Controls.Add(pnlListaCitas);
            Controls.Add(pnlAccionesCitas);
            Controls.Add(pnlDatosCita);
            Name = "FrmCitas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de citas";
            pnlDatosCita.ResumeLayout(false);
            pnlDatosCita.PerformLayout();
            pnlAccionesCitas.ResumeLayout(false);
            pnlListaCitas.ResumeLayout(false);
            pnlListaCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatosCita;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMotivoCita;
        private ComboBox cmbMedicoCita;
        private DateTimePicker dtpInicioCita;
        private DateTimePicker dtpFinCita;
        private DateTimePicker dtpFechaCita;
        private ComboBox cmbEstadoCita;
        private ComboBox cmbPacienteCita;
        private TextBox txtIdCita;
        private Panel pnlAccionesCitas;
        private Button btnVolverCitas;
        private Button btnVerExpedienteCita;
        private Button btnCancelarCita;
        private Button btnGuardarCita;
        private Button btnNuevaCita;
        private Panel pnlListaCitas;
        private Button btnMostrarTodasCitas;
        private Button btnBuscarCita;
        private TextBox txtBuscarCita;
        private Label lblBuscarCita;
        private DataGridView dgvCitas;
        private DataGridViewTextBoxColumn colIdCita;
        private DataGridViewTextBoxColumn colPacienteCita;
        private DataGridViewTextBoxColumn colMedicoCita;
        private DataGridViewTextBoxColumn colFechaCita;
        private DataGridViewTextBoxColumn colInicioCita;
        private DataGridViewTextBoxColumn colFinCita;
        private DataGridViewTextBoxColumn colEstadoCita;
        private DataGridViewTextBoxColumn colMotivoCita;
    }
}