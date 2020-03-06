using System;

namespace ProgramaGasolina

{
    //Creacion de clase.
    class TanqueDeGasolina{ //Declaracion de atributos de clase
        private double capacidadMaxima, CantidadActual;

        public TanqueDeGasolina(){
            capacidadMaxima = 42;//Declaracion de la cantidad Maxima en 42
            CantidadActual = 2;//Declaracion de la cantidad 2
        }
        //Constructor Predeterminado
        public TanqueDeGasolina(double Cact){
            capacidadMaxima = Cact;
            CantidadActual = capacidadMaxima; //Igualacion a CapacidadMaxima
        }

        public TanqueDeGasolina(double Cact, double CM){
            CantidadActual = Cact;
            capacidadMaxima = CM;
            if (2 > capacidadMaxima)//Sentencia Condicional
            {
                CantidadActual = capacidadMaxima;
            }

        }
        public void llenarTanque(){ //Meto-do
            CantidadActual = capacidadMaxima;
            Console.WriteLine("El tanque tiene actualmente:" + CantidadActual);
        }

        public void consumirGasolina()
        {//Meto-do
            double menos;
            Console.WriteLine("Gasolina menos");
            menos = double.Parse(Console.ReadLine());
            if (CantidadActual - menos < 0) //Sentencia Condicional
            {
                CantidadActual = 0;
                Console.WriteLine("Necesita Cargar Combustible");
                Console.WriteLine("Capacidad Actual: " + CantidadActual);
                Console.WriteLine("Gracias por usar nuestra Gasolinera");
            }

            else {
                CantidadActual = CantidadActual - menos;
                Console.WriteLine("Cantidad Actual: " + CantidadActual);
            }

        }

        public void consumirTotalGasolina()
        { //Meto-do
            CantidadActual = 0;
            Console.WriteLine("NuevaCantidad Actual: " + CantidadActual);
        }

        public void agregarGasolina()
        {//Meto-do
            double mas;
            Console.WriteLine("Introduzca la cantidad a agregar");
            mas = double.Parse(Console.ReadLine());
            if (CantidadActual + mas > capacidadMaxima) {
             CantidadActual = capacidadMaxima;
                Console.WriteLine("La capacidad máxima se excedía del límite. El tanque se ha llenado");
                Console.WriteLine("Capacidad Actual: " + CantidadActual);
            }
            CantidadActual = CantidadActual + mas;
            Console.WriteLine("La capacidad actual ahora es: " + CantidadActual);
        }

 
    }

    class Program

    {
        static void Main(string[] args){

            double CM1, Cact, CM2;
            int Opciones, opc1, opc2, opc3;
            bool rep1 = true;
            TanqueDeGasolina obj1 = new TanqueDeGasolina();
            Console.WriteLine("Introduce la cantidad Máxima del tanque lleno.");
            CM1 = double.Parse(Console.ReadLine());
            TanqueDeGasolina obj2 = new TanqueDeGasolina(CM1);
            Console.WriteLine("Se usa el Constructor  3.");
            Console.WriteLine("Introduce la cantidad actual del tanque.");
            Cact = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad Máxima del tanque");
            CM2 = double.Parse(Console.ReadLine());
            TanqueDeGasolina obj3 = new TanqueDeGasolina(Cact, CM2);
            Console.WriteLine("Si quisieramos llamar los metodos");
            Console.WriteLine("Primero tendriamos que instanciarlos como objetos :)");

}
    }
}

