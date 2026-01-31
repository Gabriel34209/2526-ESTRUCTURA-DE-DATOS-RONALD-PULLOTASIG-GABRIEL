using System;
using System.Collections.Generic;

namespace SistemaParqueDiversiones
{
    // Clase que representa al asistente
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime HoraLlegada { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
            HoraLlegada = DateTime.Now;
        }
    }

    // Clase que gestiona la lógica de la atracción
    public class Atraccion
    {
        private Queue<Persona> filaEspera = new Queue<Persona>();
        private const int MAX_ASIENTOS = 30;

        // Método para registrar personas en la cola
        public bool RegistrarPersona(string nombre)
        {
            if (filaEspera.Count < MAX_ASIENTOS)
            {
                Persona nuevaPersona = new Persona(nombre);
                filaEspera.Enqueue(nuevaPersona);
                Console.WriteLine($"[Registro] {nombre} ha ingresado a la fila. (Posición: {filaEspera.Count})");
                return true;
            }
            else
            {
                Console.WriteLine("!!! Lo sentimos, todos los asientos han sido vendidos.");
                return false;
            }
        }

        // Método de Reportería: Visualiza la estructura actual
        public void MostrarEstadoFila()
        {
            Console.WriteLine("\n--- ESTADO ACTUAL DE LA FILA DE ESPERA ---");
            foreach (var p in filaEspera)
            {
                Console.WriteLine($"- {p.Nombre} (Llegada: {p.HoraLlegada.ToLongTimeString()})");
            }
            Console.WriteLine("------------------------------------------\n");
        }

        // Método para asignar los asientos una vez lleno
        public void AsignarAsientos()
        {
            if (filaEspera.Count < MAX_ASIENTOS)
            {
                Console.WriteLine($"Aún quedan {MAX_ASIENTOS - filaEspera.Count} asientos disponibles.");
                return;
            }

            Console.WriteLine("\n=== INICIANDO ASIGNACIÓN DE ASIENTOS (ORDEN DE LLEGADA) ===");
            int numAsiento = 1;
            while (filaEspera.Count > 0)
            {
                Persona p = filaEspera.Dequeue(); // Sale el primero que entró
                Console.WriteLine($"Asiento #{numAsiento}: Reservado para {p.Nombre}");
                numAsiento++;
            }
            Console.WriteLine("=== PROCESO FINALIZADO: Todos los asientos han sido asignados. ===\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Atraccion montañaRusa = new Atraccion();

            // Simulación de llegada de 30 personas
            for (int i = 1; i <= 30; i++)
            {
                montañaRusa.RegistrarPersona($"Visitante {i}");
            }

            // Intentar registrar uno más para validar el límite
            montañaRusa.RegistrarPersona("Visitante Extra");

            // Mostrar reporte de la estructura
            montañaRusa.MostrarEstadoFila();

            // Ejecutar la asignación final
            montañaRusa.AsignarAsientos();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}