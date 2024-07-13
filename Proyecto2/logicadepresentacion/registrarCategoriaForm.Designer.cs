namespace Servidor.logicadepresentacion
{
    partial class registrarCategoriaForm
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
            registrarCategoriaBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idCategoriaTxt = new TextBox();
            nombreCategoriaTxt = new TextBox();
            descripcionCategoriaTxt = new TextBox();
            SuspendLayout();
            // 
            // registrarCategoriaBtn
            // 
            registrarCategoriaBtn.Location = new Point(12, 300);
            registrarCategoriaBtn.Name = "registrarCategoriaBtn";
            registrarCategoriaBtn.Size = new Size(94, 29);
            registrarCategoriaBtn.TabIndex = 0;
            registrarCategoriaBtn.Text = "Registrar";
            registrarCategoriaBtn.UseVisualStyleBackColor = true;
            registrarCategoriaBtn.Click += registrarCategoriaBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el id de la categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(233, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el nombre de la categoría";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(257, 20);
            label3.TabIndex = 3;
            label3.Text = "Ingrese la descripción de la categoría";
            // 
            // idCategoriaTxt
            // 
            idCategoriaTxt.Location = new Point(240, 53);
            idCategoriaTxt.Name = "idCategoriaTxt";
            idCategoriaTxt.Size = new Size(213, 27);
            idCategoriaTxt.TabIndex = 4;
            // 
            // nombreCategoriaTxt
            // 
            nombreCategoriaTxt.Location = new Point(263, 119);
            nombreCategoriaTxt.Name = "nombreCategoriaTxt";
            nombreCategoriaTxt.Size = new Size(190, 27);
            nombreCategoriaTxt.TabIndex = 5;
            // 
            // descripcionCategoriaTxt
            // 
            descripcionCategoriaTxt.Location = new Point(275, 195);
            descripcionCategoriaTxt.Name = "descripcionCategoriaTxt";
            descripcionCategoriaTxt.Size = new Size(200, 27);
            descripcionCategoriaTxt.TabIndex = 6;
            // 
            // registrarCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descripcionCategoriaTxt);
            Controls.Add(nombreCategoriaTxt);
            Controls.Add(idCategoriaTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registrarCategoriaBtn);
            Name = "registrarCategoriaForm";
            Text = "registrarCategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarCategoriaBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idCategoriaTxt;
        private TextBox nombreCategoriaTxt;
        private TextBox descripcionCategoriaTxt;
    }
}