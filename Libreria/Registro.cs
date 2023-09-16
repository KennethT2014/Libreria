using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Registro
    {
        public class RegistroCuenta
        {
            private int cuenta;
            private string primerNombre;
            private string apellidoPaterno;
            private decimal credito;

            public RegistroCuenta() : this(0, "", "", 0.0M)
            {

            }

            public RegistroCuenta(int valorCuenta, string valorPrimerNombre,
                string valorApellidoPaterno, decimal valorCredito)
            {
                Cuenta = valorCuenta;
                PrimerNombre = valorPrimerNombre;
                ApellidoPaterno = valorApellidoPaterno;
                Credito = valorCredito;
            }

            public int Cuenta
            {
                get { return cuenta; }
                set { cuenta = value; }
            }
            public string PrimerNombre
            {
                get { return primerNombre; }
                set { primerNombre = value; }
            }
            public string ApellidoPaterno
            {
                get { return apellidoPaterno; }
                set { apellidoPaterno = value; }
            }
            public decimal Credito
            {
                get { return credito; }
                set { credito = value; }
            }
        }
    }
}