using System;

namespace SportsStoreDiscountProgram
{
    class Program
    {
        class Descuentos
        {  //Declaracion de Variables

            public float PrecioBruto;
            public float PrecioNeto;
            public float Precio;
        

            public Descuentos() {
                Console.WriteLine("Another Assignment for my Github by KaiserinDerWelt" + DateTime.Now);
                //Me-to-do que no devuelve resultados
            }

            public float CalculoDescuentos(float PrecioBruto){
                //Sentencia Return para Devolver resultados en este me-to-do
                if (PrecioBruto <= 1000)
                {
                    Console.WriteLine("No tiene Descuento");
                    Console.WriteLine("Su Total a Pagar es: " + PrecioBruto + " Pesos");

                }

               else if (PrecioBruto > 1000 || PrecioBruto <= 4000) //Incorporacion de Operadores Logicos.
                {
                    float FormulaUno;
                    float R1;
                    FormulaUno = (PrecioBruto * 10) / 100;
                    R1 = PrecioBruto - FormulaUno;
                    Console.WriteLine("Su Total a Pagar es: " + R1 + " Pesos");
               
                }
                else if (PrecioBruto >= 4000 || PrecioBruto <= 10000) //Incorporacion de Operadores Logicos.
                {
                    float FormulaDos;
                    float R2;
                    FormulaDos = (PrecioBruto * 15) / 100;
                    R2 = PrecioBruto - FormulaDos;
                    Console.WriteLine("Su Total a Pagar es: " + R2 + " Pesos");
                }
                else if (PrecioBruto > 10000)//Incorporacion de Operadores Logicos.
                {
                    float FormulaTres;
                    float R3;
                    FormulaTres = (PrecioBruto * 20) / 100;
                    R3 = PrecioBruto - FormulaTres;

                    Console.WriteLine("Su Total a Pagar es: " + R3 + " Pesos");
                }

                return PrecioNeto; //Variable de Retorno.

            }
            static void Main(string[] args)
        {
            //Bienvenida al Programa
            // LLamado a la clase Descuentos
            Descuentos DescuentosInstanciados;
            //Instanciacion de la clase para poder usar sus me-to-dos
            DescuentosInstanciados = new Descuentos();
            Console.WriteLine("Bienvenido a SportWelt, El Mundo del Deporte");
            Console.WriteLine("Esta es Nuestro Checkout Automatico, porfavor ingrese los datos que se le piden.");
            Console.WriteLine("Indique Precio del Producto");
            //Pedir precio del producto
            DescuentosInstanciados.PrecioBruto = float.Parse(Console.ReadLine());
                //llamado de variables con tipo sin definir
                //Dot Notation para llamar Calculo y variables involucradas y que se pueda imprimir en clase main
               var CalculoDescuentos = DescuentosInstanciados.CalculoDescuentos(DescuentosInstanciados.PrecioBruto);
                //Impresion de Resultado.
                Console.WriteLine("Gracias por Comprar en SportWelt"); 
        }
    }
}
}
