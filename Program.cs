using System;
using System.Collections.Generic;

namespace Aula31_Sprint4_WhatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Agenda agenda = new Agenda();
            Contato c1 = new Contato("Paulo  ", "(11) 999999-99999");
            Contato c2 = new Contato("Jonas  ", "(11) 999999-99999");
            Contato c3 = new Contato("Gabriel", "(11) 999999-99999");

            agenda.Cadastrar(c1);
            agenda.Cadastrar(c2);
            agenda.Cadastrar(c3);

            agenda.Excluir(c1);

            foreach(Contato c in agenda.Listar())
            {
                Console.WriteLine($"Nome: {c.Nome} - Tel: {c.Telefone}");
            }
            Mensagem msg = new Mensagem();
            msg.Destinatario = c3;
            msg.Texto  = "Olá " + msg.Destinatario.Nome + "!";
            System.Console.WriteLine( msg.Enviar());



        }
    }
}
