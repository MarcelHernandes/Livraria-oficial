using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Menu
    {
        ControlPessoa controlePessoa;
        public int opcao;
        public Menu()
        {
            controlePessoa = new ControlPessoa();
            opcao = 0;
        }//fim do menu

        public void EscolherControl()
        {
            Console.WriteLine("\n\nMenu - Geral"               +
                             "\n0. Sair"                       +
                             "\n1. Pessoa"                     +
                             "\n2. Livro"                      +
                             "\n3. Reserva"                    +
                             "\n4. Compra"                     +
                             "\nEscolha uma das opções acima: ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do escolher

        public void OperacaoMenu()
        {

            do
            {
                EscolherControl();//Chamar o texto do menu
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        controlePessoa.Operacao();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }//fim do switch
            } while (opcao != 0);
        }//fim do operacaoMenu
    }//fim da classe
}//fim do projeto
