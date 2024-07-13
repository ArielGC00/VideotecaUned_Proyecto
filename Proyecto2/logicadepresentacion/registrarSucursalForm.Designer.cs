namespace Servidor.logicadepresentacion
{
    partial class registrarSucursalForm
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
            idSucursalTxt = new TextBox();
            nombreSucursalTxt = new TextBox();
            direccionSucursalTxt = new TextBox();
            telefonoSucursalTxt = new TextBox();
            activoSucursalComboBox = new ComboBox();
            encargadoSucursalComboBox = new ComboBox();
            registrarSucursalBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ID de la sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 73);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el nombre de la sucursal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 119);
            label3.Name = "label3";
            label3.Size = new Size(264, 20);
            label3.TabIndex = 2;
            label3.Text = "Seleccione el encargado de la sucursal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 170);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingrese la direccion de la sucursal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 217);
            label5.Name = "label5";
            label5.Size = new Size(226, 20);
            label5.TabIndex = 4;
            label5.Text = "Ingrese el telefono de la sucursal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 251);
            label6.Name = "label6";
            label6.Size = new Size(240, 20);
            label6.TabIndex = 5;
            label6.Text = "Seleccione si la sucursal está activa";
            // 
            // idSucursalTxt
            // 
            idSucursalTxt.Location = new Point(236, 34);
            idSucursalTxt.Name = "idSucursalTxt";
            idSucursalTxt.Size = new Size(125, 27);
            idSucursalTxt.TabIndex = 6;
            // 
            // nombreSucursalTxt
            // 
            nombreSucursalTxt.Location = new Point(258, 73);
            nombreSucursalTxt.Name = "nombreSucursalTxt";
            nombreSucursalTxt.Size = new Size(125, 27);
            nombreSucursalTxt.TabIndex = 7;
            // 
            // direccionSucursalTxt
            // 
            direccionSucursalTxt.Location = new Point(281, 167);
            direccionSucursalTxt.Name = "direccionSucursalTxt";
            direccionSucursalTxt.Size = new Size(125, 27);
            direccionSucursalTxt.TabIndex = 8;
            // 
            // telefonoSucursalTxt
            // 
            telefonoSucursalTxt.Location = new Point(274, 221);
            telefonoSucursalTxt.Name = "telefonoSucursalTxt";
            telefonoSucursalTxt.Size = new Size(125, 27);
            telefonoSucursalTxt.TabIndex = 9;
            // 
            // activoSucursalComboBox
            // 
            activoSucursalComboBox.FormattingEnabled = true;
            activoSucursalComboBox.Items.AddRange(new object[] { "Si", "No" });
            activoSucursalComboBox.Location = new Point(281, 263);
            activoSucursalComboBox.Name = "activoSucursalComboBox";
            activoSucursalComboBox.Size = new Size(151, 28);
            activoSucursalComboBox.TabIndex = 10;
            // 
            // encargadoSucursalComboBox
            // 
            encargadoSucursalComboBox.FormattingEnabled = true;
            encargadoSucursalComboBox.Location = new Point(321, 128);
            encargadoSucursalComboBox.Name = "encargadoSucursalComboBox";
            encargadoSucursalComboBox.Size = new Size(164, 28);
            encargadoSucursalComboBox.TabIndex = 11;
            // 
            // registrarSucursalBtn
            // 
            registrarSucursalBtn.Location = new Point(40, 322);
            registrarSucursalBtn.Name = "registrarSucursalBtn";
            registrarSucursalBtn.Size = new Size(94, 29);
            registrarSucursalBtn.TabIndex = 12;
            registrarSucursalBtn.Text = "Registrar";
            registrarSucursalBtn.UseVisualStyleBackColor = true;
            registrarSucursalBtn.Click += registrarSucursalBtn_Click;
            // 
            // registrarSucursalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registrarSucursalBtn);
            Controls.Add(encargadoSucursalComboBox);
            Controls.Add(activoSucursalComboBox);
            Controls.Add(telefonoSucursalTxt);
            Controls.Add(direccionSucursalTxt);
            Controls.Add(nombreSucursalTxt);
            Controls.Add(idSucursalTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registrarSucursalForm";
            Text = "registrarSucursalForm";
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
        private TextBox idSucursalTxt;
        private TextBox nombreSucursalTxt;
        private TextBox direccionSucursalTxt;
        private TextBox telefonoSucursalTxt;
        private ComboBox activoSucursalComboBox;
        private ComboBox encargadoSucursalComboBox;
        private Button registrarSucursalBtn;
    }
}