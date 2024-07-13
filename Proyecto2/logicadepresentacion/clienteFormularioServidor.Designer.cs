namespace Servidor.logicadepresentacion
{
    partial class clienteFormularioServidor
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
            activoClienteComboBox = new ComboBox();
            label6 = new Label();
            nombreClienteTxt = new TextBox();
            primerApellidoTxt = new TextBox();
            segundoApellidoTxt = new TextBox();
            fechaNacimientoSelect = new DateTimePicker();
            registrarClienteBtn = new Button();
            label7 = new Label();
            label8 = new Label();
            iDClienteTxt = new TextBox();
            cedulaClienteTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 98);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre del cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 138);
            label2.Name = "label2";
            label2.Size = new Size(253, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el primer apellido del cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 185);
            label3.Name = "label3";
            label3.Size = new Size(266, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el segundo apellido del cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 225);
            label4.Name = "label4";
            label4.Size = new Size(285, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingrese la fecha de nacimiento del cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 208);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // activoClienteComboBox
            // 
            activoClienteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activoClienteComboBox.FormattingEnabled = true;
            activoClienteComboBox.Items.AddRange(new object[] { "Si", "No" });
            activoClienteComboBox.Location = new Point(321, 260);
            activoClienteComboBox.Name = "activoClienteComboBox";
            activoClienteComboBox.Size = new Size(151, 28);
            activoClienteComboBox.TabIndex = 5;
            activoClienteComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 260);
            label6.Name = "label6";
            label6.Size = new Size(210, 20);
            label6.TabIndex = 6;
            label6.Text = "Ingrese si el cliente está activo";
            label6.Click += label6_Click;
            // 
            // nombreClienteTxt
            // 
            nombreClienteTxt.Location = new Point(237, 98);
            nombreClienteTxt.Name = "nombreClienteTxt";
            nombreClienteTxt.Size = new Size(235, 27);
            nombreClienteTxt.TabIndex = 7;
            nombreClienteTxt.TextChanged += nombreClienteTxt_TextChanged;
            // 
            // primerApellidoTxt
            // 
            primerApellidoTxt.Location = new Point(276, 135);
            primerApellidoTxt.Name = "primerApellidoTxt";
            primerApellidoTxt.Size = new Size(187, 27);
            primerApellidoTxt.TabIndex = 8;
            primerApellidoTxt.TextChanged += primerApellidoTxt_TextChanged;
            // 
            // segundoApellidoTxt
            // 
            segundoApellidoTxt.Location = new Point(289, 178);
            segundoApellidoTxt.Name = "segundoApellidoTxt";
            segundoApellidoTxt.Size = new Size(174, 27);
            segundoApellidoTxt.TabIndex = 9;
            segundoApellidoTxt.TextChanged += segundoApellidoTxt_TextChanged;
            // 
            // fechaNacimientoSelect
            // 
            fechaNacimientoSelect.Location = new Point(319, 220);
            fechaNacimientoSelect.Name = "fechaNacimientoSelect";
            fechaNacimientoSelect.Size = new Size(292, 27);
            fechaNacimientoSelect.TabIndex = 10;
            fechaNacimientoSelect.ValueChanged += fechaNacimientoSelect_ValueChanged;
            // 
            // registrarClienteBtn
            // 
            registrarClienteBtn.Location = new Point(17, 319);
            registrarClienteBtn.Name = "registrarClienteBtn";
            registrarClienteBtn.Size = new Size(94, 29);
            registrarClienteBtn.TabIndex = 11;
            registrarClienteBtn.Text = "Registrar";
            registrarClienteBtn.UseVisualStyleBackColor = true;
            registrarClienteBtn.Click += registrarClienteBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 68);
            label7.Name = "label7";
            label7.Size = new Size(194, 20);
            label7.TabIndex = 12;
            label7.Text = "Ingrese la cedula del cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 40);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 13;
            label8.Text = "Ingrese el ID del cliente";
            // 
            // iDClienteTxt
            // 
            iDClienteTxt.Location = new Point(241, 35);
            iDClienteTxt.Name = "iDClienteTxt";
            iDClienteTxt.Size = new Size(203, 27);
            iDClienteTxt.TabIndex = 14;
            iDClienteTxt.TextChanged += iDClienteTxt_TextChanged;
            // 
            // cedulaClienteTxt
            // 
            cedulaClienteTxt.Location = new Point(244, 70);
            cedulaClienteTxt.Name = "cedulaClienteTxt";
            cedulaClienteTxt.Size = new Size(200, 27);
            cedulaClienteTxt.TabIndex = 15;
            cedulaClienteTxt.TextChanged += cedulaClienteTxt_TextChanged;
            // 
            // clienteFormularioServidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cedulaClienteTxt);
            Controls.Add(iDClienteTxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(registrarClienteBtn);
            Controls.Add(fechaNacimientoSelect);
            Controls.Add(segundoApellidoTxt);
            Controls.Add(primerApellidoTxt);
            Controls.Add(nombreClienteTxt);
            Controls.Add(label6);
            Controls.Add(activoClienteComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "clienteFormularioServidor";
            Text = "clienteFormularioServidor";
            Load += clienteFormularioServidor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox activoClienteComboBox;
        private Label label6;
        private TextBox nombreClienteTxt;
        private TextBox primerApellidoTxt;
        private TextBox segundoApellidoTxt;
        private DateTimePicker fechaNacimientoSelect;
        private Button registrarClienteBtn;
        private Label label7;
        private Label label8;
        private TextBox iDClienteTxt;
        private TextBox cedulaClienteTxt;
    }
}