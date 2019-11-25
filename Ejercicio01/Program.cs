using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (AgendaContext bContexto = new AgendaContext())
                {
                    Persona bPersona = new Persona
                    {
                        PersonaId = 1,
                        Nombre = "Matias",
                        Apellido = "Noir",
                        Telefonos = new List<Telefono>
                        {
                            new Telefono
                            {
                                TelefonoId = 1,
                                Numero = "477182",
                                Tipo = "Fijo"
                            },
                            new Telefono
                            {
                                TelefonoId = 2,
                                Numero = "3447514525",
                                Tipo = "Movil"
                            }
                        }
                    };

                    bContexto.Personas.Add(bPersona);
                    bContexto.SaveChanges();

                    foreach (Persona bItem in bContexto.Personas)
                    {
                        Console.WriteLine("Persona recuperada:\nId. {0}, Nombre: {1} - Apellido: {2}",
                                            bItem.PersonaId,
                                            bItem.Nombre,
                                            bItem.Apellido);
                    }
                    Console.WriteLine("La aplicacion ha finalizado correctamente");
                }
            }
            catch (Exception bExc)
            {
                Console.WriteLine("Ha ocurrido un error", bExc);
            }
            Console.ReadKey();
        }
    }
}
