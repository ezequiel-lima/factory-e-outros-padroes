namespace DesignPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        public Numero(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public int Avalia()
        {
            return Number;
        }
    }
}
