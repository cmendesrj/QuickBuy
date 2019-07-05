namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public static bool Any { get; internal set; }
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
