using System;

namespace ejemploParcialito
{
    class Program
    {

       
        static void Main(string[] args)
        {
            string nombreAlumno;
            int legajo, contadorNotas;
            float nota1, nota2, nota3, promedio;
            contadorNotas = 0;

            legajo = cargarLegajo();
            nombreAlumno = cargarNombre();
            nota1 = cargarNota(ref contadorNotas);
            nota2 = cargarNota(ref contadorNotas);
            nota3 = cargarNota(ref contadorNotas);

            promedio = calcularPromedio(nota1, nota2, nota3, contadorNotas);

            mostrarDatos(legajo, nombreAlumno, promedio);
        }


        //CARGAR EL LEGAJO DEL ALUMNO
        public static int cargarLegajo()
        {
            int numLegajo;
            Console.WriteLine("Ingresar número de legajo del alumno: ");
            numLegajo = int.Parse(Console.ReadLine());
            return numLegajo;
        }


        //CARGA EL NOMBRE DEL ALUMNO
        public static string cargarNombre()
        {
            string nombreAlumno;
            Console.WriteLine("Ingresar el nombre del alumno: ");
            nombreAlumno = Console.ReadLine();
            return nombreAlumno;
        }

        //CARGA NOTA DEL ALUMNO
        public static float cargarNota(ref int contadorNotas)
        {
            float nota;
            contadorNotas++;
            Console.WriteLine("Cargar nota del alumno Nro " + contadorNotas + " :");
            nota = float.Parse(Console.ReadLine());
            return nota;
        }

        //CALCULA EL PROMEDIO DE LAS NOTAS INGRESADAS DEL ALUMNO
        public static float calcularPromedio(float nota1, float nota2, float nota3, int contadorNotas)
        {
            float sumaNotas, promedio;
            sumaNotas = nota1 + nota2 + nota3;
            promedio = sumaNotas / contadorNotas;
            return promedio;

        }


        //MUESTRA LOS DATOS PROCESADOS EN PANTALLA
        public static void mostrarDatos(int legajo, string nombreAlumno, float promedio)
        {
            Console.WriteLine("Legajo: " + legajo + "\nNombre: " + nombreAlumno + "\nPromedio: " + promedio);
        }

    }
}
