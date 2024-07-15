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
            verClientesBtn = new Button();
            verPeliculasBtn = new Button();
            verSucursalesRegistradasBtn = new Button();
            verEncargadoBtn = new Button();
            verCategoriasBtn = new Button();
            verPeliculaXSucursalBtn = new Button();
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
            funcionClienteBtn.Size = new Size(138, 29);
            funcionClienteBtn.TabIndex = 2;
            funcionClienteBtn.Text = "Registrar Cliente";
            funcionClienteBtn.UseVisualStyleBackColor = true;
            funcionClienteBtn.Click += funcionClienteBtn_Click;
            // 
            // peliculasBtn
            // 
            peliculasBtn.Location = new Point(22, 249);
            peliculasBtn.Name = "peliculasBtn";
            peliculasBtn.Size = new Size(138, 29);
            peliculasBtn.TabIndex = 3;
            peliculasBtn.Text = "Registrar Pelicula";
            peliculasBtn.UseVisualStyleBackColor = true;
            peliculasBtn.Click += peliculasBtn_Click;
            // 
            // sucursalBtn
            // 
            sucursalBtn.Location = new Point(22, 302);
            sucursalBtn.Name = "sucursalBtn";
            sucursalBtn.Size = new Size(138, 29);
            sucursalBtn.TabIndex = 4;
            sucursalBtn.Text = "Registrar Sucursal";
            sucursalBtn.UseVisualStyleBackColor = true;
            sucursalBtn.Click += sucursalBtn_Click;
            // 
            // encargadoBtn
            // 
            encargadoBtn.Location = new Point(22, 346);
            encargadoBtn.Name = "encargadoBtn";
            encargadoBtn.Size = new Size(157, 29);
            encargadoBtn.TabIndex = 5;
            encargadoBtn.Text = "Registrar Encargado";
            encargadoBtn.UseVisualStyleBackColor = true;
            encargadoBtn.Click += encargadoBtn_Click;
            // 
            // categoriaBtn
            // 
            categoriaBtn.Location = new Point(22, 391);
            categoriaBtn.Name = "categoriaBtn";
            categoriaBtn.Size = new Size(157, 29);
            categoriaBtn.TabIndex = 6;
            categoriaBtn.Text = "Registrar Categoria";
            categoriaBtn.UseVisualStyleBackColor = true;
            categoriaBtn.Click += categoriaBtn_Click;
            // 
            // peliculaXSucursalBtn
            // 
            peliculaXSucursalBtn.Location = new Point(22, 439);
            peliculaXSucursalBtn.Name = "peliculaXSucursalBtn";
            peliculaXSucursalBtn.Size = new Size(218, 29);
            peliculaXSucursalBtn.TabIndex = 7;
            peliculaXSucursalBtn.Text = "Registrar Pelicula por Sucursal";
            peliculaXSucursalBtn.UseVisualStyleBackColor = true;
            peliculaXSucursalBtn.Click += peliculaXSucursalBtn_Click;
            // 
            // verClientesBtn
            // 
            verClientesBtn.Location = new Point(196, 205);
            verClientesBtn.Name = "verClientesBtn";
            verClientesBtn.Size = new Size(182, 29);
            verClientesBtn.TabIndex = 8;
            verClientesBtn.Text = "Ver clientes registrados";
            verClientesBtn.UseVisualStyleBackColor = true;
            verClientesBtn.Click += verClientesBtn_Click;
            // 
            // verPeliculasBtn
            // 
            verPeliculasBtn.Location = new Point(187, 249);
            verPeliculasBtn.Name = "verPeliculasBtn";
            verPeliculasBtn.Size = new Size(191, 29);
            verPeliculasBtn.TabIndex = 9;
            verPeliculasBtn.Text = "Ver peliculas registradas";
            verPeliculasBtn.UseVisualStyleBackColor = true;
            verPeliculasBtn.Click += verPeliculasBtn_Click;
            // 
            // verSucursalesRegistradasBtn
            // 
            verSucursalesRegistradasBtn.Location = new Point(185, 307);
            verSucursalesRegistradasBtn.Name = "verSucursalesRegistradasBtn";
            verSucursalesRegistradasBtn.Size = new Size(193, 29);
            verSucursalesRegistradasBtn.TabIndex = 10;
            verSucursalesRegistradasBtn.Text = "Ver sucursales registradas";
            verSucursalesRegistradasBtn.UseVisualStyleBackColor = true;
            verSucursalesRegistradasBtn.Click += verSucursalesRegistradasBtn_Click;
            // 
            // verEncargadoBtn
            // 
            verEncargadoBtn.Location = new Point(187, 346);
            verEncargadoBtn.Name = "verEncargadoBtn";
            verEncargadoBtn.Size = new Size(210, 29);
            verEncargadoBtn.TabIndex = 11;
            verEncargadoBtn.Text = "Ver encargados registrados";
            verEncargadoBtn.UseVisualStyleBackColor = true;
            verEncargadoBtn.Click += verEncargadoBtn_Click;
            // 
            // verCategoriasBtn
            // 
            verCategoriasBtn.Location = new Point(185, 391);
            verCategoriasBtn.Name = "verCategoriasBtn";
            verCategoriasBtn.Size = new Size(204, 29);
            verCategoriasBtn.TabIndex = 12;
            verCategoriasBtn.Text = "Ver categorias registradas";
            verCategoriasBtn.UseVisualStyleBackColor = true;
            verCategoriasBtn.Click += verCategoriasBtn_Click;
            // 
            // verPeliculaXSucursalBtn
            // 
            verPeliculaXSucursalBtn.Location = new Point(246, 439);
            verPeliculaXSucursalBtn.Name = "verPeliculaXSucursalBtn";
            verPeliculaXSucursalBtn.Size = new Size(290, 29);
            verPeliculaXSucursalBtn.TabIndex = 13;
            verPeliculaXSucursalBtn.Text = "Ver las peliculas por sucursal registradas";
            verPeliculaXSucursalBtn.UseVisualStyleBackColor = true;
            verPeliculaXSucursalBtn.Click += verPeliculaXSucursalBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 500);
            Controls.Add(verPeliculaXSucursalBtn);
            Controls.Add(verCategoriasBtn);
            Controls.Add(verEncargadoBtn);
            Controls.Add(verSucursalesRegistradasBtn);
            Controls.Add(verPeliculasBtn);
            Controls.Add(verClientesBtn);
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
        private Button verClientesBtn;
        private Button verPeliculasBtn;
        private Button verSucursalesRegistradasBtn;
        private Button verEncargadoBtn;
        private Button verCategoriasBtn;
        private Button verPeliculaXSucursalBtn;
    }
}
