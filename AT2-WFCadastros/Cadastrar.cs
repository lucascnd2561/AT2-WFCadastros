using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mtbCodigo.Text))
                Erro("Campo vazio");
            if (cbxCategoria.SelectedIndex == -1)
                Erro("Campo vazio");
            if (string.IsNullOrEmpty(txtNome.Text))
                Erro("Campo vazio");
            if (dtpDataCadastro.Value == DateTime.Today)
                Erro("Campo vazio");
            if (string.IsNullOrEmpty(rtbStatus.Text))
                Erro("Campo vazio");
            if (string.IsNullOrEmpty(txtDescricao.Text))
                Erro("Campo vazio");

        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Listagem form = new Listagem();
            form.ShowDialog();

            int codigo = Convert.ToInt32(mtbCodigo.Text); // ou gerar automaticamente
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            string status = rtbStatus.Text.Contains("[x]") ? "Ativo" : "Inativo";
            DateTime dataCadastro = dtpDataCadastro.Value;

            Categoria novaCategoria = new Categoria(codigo, nome, descricao, status, dataCadastro);

            // Aqui você pode adicionar a categoria a um banco de dados ou lista
            MessageBox.Show("Categoria cadastrada com sucesso!");

            // Limpar campos ou fechar o formulário
            this.Close();
        }
    }

}




    





