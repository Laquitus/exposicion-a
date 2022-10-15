using System;
					
public class Program
{
	public static void Main()
	{
        int Filas;
        int Columnas;
		Console.WriteLine("-_-_-_-Porfavor ingrese lo solicitado-_-_-_-");
        Console.WriteLine("Ingrese el tamaño de filas para su arreglo");
        Filas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el tamaño de columnas para su arreglo");
        Columnas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine (("Su arreglo se compondra de Filas: ") + Filas + (" y Columnas: ") + Columnas);

        int [,] arreglo1 = new int [Filas,Columnas];
       
{
        int filas = arreglo1.GetLength(0); 
        int columnas = arreglo1.GetLength(1); 
        
        Random Ale = new Random();
        for (int i = 0; i < filas; i++) 
        {
            for (int j = 0; j < columnas; j++) 
            {
                arreglo1[i,j] = Ale.Next(0,50);
                
            }
        }

        Console.WriteLine("Su arreglo esta completado ");
        Console.WriteLine("Presione una tecla para poder Visualizar su arreglo ");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Su arreglo esta constituido con los siguientes datos:");
        Console.WriteLine("");

        for (int l = 0; l < filas; l++)
        {
            for (int k = 0; k < columnas; k++)
            {
               
             Console.Write(arreglo1[l,k] + "\t");
            
            }
            Console.WriteLine("");
        }
    }
    }
    }


    
        

	


