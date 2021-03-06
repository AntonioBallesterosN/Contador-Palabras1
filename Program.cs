class Program
{

    static void Main(string[] args)
    {
        Console.Write("Escriba un texto: ");
       

        string textoUsuario = Console.ReadLine().Trim();
        int numeroDePalabras = ContadorDePalabras(textoUsuario);
        int numeroDePalabras1= ContadorDePalabrasConArray(textoUsuario);
        int numeroDePalabrasQueEmpiezanConVocal = ContadorDePalabrasQueComienzanConVocal(textoUsuario); 

        Console.WriteLine("");
        Console.WriteLine("Total de palabras en el texto: {0}", numeroDePalabras);
        Console.WriteLine("");
        Console.WriteLine("Total de palabras en el texto con ARRAY: {0}", numeroDePalabras1);
        Console.WriteLine("");
        Console.WriteLine("Palabras en el texto que estan en una posición par:");
        Console.WriteLine("");

        SeleccionadorDePalabrasPares(textoUsuario);

        Console.WriteLine("");
        Console.WriteLine("Total de palabras en el texto que empiezan con una vocal: {0}", numeroDePalabrasQueEmpiezanConVocal);
        Console.WriteLine("");
        Console.WriteLine("Palabras en el texto que empiezan con una vocal");
        Console.WriteLine("");

        SeleccionadorDePalabrasQueComienzanConVocal(textoUsuario);

        Console.ReadKey();
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
        string[] arreglo = textoUsuario.Split(' ');
        int numeroDePalabras = arreglo.Length;
        
        return numeroDePalabras;    
    }

    static void SeleccionadorDePalabrasPares(string textoUsuario)
    {
        string[] arreglo = textoUsuario.Trim().Split(' ');

        for (int i = 0; i < arreglo.Length; i++)
        {
            if ((i % 2) == 1)
            {
                string palabras = arreglo[i];
               
                Console.WriteLine(palabras);
            }
        }
    }

    static int ContadorDePalabrasQueComienzanConVocal(string textoUsuario)
    {
        string[] arreglo = textoUsuario.Trim().Split(' ');
        int contador = 0;
        
        foreach (var item in arreglo)
        {
            if(item.StartsWith("a") == true || item.StartsWith("e") == true || item.StartsWith("i") == true || item.StartsWith("o") == true || item.StartsWith("u") == true ||
               item.StartsWith("A") == true || item.StartsWith("E") == true || item.StartsWith("I") == true || item.StartsWith("O") == true || item.StartsWith("U") == true)
            {
                contador++;
            }
        }
        return contador;
    }

    static void SeleccionadorDePalabrasQueComienzanConVocal(string textoUsuario)
    {
        string[] arreglo = textoUsuario.Trim().Split(' ');
        int contador = 0;

        foreach (var item in arreglo)
        {
            if (item.StartsWith("a") == true || item.StartsWith("e") == true || item.StartsWith("i") == true || item.StartsWith("o") == true || item.StartsWith("u") == true ||
                item.StartsWith("A") == true || item.StartsWith("E") == true || item.StartsWith("I") == true || item.StartsWith("O") == true || item.StartsWith("U") == true)
            {
                string palabras = arreglo[contador];
                Console.WriteLine(palabras);
                contador++;
            }
            else
            {
                contador++;
            }
        }
    }
}
