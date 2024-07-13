namespace Proyecto2
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
            tituloLabel = new Label();
            label1 = new Label();
            funcionClienteBtn = new Button();
            peliculasBtn = new Button();
            sucursalBtn = new Button();
            encargadoBtn = new Button();
            categoriaBtn = new Button();
            peliculaXSucursalBtn = new Button();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.Font = new Font("Segoe UI", 15F);
            tituloLabel.Location = new Point(295, 9);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(313, 41);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Bienvenido Administrador";
            tituloLabel.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 139);
            label1.Name = "label1";
            label1.Size = new Size(268, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la acción que desea realizar";
            // 
            // funcionClienteBtn
            // 
            funcionClienteBtn.Location = new Point(22, 205);
            funcionClienteBtn.Name = "funcionClienteBtn";
            funcionClienteBtn.Size = new Size(94, 29);
            funcionClienteBtn.TabIndex = 2;
            funcionClienteBtn.Text = "Clientes";
            funcionClienteBtn.UseVisualStyleBackColor = true;
            funcionClienteBtn.Click += funcionClienteBtn_Click;
            // 
            // peliculasBtn
            // 
            peliculasBtn.Location = new Point(158, 205);
            peliculasBtn.Name = "peliculasBtn";
            peliculasBtn.Size = new Size(94, 29);
            peliculasBtn.TabIndex = 3;
            peliculasBtn.Text = "Peliculas";
            peliculasBtn.UseVisualStyleBackColor = true;
            // 
            // sucursalBtn
            // 
            sucursalBtn.Location = new Point(295, 205);
            sucursalBtn.Name = "sucursalBtn";
            sucursalBtn.Size = new Size(94, 29);
            sucursalBtn.TabIndex = 4;
            sucursalBtn.Text = "Sucursal";
            sucursalBtn.UseVisualStyleBackColor = true;
            // 
            // encargadoBtn
            // 
            encargadoBtn.Location = new Point(420, 205);
            encargadoBtn.Name = "encargadoBtn";
            encargadoBtn.Size = new Size(94, 29);
            encargadoBtn.TabIndex = 5;
            encargadoBtn.Text = "Encargado";
            encargadoBtn.UseVisualStyleBackColor = true;
            // 
            // categoriaBtn
            // 
            categoriaBtn.Location = new Point(544, 205);
            categoriaBtn.Name = "categoriaBtn";
            categoriaBtn.Size = new Size(94, 29);
            categoriaBtn.TabIndex = 6;
            categoriaBtn.Text = "Categorias";
            categoriaBtn.UseVisualStyleBackColor = true;
            categoriaBtn.Click += categoriaBtn_Click;
            // 
            // peliculaXSucursalBtn
            // 
            peliculaXSucursalBtn.Location = new Point(677, 205);
            peliculaXSucursalBtn.Name = "peliculaXSucursalBtn";
            peliculaXSucursalBtn.Size = new Size(184, 29);
            peliculaXSucursalBtn.TabIndex = 7;
            peliculaXSucursalBtn.Text = "Pelicula por Sucursal";
            peliculaXSucursalBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 500);
            Controls.Add(peliculaXSucursalBtn);
            Controls.Add(categoriaBtn);
            Controls.Add(encargadoBtn);
            Controls.Add(sucursalBtn);
            Controls.Add(peliculasBtn);
            Controls.Add(funcionClienteBtn);
            Controls.Add(label1);
            Controls.Add(tituloLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label label1;
        private Button funcionClienteBtn;
        private Button peliculasBtn;
        private Button sucursalBtn;
        private Button encargadoBtn;
        private Button categoriaBtn;
        private Button peliculaXSucursalBtn;
    }
}
