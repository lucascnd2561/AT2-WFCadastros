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

        }
       
    }

}




    





