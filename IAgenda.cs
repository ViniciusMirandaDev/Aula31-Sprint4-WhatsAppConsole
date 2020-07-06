using System.Collections.Generic;

namespace Aula31_Sprint4_WhatsAppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato cont);

         void Excluir(Contato cont);
         
         List<Contato> Listar();

    }
}