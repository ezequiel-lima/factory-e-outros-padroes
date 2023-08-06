using DesignPatterns2.Cap5;
using DesignPatterns2.Visitor;

namespace DesignPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        public Numero(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return Number;
        }
    }
}
