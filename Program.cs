using Atividades_Robson_2;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;



internal class Program
{

    private static void Main(string[] args)
    {
        GerarForma _GerarForma = new GerarForma();

        _GerarForma.Solicitarforma();

        Console.ReadLine();
    }
}