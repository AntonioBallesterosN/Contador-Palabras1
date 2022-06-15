class Program
{

    static void Main(string[] args)
    {
        string texto;
        int espacio;
        int espacioVocal;
        int numeroCaracter;
       
        Console.Write("Escriba un texto: ");
        texto = Console.ReadLine();

        espacio = 1;
        numeroCaracter = 0;
        espacioVocal = 0;

        while (numeroCaracter < texto.Length)
        {
            if (texto[numeroCaracter] == ' ')
            {
                espacio++;
            }
            
            else if 
            (texto[numeroCaracter] == ' ' && texto[numeroCaracter] == 'a' || texto[numeroCaracter] == 'e' || texto[numeroCaracter] == 'i' || texto[numeroCaracter] == 'o' || texto[numeroCaracter] == 'u')
            {
                espacioVocal++;
            }

            numeroCaracter++;
        }

        Console.Write("Total de palabras en el texto : {0} {1}", espacio, espacioVocal);


    }
}

