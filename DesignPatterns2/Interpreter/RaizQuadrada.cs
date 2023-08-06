using DesignPatterns2.Cap4;

namespace DesignPatterns2.Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        public RaizQuadrada(IExpressao numero)
        {
            Numero = numero;
        }

        public IExpressao Numero { get; private set; }

        public int Avalia()
        {
            int valor = Numero.Avalia();
            int resultado = (int)Math.Sqrt(valor);
            return resultado;
        }
    }
}
