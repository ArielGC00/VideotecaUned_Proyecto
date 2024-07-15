namespace Cliente
{
    partial class ConectarForm
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
            crearClientesBtn = new Button();
            SuspendLayout();
            // 
            // crearClientesBtn
            // 
            crearClientesBtn.Location = new Point(282, 135);
            crearClientesBtn.Name = "crearClientesBtn";
            crearClientesBtn.Size = new Size(186, 29);
            crearClientesBtn.TabIndex = 0;
            crearClientesBtn.Text = "Crear Cliente";
            crearClientesBtn.UseVisualStyleBackColor = true;
            crearClientesBtn.Click += crearClientesBtn_Click;
            // 
            // ConectarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crearClientesBtn);
            Name = "ConectarForm";
            Text = "ConectarForm";
            ResumeLayout(false);
        }

        #endregion

        private Button crearClientesBtn;
    }
}