namespace Aula31_Sprint4_WhatsAppConsole
{
    public class Contato 
    {
        //Prop - PascalCase
        //Atributo - CamelCase
        public string Nome { get; set; }
        public string Telefone { get; set; }
        
        public Contato(string _nome, string _telefone){
            this.Nome = _nome;
            this.Telefone = _telefone;
        }

        
    }
}