namespace DesignPatterns2.Cap6
{
    public class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por Sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
