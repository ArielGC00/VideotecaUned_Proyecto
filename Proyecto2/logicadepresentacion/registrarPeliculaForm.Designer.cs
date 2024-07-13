namespace Servidor.logicadepresentacion
{
    partial class registrarPeliculaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idPeliculaTxt = new TextBox();
            tituloTxt = new TextBox();
            anioLanzamientoTxt = new TextBox();
            idomaTxt = new TextBox();
            idCategoriaComboBox = new ComboBox();
            registrarBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID de la pelicula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 56);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el titulo de la peliicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 99);
            label3.Name = "label3";
            label3.Size = new Size(219, 20);
            label3.TabIndex = 2;
            label3.Text = "Selecciona el ID de la categroia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 146);
            label4.Name = "label4";
            label4.Size = new Size(311, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingrese el año de lanzamioento de la pelicula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 183);
            label5.Name = "label5";
            label5.Size = new Size(217, 20);
            label5.TabIndex = 4;
            label5.Text = "Ingrese el idioma de la pelicula";
            // 
            // idPeliculaTxt
            // 
            idPeliculaTxt.Location = new Point(216, 24);
            idPeliculaTxt.Name = "idPeliculaTxt";
            idPeliculaTxt.Size = new Size(125, 27);
            idPeliculaTxt.TabIndex = 5;
            // 
            // tituloTxt
            // 
            tituloTxt.Location = new Point(230, 60);
            tituloTxt.Name = "tituloTxt";
            tituloTxt.Size = new Size(125, 27);
            tituloTxt.TabIndex = 6;
            // 
            // anioLanzamientoTxt
            // 
            anioLanzamientoTxt.Location = new Point(336, 146);
            anioLanzamientoTxt.Name = "anioLanzamientoTxt";
            anioLanzamientoTxt.Size = new Size(125, 27);
            anioLanzamientoTxt.TabIndex = 7;
            // 
            // idomaTxt
            // 
            idomaTxt.Location = new Point(255, 187);
            idomaTxt.Name = "idomaTxt";
            idomaTxt.Size = new Size(125, 27);
            idomaTxt.TabIndex = 8;
            // 
            // idCategoriaComboBox
            // 
            idCategoriaComboBox.FormattingEnabled = true;
            idCategoriaComboBox.Location = new Point(249, 102);
            idCategoriaComboBox.Name = "idCategoriaComboBox";
            idCategoriaComboBox.Size = new Size(151, 28);
            idCategoriaComboBox.TabIndex = 9;
            idCategoriaComboBox.SelectedIndexChanged += idCategoriaComboBox_SelectedIndexChanged;
            // 
            // registrarBtn
            // 
            registrarBtn.Location = new Point(22, 249);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(94, 29);
            registrarBtn.TabIndex = 10;
            registrarBtn.Text = "Registrar";
            registrarBtn.UseVisualStyleBackColor = true;
            registrarBtn.Click += registrarBtn_Click;
            // 
            // registrarPeliculaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registrarBtn);
            Controls.Add(idCategoriaComboBox);
            Controls.Add(idomaTxt);
            Controls.Add(anioLanzamientoTxt);
            Controls.Add(tituloTxt);
            Controls.Add(idPeliculaTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registrarPeliculaForm";
            Text = "registrarPeliculaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idPeliculaTxt;
        private TextBox tituloTxt;
        private TextBox anioLanzamientoTxt;
        private TextBox idomaTxt;
        private ComboBox idCategoriaComboBox;
        private Button registrarBtn;
    }
}