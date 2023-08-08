namespace DesignPatterns2.Cap7
{
    public class FinalizaPedido : ICommand
    {
        public Pedido Pedido { get; set; }

        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente " + Pedido.Cliente);
            Pedido.Finaliza();
        }
    }
}
