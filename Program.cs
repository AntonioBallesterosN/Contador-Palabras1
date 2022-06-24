class Program
{

    static void Main(string[] args)
    {

        Console.Write("Escriba un texto: ");
        string textoUsuario = Console.ReadLine();
        ContadorDePalabras(textoUsuario);
        int numeroDePalabras = ContadorDePalabras(textoUsuario);
        Console.Write("Total de palabras en el texto : {0}", numeroDePalabras);
    }
    static int ContadorDePalabras(string textoUsuario)
    {
        int espacio = 1;
        int numeroCaracter = 0;

        while (numeroCaracter < textoUsuario.Length)
        {

            if (textoUsuario[numeroCaracter] == ' ')
            {
                espacio++;
            }
            
            numeroCaracter++;

        }
        
        return espacio;

    }
   
}

