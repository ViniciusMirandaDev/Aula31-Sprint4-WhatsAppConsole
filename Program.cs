using System;
using System.Collections.Generic;

namespace Aula31_Sprint4_WhatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato c1 = new Contato("Amanda", "1142323253");
            Agenda contact = new Agenda();
            Mensagem m1 = new Mensagem();
        

            contact.Cadastrar(c1);
            contact.Excluir("Amanda");
            
            List<Contato> lista = lista = contact.Listar();

            foreach( Contato item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"R$ {item.Nome} - {item.Telefone}");
                Console.ResetColor();
            }

            System.Console.WriteLine();

            m1.Destinatario=;

            

        }
    }
}
