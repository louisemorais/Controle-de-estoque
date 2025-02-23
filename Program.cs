using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_estoque
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Produtos> listaproduto = new List<Produtos>();
            Boolean rodando = true;
            while (rodando) {
                exibir("| [1] Novo            |");
                exibir("| [2] Listar Produto  |");
                exibir("| [3] Remover Produto |");
                exibir("| [4] Entrada         |");
                exibir("| [5] Saída           |");
                exibir("| [0] Sair            |");
                exibir("selecione a sua opção:");
                int Call = int.Parse(Console.ReadLine());

                switch (Call)
                {
                    case 1:
                        exibir("diga o nome do produto:");
                        string produto = Console.ReadLine();
                        exibir("diga a quantidade:");
                        int quantidade = int.Parse(Console.ReadLine());
                        exibir("diga o preço");
                        double preco = double.Parse(Console.ReadLine());
                        exibir("digite o tipo:");
                        exibir("[1] Limpeza");
                        exibir("[2] Eletrônica");
                        exibir("[3] Alimento");
                        exibir("[4] Vestes");
                        exibir("[5] Outros");
                        int call2 = int.Parse(Console.ReadLine());
                        Enum tipagem;
                        switch (call2)
                        {
                            case 1:
                                tipagem = Produtos.TipoProduto.LIMPEZA;
                                break;

                            case 2:
                                tipagem = Produtos.TipoProduto.ELETRONICA;
                                break;
                            case 3:
                                tipagem = Produtos.TipoProduto.ALIMENTO;
                                break;
                            case 4:
                                tipagem = Produtos.TipoProduto.VESTES;
                                break;
                            default:
                                tipagem = Produtos.TipoProduto.INDEFINIDO;
                                break;
                        }
                        listaproduto.Add(new Produtos(produto, quantidade, preco, tipagem));
                        break;

                    case 2: //lista
                        for (int i = 0; i < listaproduto.Count; i++)
                        {
                            listaproduto[i].mostrar(i + 1);
                        }
                        break;
                    case 3: //deleção de produto
                        exibir("digite a posição do item para remover:");
                        int valor_remover = int.Parse(Console.ReadLine());
                        listaproduto.RemoveAt(valor_remover-1);
                        exibir("produto removido!");
                        break;
                    case 4://entrada de produto
                        exibir("escreva a posição a se adicionar: ");
                        int posicao = int.Parse(Console.ReadLine());
                        exibir("escreva a quantidade a se adicionar: ");
                        int entrada= int.Parse(Console.ReadLine());
                        listaproduto[posicao-1].quantidade+= entrada;
                        exibir("adicionado!");

                        break;
                    case 5: //saída de produto
                        exibir("escreva a posição a se adicionar: ");
                        int posicao1 = int.Parse(Console.ReadLine());
                        exibir("escreva a quantidade a se removerr: ");
                        int entrada1 = int.Parse(Console.ReadLine());
                        if ((entrada1- listaproduto[posicao1 -1].quantidade)>0)
                        {
                            exibir("quantidade inválida valor negativo");
                            break;
                        }
                        listaproduto[posicao1 - 1].quantidade -= entrada1;
                        exibir("removido!");

                        break;
                    case 0: //saída do menu
                        rodando = false;
                        break;
                    default:
                        exibir("opção indisponível, tente novamente");
                        break;

                }
            }

        }
        
        public static void exibir(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
