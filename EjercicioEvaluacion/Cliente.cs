using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEvaluacion
{
    public class Cliente

    {   //Atributos
        public int Monto;
        public string Nombre;
        public int TotalDepositos { get; set; }
        
        //Constructor
        public Cliente(int _monto, string _nombre)
        {
            this.Monto = _monto;
            this.Nombre = _nombre;
        }
        
        //Metodo para depositar saldo
        public int DepositarDinero(int _Monto)
        {
            this.Monto += _Monto;
            TotalDepositos++;
            return Monto;
        }
        
        //Metodo para extrar saldo
        public int ExtraerDinero(int _Monto)
        {
            this.Monto -= _Monto;
            TotalDepositos++;
            return Monto;
        }
        
        //Matodo para consultar saldo
        public int RetornarDinero()
        {
            return this.Monto;
        }

    }
}
