namespace DesignPatterns2.Cap6
{
    public class MensagemAdm : IMensagem
    {
        public MensagemAdm(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o ADM " + Nome);
        }
    }
}
