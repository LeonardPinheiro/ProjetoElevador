using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model

{
    class Elevador
    {
       
        //Método contendo as principais operações do elevador.
        public static void Inicializar()
        {
            //Indica que o usuário começara no térreo.
            Console.WriteLine("Voçê está no térreo \n");

            //Pede a quantidade de andares do predio.
            Console.WriteLine("Quantos andares tem o predio? \n");
            int andar = Int32.Parse(Console.ReadLine());
           
            //Pede a capacidade de pessoas que o elevador terá.
            Console.WriteLine("Qual a capacidade do elevador? \n");
            int capacidade = Int32.Parse(Console.ReadLine());

            //Pede a quantidade de pessoas que irão entrar no elevador.
            Console.WriteLine("Quantas pessoas irão entrar no elevador? \n");
            int pessoas = Int32.Parse(Console.ReadLine());
            
            //Estrutura de decisão para verificar a capacidade maxima de pessoas no elevador.
            if (pessoas > capacidade)
            {
                Console.WriteLine("O elevador não suporta essa capacidade! \nSão permitodo apenas "+capacidade+ " pessoas");
            }

            //variáveis de controle da aplicação
            pessoas = 0;
            int subirDescer = 0;
            int terreo = 0;

            //Menu de controle do elevador.
            Console.WriteLine(@"Selecione uma opção!

                1-Entrar

                2-Sair

                3-Subir

                4-Descer");

            

            /*Laço de repetição para controlar o fluxo do elevador com base na quantidade de andares*/
            do{
                //recebe as informações do menu e armazena em uma variável.
                int opcao = Int32.Parse(Console.ReadLine());

                //estrutura de decisão para a seleção do número 1 do menu.
                if (opcao == 1)
                {
                    Console.WriteLine("\nUma pessoa entrou no levador" + " Quantidade: " + pessoas);
                    //chama o método e armazenando ele, ao mesmo tempo já mostra a quantidade de pessoas que entrarão no elevador.
                    pessoas = Entrar(pessoas); 
                    
                    //estrutura de decisão para verificar a capacidade maxima do elevador.
                    if (pessoas > capacidade)
                    {
                        //seta a variável para a capacidade maxima, impede o usuário de colocar mais pessoas no elevador.
                        pessoas = capacidade;
                        Console.WriteLine("\n Não é permitido exceder a capacidade do elevador");
                    }
                }

                //estrutura de decisão para a seleção do número 2 do menu.
                if (opcao == 2)
                {
                    
                    //chama o método e armazenando ele, ao mesmo tempo já mostra a quantidade de pessoas que sairão no elevador.
                    pessoas = Sair(pessoas); 
                    Console.WriteLine("\nUma pessoa saiu do elevador" + " Quantidade: " + pessoas);

                    //estrutura de decisão para verificar a capacidade minina do elevador.
                    if (pessoas < terreo)
                    {
                        //seta a variável para a capacidade minima, impede o usuário de retirar pessoas inexistentes do elevador.
                        pessoas = terreo+1;
                        Console.WriteLine("\n Elevador Vazio");
                    }
                }

                //estrutura de decisão para a seleção do número 3 do menu.
                if (opcao == 3)
                {
                    Console.WriteLine("\nSubiu 1 andar" + " Andar: " + subirDescer);
                    //chama o método e armazenando ele, ao mesmo tempo já mostra a quantidade de andares que o elevador subiu.
                    subirDescer = Subir(subirDescer); 
                    

                    //estrutura de decisão para verificar a capacidade maxima dos andares.
                    if (subirDescer > andar)
                    {
                        //seta a variável para a capacidade maxima, impede o usuário de subir mais andares o elevador.
                        subirDescer = andar;
                        Console.WriteLine("\n Voçe já está no ultimo andar");
                    }
                }

                //estrutura de decisão para a seleção do número 4 do menu.
                if (opcao == 4)
                {
                    
                    //chama o método e armazenando ele, ao mesmo tempo já mostra a quantidade de andares que o elevador Desceu.
                    subirDescer = Descer(subirDescer);
                    Console.WriteLine("\nDesceu 1 andar" + " Andar: " + subirDescer);

                    //estrutura de decisão para verificar a capacidade minima dos andares.
                    if (subirDescer < terreo)
                    {
                        //seta a variável para a capacidade minima, impede o usuário de descer mais andares o elevador.
                        subirDescer = 0;
                        Console.WriteLine("\n Não da para descer além do térreo");
                    }
                }
            }while (true);
        }

        //Método para colocar pessoas no elevador
        public static int Entrar(int pessoas)
        {
            pessoas++;
            return pessoas;
        }

        //Método para retirar pessoas do elevador
        public static int Sair(int pessoas)
        {
            pessoas--;
            return pessoas;
        }

        //Método para subir o elevador
        public static int Subir(int andar)
        {
            andar++;
            return andar;
        }

        //Método para descer o elevador
        public static int Descer(int andar)
        {
            andar--;
            return andar;
        }      
    }
}
