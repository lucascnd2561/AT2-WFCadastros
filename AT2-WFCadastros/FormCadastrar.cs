using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }
   

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(mtbCodigo.Text))
            {
                Erro("O preenchimento do Código é Obrigatório!");
                return true;
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("O preenchimento do Nome da Categoria é Obrigatório!");
                return true;
            }
            else if (string.IsNullOrEmpty(rtbDescricao.Text))
            {
                Erro("O preenchimento da Descrição da Categoria é Obrigatória!");
                return true;
            }
            else if (rdbAtivo.Checked == false && rdbInativo.Checked == false)
            {
                Erro("Deve-se selecionar um status para a Categoria!");
                return true;
            }

            return false;
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (this.CamposNaoPreenchidos() == false)
            {
                Categoria cat = new Categoria();
                cat.Codigo = int.Parse(mtbCodigo.Text);
                cat.Nome = txtNome.Text;
                cat.Descricao = rtbDescricao.Text;

                if (rdbAtivo.Checked == true)
                    cat.Status = EStatus.Ativo;
                else
                    cat.Status = EStatus.Inativo;

                cat.DataCadastro = DateTime.Now;

                Categoria.ListaCategorias.Add(cat);

                Sucesso("Cadastro Efetuado com Sucesso");

                LimparCampos();

            }

        }

        private void LimparCampos()
        {
            int quantidadeLista = Categoria.ListaCategorias.Count;
            int codigoGerado = quantidadeLista + 1;
            mtbCodigo.Text = codigoGerado.ToString("D4");
            txtNome.Clear();
            rtbDescricao.Clear();
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            int quantidadeLista = Categoria.ListaCategorias.Count;
            int codigoGerado = quantidadeLista + 1;
            mtbCodigo.Text = codigoGerado.ToString("D4");
        }
    }
}









