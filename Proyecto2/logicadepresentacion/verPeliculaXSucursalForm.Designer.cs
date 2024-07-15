namespace Servidor.logicadepresentacion
{
    partial class verPeliculaXSucursalForm
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
            dataGridViewPeliculaXSucursal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeliculaXSucursal).BeginInit();
            SuspendLayout();
            // 
            // mostrarBtn
            // 
            mostrarBtn.Location = new Point(496, 21);
            mostrarBtn.Name = "mostrarBtn";
            mostrarBtn.Size = new Size(94, 29);
            mostrarBtn.TabIndex = 0;
            mostrarBtn.Text = "Mostrar";
            mostrarBtn.UseVisualStyleBackColor = true;
            mostrarBtn.Click += mostrarBtn_Click;
            // 
            // dataGridViewPeliculaXSucursal
            // 
            dataGridViewPeliculaXSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeliculaXSucursal.Location = new Point(12, 67);
            dataGridViewPeliculaXSucursal.Name = "dataGridViewPeliculaXSucursal";
            dataGridViewPeliculaXSucursal.RowHeadersWidth = 51;
            dataGridViewPeliculaXSucursal.Size = new Size(1086, 458);
            dataGridViewPeliculaXSucursal.TabIndex = 1;
            dataGridViewPeliculaXSucursal.CellContentClick += dataGridViewPeliculaXSucursal_CellContentClick;
            // 
            // verPeliculaXSucursalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 534);
            Controls.Add(dataGridViewPeliculaXSucursal);
            Controls.Add(mostrarBtn);
            Name = "verPeliculaXSucursalForm";
            Text = "verPeliculaXSucursalForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeliculaXSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarBtn;
        private DataGridView dataGridViewPeliculaXSucursal;
    }
}