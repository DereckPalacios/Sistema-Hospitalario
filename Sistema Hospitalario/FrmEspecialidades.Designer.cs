namespace Sistema_Hospitalario
{
    partial class FrmEspecialidades
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
            pnlDatosEspecialidad = new Panel();
            cmbClasificacionEspecialidad = new ComboBox();
            txtNombreEspecialidad = new TextBox();
            txtIdEspecialidad = new TextBox();
            lblClasificacionEspecialidad = new Label();
            lblNombreEspecialidad = new Label();
            lblCodigoEspecialidad = new Label();
            lblTituloEspecialidad = new Label();
            pnlAccionesEspecialidades = new Panel();
            btnVolverEspecialidades = new Button();
            btnGuardarEspecialidad = new Button();
            btnNuevaEspecialidad = new Button();
            pnlListaEspecialidades = new Panel();
            dgvEspecialidades = new DataGridView();
            colIdEspecialidad = new DataGridViewTextBoxColumn();
            colNombreEspecialidad = new DataGridViewTextBoxColumn();
            colClasificacionEspecialidad = new DataGridViewTextBoxColumn();
            btnMostrarTodasEspecialidades = new Button();
            btnBuscarEspecialidad = new Button();
            txtBuscarEspecialidad = new TextBox();
            lblBuscarEspecialidad = new Label();
            pnlDatosEspecialidad.SuspendLayout();
            pnlAccionesEspecialidades.SuspendLayout();
            pnlListaEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // pnlDatosEspecialidad
            // 
            pnlDatosEspecialidad.BackColor = Color.White;
            pnlDatosEspecialidad.BorderStyle = BorderStyle.FixedSingle;
            pnlDatosEspecialidad.Controls.Add(cmbClasificacionEspecialidad);
            pnlDatosEspecialidad.Controls.Add(txtNombreEspecialidad);
            pnlDatosEspecialidad.Controls.Add(txtIdEspecialidad);
            pnlDatosEspecialidad.Controls.Add(lblClasificacionEspecialidad);
            pnlDatosEspecialidad.Controls.Add(lblNombreEspecialidad);
            pnlDatosEspecialidad.Controls.Add(lblCodigoEspecialidad);
            pnlDatosEspecialidad.Controls.Add(lblTituloEspecialidad);
            pnlDatosEspecialidad.Location = new Point(20, 20);
            pnlDatosEspecialidad.Name = "pnlDatosEspecialidad";
            pnlDatosEspecialidad.Size = new Size(840, 180);
            pnlDatosEspecialidad.TabIndex = 0;
            // 
            // cmbClasificacionEspecialidad
            // 
            cmbClasificacionEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClasificacionEspecialidad.Font = new Font("Segoe UI", 11F);
            cmbClasificacionEspecialidad.FormattingEnabled = true;
            cmbClasificacionEspecialidad.Items.AddRange(new object[] { "Clínica", "Quirúrgica", "Diagnóstica" });
            cmbClasificacionEspecialidad.Location = new Point(540, 95);
            cmbClasificacionEspecialidad.Name = "cmbClasificacionEspecialidad";
            cmbClasificacionEspecialidad.Size = new Size(270, 28);
            cmbClasificacionEspecialidad.TabIndex = 6;
            // 
            // txtNombreEspecialidad
            // 
            txtNombreEspecialidad.Font = new Font("Segoe UI", 11F);
            txtNombreEspecialidad.Location = new Point(180, 95);
            txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            txtNombreEspecialidad.Size = new Size(330, 27);
            txtNombreEspecialidad.TabIndex = 5;
            // 
            // txtIdEspecialidad
            // 
            txtIdEspecialidad.Font = new Font("Segoe UI", 11F);
            txtIdEspecialidad.Location = new Point(20, 95);
            txtIdEspecialidad.Name = "txtIdEspecialidad";
            txtIdEspecialidad.ReadOnly = true;
            txtIdEspecialidad.Size = new Size(130, 27);
            txtIdEspecialidad.TabIndex = 4;
            // 
            // lblClasificacionEspecialidad
            // 
            lblClasificacionEspecialidad.AutoSize = true;
            lblClasificacionEspecialidad.BackColor = Color.Transparent;
            lblClasificacionEspecialidad.Font = new Font("Segoe UI", 10F);
            lblClasificacionEspecialidad.ForeColor = Color.FromArgb(15, 42, 68);
            lblClasificacionEspecialidad.Location = new Point(540, 65);
            lblClasificacionEspecialidad.Name = "lblClasificacionEspecialidad";
            lblClasificacionEspecialidad.Size = new Size(82, 19);
            lblClasificacionEspecialidad.TabIndex = 3;
            lblClasificacionEspecialidad.Text = "Clasificación";
            // 
            // lblNombreEspecialidad
            // 
            lblNombreEspecialidad.AutoSize = true;
            lblNombreEspecialidad.BackColor = Color.Transparent;
            lblNombreEspecialidad.Font = new Font("Segoe UI", 10F);
            lblNombreEspecialidad.ForeColor = Color.FromArgb(15, 42, 68);
            lblNombreEspecialidad.Location = new Point(180, 65);
            lblNombreEspecialidad.Name = "lblNombreEspecialidad";
            lblNombreEspecialidad.Size = new Size(169, 19);
            lblNombreEspecialidad.TabIndex = 2;
            lblNombreEspecialidad.Text = "Nombre de la especialidad";
            // 
            // lblCodigoEspecialidad
            // 
            lblCodigoEspecialidad.AutoSize = true;
            lblCodigoEspecialidad.BackColor = Color.Transparent;
            lblCodigoEspecialidad.Font = new Font("Segoe UI", 10F);
            lblCodigoEspecialidad.ForeColor = Color.FromArgb(15, 42, 68);
            lblCodigoEspecialidad.Location = new Point(20, 65);
            lblCodigoEspecialidad.Name = "lblCodigoEspecialidad";
            lblCodigoEspecialidad.Size = new Size(53, 19);
            lblCodigoEspecialidad.TabIndex = 1;
            lblCodigoEspecialidad.Text = "Código";
            // 
            // lblTituloEspecialidad
            // 
            lblTituloEspecialidad.AutoSize = true;
            lblTituloEspecialidad.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloEspecialidad.Location = new Point(20, 15);
            lblTituloEspecialidad.Name = "lblTituloEspecialidad";
            lblTituloEspecialidad.Size = new Size(264, 30);
            lblTituloEspecialidad.TabIndex = 0;
            lblTituloEspecialidad.Text = "Datos de la especialidad";
            // 
            // pnlAccionesEspecialidades
            // 
            pnlAccionesEspecialidades.BackColor = Color.White;
            pnlAccionesEspecialidades.Controls.Add(btnVolverEspecialidades);
            pnlAccionesEspecialidades.Controls.Add(btnGuardarEspecialidad);
            pnlAccionesEspecialidades.Controls.Add(btnNuevaEspecialidad);
            pnlAccionesEspecialidades.Location = new Point(20, 215);
            pnlAccionesEspecialidades.Name = "pnlAccionesEspecialidades";
            pnlAccionesEspecialidades.Size = new Size(840, 60);
            pnlAccionesEspecialidades.TabIndex = 1;
            // 
            // btnVolverEspecialidades
            // 
            btnVolverEspecialidades.BackColor = Color.FromArgb(100, 110, 120);
            btnVolverEspecialidades.Cursor = Cursors.Hand;
            btnVolverEspecialidades.FlatAppearance.BorderSize = 0;
            btnVolverEspecialidades.FlatStyle = FlatStyle.Flat;
            btnVolverEspecialidades.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolverEspecialidades.ForeColor = Color.White;
            btnVolverEspecialidades.Location = new Point(675, 10);
            btnVolverEspecialidades.Name = "btnVolverEspecialidades";
            btnVolverEspecialidades.Size = new Size(150, 40);
            btnVolverEspecialidades.TabIndex = 2;
            btnVolverEspecialidades.Text = "Volver";
            btnVolverEspecialidades.UseVisualStyleBackColor = false;
            btnVolverEspecialidades.Click += btnVolverEspecialidades_Click;
            // 
            // btnGuardarEspecialidad
            // 
            btnGuardarEspecialidad.BackColor = Color.FromArgb(0, 166, 180);
            btnGuardarEspecialidad.Cursor = Cursors.Hand;
            btnGuardarEspecialidad.FlatAppearance.BorderSize = 0;
            btnGuardarEspecialidad.FlatStyle = FlatStyle.Flat;
            btnGuardarEspecialidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarEspecialidad.ForeColor = Color.White;
            btnGuardarEspecialidad.Location = new Point(180, 10);
            btnGuardarEspecialidad.Name = "btnGuardarEspecialidad";
            btnGuardarEspecialidad.Size = new Size(150, 40);
            btnGuardarEspecialidad.TabIndex = 1;
            btnGuardarEspecialidad.Text = "Guardar";
            btnGuardarEspecialidad.UseVisualStyleBackColor = false;
            btnGuardarEspecialidad.Click += btnGuardarEspecialidad_Click;
            // 
            // btnNuevaEspecialidad
            // 
            btnNuevaEspecialidad.BackColor = Color.FromArgb(15, 42, 68);
            btnNuevaEspecialidad.Cursor = Cursors.Hand;
            btnNuevaEspecialidad.FlatAppearance.BorderSize = 0;
            btnNuevaEspecialidad.FlatStyle = FlatStyle.Flat;
            btnNuevaEspecialidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaEspecialidad.ForeColor = Color.White;
            btnNuevaEspecialidad.Location = new Point(15, 10);
            btnNuevaEspecialidad.Name = "btnNuevaEspecialidad";
            btnNuevaEspecialidad.Size = new Size(150, 40);
            btnNuevaEspecialidad.TabIndex = 0;
            btnNuevaEspecialidad.Text = "Nueva";
            btnNuevaEspecialidad.UseVisualStyleBackColor = false;
            btnNuevaEspecialidad.Click += btnNuevaEspecialidad_Click;
            // 
            // pnlListaEspecialidades
            // 
            pnlListaEspecialidades.BackColor = Color.White;
            pnlListaEspecialidades.BorderStyle = BorderStyle.FixedSingle;
            pnlListaEspecialidades.Controls.Add(dgvEspecialidades);
            pnlListaEspecialidades.Controls.Add(btnMostrarTodasEspecialidades);
            pnlListaEspecialidades.Controls.Add(btnBuscarEspecialidad);
            pnlListaEspecialidades.Controls.Add(txtBuscarEspecialidad);
            pnlListaEspecialidades.Controls.Add(lblBuscarEspecialidad);
            pnlListaEspecialidades.Location = new Point(20, 290);
            pnlListaEspecialidades.Name = "pnlListaEspecialidades";
            pnlListaEspecialidades.Size = new Size(840, 250);
            pnlListaEspecialidades.TabIndex = 2;
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.BorderStyle = BorderStyle.None;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new DataGridViewColumn[] { colIdEspecialidad, colNombreEspecialidad, colClasificacionEspecialidad });
            dgvEspecialidades.Location = new Point(15, 65);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersVisible = false;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(805, 165);
            dgvEspecialidades.TabIndex = 4;
            dgvEspecialidades.CellClick += dgvEspecialidades_CellClick;
            // 
            // colIdEspecialidad
            // 
            colIdEspecialidad.HeaderText = "Código";
            colIdEspecialidad.Name = "colIdEspecialidad";
            colIdEspecialidad.ReadOnly = true;
            // 
            // colNombreEspecialidad
            // 
            colNombreEspecialidad.HeaderText = " Especialidad";
            colNombreEspecialidad.Name = "colNombreEspecialidad";
            colNombreEspecialidad.ReadOnly = true;
            // 
            // colClasificacionEspecialidad
            // 
            colClasificacionEspecialidad.HeaderText = "Clasificación";
            colClasificacionEspecialidad.Name = "colClasificacionEspecialidad";
            colClasificacionEspecialidad.ReadOnly = true;
            // 
            // btnMostrarTodasEspecialidades
            // 
            btnMostrarTodasEspecialidades.BackColor = Color.FromArgb(15, 42, 68);
            btnMostrarTodasEspecialidades.Cursor = Cursors.Hand;
            btnMostrarTodasEspecialidades.FlatAppearance.BorderSize = 0;
            btnMostrarTodasEspecialidades.FlatStyle = FlatStyle.Flat;
            btnMostrarTodasEspecialidades.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMostrarTodasEspecialidades.ForeColor = Color.White;
            btnMostrarTodasEspecialidades.Location = new Point(655, 10);
            btnMostrarTodasEspecialidades.Name = "btnMostrarTodasEspecialidades";
            btnMostrarTodasEspecialidades.Size = new Size(165, 40);
            btnMostrarTodasEspecialidades.TabIndex = 3;
            btnMostrarTodasEspecialidades.Text = "Mostrar todas";
            btnMostrarTodasEspecialidades.UseVisualStyleBackColor = false;
            btnMostrarTodasEspecialidades.Click += btnMostrarTodasEspecialidades_Click;
            // 
            // btnBuscarEspecialidad
            // 
            btnBuscarEspecialidad.BackColor = Color.FromArgb(15, 42, 68);
            btnBuscarEspecialidad.Cursor = Cursors.Hand;
            btnBuscarEspecialidad.FlatAppearance.BorderSize = 0;
            btnBuscarEspecialidad.FlatStyle = FlatStyle.Flat;
            btnBuscarEspecialidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarEspecialidad.ForeColor = Color.White;
            btnBuscarEspecialidad.Location = new Point(500, 10);
            btnBuscarEspecialidad.Name = "btnBuscarEspecialidad";
            btnBuscarEspecialidad.Size = new Size(140, 40);
            btnBuscarEspecialidad.TabIndex = 2;
            btnBuscarEspecialidad.Text = "Buscar";
            btnBuscarEspecialidad.UseVisualStyleBackColor = false;
            btnBuscarEspecialidad.Click += btnBuscarEspecialidad_Click;
            // 
            // txtBuscarEspecialidad
            // 
            txtBuscarEspecialidad.Font = new Font("Segoe UI", 10F);
            txtBuscarEspecialidad.Location = new Point(155, 15);
            txtBuscarEspecialidad.Name = "txtBuscarEspecialidad";
            txtBuscarEspecialidad.Size = new Size(330, 25);
            txtBuscarEspecialidad.TabIndex = 1;
            // 
            // lblBuscarEspecialidad
            // 
            lblBuscarEspecialidad.AutoSize = true;
            lblBuscarEspecialidad.Font = new Font("Segoe UI", 10F);
            lblBuscarEspecialidad.Location = new Point(15, 20);
            lblBuscarEspecialidad.Name = "lblBuscarEspecialidad";
            lblBuscarEspecialidad.Size = new Size(126, 19);
            lblBuscarEspecialidad.TabIndex = 0;
            lblBuscarEspecialidad.Text = "Buscar especialidad";
            // 
            // FrmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(884, 561);
            Controls.Add(pnlListaEspecialidades);
            Controls.Add(pnlAccionesEspecialidades);
            Controls.Add(pnlDatosEspecialidad);
            Name = "FrmEspecialidades";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de especialidades";
            pnlDatosEspecialidad.ResumeLayout(false);
            pnlDatosEspecialidad.PerformLayout();
            pnlAccionesEspecialidades.ResumeLayout(false);
            pnlListaEspecialidades.ResumeLayout(false);
            pnlListaEspecialidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatosEspecialidad;
        private TextBox txtNombreEspecialidad;
        private TextBox txtIdEspecialidad;
        private Label lblClasificacionEspecialidad;
        private Label lblNombreEspecialidad;
        private Label lblCodigoEspecialidad;
        private Label lblTituloEspecialidad;
        private ComboBox cmbClasificacionEspecialidad;
        private Panel pnlAccionesEspecialidades;
        private Button btnVolverEspecialidades;
        private Button btnGuardarEspecialidad;
        private Button btnNuevaEspecialidad;
        private Panel pnlListaEspecialidades;
        private DataGridView dgvEspecialidades;
        private Button btnMostrarTodasEspecialidades;
        private Button btnBuscarEspecialidad;
        private TextBox txtBuscarEspecialidad;
        private Label lblBuscarEspecialidad;
        private DataGridViewTextBoxColumn colIdEspecialidad;
        private DataGridViewTextBoxColumn colNombreEspecialidad;
        private DataGridViewTextBoxColumn colClasificacionEspecialidad;
    }
}