namespace Cliente
{
    partial class ClienteForm
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
            conectarBtn = new Button();
            label1 = new Label();
            cedulaClienteTxt = new TextBox();
            SuspendLayout();
            // 
            // conectarBtn
            // 
            conectarBtn.Location = new Point(26, 308);
            conectarBtn.Name = "conectarBtn";
            conectarBtn.Size = new Size(190, 44);
            conectarBtn.TabIndex = 0;
            conectarBtn.Text = "Conectar con el servidor";
            conectarBtn.UseVisualStyleBackColor = true;
            conectarBtn.Click += conectarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su número de cédula";
            // 
            // cedulaClienteTxt
            // 
            cedulaClienteTxt.Location = new Point(239, 73);
            cedulaClienteTxt.Name = "cedulaClienteTxt";
            cedulaClienteTxt.Size = new Size(221, 27);
            cedulaClienteTxt.TabIndex = 2;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cedulaClienteTxt);
            Controls.Add(label1);
            Controls.Add(conectarBtn);
            Name = "ClienteForm";
            Text = "ClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button conectarBtn;
        private Label label1;
        private TextBox cedulaClienteTxt;
    }
}