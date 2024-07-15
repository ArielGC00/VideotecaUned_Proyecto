namespace Servidor.logicadepresentacion
{
    partial class verSucursalForm
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
            dataGridViewSucursal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSucursal).BeginInit();
            SuspendLayout();
            // 
            // mostrarBtn
            // 
            mostrarBtn.Location = new Point(494, 40);
            mostrarBtn.Name = "mostrarBtn";
            mostrarBtn.Size = new Size(94, 29);
            mostrarBtn.TabIndex = 0;
            mostrarBtn.Text = "Mostrar";
            mostrarBtn.UseVisualStyleBackColor = true;
            mostrarBtn.Click += mostrarBtn_Click;
            // 
            // dataGridViewSucursal
            // 
            dataGridViewSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSucursal.Location = new Point(17, 113);
            dataGridViewSucursal.Name = "dataGridViewSucursal";
            dataGridViewSucursal.RowHeadersWidth = 51;
            dataGridViewSucursal.Size = new Size(1070, 406);
            dataGridViewSucursal.TabIndex = 1;
            dataGridViewSucursal.CellContentClick += dataGridViewSucursal_CellContentClick;
            // 
            // verSucursalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 531);
            Controls.Add(dataGridViewSucursal);
            Controls.Add(mostrarBtn);
            Name = "verSucursalForm";
            Text = "verSucursalForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarBtn;
        private DataGridView dataGridViewSucursal;
    }
}