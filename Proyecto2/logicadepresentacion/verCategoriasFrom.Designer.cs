namespace Servidor.logicadepresentacion
{
    partial class verCategoriasFrom
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
            dataGridViewCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).BeginInit();
            SuspendLayout();
            // 
            // mostrarBtn
            // 
            mostrarBtn.Location = new Point(433, 42);
            mostrarBtn.Name = "mostrarBtn";
            mostrarBtn.Size = new Size(94, 29);
            mostrarBtn.TabIndex = 0;
            mostrarBtn.Text = "Mostrar";
            mostrarBtn.UseVisualStyleBackColor = true;
            mostrarBtn.Click += mostrarBtn_Click;
            // 
            // dataGridViewCategoria
            // 
            dataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoria.Location = new Point(21, 89);
            dataGridViewCategoria.Name = "dataGridViewCategoria";
            dataGridViewCategoria.RowHeadersWidth = 51;
            dataGridViewCategoria.Size = new Size(965, 387);
            dataGridViewCategoria.TabIndex = 1;
            dataGridViewCategoria.CellContentClick += dataGridViewCategoria_CellContentClick;
            // 
            // verCategoriasFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 525);
            Controls.Add(dataGridViewCategoria);
            Controls.Add(mostrarBtn);
            Name = "verCategoriasFrom";
            Text = "verCategoriasFrom";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarBtn;
        private DataGridView dataGridViewCategoria;
    }
}