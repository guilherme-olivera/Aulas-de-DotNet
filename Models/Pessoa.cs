using System.Linq;
using System.Collections;
using System.Threading;

namespace CSharp.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;

        public string Nome
         {
            //get => _nome.ToUpper(); pode ser usado em casos simples
            get
            {
                //tratando o retorno e deixando com letras maiusculas
                return _nome.ToUpper();
            } 

            set{
                //valeu é o argumento  que está recendo o nome
                if (value == "")  //tratamento de erro
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                    //ocorreu uma excessao- apresenta a mensagem 
                }
                _nome = value;
            }
         }

        public string Sobrenome {get;set;}
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade  
        { 
            get => _idade;
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("A idade não pode se menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Sobrenome}, Idade: {Idade}");

        }
    }
}