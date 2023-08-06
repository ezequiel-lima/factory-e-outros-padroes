﻿using DesignPatterns2.Cap4;
using DesignPatterns2.Visitor;

namespace DesignPatterns2.Cap5
{
    public class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write(" + ");
            soma.Esquerda.Aceita(this);

            Console.Write(""); 
            soma.Direita.Aceita(this);

            Console.Write(")");      
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write(" - ");
            subtracao.Esquerda.Aceita(this);

            Console.Write(" ");
            subtracao.Direita.Aceita(this);


            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Number);
        }
    }
}
