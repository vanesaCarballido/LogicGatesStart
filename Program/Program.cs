﻿
using Library;
using System;
public class Program
{
    public static void Main()
    {
        CompuertaAND and1 = new CompuertaAND("and11", LogicaVerdadero.Instance);
        and1.AgregarEntrada(LogicaVerdadero.Instance);
        Console.WriteLine(and1);
    }
}

