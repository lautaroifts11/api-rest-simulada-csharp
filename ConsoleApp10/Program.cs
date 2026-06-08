namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testeamo el encapsulamiento!");

            Ejemplo e1 = new Ejemplo();

            //get set standard
            e1.setId(100);
            Console.WriteLine("Id n 1: " + e1.getId());

            // get set de props
            e1.Name = "Prueba";
            Console.WriteLine("Nombre n 1: " + e1.Name);

        }
    }
}
