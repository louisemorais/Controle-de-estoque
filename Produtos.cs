using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_estoque
{
    class Produtos
    {
        public string nome { get;}
        public int quantidade { get; set; }
        public double preco { get; set; }
        public Enum tipo { get; }
        public Produtos(string nome, int quantidade, double preco, Enum tipo)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
            this.tipo = tipo;
        }
        public enum TipoProduto
        {
            INDEFINIDO,
            LIMPEZA,
            ELETRONICA,
            ALIMENTO,
            VESTES
        }
        public void mostrar(int i)
        {
            Console.WriteLine( i+" .produtos: "   + nome       +
                               " | quantidade: " + quantidade +
                               " | preço: "      + preco      +
                               " | tipo: "       + tipo );
        }
    } 

}
