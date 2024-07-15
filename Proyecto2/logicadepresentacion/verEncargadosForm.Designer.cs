namespace Servidor.logicadepresentacion
{
    partial class verEncargadosForm
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
            dataGridViewEncargado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEncargado).BeginInit();
            SuspendLayout();
            // 
            // mostrarBtn
            // 
            mostrarBtn.Location = new Point(473, 50);
            mostrarBtn.Name = "mostrarBtn";
            mostrarBtn.Size = new Size(94, 29);
            mostrarBtn.TabIndex = 0;
            mostrarBtn.Text = "Mostrar";
            mostrarBtn.UseVisualStyleBackColor = true;
            mostrarBtn.Click += mostrarBtn_Click;
            // 
            // dataGridViewEncargado
            // 
            dataGridViewEncargado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEncargado.Location = new Point(10, 117);
            dataGridViewEncargado.Name = "dataGridViewEncargado";
            dataGridViewEncargado.RowHeadersWidth = 51;
            dataGridViewEncargado.Size = new Size(1069, 394);
            dataGridViewEncargado.TabIndex = 1;
            dataGridViewEncargado.CellContentClick += dataGridViewEncargado_CellContentClick;
            // 
            // verEncargadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 523);
            Controls.Add(dataGridViewEncargado);
            Controls.Add(mostrarBtn);
            Name = "verEncargadosForm";
            Text = "verEncargadosForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEncargado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarBtn;
        private DataGridView dataGridViewEncargado;
    }
}