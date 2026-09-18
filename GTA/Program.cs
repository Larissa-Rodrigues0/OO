namespace GTA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new Carro(); // new chama o meteodo construtor 
            fusca.Acelerar();
            fusca.Acelerar(5);

            fusca.Marca = "Joca";

            CarroEletrico dolphin = new CarroEletrico();
            dolphin.Acelerar();
            dolphin.QuantidadeCelulasBateria = 8;
            dolphin.subirMarcha();

            CarroEsportivo ferrari = new CarroEsportivo();
            ferrari.Acelerar();
            ferrari.subirMarcha();



            Carro gol = new Carro();
            gol.Acelerar();
            gol.Marca = "Zeca";

            //for (int i = 0; i < 49; i++)
            //{
            //    gol.Acelerar();
            //}

            Console.WriteLine("GOL:");
            Console.WriteLine("Velocidade: " + gol.Velocidade);
            Console.WriteLine("Marca: " + gol.Marca + "\n");

            Console.WriteLine("FUSCA:");
            Console.WriteLine("Velocidade: " + fusca.Velocidade);
            Console.WriteLine("Marca: " + fusca.Marca);


            gol.Acelerar(0);
            gol.Acelerar(0);




            Console.WriteLine("\n\nVelocidade: " + gol.Velocidade);
        }
    }
}
