using System;

namespace DPRN1_U1_A3_MALA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valor Inicial: Es el valor ingresado por teclado
            //ValorAlgoritmico: Es la conversion implicita.
            //Se le asigna uno  porque el algoritmo de fiboccini le suma 1 al numero anterior.
            //El limite esta definido por el valor ingresado con el teclado
            int ValorInicial, ValorAlgoritmico, i, NumeroIngresado, auxiliar;
            Console.WriteLine("Bienvenido a mi programa de Fibonacci");
            Console.WriteLine("Porfavor sigue las instrucciones paso a paso.");
            Console.WriteLine("Ingrese un numero:");
            //Ahora convertiremos a int nuestro input de teclado
            NumeroIngresado = int.Parse(Console.ReadLine());
            //Ahora las indicaciones para la serie de fibonacci.
            ValorInicial = NumeroIngresado;
            ValorAlgoritmico = 1;
            //Usamos Ciclo for
            for (i=0; i< NumeroIngresado; i++)
            {
                auxiliar = ValorInicial;
                ValorInicial = ValorAlgoritmico;
                ValorAlgoritmico = auxiliar + ValorInicial;
                Console.WriteLine(ValorInicial);
            }
            Console.WriteLine("Me gusta C#");
        }
    }
}
