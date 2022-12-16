
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
