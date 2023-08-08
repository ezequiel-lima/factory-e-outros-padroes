using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap8;
using System.Xml.Serialization;
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

/* Bridge */

IMensagem mensagem = new MensagemAdm("Vitor");
IEnviador enviador = new EnviaPorEmail();
mensagem.Enviador = enviador;

mensagem.Envia();

/* Command */

FilaDeTrabalho fila = new FilaDeTrabalho();
Pedido pedido1 = new Pedido("Mauricio", 250);
Pedido pedido2 = new Pedido("Gustavo", 136);

fila.Adiciona(new PagaPedido(pedido1));
fila.Adiciona(new PagaPedido(pedido2));

fila.Adiciona(new FinalizaPedido(pedido1));

fila.Processa();

/* Adapter */

Cliente cliente = new Cliente();

cliente.Nome = "Ezequiel";
cliente.Endereco = "Rua teste";
cliente.DataNascimento = DateTime.Now;

var xml = new GeradorXml().GeraXml(cliente);

Console.WriteLine(xml);

/* Facade Apenas Ilustrativo */

//string cpf = "1234";

////EmpresaFacade facade =  new EmpresaFacade();
//EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;

//Cliente cliente = facade.BuscaCliente(cpf);

//var fatura = facade.CriaFatura(cliente, 5000);
//facede.GeraCobranca(Tipo.Boleto, fatura);

//Cliente cliente = new ClienteDao().BuscarPorCPf(cpf);
//Fatura fatura = new Fatura(cliente, 5000);

//Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
//cobranca.Emite();

//ContatoCliente contato = new ContatoCliente(cliente, cobranca);
//contato.Dispara();