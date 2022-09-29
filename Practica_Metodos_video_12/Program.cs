namespace Practica_Metodos_video_12
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(7,10));
            Console.ReadKey(true);
        }
    static int Suma(int operador1, int operador2)=> operador1 + operador2;
    static int Suma(int numero1, double numero2) => numero1;
    static int Suma(int numero1, int numero2, int numero3,int numero4) => numero1 + numero2;
    }
}