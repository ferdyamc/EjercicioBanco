using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Banco Bank = new Banco();//Instacia de la clase Banco
            int opcion=0;//Variable que almacena la opcion seleccionada en diferentes ocaciones

            
            try//Try (Consulta que cliente de los perteneicentes a la clase Banco desea instanciar para realizar alguna operación)
            {   Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Bienvenido@\nSeleccione un cliente:\n1)Presione '1' para seleccionar -> {Bank.cl1.Nombre}\n1)Presione '2' para seleccionar -> {Bank.cl2.Nombre}\n1)Presione '3' para seleccionar -> {Bank.cl3.Nombre}");
                opcion = int.Parse(Console.ReadLine());
            }catch(FormatException e)//Catch para capturar errores de formato
            {   Console.WriteLine("Formato Incorrecto");
            }catch(Exception e)//Catch para capturar errores en general
            {   Console.WriteLine("Error");
            }
            finally //Finally para:
            {               
                while (opcion < 1 || opcion > 3)//Confimar que la opción seleccionada este dentro del rango : (1-2)
                { 
                    try
                    {   Console.WriteLine($"Opción invalida.\nSeleccione un cliente:\n1)Presione '1' para seleccionar -> {Bank.cl1.Nombre}\n1)Presione '2' para seleccionar -> {Bank.cl2.Nombre}\n1)Presione '3' para seleccionar -> {Bank.cl3.Nombre}");
                        opcion = int.Parse(Console.ReadLine());
                    }catch (FormatException e){
                        Console.WriteLine("Formato Incorrecto");
                    }
                    catch(Exception e){
                        Console.WriteLine("Error");
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                switch (opcion)//Generar la instacia del cliente seleccionado y llamar a su metodo operar.
                {
                    case 1:Bank.Operar(Bank.cl1);
                           break;
                    case 2:Bank.Operar(Bank.cl2);
                           break;
                    case 3:Bank.Operar(Bank.cl3);
                           break;
                    default:Console.WriteLine("Upss!! Algo ha ocurrido. Por favor reinicie el programa eintente nuevamente");
                           break;
                }
            }
            Console.ReadKey();
        }
    }
}
