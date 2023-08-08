namespace DesignPatterns2.Cap7
{
    public class PagaPedido : ICommand
    {
        public Pedido Pedido { get; set; }

        public PagaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do cliente " + Pedido.Cliente);
            Pedido.Paga();
        }
    }
}
