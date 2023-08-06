using DesignPatterns2.Cap5;
using DesignPatterns2.Visitor;

namespace DesignPatterns2.Cap4
{
    public class Soma : IExpressao
    {
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();

            return valorEsquerda + valorDireita;
        }
    }
}
