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
            txtDescricao = new TextBox();
            lblStatus = new Label();
            dtpDataCadastro = new DateTimePicker();
            lblDatadeCadastro = new Label();
            btnSalvar = new Button();
            cbxCategoria = new ComboBox();
            lblCategoria = new Label();
            mtbCodigo = new MaskedTextBox();
            rtbStatus = new RichTextBox();
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
            lblNome.Location = new Point(49, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(49, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(279, 23);
            txtNome.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(49, 187);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(49, 205);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(279, 112);
            txtDescricao.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(186, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(201, 149);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(127, 23);
            dtpDataCadastro.TabIndex = 8;
            // 
            // lblDatadeCadastro
            // 
            lblDatadeCadastro.AutoSize = true;
            lblDatadeCadastro.Location = new Point(201, 122);
            lblDatadeCadastro.Name = "lblDatadeCadastro";
            lblDatadeCadastro.Size = new Size(97, 15);
            lblDatadeCadastro.TabIndex = 9;
            lblDatadeCadastro.Text = "Data de Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.Highlight;
            btnSalvar.ForeColor = Color.Red;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(228, 358);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 53);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Açougue", "", "HortiFruti", "", "Eletrônicos", "", "Limpeza", "", "Padaria", "", "Frios", "", "Laticínios", "", "Peixaria", "Bazar" });
            cbxCategoria.Location = new Point(49, 149);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(134, 23);
            cbxCategoria.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(49, 122);
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
            // rtbStatus
            // 
            rtbStatus.Location = new Point(186, 27);
            rtbStatus.Name = "rtbStatus";
            rtbStatus.Size = new Size(142, 37);
            rtbStatus.TabIndex = 14;
            rtbStatus.Text = "Ativo    [  ]\nInativo [  ]";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(rtbStatus);
            Controls.Add(mtbCodigo);
            Controls.Add(lblCategoria);
            Controls.Add(cbxCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(lblDatadeCadastro);
            Controls.Add(dtpDataCadastro);
            Controls.Add(lblStatus);
            Controls.Add(txtDescricao);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblStatus;
        private DateTimePicker dtpDataCadastro;
        private Label lblDatadeCadastro;
        private Button btnSalvar;
        private ComboBox cbxCategoria;
        private Label lblCategoria;
        private MaskedTextBox mtbCodigo;
        private RichTextBox rtbStatus;
    }
}
