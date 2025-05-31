using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace PirncipiosSOLID
{
    internal class PrincipioResponsabilidadUnica
    {
        static void Main(string[] args)
        {
            //ES CUANDO UNA CLASE SIMPLEMENTE DEBE DE TENER UNA UNICA RESPONSABILIDAD SRP

            //EJEMPLO CON CLASE CERVEZA principio de responsabilidad unica SRP

           
        }

        public class Cerveza
        {
            public string Nombre { get; set; }
            public string Marca { get; set; }

            public Cerveza(string Nombre, string Marca)
            {
                this.Nombre = Nombre;
                this.Marca = Marca;
            }
        }

        public class GuardarBD
        {
            private Cerveza _cerveza;
            public GuardarBD(Cerveza cerveza)
            {
                _cerveza = cerveza;
            }
            public void Guardar()
            {
                Console.WriteLine($"El dato que guardamos {_cerveza.Nombre} y {_cerveza.Marca}");
            }
        }

        public class EnviarCerveza
        {
            private Cerveza _cerveza;

            public EnviarCerveza(Cerveza cerveza)
            {
                _cerveza = cerveza;
            }
            public void Enviar(Cerveza cerveza)
            {

                Console.WriteLine($"Enviamos: {_cerveza.Nombre} y {_cerveza.Marca}");
            }
        }

        
    }
}
          
