using System;

namespace EvaluacionNumerosPrimos
{
	class Program

	{
		class NumeroPerfecto //Creacion de Clase para Calculo de Numeros Perfectos
		{
			//Instrucciones para la clase
			// Boleano para indicar si es perfecto o no
			static bool Perfecto(int x)
			{
				// Guarda los productos de las divisiones
				int Suma = 1;

				// Find all divisors and add them 
				for (int i = 2; i * i <= x; i++)
				{
					if (x % i == 0)
					{
						if (i * i != x)
							Suma = Suma + i + x / i;
						else
							Suma = Suma + i;
					}
				}
				if (Suma == x && x != 1)
					return true;

				return false;
			}
			static void Main(string[] args)
			{
				Console.WriteLine("Bienvenido al Programa de Numeros");
				Console.WriteLine("Por favor ingrese los datos requeridos y seleccione el menu de opciones");
				Console.WriteLine("Presione: 1.Numeros Primos 2.Numeros Perfectos 3.Numeros Enteros Invertidos");
				int Opcion;
				Opcion = Int32.Parse(Console.ReadLine());
				switch (Opcion)
				{
					case 1: //Numeros Primos
						Console.WriteLine("Numeros Primos");
						int A = 0;
						int B = 0;
						int C = 0;
						int D = 0;
						Console.WriteLine("Ingrese la Cantidad de Numeros que Ingresara");
						A = Int32.Parse(Console.ReadLine());
						for (int i = 0; i < A; i++)
						{
							Console.WriteLine(" Ingrese el numero a evaluar ");
							B = Int32.Parse(Console.ReadLine());

							if (B % 2 == 0)
							{
								Console.WriteLine(" Par ");
								C = C + 1;
							}
							else
							{
								Console.WriteLine(" Impar ");
								D = D + 1;
							}

						}
						Console.WriteLine(" Hay " + C + " Pares ");
						Console.WriteLine(" Hay " + D + " Impares ");
						break;
					case 2: //Numeros perfectos
						Console.WriteLine("Numeros Perfectos");
						Console.WriteLine("Porfavor ingrese un Numero");
						int x;//Declaracion de la variable
							  //Obtener input de usuario
						x = Int32.Parse(Console.ReadLine());
						Console.WriteLine("Estos son numeros perfectos" +
									"hasta el 100");
						for (int n = 2; x < 100; x++) //No entiendo porque  tuve que cambiar n=2 segun yo se tenia que llamar x
							if (Perfecto(x))
								Console.WriteLine(x + " Es un Numero Perfecto");
						break;
					case 3: //Numero entero y regresar con numeros invertidos
						Console.WriteLine("Numeros Invertidos");
						Console.WriteLine("Porfavor ingrese un numero de por los menos dos digitos");
						int NumeroARevertir;//Declaracion de la variable
						NumeroARevertir = Int32.Parse(Console.ReadLine());//Input de usuario
						int NumeroRevertido;
						//inicializacion de la variable en 0
						NumeroRevertido = 0;
						int AuxiliarCalculo; //Variable auxiliar
											 ////Bucle de logica para revertir el numero
						while (NumeroARevertir != 0)
						{
							AuxiliarCalculo = NumeroARevertir % 10;        //extract a digit
							NumeroRevertido = (NumeroRevertido * 10) + AuxiliarCalculo;   //reverse the digits logic
							NumeroARevertir = NumeroARevertir / 10;             //remained number
						}
						Console.WriteLine("El Numero Revertido es: " + NumeroRevertido);
						break;
						
				}
	

			}
		}
	}
}
