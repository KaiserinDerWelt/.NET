using System;

namespace TicketsForFootbalGame
{
    class StockBoletos{
        public int StockGeneral = 5000;
        public int StockPreferente = 2000;
        public int StockPlantaAlta = 3500;
        public int StockPlantaBaja = 4500;
        public int BoletosVendidos;
        public int RecaudacionTotal;
        public int BoletosEnInventarioTotal;


        public StockBoletos()
        {
            Console.WriteLine("Another Project by KaiserinDerWelt" + DateTime.Now);
            //Me-to-do que no devuelve resultados
        }

        public int  CalculoTotal(int StockGeneral, int StockPreferente, int StockPlantaBaja, int StockPlantaAlta)
        {
           
            RecaudacionTotal = (StockGeneral * 150) + (StockPreferente * 200) + (StockPlantaAlta * 300) + (StockPlantaBaja * 200);
            return (RecaudacionTotal); //Variable de Retorno

        }
        public int BoletosEnVenta(int StockGeneral, int StockPreferente, int StockPlantaBaja, int StockPlantaAlta)
        {
            BoletosEnInventarioTotal = StockGeneral + StockPlantaAlta + StockPlantaBaja + StockPreferente;

            return BoletosEnInventarioTotal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Llamado clase instaciada
            StockBoletos BoletosInstanciados;
            //Instanciacion de clase
            BoletosInstanciados = new StockBoletos();

            //Declaracion de Constantes precios de 
            const int PrecioGeneral = 150;
            const int Preferente = 200;
            const int PlantaAlta = 300;
            const int PlantaBaja = 350;
            Console.WriteLine("Bienvenido a la Compra en Linea de Boletos");
            Console.WriteLine("Porfavor proporciona la  informacion solicitada");
            Console.WriteLine("Si desea comprar presione: 1.SI 2.NO");
            //Declaracion de variable para menu
            int Seleccion;
            //Asignacion de variable sin input de usuario.
            Seleccion = Int32.Parse(Console.ReadLine());
            switch(Seleccion){
                case 1:
                    Console.WriteLine("Siga los pasos para comprar");
                    if(Seleccion == 1){
                        Console.WriteLine("Porfavor vea los productos y precios");
                        Console.WriteLine("General: $150 Preferente: $200 Planta Alta: $300 Planta Baja: $350 ");
                        Console.WriteLine("Escoge el tipo de Boleto Presiona 1.General 2.Preferente \n" +
                            "3.Planta Alta 4.Planta Baja");
                        int TipoBoleto;
                        TipoBoleto = Int32.Parse(Console.ReadLine());
                        switch (TipoBoleto){
                            case 1:
                                Console.WriteLine("Indique cantidad de boletos:");
                                int BoletosUno;
                                int CalculoTotalUno;
                                BoletosUno = Int32.Parse(Console.ReadLine());
                                CalculoTotalUno = PrecioGeneral * BoletosUno;
                                Console.WriteLine("El total a pagar es de:" + CalculoTotalUno + " pesos");
                                break;
                            case 2:
                                Console.WriteLine("Indique cantidad de boletos:");
                                int BoletosDos;
                                int CalculoTotalDos;
                                BoletosDos = Int32.Parse(Console.ReadLine());
                                CalculoTotalDos = Preferente * BoletosDos;
                                Console.WriteLine("El total a pagar es de:" + CalculoTotalDos + "pesos");
                                break;
                            case 3:
                                Console.WriteLine("Indique cantidad de boletos");
                                int BoletosTres;
                                int CalculoTotalTres;
                                BoletosTres = Int32.Parse(Console.ReadLine());
                                CalculoTotalTres = PlantaAlta * BoletosTres;
                                Console.WriteLine("El total a pagar es de:"  + CalculoTotalTres + " pesos");
                                break;
                            case 4:
                                Console.WriteLine("Indique cantidad de boletos");
                                int BoletosCuatro;
                                int CalculoTotalCuatro;
                                BoletosCuatro = Int32.Parse(Console.ReadLine());
                                CalculoTotalCuatro = PlantaBaja * BoletosCuatro;
                                Console.WriteLine("El total a pagar es de: " + CalculoTotalCuatro + " pesos");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Las estadisticas de venta son las siguientes:");
                    //Ruta Dot Notation para calculo de recaudacion total
                    var CalculoTotal = BoletosInstanciados.CalculoTotal((BoletosInstanciados.StockGeneral),(BoletosInstanciados.StockPlantaAlta),(BoletosInstanciados.StockPlantaBaja),(BoletosInstanciados.StockPreferente));
                    Console.WriteLine("La recaudacion total de boletos es de:" + CalculoTotal + "pesos");
                    //Ruta Dot Notation para calculo de boletos totales.
                    Console.WriteLine("El total de boletos en venta es de:");
                    var BoletosEnVenta = BoletosInstanciados.BoletosEnVenta((BoletosInstanciados.StockGeneral), (BoletosInstanciados.StockPlantaAlta), (BoletosInstanciados.StockPlantaBaja), (BoletosInstanciados.StockPreferente));
                   break;
                
            }
        }
    }
}
