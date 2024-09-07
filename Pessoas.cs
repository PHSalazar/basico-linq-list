using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_com_DotNET
{
    internal class Pessoas
    {
        public Pessoas(string nome, int idade, char sexo) {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public string Nome { get; set; }
        public int Idade {  get; set; }
        public char Sexo { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Idade: {Idade} | Sexo: {Sexo}";
        }
    }
}
