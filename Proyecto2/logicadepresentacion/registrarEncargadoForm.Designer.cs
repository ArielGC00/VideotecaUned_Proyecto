namespace Servidor.logicadepresentacion
{
    partial class registrarEncargadoForm
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
            label6 = new Label();
            btnRegistrarEncargado = new Button();
            cedulaEncargadoTxt = new TextBox();
            idEncargadoTxt = new TextBox();
            nombreEncargadoTxt = new TextBox();
            primerApellidoTxt = new TextBox();
            segundoApellidoTxt = new TextBox();
            fechaNacimientoEncargado = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el numero de cedula del encargado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el ID de encargado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 106);
            label3.Name = "label3";
            label3.Size = new Size(229, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el nombre del encargado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 145);
            label4.Name = "label4";
            label4.Size = new Size(280, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingrese el primer apellido del encargado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 185);
            label5.Name = "label5";
            label5.Size = new Size(293, 20);
            label5.TabIndex = 4;
            label5.Text = "Ingrese el segundo apellido del encargado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 233);
            label6.Name = "label6";
            label6.Size = new Size(312, 20);
            label6.TabIndex = 5;
            label6.Text = "Ingrese la fecha de nacimiento del encargado";
            // 
            // btnRegistrarEncargado
            // 
            btnRegistrarEncargado.Location = new Point(20, 308);
            btnRegistrarEncargado.Name = "btnRegistrarEncargado";
            btnRegistrarEncargado.Size = new Size(94, 29);
            btnRegistrarEncargado.TabIndex = 6;
            btnRegistrarEncargado.Text = "Registrar";
            btnRegistrarEncargado.UseVisualStyleBackColor = true;
            btnRegistrarEncargado.Click += btnRegistrarEncargado_Click;
            // 
            // cedulaEncargadoTxt
            // 
            cedulaEncargadoTxt.Location = new Point(335, 29);
            cedulaEncargadoTxt.Name = "cedulaEncargadoTxt";
            cedulaEncargadoTxt.Size = new Size(125, 27);
            cedulaEncargadoTxt.TabIndex = 7;
            // 
            // idEncargadoTxt
            // 
            idEncargadoTxt.Location = new Point(214, 64);
            idEncargadoTxt.Name = "idEncargadoTxt";
            idEncargadoTxt.Size = new Size(125, 27);
            idEncargadoTxt.TabIndex = 8;
            // 
            // nombreEncargadoTxt
            // 
            nombreEncargadoTxt.Location = new Point(253, 103);
            nombreEncargadoTxt.Name = "nombreEncargadoTxt";
            nombreEncargadoTxt.Size = new Size(125, 27);
            nombreEncargadoTxt.TabIndex = 9;
            // 
            // primerApellidoTxt
            // 
            primerApellidoTxt.Location = new Point(319, 146);
            primerApellidoTxt.Name = "primerApellidoTxt";
            primerApellidoTxt.Size = new Size(125, 27);
            primerApellidoTxt.TabIndex = 10;
            // 
            // segundoApellidoTxt
            // 
            segundoApellidoTxt.Location = new Point(330, 186);
            segundoApellidoTxt.Name = "segundoApellidoTxt";
            segundoApellidoTxt.Size = new Size(125, 27);
            segundoApellidoTxt.TabIndex = 11;
            // 
            // fechaNacimientoEncargado
            // 
            fechaNacimientoEncargado.Location = new Point(351, 235);
            fechaNacimientoEncargado.Name = "fechaNacimientoEncargado";
            fechaNacimientoEncargado.Size = new Size(250, 27);
            fechaNacimientoEncargado.TabIndex = 12;
            // 
            // registrarEncargadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaNacimientoEncargado);
            Controls.Add(segundoApellidoTxt);
            Controls.Add(primerApellidoTxt);
            Controls.Add(nombreEncargadoTxt);
            Controls.Add(idEncargadoTxt);
            Controls.Add(cedulaEncargadoTxt);
            Controls.Add(btnRegistrarEncargado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registrarEncargadoForm";
            Text = "registrarEncargadoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegistrarEncargado;
        private TextBox cedulaEncargadoTxt;
        private TextBox idEncargadoTxt;
        private TextBox nombreEncargadoTxt;
        private TextBox primerApellidoTxt;
        private TextBox segundoApellidoTxt;
        private DateTimePicker fechaNacimientoEncargado;
    }
}