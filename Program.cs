/*string[,] estanteLivros = new string[3, 3];
for (int linha = 0; linha < estanteLivros.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < estanteLivros.GetLength(1); coluna++)
    {
        Console.WriteLine($"Digite o seu livro no indice linha {linha} coluna {coluna}: ");
        estanteLivros[linha, coluna] = Console.ReadLine();
        Console.WriteLine("\n");
    }
}
for (int linha = 0; linha < estanteLivros.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < estanteLivros.GetLength(1); coluna++)
    {
        Console.WriteLine(estanteLivros[linha, coluna]);
        Console.WriteLine("\n");
    }
}


string[,] campoMinado = new string[2, 2];
campoMinado[0, 0] = "B";
campoMinado[0, 1] = "B";
campoMinado[1, 0] = "L";
campoMinado[1, 1] = "L";
for (int linhas = 0; linhas < campoMinado.GetLength(0); linhas++)
{
    for (int colunas = 0; colunas < campoMinado.GetLength(1); colunas++)
    {
        Console.Write($"{campoMinado[linhas, colunas]}   ");
    }
    Console.WriteLine();
}

*/

using System;
using MaquinaDeBebidas;

Maquina maquina = new Maquina();

maquina.Agua = 1;
maquina.Cafe = 1;
maquina.Suco = 1;
maquina.Refrigerante = 1;
maquina.Energetico = 1;
bool loop = true;

while (loop)
{
 
    Console.WriteLine("Escolha uma das opções do menu:");
    maquina.PrateleirasMenu();
    maquina.OpcaoMenu = Console.ReadLine();

    if (maquina.OpcaoMenu == "00")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "01")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "02")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "03")
    {
        Console.Clear();
        maquina.Comprar();
    }
    if (maquina.OpcaoMenu == "04")
    {
        Console.Clear();
        maquina.Comprar();
    }

    if (maquina.OpcaoMenu == "10")
    {
        Console.Clear();
        maquina.Repor();
    }
    if (maquina.OpcaoMenu == "11")
    {
        Console.Clear();
        Console.WriteLine($"Obrigado por usar nossa máquina. Seu total gasto foi de: {maquina.ValorTotal}");
        break;

    }
}