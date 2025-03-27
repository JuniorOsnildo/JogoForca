namespace JogoForca;

public class Forca
{
    
    private Random random = new Random();
    
    private string palavra;
    
    private char[] palavraCodificada;
    
    private int erros;
    
    private int acertos;
    
    private string[] palavras = ["ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA",
    "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI",
    "TANGERINA", "UMBU", "UVA", "UVAIA"];
    
    private string[] corpo = [" "," "," "," "," "," "];
    
    private string[] corpoCompleto = ["o","|","/",@"\","/",@"\"];
    
    public Forca()
    {
        palavra = palavras[random.Next(0, palavras.Length)];
        
        palavraCodificada = new char[palavra.Length];
        for (int i = 0; i < palavra.Length; i++)
        {
            palavraCodificada[i] = '_';
        }
    }
    
    public void ForcaDesenho()
    {
        Console.Clear();
        Console.WriteLine("     ----------     ");
        Console.WriteLine("     |/       |     ");
        Console.WriteLine("     |        {0}     ", corpo[0]);
        Console.WriteLine("     |       {1}{0}{2}    ", corpo[1], corpo[2], corpo[3]);
        Console.WriteLine("     |       {0} {1}     ", corpo[4], corpo[5]);
        Console.WriteLine("     |              ");
        Console.WriteLine("     |              ");
        Console.WriteLine("--------------------");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++\n");

        Console.Write("-> ");
        EscreverPalavraCodificada();
        
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++");

    }

    public bool chute(char letra)
    {
        bool achou = false;

        foreach (var l in palavra)
        {
            if(l == letra)
                achou = true;
        }
        
        return achou;
    }

    public void Acertou(char letra)
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == letra)
            {
                palavraCodificada[i] = letra;
                acertos++;
            }
        }
    }

    public void Errou()
    {
        erros++;
        corpo[erros-1] = corpoCompleto[erros - 1];
    }

    private void EscreverPalavraCodificada()
    {
        foreach (var c in palavraCodificada)
        {
            Console.Write(c);
        }
        Console.WriteLine();
    }

    public bool fimDeJogo()
    {
        if (acertos == palavra.Length)
        {
            ForcaDesenho();
            Console.WriteLine("VOCÊ VENCEU! :D");
            return true;
        }

        if (erros == 6)
        {
            ForcaDesenho();
            Console.WriteLine("Suas chances acabaram :(");
            return true;
        }
        
        return false;
    }
    
}