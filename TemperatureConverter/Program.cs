using System;

namespace EvidenciaU1
{
    class Program
    {
        static void Main(string[] args)
        {   //Declaracion de Variables
            Double ValorCelcius, ValorFahrenheit, ValorKelvin, ConversionFa, ConversionCe, ConversionKe;
            int Seleccion;
            const Double Kelvin = 273.15; //Declaracion de Constantes
            const Double Fahrenheit = 1.8;
            Console.WriteLine("Bienvenido al Programa de Conversion");
            Console.WriteLine("Elije una Opcion: 1.Celsius, 2.Fahrenheit 3.Kelvin");//Enunciado de Opciones
            int Opcion;
            Opcion = int.Parse(Console.ReadLine());// Recoger input de teclado segun Opcion
            switch (Opcion) {
                case 1: //Caso Celsius - Se usan Operadores aritmeticos,variables y constantes
                    Console.WriteLine("Ingrese la Temperatura en Celcius");
                    ValorCelcius = Double.Parse(Console.ReadLine());
                    ConversionFa = (ValorCelcius * Fahrenheit) + 32;
                    ConversionKe = (ValorCelcius + Kelvin);
                    Console.WriteLine("Conversion Fahrenheit:" + ConversionFa + "°F");
                    Console.WriteLine("Conversion Kelvin:" + ConversionKe + "°K");
                    Console.WriteLine("Desea realizar otra operacion? Presione la Opcion adecuada:");
                    Console.WriteLine("1.Si 2.No");
                    Seleccion = int.Parse(Console.ReadLine());
                    if (Seleccion ==1)
                    {
                        // Console.WriteLine("Funciona"); Probando mi condicional
                        Main(args); //Devuelve a inicio del programa.

                    }
                    else
                       {
                         Environment.Exit(0);//Cualquier valor diferente de 1 saca del programa
                    }
                    break;
                case 2: //Caso Fahrenheit - Se usan Operadores aritmeticos,variables y constantes
                    Console.WriteLine("Ingrese la Temperatura en Fahrenheit");
                    ValorFahrenheit = Double.Parse(Console.ReadLine());
                    ConversionCe = (ValorFahrenheit - 32)/ 1.8;
                    ConversionKe = (5) * (ValorFahrenheit - 32) / 9 + (Kelvin);
                    Console.WriteLine("Conversion Celsius:" + ConversionCe + "°C");
                    Console.WriteLine("Conversion Kelvin:" + ConversionKe + "°K" );
                    Console.WriteLine("Desea realizar otra operacion? Presione la Opcion adecuada:");
                    Console.WriteLine("1.Si 2.No");
                    Seleccion = int.Parse(Console.ReadLine());
                    if (Seleccion == 1)
                    {
                        // Console.WriteLine("Funciona"); Probando mi condicional
                        Main(args); //Devuelve a inicio del programa.

                    }
                    else
                    {
                        Environment.Exit(0);//Cualquier valor diferente de 1 saca del programa
                    }
                    break;
                case 3: //Caso Kelvin - Se usan Operadores aritmeticos,variables y constantes
                    Console.WriteLine("Ingrese la Temperatura en Kelvin");
                    ValorKelvin = Double.Parse(Console.ReadLine());
                    ConversionFa = Fahrenheit * (ValorKelvin - Kelvin + 32);
                    ConversionCe = ValorKelvin - Kelvin;
                    Console.WriteLine("Conversion Celsius:" + ConversionCe + "°C");
                    Console.WriteLine("Conversion Fahrenheit:" + ConversionFa + "°F");
                    Console.WriteLine("Desea realizar otra operacion? Presione la Opcion adecuada:");
                    Console.WriteLine("1.Si 2.No");
                    Seleccion = int.Parse(Console.ReadLine());
                    if (Seleccion == 1)
                    {
                        // Console.WriteLine("Funciona"); Probando mi condicional
                        Main(args); //Devuelve a inicio del programa.

                    }
                    else
                    {
                        Environment.Exit(0);//Cualquier valor diferente de 1 saca del programa
                    }
                    break; 
            }

        }

    }
    }
