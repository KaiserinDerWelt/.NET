using System;

namespace Actividad4U2
{
    //Creacion de Clase Persona
    class Persona {
        public String Nombre;
        public String Sexo;
        public int Edad;
        public double Peso, Altura, CalcularImc;

        public Persona()
        {//Inicializa atributos en blanco
            Nombre = "";
            Sexo = "H";
            Edad = 0;
            Peso = 0;
            Altura = 0;

        }
    }
       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Progrma de Calculo de IMC");
          
            //Solicitud de atributos por input de usuario
            Console.WriteLine("Porfavor Ingresa los Siguientes Datos:");
            Console.WriteLine("Ingresa Nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Peso (en kilogramos)");
            double Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Altura (en metros)");
            double Altura = double.Parse(Console.ReadLine());
            double IMC = Peso / (Altura*Altura);
            //Instanciacion de la clase Persona
            Persona PersonaInstanciada = new Persona();
            Console.WriteLine(Nombre + "  "+ "Su IMC es:" + IMC);
            //Estructuras de control IF ELSE para asignar valor segun parametros
            if (IMC < 18){ //PUNTO DE CORTE BAJO
                Console.WriteLine("Peso Bajo");
            }
            else if (IMC >= 18 && IMC < 25)
            {//PUNTO DE CORTE NORMAL
                Console.WriteLine("Peso normal. ");
            }
            //PUNTO DE CORTE SOBREPESO
            else if (IMC >= 25 && IMC < 27){
                Console.WriteLine("Sobrepeso");
            }
            //PUNTO DE CORTE BAJO OBESIDAD GRADO 1
            else if (IMC >= 27 && IMC < 30){
                Console.WriteLine("Obesidad Grado 1");
            }
            //PUNTO DE CORTE OBESIDAD GRADO 2
            else if (IMC >= 30 && IMC < 40){
                Console.WriteLine("Obesidad Grad 2");
            } //PUNTO DE CORTE OBESIDAD GRADO 3
            else
            {
                Console.WriteLine("Obesidad Grado 3");
            }
        }
        }
    }

