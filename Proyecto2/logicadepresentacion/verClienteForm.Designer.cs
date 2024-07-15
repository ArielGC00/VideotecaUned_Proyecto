namespace Servidor.logicadepresentacion
{
    partial class verClienteForm
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
            mostrarBtn = new Button();
            dataGridViewCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            SuspendLayout();
            // 
            // mostrarBtn
            // 
            mostrarBtn.Location = new Point(481, 45);
            mostrarBtn.Name = "mostrarBtn";
            mostrarBtn.Size = new Size(94, 29);
            mostrarBtn.TabIndex = 0;
            mostrarBtn.Text = "Mostrar";
            mostrarBtn.UseVisualStyleBackColor = true;
            mostrarBtn.Click += mostrarBtn_Click;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(12, 109);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(1061, 401);
            dataGridViewCliente.TabIndex = 1;
            dataGridViewCliente.CellContentClick += dataGridViewCliente_CellContentClick;
            // 
            // verClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 522);
            Controls.Add(dataGridViewCliente);
            Controls.Add(mostrarBtn);
            Name = "verClienteForm";
            Text = "verClienteForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarBtn;
        private DataGridView dataGridViewCliente;
    }
}