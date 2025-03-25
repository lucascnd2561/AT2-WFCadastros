namespace AT2_WFCadastros
{
    partial class FormListar
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
            dgvListarCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListarCategoria).BeginInit();
            SuspendLayout();
            // 
            // dgvListarCategoria
            // 
            dgvListarCategoria.BorderStyle = BorderStyle.Fixed3D;
            dgvListarCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarCategoria.Dock = DockStyle.Fill;
            dgvListarCategoria.Location = new Point(0, 0);
            dgvListarCategoria.Name = "dgvListarCategoria";
            dgvListarCategoria.Size = new Size(800, 450);
            dgvListarCategoria.TabIndex = 0;
            dgvListarCategoria.CellContentClick += dgvListagem_CellContentClick;
            // 
            // FormListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListarCategoria);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem";
            ((System.ComponentModel.ISupportInitialize)dgvListarCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListarCategoria;
    }
}