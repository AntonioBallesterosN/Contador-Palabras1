class Program
{

    static void Main(string[] args)
    {
        Console.Write("Escriba un texto: ");
       

        string textoUsuario = Console.ReadLine();
        int numeroDePalabras = ContadorDePalabras(textoUsuario);
        int numeroDePalabras1= ContadorDePalabrasConArray(textoUsuario);

        Console.WriteLine("");
        Console.WriteLine("Total de palabras en el texto: {0}", numeroDePalabras);
        Console.WriteLine("");
        Console.WriteLine("Total de palabras en el texto con ARRAY: {0}", numeroDePalabras1);
        Console.WriteLine("");
        Console.WriteLine("Palabras en el texto que son pares: ");

        SeleccionadorDePalabrasPares(textoUsuario);
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

    static int ContadorDePalabrasConArray(string textoUsuario)
    {
        string[] arreglo = textoUsuario.Split();
        int numeroDePalabras = arreglo.Length;
        
        return numeroDePalabras;    
    }

    static void SeleccionadorDePalabrasPares(string textoUsuario)
    {
        string[] arreglo = textoUsuario.Split(); ;
        
        for (int i = 0; i < arreglo.Length; i++)
        {
            if ((i % 2) == 1)
            {
                string palabras = arreglo[i];
               
                Console.WriteLine(palabras);
            }
        }
    }
}