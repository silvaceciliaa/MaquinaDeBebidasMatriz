using System;
namespace MaquinaDeBebidas
{
    public class Maquina
    {
        public string OpcaoMenu { get; set; }

        public int Agua { get; set; }

        public int Cafe { get; set; }

        public double Suco { get; set; }

        public int Refrigerante { get; set; }

        public int Energetico { get; set; }

        public double ValorTotal { get; set; }

       

        public void Buy()
        {
            if (OpcaoMenu == "00" && Agua > 0)
            {
                Agua = 0;
                ValorTotal = ValorTotal + 2.00;
                Console.Clear();
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "0,0" && Agua == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "01" && Cafe > 0)
            {
                Cafe = 0;
                ValorTotal = ValorTotal + 2.50;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "01" && Cafe == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "02" && Suco > 0)
            {
                Suco = 0;
                ValorTotal = ValorTotal + 5.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "02" && Suco == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "03" && Refrigerante > 0)
            {
                Refrigerante = 0;
                ValorTotal = ValorTotal + 5.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "03" && Refrigerante == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }
            if (OpcaoMenu == "04" && Energetico > 0)
            {
                Energetico = 0;
                ValorTotal = ValorTotal + 10.00;
                Console.WriteLine("Produto entregue!");
            }
            else if (OpcaoMenu == "04" && Energetico == 0)
            {
                Console.WriteLine("O produto precisa ser reposto");
            }

        }

        public void PrateleirasMenu()
        {

            string[,] prateleiras = new string[2, 5];
            prateleiras[0, 0] = "Água - R$: 2,00 - [0,0]";
            prateleiras[0, 1] = "Café - R$:2,50 - [0,1]";
            prateleiras[0, 2] = "Suco - R$:5,00 - [0,2]";
            prateleiras[0, 3] = "Refrigerante - R$:5,00 [0,3]";
            prateleiras[0, 4] = "Energético - R$:10,00 - [0,4]";
            prateleiras[1, 0] = "Repor - [1, 0]";
            prateleiras[1, 1] = "Sair - [1, 1]";

            for (int i = 0; i < prateleiras.GetLength(0); i++)
            {
                for (int j = 0; j < prateleiras.GetLength(1); j++)
                {
                    Console.WriteLine(prateleiras[i, j]);
                }
            }
        }

        public void Repor()
        {
            if (OpcaoMenu == "r")
            {
                Console.WriteLine("Digite o número do produto que deseja repor");
                string produtoR = Console.ReadLine();

                if (produtoR == "00" && Agua == 0)
                {
                    Agua++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "00" && Agua > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "01" && Cafe == 0)
                {
                    Cafe++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "01" && Cafe > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "02" && Suco > 0)
                {
                    Suco++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "02" && Suco > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "03" && Refrigerante == 0)
                {
                    Refrigerante++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "03" && Refrigerante > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
                if (produtoR == "04" && Energetico == 0)
                {
                    Energetico++;
                    Console.WriteLine("O produto adicionado ao estoque");
                }
                else if (produtoR == "04" && Energetico > 0)
                {
                    Console.WriteLine("Produto já está no estoque");
                }
            }


        }
    }
}


