﻿//using DesignPatterns2.Cap3;
//using DesignPatterns2.Cap8;

//namespace DesignPatterns2.Cap9
//{
//    public class EmpresaFacade
//    {
//        public Cliente BuscaCliente(string cpf)
//        {
//            return new ClienteDao().BuscaPorCpf(cpf);
//        }

//        public Fatura CriaFatura(Cliente cliente, double valor)
//        {
//            return new Fatura(cliente, valor);
//        }

//        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
//        {
//            Cobranca cobranca = new Cobranca(tipo, fatura);
//            cobranca.Emite();
//        }

//        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
//        {
//            CantatoCliente contato = new ContatoCliente(cliente, cobranca);
//            contato.Dispara();
//            return contato;
//        }
//    }
//}
