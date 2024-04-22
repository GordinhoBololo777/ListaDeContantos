using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContantos
{
    internal class Class1
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        //propriedades (get e set)
        // é um controle de acesso ás variáveis. */
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;

            }
            set
            {
                sobrenome = value;
            }
        }
        public string Tlefone
        {
            get
            {
                return telefone;

            }
            // set = escrita
            set
            {
                if (value.Lenght == 11)
                {
                    telefone = value;
                }
                else
                {

                    //País-Cidade-Telefone, ex: +55-11-97878-8787
                    telefone = "00-00000-0000"
                }
            }

             // O método que tem o mesmo nome de classe
             // e não retorna nada, é chamado CONSTRUTOR
             // DA CLASSE.
            public Contato()
        {
            Nome = "José";
            Sobrenome = "Da Silva";
            telefone = "11-99999-9999";
        }


        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        // Sobscreve o método ToSting()
        // "polimorfismo".
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0, 2)
                Telefone.Substring(0, 2),
                Telefone.Substring(2, 5),
                Telefone.Substring(8, 4);
            return saida;
        }
    }


}
