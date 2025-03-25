namespace AT2_WFCadastros
{
    partial class Cadastrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            lblCodigo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblDescricao = new Label();
            btnSalvar = new Button();
            cbxCategoria = new ComboBox();
            lblCategoria = new Label();
            mtbCodigo = new MaskedTextBox();
            gbxStatus = new GroupBox();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            rtbDescricao = new RichTextBox();
            gbxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(49, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(49, 79);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(49, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(265, 23);
            txtNome.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(49, 188);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.Highlight;
            btnSalvar.ForeColor = Color.Red;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(214, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 53);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
           
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Açougue", "", "HortiFruti", "", "Eletrônicos", "", "Limpeza", "", "Padaria", "", "Frios", "", "Laticínios", "", "Peixaria", "Bazar" });
            cbxCategoria.Location = new Point(49, 153);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(134, 23);
            cbxCategoria.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(49, 135);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoria";
            // 
            // mtbCodigo
            // 
            mtbCodigo.Location = new Point(49, 27);
            mtbCodigo.Mask = "0000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(100, 23);
            mtbCodigo.TabIndex = 13;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Location = new Point(173, 27);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(141, 67);
            gbxStatus.TabIndex = 14;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(14, 20);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(14, 42);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(49, 206);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(265, 96);
            rtbDescricao.TabIndex = 15;
            rtbDescricao.Text = "";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 400);
            Controls.Add(rtbDescricao);
            Controls.Add(gbxStatus);
            Controls.Add(mtbCodigo);
            Controls.Add(lblCategoria);
            Controls.Add(cbxCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            Load += Cadastrar_Load;
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private Button btnSalvar;
        private ComboBox cbxCategoria;
        private Label lblCategoria;
        private MaskedTextBox mtbCodigo;
        private GroupBox gbxStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private RichTextBox rtbDescricao;
    }
}
