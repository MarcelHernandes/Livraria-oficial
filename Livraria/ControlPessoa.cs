using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlPessoa
    {
        DAOpessoa person;//Conexão com pessoa
        Pessoa model;//Conectar com a classe pessoa
        private int opcao;
        public ControlPessoa()
        {
            person = new DAOpessoa();
            model = new Pessoa();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;
        }//fim do construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do modificarOpcao

        public void Menu()
        {
            Console.WriteLine("Menu - Pessoa"                     +
                              "\nEscolha uma das opções abaixo: " +
                              "\n1. Cadastrar Pessoa"             +
                              "\n2. Consultar Tudo"               +
                              "\n3. Consultar Individual"         +
                              "\n4. Atualizar Nome"               +
                              "\n5. Atualizar Telefone"           +
                              "\n6. Atualizar Endereço"           +
                              "\n7. Atualizar Data de Nascimento" +
                              "\n8. Atualizar Senha"              +
                              "\n9. Atualizar Situação"           +
                              "\n10. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());          
        }//fim do menu

        public void Operacao()
        {
            Menu();//Mostrar o menu
            switch (ModificarOpcao) {
                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    long CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o seu telefone: ");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Informe o seu endereço: ");
                    string endereco = Console.ReadLine();

                    Console.WriteLine("Informe sua data de nascimento: ");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe o seu login: ");
                    string login = Console.ReadLine();

                    Console.WriteLine("Informe a sua senha: ");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Informe o seu cargo: ");
                    string cargo = Console.ReadLine();

                    //Chamar o método cadastrar
                    person.Inserir(CPF, nome, telefone, endereco, data, login, senha, "Ativo", cargo);
                    break;
                case 2:
                    //Mostrar os dados
                    Console.WriteLine(person.ConsultarTudo());
                    break;
                case 3:
                    Console.WriteLine("Informe o CPF que deseja consultar: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine(person.ConsultarIndividual(CPF));
                    break;
                case 4:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());
                    
                    Console.WriteLine("Informe o novo nome: ");
                    nome = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "nome", nome));
                    break;
                case 5:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo telefone: ");
                    telefone = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "telefone", telefone));
                    break;
                case 6:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo endereço: ");
                    endereco = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "endereco", endereco));
                    break;
                case 7:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a data de nascimento: ");
                    data = Convert.ToDateTime(Console.ReadLine());

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "dtNascimento", data));
                    break;
                case 8:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a nova senha: ");
                    senha = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "senha", senha));
                    break;
                case 9:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o cargo: ");
                    cargo = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "cargo", cargo));
                    break;
                case 10:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    person.Excluir(CPF);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida!");
                    break;
            }//fim do switch
        }//fim da operacao

    }//fim da classe
}//fim do projeto
