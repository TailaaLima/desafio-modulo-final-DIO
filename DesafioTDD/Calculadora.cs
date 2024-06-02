﻿namespace DesafioTDD;
public class Calculadora
{
    private List<String> listaHistorico;

    private string data;

    public Calculadora(string data)
    {
        listaHistorico = new List<String>();
        this.data = data;
    }

    public int Somar(int num1, int num2)
    {
        int resultado = num1 + num2;

        listaHistorico.Insert(0, "Resultado: " + resultado + " -data: " + data);

        return resultado;
    }

    public int Subtrair(int num1, int num2)
    {
        int resultado = num1 - num2;

        listaHistorico.Insert(0, "Resultado: " + resultado + " -data: " + data);

        return resultado;
    }

    public int Multiplicar(int num1, int num2)
    {

        int resultado = num1 * num2;

        listaHistorico.Insert(0, "Resultado: " + resultado + " -data: " + data);

        return resultado;
    }

    public int Dividir(int num1, int num2)
    {
        int resultado = num1 / num2;

        listaHistorico.Insert(0, "Resultado: " + resultado + " -data: " + data);

        return resultado;
    }

    public List<string> Historico()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

        return listaHistorico;
    }
}
