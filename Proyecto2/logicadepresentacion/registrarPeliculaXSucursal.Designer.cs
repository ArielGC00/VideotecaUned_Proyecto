namespace Servidor.logicadepresentacion
{
    partial class registrarPeliculaXSucursal
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
            registarPeliculaXSucursalBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cantidadPeliculasTxt = new NumericUpDown();
            peliculaComboBox = new ComboBox();
            sucursalComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)cantidadPeliculasTxt).BeginInit();
            SuspendLayout();
            // 
            // registarPeliculaXSucursalBtn
            // 
            registarPeliculaXSucursalBtn.Location = new Point(27, 357);
            registarPeliculaXSucursalBtn.Name = "registarPeliculaXSucursalBtn";
            registarPeliculaXSucursalBtn.Size = new Size(94, 29);
            registarPeliculaXSucursalBtn.TabIndex = 0;
            registarPeliculaXSucursalBtn.Text = "Registrar";
            registarPeliculaXSucursalBtn.UseVisualStyleBackColor = true;
            registarPeliculaXSucursalBtn.Click += registarPeliculaXSucursalBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 21);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 2;
            label2.Text = "Seleccione la pelicula ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 163);
            label3.Name = "label3";
            label3.Size = new Size(328, 20);
            label3.TabIndex = 3;
            label3.Text = "Ingrese la cantidad de peliculas que va aregistar";
            // 
            // cantidadPeliculasTxt
            // 
            cantidadPeliculasTxt.Location = new Point(394, 163);
            cantidadPeliculasTxt.Name = "cantidadPeliculasTxt";
            cantidadPeliculasTxt.Size = new Size(150, 27);
            cantidadPeliculasTxt.TabIndex = 4;
            // 
            // peliculaComboBox
            // 
            peliculaComboBox.FormattingEnabled = true;
            peliculaComboBox.Location = new Point(233, 96);
            peliculaComboBox.Name = "peliculaComboBox";
            peliculaComboBox.Size = new Size(151, 28);
            peliculaComboBox.TabIndex = 5;
            // 
            // sucursalComboBox
            // 
            sucursalComboBox.FormattingEnabled = true;
            sucursalComboBox.Location = new Point(218, 25);
            sucursalComboBox.Name = "sucursalComboBox";
            sucursalComboBox.Size = new Size(151, 28);
            sucursalComboBox.TabIndex = 6;
            // 
            // registrarPeliculaXSucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sucursalComboBox);
            Controls.Add(peliculaComboBox);
            Controls.Add(cantidadPeliculasTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registarPeliculaXSucursalBtn);
            Name = "registrarPeliculaXSucursal";
            Text = "registrarPeliculaXSucursal";
            ((System.ComponentModel.ISupportInitialize)cantidadPeliculasTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registarPeliculaXSucursalBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown cantidadPeliculasTxt;
        private ComboBox peliculaComboBox;
        private ComboBox sucursalComboBox;
    }
}