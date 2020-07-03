using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31_Sprint4_WhatsAppConsole
{
    public class Agenda : IAgenda
    {
       
        private const string PATH ="Database/contato.csv";

         public Agenda()
        {

            //Verifica a existência do CSV caso não exista ele cria
            if(!File.Exists(PATH))
            {

                Directory.CreateDirectory("Database");
                File.Create(PATH).Close();
            }
        }

       /// <summary>
       /// Cadastra um novo contato
       /// </summary>
       /// <param name="_contato">Objeto _contato</param>
        public void Cadastrar(Contato _contato)
        {

            //Cadastra uma linha nova no nosso csv
            var linha = new string[] { PrepararLinhaCSV(_contato) };
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Exclui o contato
        /// </summary>
        /// <param name="Contato">Objeto Contato</param>
        public void Excluir(string Contato)
        {

            //Cria-se uma lista que servirá como backup
            List<string> linhas = new  List<string>();

            //Refatoração Aplicada
            LerCSV(linhas);

            //Removemos as linhas que tiverem o termo
            linhas.RemoveAll(l => l.Contains(Contato));

            //Refatoração Aplicada
            ReescreverCSV(linhas);
        }

        public List<Contato> Listar()
        {
            //Lista que servirá como retorno
            List<Contato> contatos = new List<Contato>();
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas)
            {

                //Separamos os dados de cada linha com o split
                string[] dado = linha.Split(";");
                
                //Criam-se instâncias de produtos para serem colocados na lista
                Contato c = new Contato();
                c.Nome = (Separar(dado [0]));
                c.Telefone = (Separar(dado[1]));
                
                //Adicionamos o Contato para a lista
                contatos.Add(c);
            }

            //Usa-se o OrderBy para mandar o Nome em ordem para a lista criada
            contatos = contatos.OrderBy(x => x.Nome).ToList();
            return contatos;
        }

        private void ReescreverCSV(List<string> lines){
            
            //Reescreve-se o CSV do zero
            using(StreamWriter output = new StreamWriter(PATH)){

                //Cria-se o ln aqui
                foreach(string ln in lines){

                    output.Write(ln + "\n");
                }
            }
        }

        private void LerCSV(List<string> lines){

            using(StreamReader arquivo = new StreamReader(PATH)){

                //StreamReader vai ler o nosso CSV
                //Using serve para não sobrecarregar o sistema, ele abre e fehca o arquivo
                string line;
                while((line = arquivo.ReadLine()) !=null){
                    
                    lines.Add(line);
                } 
            }
        }
        
        private string Separar(string _coluna){

            //Separa as colunas para obter os valores necesários
            return _coluna.Split("=")[1];
        }
        private string PrepararLinhaCSV(Contato c){

            //Prepara as linhas do csv para que elas fiquem do jeito desejado
             return $"nome={c.Nome};telefone={c.Telefone}";
        }

    }
}