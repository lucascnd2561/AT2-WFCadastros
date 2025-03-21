
namespace AT2_WFCadastros
{
    internal class Categoria
    {
        private int codigo;
        private string nome;
        private string descricao;
        private string status;
        private DateTime dataCadastro;

        public Categoria(int codigo, string nome, string descricao, string status, DateTime dataCadastro)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.descricao = descricao;
            this.status = status;
            this.dataCadastro = dataCadastro;
        }
    }
}