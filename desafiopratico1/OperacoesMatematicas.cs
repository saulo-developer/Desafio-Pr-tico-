
using System.Transactions;

namespace desafiopratico1;


class OperacoesMatematicas
{
    // Método Somar que retorna a soma de dois números
    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Método Subtrair que retorna a subtração de dois números
     public double Subtrair(double a, double b)
    { 
        return a - b;
    
    }

    // Método Multiplicar que retorna a multiplocação de dois números

    public double Multiplicar(double a, double b)

    { 
        return a * b;
    }

    public double Divisao(double a, double b)
    {


        return a / b;
    }

    public double Divisao2(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }

        return a / b;
    }

    public double FazeraMedia1(double a, double b, double c)
    {
        return a + b / c;
    }
}