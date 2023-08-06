using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Visitor;

namespace DesignPatterns2.Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        public RaizQuadrada(IExpressao numero)
        {
            Numero = numero;
        }

        public IExpressao Numero { get; private set; }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int valor = Numero.Avalia();
            int resultado = (int)Math.Sqrt(valor);
            return resultado;
        }
    }
}
