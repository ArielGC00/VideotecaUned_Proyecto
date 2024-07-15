namespace Cliente
{
    partial class PrestamoForm
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
            enviarSolicitudBtn = new Button();
            clienteInfoLabel = new Label();
            solicitudTxt = new TextBox();
            SuspendLayout();
            // 
            // enviarSolicitudBtn
            // 
            enviarSolicitudBtn.Location = new Point(28, 366);
            enviarSolicitudBtn.Name = "enviarSolicitudBtn";
            enviarSolicitudBtn.Size = new Size(94, 29);
            enviarSolicitudBtn.TabIndex = 0;
            enviarSolicitudBtn.Text = "Solicitar";
            enviarSolicitudBtn.UseVisualStyleBackColor = true;
            enviarSolicitudBtn.Click += enviarSolicitudBtn_Click;
            // 
            // clienteInfoLabel
            // 
            clienteInfoLabel.AutoSize = true;
            clienteInfoLabel.Location = new Point(24, 19);
            clienteInfoLabel.Name = "clienteInfoLabel";
            clienteInfoLabel.Size = new Size(0, 20);
            clienteInfoLabel.TabIndex = 1;
            // 
            // solicitudTxt
            // 
            solicitudTxt.Location = new Point(27, 84);
            solicitudTxt.Name = "solicitudTxt";
            solicitudTxt.Size = new Size(125, 27);
            solicitudTxt.TabIndex = 2;
            // 
            // PrestamoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(solicitudTxt);
            Controls.Add(clienteInfoLabel);
            Controls.Add(enviarSolicitudBtn);
            Name = "PrestamoForm";
            Text = "PrestamoForm";
            Load += PrestamoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enviarSolicitudBtn;
        private Label clienteInfoLabel;
        private TextBox solicitudTxt;
    }
}