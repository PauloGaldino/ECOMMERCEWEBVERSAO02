namespace ECOMMERCE.APPLICATION.CORE.Entities.Bebida
{
    public class Bebida
    {
        public int BebidaId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get; set; }
        public decimal Preco { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool BebidaPreferida { get; set; }
        public bool Estoque { get; set; }
        public int CategoriaId { get; set; }
        public  Categoria Categoria { get; set; }
    }
}
