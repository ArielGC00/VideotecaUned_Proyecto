namespace Servidor.logicadepresentacion
{
    partial class verPeliculasForm
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
            dataGridViewPelicula = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPelicula).BeginInit();
            SuspendLayout();
            // 
            // mostrarBtn
            // 
            mostrarBtn.Location = new Point(508, 44);
            mostrarBtn.Name = "mostrarBtn";
            mostrarBtn.Size = new Size(94, 29);
            mostrarBtn.TabIndex = 0;
            mostrarBtn.Text = "Mostrar";
            mostrarBtn.UseVisualStyleBackColor = true;
            mostrarBtn.Click += mostrarBtn_Click;
            // 
            // dataGridViewPelicula
            // 
            dataGridViewPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPelicula.Location = new Point(12, 110);
            dataGridViewPelicula.Name = "dataGridViewPelicula";
            dataGridViewPelicula.RowHeadersWidth = 51;
            dataGridViewPelicula.Size = new Size(1077, 383);
            dataGridViewPelicula.TabIndex = 1;
            dataGridViewPelicula.CellContentClick += dataGridViewPelicula_CellContentClick;
            // 
            // verPeliculasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 526);
            Controls.Add(dataGridViewPelicula);
            Controls.Add(mostrarBtn);
            Name = "verPeliculasForm";
            Text = "verPeliculasForm";
            Load += verPeliculasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPelicula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarBtn;
        private DataGridView dataGridViewPelicula;
    }
}