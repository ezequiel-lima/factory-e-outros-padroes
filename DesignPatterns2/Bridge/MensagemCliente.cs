namespace DesignPatterns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o cliente " + Nome);
        }
    }
}
