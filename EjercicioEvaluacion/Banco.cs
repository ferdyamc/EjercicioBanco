using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEvaluacion
{
    internal class Banco
    {
        //Atributos-----------------------------------------------------------------------------------------------------------------------------------
        public Cliente cl1;
        public Cliente cl2;      
        public Cliente cl3;
        
        //Constructor--------------------------------------------------------------------------------------------------------------------------------
        public Banco()
        {
            cl1 = new Cliente(1000000,"Andrés");
            cl2 = new Cliente(1500000, "Andrés2");
            cl3 = new Cliente(12000000, "Andrés3");
        }

        //Metodo para realizar operaciones en cliente------------------------------------------------------------------------------------------------
        public void Operar(Cliente cl)
        {
            //Variables locales del metodo
            int opcion_operacion;
            int valor;
            
            //Consultar y asignar valor a opcion_operacion
            Console.WriteLine("¿Que operación desea realizar?\na)Presione '1' para depositar dinero\nb)Presione '2' para extraer dinero\nc)Presione '3' para retornar Monto\nd)Presione '4' para consultar No. de retiros");
            opcion_operacion = int.Parse(Console.ReadLine());

            //Confirmar que el valor de opción seleccionado este en rango : (1-2-3)
            while (opcion_operacion < 1 || opcion_operacion > 4)
            {
                Console.WriteLine("Opción incorrecta.\na)Presione 1 para  Depositar dinero\nb)Presione 2 para  extraer dinero\nc)Presione 3 para retornar Monto");
                opcion_operacion = int.Parse(Console.ReadLine());
            }

            //Realizar la operación seleccionada
            switch (opcion_operacion)
            {
                case 1://Depositar dinero
                    Console.Write("Ingrese el valor e Depositar : ");
                    valor = int.Parse(Console.ReadLine());
                    cl.DepositarDinero(valor);
                    break;

                case 2://Extaer dinero
                    Console.Write("Ingrese el valor el valor a extraer Depositar : ");
                    valor = int.Parse(Console.ReadLine());
                    while (valor > cl.Monto)//Confirma que el monto a retirar sea menor o igual al saldo (si es mayor lo solicita nuevamente)
                    {
                        Console.Write("Saldo no disponible. Intente con un valor menor : ");
                        valor = int.Parse(Console.ReadLine());
                    }
                    cl.ExtraerDinero(valor);
                    break;

                case 3://Consultar saldo
                    Console.WriteLine("Saldo Total : " + cl.RetornarDinero());
                    break;

                case 4://Consultar No. de depositos
                    Console.WriteLine("No. de depositos : " + DepositosTotales(cl));
                    break;

                default://Opción por defecto
                    Console.WriteLine("Opción invalida");
                    break;
            }

            //Preguntar si desea realizar otra accion
            Console.WriteLine("Presione '1'  para regresar al menú.\nPresione '2' para cerrar sesion.");
            opcion_operacion = int.Parse(Console.ReadLine());

            while (opcion_operacion < 1 || opcion_operacion > 2)//Confirmar que la opcíón seleccionada sea correcta : (1-2)
            {
                Console.WriteLine("Opción invalida.\nPresione '1'  para regresar al menú.\nPresione '2' para cerrar sesion.");
                opcion_operacion = int.Parse(Console.ReadLine());
            }
            if (opcion_operacion == 1) //Si lo es vuelve a llamarse asi mismp eñ metodo operaciones para continuar realizando acciones en el cliente.
            {
                Operar(cl);
            }
            else//Si no lo desea, finaliza el programa (cierra sesion).
            {               
                Environment.Exit(1); 
            }
        }

        //Metodo para consultar No. de depositos en cliente.---------------------------------------------------------------------------------------
        public int DepositosTotales(Cliente cl)
        {
             return cl.TotalDepositos;
        }
    }
}
