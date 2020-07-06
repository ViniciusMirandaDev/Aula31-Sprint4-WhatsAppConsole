using System.Collections.Generic;
using System.IO;

namespace Aula31_Sprint4_WhatsAppConsole
{
    public class Mensagem
    {
        public string Texto { get; set; }
        public Contato Destinatario { get; set; }

        public string Enviar(){
            
            return ($"Para: {Destinatario.Nome} \nMensagem:{Texto}");
        }
    }
}