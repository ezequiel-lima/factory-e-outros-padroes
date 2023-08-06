using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Interpreter;
using System.Data;

/* Factory Method */
IDbConnection conexao = new ConnectionFactory().GetConnection();

IDbCommand comando = conexao.CreateCommand();
comando.CommandText = "select * from table";

/* Flyweight */

NotasMusicais notas = new NotasMusicais();

IList<INota> musica = new List<INota>()
{
    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("mi"),
    notas.Pega("fa"),
    notas.Pega("fa"),
    notas.Pega("fa"),
};

Piano piano = new Piano();
piano.Toca(musica);

/* Memento */
Historico historico = new Historico();

Contrato contrato = new Contrato(DateTime.Now, "Ezequiel", TipoContrato.Novo);
historico.Adiciona(contrato.SalvaEstado());

Console.WriteLine(contrato.Tipo);

contrato.Avanca();
historico.Adiciona(contrato.SalvaEstado());
Console.WriteLine(contrato.Tipo);

contrato.Avanca();
historico.Adiciona(contrato.SalvaEstado());
Console.WriteLine(contrato.Tipo);

Console.WriteLine(historico.Pega(1).Contrato.Tipo);

/* DSLs e o Interpreter */

IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
IExpressao soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());

/* Visitor */
ImpressoraVisitor impressora = new ImpressoraVisitor();
soma.Aceita(impressora);