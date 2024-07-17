namespace Cliente
{
    partial class PrestamoClienteForm
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
            nombreUsuarioLabel = new Label();
            label1 = new Label();
            comboBoxSucursal = new ComboBox();
            cargarSucursal = new Button();
            solicitarPrestamoBtn = new Button();
            label2 = new Label();
            dataGridViewPeliculas = new DataGridView();
            selectSucursalBtn = new Button();
            verPrestamosBtn = new Button();
            dataGridViewVerPrestamos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVerPrestamos).BeginInit();
            SuspendLayout();
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new Point(300, 29);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new Size(0, 20);
            nombreUsuarioLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 82);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la sucursal";
            // 
            // comboBoxSucursal
            // 
            comboBoxSucursal.DisplayMember = "Value";
            comboBoxSucursal.FormattingEnabled = true;
            comboBoxSucursal.Location = new Point(204, 82);
            comboBoxSucursal.Name = "comboBoxSucursal";
            comboBoxSucursal.Size = new Size(281, 28);
            comboBoxSucursal.TabIndex = 2;
            // 
            // cargarSucursal
            // 
            cargarSucursal.Location = new Point(491, 82);
            cargarSucursal.Name = "cargarSucursal";
            cargarSucursal.Size = new Size(142, 29);
            cargarSucursal.TabIndex = 3;
            cargarSucursal.Text = "Cargar sucursales";
            cargarSucursal.UseVisualStyleBackColor = true;
            cargarSucursal.Click += cargarSucursal_Click;
            // 
            // solicitarPrestamoBtn
            // 
            solicitarPrestamoBtn.Location = new Point(33, 458);
            solicitarPrestamoBtn.Name = "solicitarPrestamoBtn";
            solicitarPrestamoBtn.Size = new Size(157, 29);
            solicitarPrestamoBtn.TabIndex = 4;
            solicitarPrestamoBtn.Text = "Solicitar prestamo";
            solicitarPrestamoBtn.UseVisualStyleBackColor = true;
            solicitarPrestamoBtn.Click += solicitarPrestamoBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 137);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 5;
            label2.Text = "Seleccione una pelicula";
            // 
            // dataGridViewPeliculas
            // 
            dataGridViewPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeliculas.Location = new Point(20, 171);
            dataGridViewPeliculas.Name = "dataGridViewPeliculas";
            dataGridViewPeliculas.RowHeadersWidth = 51;
            dataGridViewPeliculas.Size = new Size(780, 258);
            dataGridViewPeliculas.TabIndex = 6;
            // 
            // selectSucursalBtn
            // 
            selectSucursalBtn.Location = new Point(639, 82);
            selectSucursalBtn.Name = "selectSucursalBtn";
            selectSucursalBtn.Size = new Size(161, 29);
            selectSucursalBtn.TabIndex = 8;
            selectSucursalBtn.Text = "Seleccionar sucursal";
            selectSucursalBtn.UseVisualStyleBackColor = true;
            selectSucursalBtn.Click += selectSucursalBtn_Click;
            // 
            // verPrestamosBtn
            // 
            verPrestamosBtn.Location = new Point(1407, 485);
            verPrestamosBtn.Name = "verPrestamosBtn";
            verPrestamosBtn.Size = new Size(161, 29);
            verPrestamosBtn.TabIndex = 9;
            verPrestamosBtn.Text = "Ver mis prestamos";
            verPrestamosBtn.UseVisualStyleBackColor = true;
            verPrestamosBtn.Click += verPrestamosBtn_Click;
            // 
            // dataGridViewVerPrestamos
            // 
            dataGridViewVerPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVerPrestamos.Location = new Point(849, 94);
            dataGridViewVerPrestamos.Name = "dataGridViewVerPrestamos";
            dataGridViewVerPrestamos.RowHeadersWidth = 51;
            dataGridViewVerPrestamos.Size = new Size(719, 360);
            dataGridViewVerPrestamos.TabIndex = 10;
            // 
            // PrestamoClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 526);
            Controls.Add(dataGridViewVerPrestamos);
            Controls.Add(verPrestamosBtn);
            Controls.Add(selectSucursalBtn);
            Controls.Add(dataGridViewPeliculas);
            Controls.Add(label2);
            Controls.Add(solicitarPrestamoBtn);
            Controls.Add(cargarSucursal);
            Controls.Add(comboBoxSucursal);
            Controls.Add(label1);
            Controls.Add(nombreUsuarioLabel);
            Name = "PrestamoClienteForm";
            Text = "PrestamoClienteForm";
            Load += PrestamoClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVerPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreUsuarioLabel;
        private Label label1;
        private ComboBox comboBoxSucursal;
        private Button cargarSucursal;
        private Button solicitarPrestamoBtn;
        private Label label2;
        private DataGridView dataGridViewPeliculas;
        private Button selectSucursalBtn;
        private Button verPrestamosBtn;
        private DataGridView dataGridViewVerPrestamos;
    }
}