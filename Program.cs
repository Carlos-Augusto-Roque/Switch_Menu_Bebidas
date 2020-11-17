using System;

namespace While_Do_While_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de Opções");//exibição da mensagem
            Console.WriteLine("Escolha uma opção de bebida abaixo");//exibição da mensagem
            Console.WriteLine("1 - Coca Cola");//exibição da mensagem
            Console.WriteLine("2 - Pepsi");//exibição da mensagem
            Console.WriteLine("3 - Fanta");//exibição da mensagem
            Console.WriteLine("4 - Água com gás");//exibição da mensagem
            int resposta = int.Parse(Console.ReadLine());//campo para inserir e armazenar a resposta (no caso qual o número da opção da bebida)

            //início da Condicional switch
            switch(resposta)
            {
                case 1://caso 1
                Console.WriteLine("Você gostaria de adicionar gelo? sim ou não");//exibição da mensagem
                string gelo = Console.ReadLine();//campo para inserir e armazenar a resposta(sim ou não)
                if(gelo == "sim"){//se a resposta for sim :
                    Console.WriteLine("Será enviado uma COCA COLA com adicional de gelo para sua mesa");//exibição da mensagem
                }else{//se não :
                    Console.WriteLine("Será enviado uma COCA COLA sem adicional de gelo para sua mesa");//exibição da mensagem
                }
                break;//quebra

                case 2://caso 2
                Console.WriteLine("Será enviado uma PEPSI para sua mesa");//exibição da mensagem
                break;//quebra

                case 3://caso 3
                Console.WriteLine("Será enviado uma FANTA para sua mesa");//exibição da mensagem
                break;//quebra

                case 4://caso 4
                Console.WriteLine("Será enviado uma ÁGUA COM GÁS para sua mesa");//exibição da mensagem
                break;//quebra

                default://caso seja digitado outra opção, então : 
                Console.WriteLine("Opção Inválida");//exibição da mensagem
                break;//quebra
            }//fim da condicional switch
            
        }
    }
}
