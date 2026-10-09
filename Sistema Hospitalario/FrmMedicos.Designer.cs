namespace Sistema_Hospitalario
{
    partial class FrmMedicos
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
            pnlDatosMedico = new Panel();
            txtColegiadoMedico = new TextBox();
            txtNombreMedico = new TextBox();
            txtIdMedico = new TextBox();
            cmbEspecialidadMedico = new ComboBox();
            lblEspecialidadMedico = new Label();
            lblColegiadoMedico = new Label();
            lblNombreMedico = new Label();
            lblCodigoMedico = new Label();
            lblTituloMedico = new Label();
            pnlAccionesMedicos = new Panel();
            btnVolverMedicos = new Button();
            btnHorariosMedico = new Button();
            btnDesactivarMedico = new Button();
            btnGuardarMedico = new Button();
            btnNuevoMedico = new Button();
            pnlListaMedicos = new Panel();
            dgvMedicos = new DataGridView();
            colIdMedico = new DataGridViewTextBoxColumn();
            colNombreMedico = new DataGridViewTextBoxColumn();
            colColegiadoMedico = new DataGridViewTextBoxColumn();
            colEspecialidadMedico = new DataGridViewTextBoxColumn();
            colEstadoMedico = new DataGridViewTextBoxColumn();
            btnMostrarTodosMedicos = new Button();
            btnBuscarMedico = new Button();
            txtBuscarMedico = new TextBox();
            lblBuscarMedico = new Label();
            pnlDatosMedico.SuspendLayout();
            pnlAccionesMedicos.SuspendLayout();
            pnlListaMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // pnlDatosMedico
            // 
            pnlDatosMedico.BackColor = Color.White;
            pnlDatosMedico.BorderStyle = BorderStyle.FixedSingle;
            pnlDatosMedico.Controls.Add(txtColegiadoMedico);
            pnlDatosMedico.Controls.Add(txtNombreMedico);
            pnlDatosMedico.Controls.Add(txtIdMedico);
            pnlDatosMedico.Controls.Add(cmbEspecialidadMedico);
            pnlDatosMedico.Controls.Add(lblEspecialidadMedico);
            pnlDatosMedico.Controls.Add(lblColegiadoMedico);
            pnlDatosMedico.Controls.Add(lblNombreMedico);
            pnlDatosMedico.Controls.Add(lblCodigoMedico);
            pnlDatosMedico.Controls.Add(lblTituloMedico);
            pnlDatosMedico.Location = new Point(20, 20);
            pnlDatosMedico.Name = "pnlDatosMedico";
            pnlDatosMedico.Size = new Size(940, 190);
            pnlDatosMedico.TabIndex = 0;
            pnlDatosMedico.Paint += panel1_Paint;
            // 
            // txtColegiadoMedico
            // 
            txtColegiadoMedico.Location = new Point(620, 90);
            txtColegiadoMedico.Name = "txtColegiadoMedico";
            txtColegiadoMedico.Size = new Size(290, 23);
            txtColegiadoMedico.TabIndex = 8;
            // 
            // txtNombreMedico
            // 
            txtNombreMedico.Location = new Point(180, 90);
            txtNombreMedico.Name = "txtNombreMedico";
            txtNombreMedico.Size = new Size(410, 23);
            txtNombreMedico.TabIndex = 7;
            // 
            // txtIdMedico
            // 
            txtIdMedico.Location = new Point(20, 90);
            txtIdMedico.Name = "txtIdMedico";
            txtIdMedico.ReadOnly = true;
            txtIdMedico.Size = new Size(130, 23);
            txtIdMedico.TabIndex = 6;
            // 
            // cmbEspecialidadMedico
            // 
            cmbEspecialidadMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidadMedico.Font = new Font("Segoe UI", 11F);
            cmbEspecialidadMedico.FormattingEnabled = true;
            cmbEspecialidadMedico.Location = new Point(20, 150);
            cmbEspecialidadMedico.Name = "cmbEspecialidadMedico";
            cmbEspecialidadMedico.Size = new Size(570, 28);
            cmbEspecialidadMedico.TabIndex = 5;
            // 
            // lblEspecialidadMedico
            // 
            lblEspecialidadMedico.AutoSize = true;
            lblEspecialidadMedico.BackColor = Color.Transparent;
            lblEspecialidadMedico.Font = new Font("Segoe UI", 10F);
            lblEspecialidadMedico.ForeColor = Color.FromArgb(15, 42, 68);
            lblEspecialidadMedico.Location = new Point(20, 125);
            lblEspecialidadMedico.Name = "lblEspecialidadMedico";
            lblEspecialidadMedico.Size = new Size(82, 19);
            lblEspecialidadMedico.TabIndex = 4;
            lblEspecialidadMedico.Text = "Especialidad";
            // 
            // lblColegiadoMedico
            // 
            lblColegiadoMedico.AutoSize = true;
            lblColegiadoMedico.BackColor = Color.Transparent;
            lblColegiadoMedico.Font = new Font("Segoe UI", 10F);
            lblColegiadoMedico.ForeColor = Color.FromArgb(15, 42, 68);
            lblColegiadoMedico.Location = new Point(620, 65);
            lblColegiadoMedico.Name = "lblColegiadoMedico";
            lblColegiadoMedico.Size = new Size(140, 19);
            lblColegiadoMedico.TabIndex = 3;
            lblColegiadoMedico.Text = "Número de colegiado";
            // 
            // lblNombreMedico
            // 
            lblNombreMedico.AutoSize = true;
            lblNombreMedico.BackColor = Color.Transparent;
            lblNombreMedico.Font = new Font("Segoe UI", 10F);
            lblNombreMedico.ForeColor = Color.FromArgb(15, 42, 68);
            lblNombreMedico.Location = new Point(180, 65);
            lblNombreMedico.Name = "lblNombreMedico";
            lblNombreMedico.Size = new Size(120, 19);
            lblNombreMedico.TabIndex = 2;
            lblNombreMedico.Text = "Nombre completo";
            // 
            // lblCodigoMedico
            // 
            lblCodigoMedico.AutoSize = true;
            lblCodigoMedico.BackColor = Color.Transparent;
            lblCodigoMedico.Font = new Font("Segoe UI", 10F);
            lblCodigoMedico.ForeColor = Color.FromArgb(15, 42, 68);
            lblCodigoMedico.Location = new Point(20, 65);
            lblCodigoMedico.Name = "lblCodigoMedico";
            lblCodigoMedico.Size = new Size(53, 19);
            lblCodigoMedico.TabIndex = 1;
            lblCodigoMedico.Text = "Código";
            // 
            // lblTituloMedico
            // 
            lblTituloMedico.AutoSize = true;
            lblTituloMedico.BackColor = Color.Transparent;
            lblTituloMedico.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloMedico.ForeColor = Color.FromArgb(15, 42, 68);
            lblTituloMedico.Location = new Point(20, 15);
            lblTituloMedico.Name = "lblTituloMedico";
            lblTituloMedico.Size = new Size(193, 30);
            lblTituloMedico.TabIndex = 0;
            lblTituloMedico.Text = "Datos del médico";
            // 
            // pnlAccionesMedicos
            // 
            pnlAccionesMedicos.BackColor = Color.White;
            pnlAccionesMedicos.Controls.Add(btnVolverMedicos);
            pnlAccionesMedicos.Controls.Add(btnHorariosMedico);
            pnlAccionesMedicos.Controls.Add(btnDesactivarMedico);
            pnlAccionesMedicos.Controls.Add(btnGuardarMedico);
            pnlAccionesMedicos.Controls.Add(btnNuevoMedico);
            pnlAccionesMedicos.Location = new Point(20, 225);
            pnlAccionesMedicos.Name = "pnlAccionesMedicos";
            pnlAccionesMedicos.Size = new Size(940, 60);
            pnlAccionesMedicos.TabIndex = 1;
            // 
            // btnVolverMedicos
            // 
            btnVolverMedicos.BackColor = Color.FromArgb(100, 110, 120);
            btnVolverMedicos.Cursor = Cursors.Hand;
            btnVolverMedicos.FlatAppearance.BorderSize = 0;
            btnVolverMedicos.FlatStyle = FlatStyle.Flat;
            btnVolverMedicos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolverMedicos.ForeColor = Color.White;
            btnVolverMedicos.Location = new Point(790, 10);
            btnVolverMedicos.Name = "btnVolverMedicos";
            btnVolverMedicos.Size = new Size(140, 40);
            btnVolverMedicos.TabIndex = 4;
            btnVolverMedicos.Text = "Volver";
            btnVolverMedicos.UseVisualStyleBackColor = false;
            btnVolverMedicos.Click += btnVolverMedicos_Click;
            // 
            // btnHorariosMedico
            // 
            btnHorariosMedico.BackColor = Color.FromArgb(40, 120, 230);
            btnHorariosMedico.Cursor = Cursors.Hand;
            btnHorariosMedico.FlatAppearance.BorderSize = 0;
            btnHorariosMedico.FlatStyle = FlatStyle.Flat;
            btnHorariosMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHorariosMedico.ForeColor = Color.White;
            btnHorariosMedico.Location = new Point(460, 10);
            btnHorariosMedico.Name = "btnHorariosMedico";
            btnHorariosMedico.Size = new Size(140, 40);
            btnHorariosMedico.TabIndex = 3;
            btnHorariosMedico.Text = "Horarios";
            btnHorariosMedico.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarMedico
            // 
            btnDesactivarMedico.BackColor = Color.FromArgb(190, 65, 65);
            btnDesactivarMedico.Cursor = Cursors.Hand;
            btnDesactivarMedico.FlatAppearance.BorderSize = 0;
            btnDesactivarMedico.FlatStyle = FlatStyle.Flat;
            btnDesactivarMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDesactivarMedico.ForeColor = Color.White;
            btnDesactivarMedico.Location = new Point(310, 10);
            btnDesactivarMedico.Name = "btnDesactivarMedico";
            btnDesactivarMedico.Size = new Size(140, 40);
            btnDesactivarMedico.TabIndex = 2;
            btnDesactivarMedico.Text = "Desactivar";
            btnDesactivarMedico.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMedico
            // 
            btnGuardarMedico.BackColor = Color.FromArgb(0, 166, 180);
            btnGuardarMedico.Cursor = Cursors.Hand;
            btnGuardarMedico.FlatAppearance.BorderSize = 0;
            btnGuardarMedico.FlatStyle = FlatStyle.Flat;
            btnGuardarMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarMedico.ForeColor = Color.White;
            btnGuardarMedico.Location = new Point(160, 10);
            btnGuardarMedico.Name = "btnGuardarMedico";
            btnGuardarMedico.Size = new Size(140, 40);
            btnGuardarMedico.TabIndex = 1;
            btnGuardarMedico.Text = "Guardar";
            btnGuardarMedico.UseVisualStyleBackColor = false;
            btnGuardarMedico.Click += btnGuardarMedico_Click;
            // 
            // btnNuevoMedico
            // 
            btnNuevoMedico.BackColor = Color.FromArgb(15, 42, 68);
            btnNuevoMedico.Cursor = Cursors.Hand;
            btnNuevoMedico.FlatAppearance.BorderSize = 0;
            btnNuevoMedico.FlatStyle = FlatStyle.Flat;
            btnNuevoMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoMedico.ForeColor = Color.White;
            btnNuevoMedico.Location = new Point(10, 10);
            btnNuevoMedico.Name = "btnNuevoMedico";
            btnNuevoMedico.Size = new Size(140, 40);
            btnNuevoMedico.TabIndex = 0;
            btnNuevoMedico.Text = "Nuevo";
            btnNuevoMedico.UseVisualStyleBackColor = false;
            btnNuevoMedico.Click += button1_Click;
            // 
            // pnlListaMedicos
            // 
            pnlListaMedicos.BackColor = Color.White;
            pnlListaMedicos.BorderStyle = BorderStyle.FixedSingle;
            pnlListaMedicos.Controls.Add(dgvMedicos);
            pnlListaMedicos.Controls.Add(btnMostrarTodosMedicos);
            pnlListaMedicos.Controls.Add(btnBuscarMedico);
            pnlListaMedicos.Controls.Add(txtBuscarMedico);
            pnlListaMedicos.Controls.Add(lblBuscarMedico);
            pnlListaMedicos.Location = new Point(20, 300);
            pnlListaMedicos.Name = "pnlListaMedicos";
            pnlListaMedicos.Size = new Size(940, 340);
            pnlListaMedicos.TabIndex = 2;
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.BorderStyle = BorderStyle.None;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Columns.AddRange(new DataGridViewColumn[] { colIdMedico, colNombreMedico, colColegiadoMedico, colEspecialidadMedico, colEstadoMedico });
            dgvMedicos.Location = new Point(15, 65);
            dgvMedicos.MultiSelect = false;
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersVisible = false;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.Size = new Size(910, 255);
            dgvMedicos.TabIndex = 4;
            dgvMedicos.CellClick += dgvMedicos_CellClick;
            // 
            // colIdMedico
            // 
            colIdMedico.HeaderText = "Código";
            colIdMedico.Name = "colIdMedico";
            colIdMedico.ReadOnly = true;
            // 
            // colNombreMedico
            // 
            colNombreMedico.HeaderText = "Nombre completo";
            colNombreMedico.Name = "colNombreMedico";
            colNombreMedico.ReadOnly = true;
            // 
            // colColegiadoMedico
            // 
            colColegiadoMedico.HeaderText = "Colegiado";
            colColegiadoMedico.Name = "colColegiadoMedico";
            colColegiadoMedico.ReadOnly = true;
            // 
            // colEspecialidadMedico
            // 
            colEspecialidadMedico.HeaderText = "Especialidad";
            colEspecialidadMedico.Name = "colEspecialidadMedico";
            colEspecialidadMedico.ReadOnly = true;
            // 
            // colEstadoMedico
            // 
            colEstadoMedico.HeaderText = "Estado";
            colEstadoMedico.Name = "colEstadoMedico";
            colEstadoMedico.ReadOnly = true;
            // 
            // btnMostrarTodosMedicos
            // 
            btnMostrarTodosMedicos.BackColor = Color.FromArgb(15, 42, 68);
            btnMostrarTodosMedicos.Cursor = Cursors.Hand;
            btnMostrarTodosMedicos.FlatAppearance.BorderSize = 0;
            btnMostrarTodosMedicos.FlatStyle = FlatStyle.Flat;
            btnMostrarTodosMedicos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMostrarTodosMedicos.ForeColor = Color.White;
            btnMostrarTodosMedicos.Location = new Point(750, 10);
            btnMostrarTodosMedicos.Name = "btnMostrarTodosMedicos";
            btnMostrarTodosMedicos.Size = new Size(175, 40);
            btnMostrarTodosMedicos.TabIndex = 3;
            btnMostrarTodosMedicos.Text = "Mostrar todos";
            btnMostrarTodosMedicos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarMedico
            // 
            btnBuscarMedico.BackColor = Color.FromArgb(15, 42, 68);
            btnBuscarMedico.Cursor = Cursors.Hand;
            btnBuscarMedico.FlatAppearance.BorderSize = 0;
            btnBuscarMedico.FlatStyle = FlatStyle.Flat;
            btnBuscarMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarMedico.ForeColor = Color.White;
            btnBuscarMedico.Location = new Point(595, 10);
            btnBuscarMedico.Name = "btnBuscarMedico";
            btnBuscarMedico.Size = new Size(140, 40);
            btnBuscarMedico.TabIndex = 2;
            btnBuscarMedico.Text = "Buscar";
            btnBuscarMedico.UseVisualStyleBackColor = false;
            // 
            // txtBuscarMedico
            // 
            txtBuscarMedico.Font = new Font("Segoe UI", 10F);
            txtBuscarMedico.Location = new Point(140, 15);
            txtBuscarMedico.Name = "txtBuscarMedico";
            txtBuscarMedico.Size = new Size(440, 25);
            txtBuscarMedico.TabIndex = 1;
            // 
            // lblBuscarMedico
            // 
            lblBuscarMedico.AutoSize = true;
            lblBuscarMedico.Font = new Font("Segoe UI", 10F);
            lblBuscarMedico.Location = new Point(15, 20);
            lblBuscarMedico.Name = "lblBuscarMedico";
            lblBuscarMedico.Size = new Size(97, 19);
            lblBuscarMedico.TabIndex = 0;
            lblBuscarMedico.Text = "Buscar médico";
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(984, 661);
            Controls.Add(pnlListaMedicos);
            Controls.Add(pnlAccionesMedicos);
            Controls.Add(pnlDatosMedico);
            Name = "FrmMedicos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de médicos";
            Load += FrmMedicos_Load;
            pnlDatosMedico.ResumeLayout(false);
            pnlDatosMedico.PerformLayout();
            pnlAccionesMedicos.ResumeLayout(false);
            pnlListaMedicos.ResumeLayout(false);
            pnlListaMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatosMedico;
        private Label lblEspecialidadMedico;
        private Label lblColegiadoMedico;
        private Label lblNombreMedico;
        private Label lblCodigoMedico;
        private Label lblTituloMedico;
        private ComboBox cmbEspecialidadMedico;
        private Panel pnlAccionesMedicos;
        private Button btnVolverMedicos;
        private Button btnHorariosMedico;
        private Button btnDesactivarMedico;
        private Button btnGuardarMedico;
        private Button btnNuevoMedico;
        private Panel pnlListaMedicos;
        private Button btnMostrarTodosMedicos;
        private Button btnBuscarMedico;
        private TextBox txtBuscarMedico;
        private Label lblBuscarMedico;
        private TextBox txtColegiadoMedico;
        private TextBox txtNombreMedico;
        private TextBox txtIdMedico;
        private DataGridView dgvMedicos;
        private DataGridViewTextBoxColumn colIdMedico;
        private DataGridViewTextBoxColumn colNombreMedico;
        private DataGridViewTextBoxColumn colColegiadoMedico;
        private DataGridViewTextBoxColumn colEspecialidadMedico;
        private DataGridViewTextBoxColumn colEstadoMedico;
    }
}