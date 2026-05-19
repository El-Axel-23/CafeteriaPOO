namespace CafeteriaPOO
{
    class Bebida
    {
        // Atributos privados
        private string nombre;
        private string tamaño;
        private float precio;
        // Constructor
        public Bebida(string nombre, string tamaño, float precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }
        // Metodo Preparar()
        public string Preparar()
        {
            return "Preparando un " + nombre + " tamaño " + tamaño + "...";
        }
        // Metodo para AplicarDescuento
        public void AplicarDescuento(float porcentaje)
        {
            // Validar rango de descuento
            if (porcentaje >= 0 && porcentaje <= 100)
            {
                precio = precio - (precio * (porcentaje / 100));
            }
        }
        // Metodo MostrarDescripcion
        public string MostrarDescripcion()
        {
            return "Esto es un " + nombre + " de tamaño " + tamaño + " con un costo de $" + precio;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Variables para datos
            string nombre, tamaño;
            float precio;
            // Bebida 1
            Console.WriteLine("Ingrese el nombre de la bebida 1:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño de la bebida 1:");
            tamaño = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la bebida 1:");
            precio = float.Parse(Console.ReadLine());
            Bebida bebida1 = new Bebida(nombre, tamaño, precio);
            Console.WriteLine();
            // Bebida 2
            Console.WriteLine("Ingrese el nombre de la bebida 2:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño de la bebida 2:");
            tamaño = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la bebida 2:");
            precio = float.Parse(Console.ReadLine());
            Bebida bebida2 = new Bebida(nombre, tamaño, precio);
            Console.WriteLine();
            // Bebida 3
            Console.WriteLine("Ingrese el nombre de la bebida 3:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño de la bebida 3:");
            tamaño = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la bebida 3:");
            precio = float.Parse(Console.ReadLine());
            Bebida bebida3 = new Bebida(nombre, tamaño, precio);
            Console.WriteLine();
            // Descuento bebida 1
            Console.WriteLine("Ingrese el porcentaje de descuento para la bebida 1:");
            float descuento1 = float.Parse(Console.ReadLine());
            bebida1.AplicarDescuento(descuento1);
            Console.WriteLine();
            // Descuento bebida 2
            Console.WriteLine("Ingrese el porcentaje de descuento para la bebida 2:");
            float descuento2 = float.Parse(Console.ReadLine());
            bebida2.AplicarDescuento(descuento2);
            Console.WriteLine();
            // Descuento bebida 3
            Console.WriteLine("Ingrese el porcentaje de descuento para la bebida 3:");
            float descuento3 = float.Parse(Console.ReadLine());
            bebida3.AplicarDescuento(descuento3);
            Console.WriteLine();
            // Preparar bebidas
            Console.WriteLine(bebida1.Preparar());
            Console.WriteLine(bebida2.Preparar());
            Console.WriteLine(bebida3.Preparar());
            Console.WriteLine();
            // Mostrar descripciones
            Console.WriteLine(bebida1.MostrarDescripcion());
            Console.WriteLine(bebida2.MostrarDescripcion());
            Console.WriteLine(bebida3.MostrarDescripcion());
        }
    }
}