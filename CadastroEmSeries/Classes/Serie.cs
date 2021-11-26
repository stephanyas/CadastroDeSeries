using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEmSeries
{
    public class Serie : EntidadeBase // : indica que é uma herança
    {
        //Atributos
        public Genero Genero { get; set; } //Enum
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        private bool Excluido { get; set; }

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id; //esta recebendo da classe entidade base
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo() //metodo de encapsulamento
        {
            return this.Titulo;
        }

        public int retornaId() //metodo de encapsulamento
        {
            return this.id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }
    }
}
