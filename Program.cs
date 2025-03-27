using JogoForca;

bool jogar = true;

while (jogar)
{
    bool partida = true;
    Forca forca = new Forca();

    while (partida)
    {
     
        forca.ForcaDesenho();

        Console.Write("\nSeu palpite -> ");
        char palpite = char.Parse(Console.ReadLine().ToUpper());
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++");
        
        if(forca.chute(palpite))
            forca.Acertou(palpite);
        else
            forca.Errou();

        if (forca.fimDeJogo())
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Gostaria de jogar novamente? S/N");
            
            char reiniciar = char.Parse(Console.ReadLine().ToUpper());

            if (reiniciar == 'S')
            {
                partida = false;
            } 
            else if (reiniciar == 'N')
            {
                partida = false;
                jogar = false;
            }
        }
        
    }
}
