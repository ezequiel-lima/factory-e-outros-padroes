using DesignPatterns2.Cap5;
using DesignPatterns2.Visitor;

namespace DesignPatterns2.Cap4
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
