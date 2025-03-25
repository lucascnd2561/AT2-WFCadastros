
namespace AT2_WFCadastros
{
    public enum EStatus
    {
        Ativo = 1,
        Inativo
    }
    public class Categoria
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public EStatus Status { get; set; }
        public DateTime DataCadastro { get; set; }


        public static List<Categoria>
            ListaCategorias = new List<Categoria>();

    }


 }