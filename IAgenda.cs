using System.Collections.Generic;

namespace Aula31_Sprint4_WhatsAppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato _contato);

         void Excluir(string Contato);
         
         List<Contato> Listar();

    }
}