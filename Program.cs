//task54

int [,] Create2dArray() // создание 2-х мерного массива
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] createdArray = new int [rows, columns];  // Cоздание двумерного массива
    for(int i = 0; i < rows; i++)
    {   
        for(int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(minValue, maxValue+1);
        }    
    }
    return createdArray;        
}

void Show2dArray(int [,] array) // вывод 2-х массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] Change2dArray (int [,] array)
{
  for (int i =  0 ; i < array.GetLength(0);i ++)
  {
    for (int j =  0 ; j < array.GetLength(1) - 1 ;j ++) 
    {
      int temp = array[i , j]; 
      if (array[i, j] < array [i, j  +  1])
      {
 
        temp = array [i , j  +  1];
        array[i, j + 1] = array [i , j]; 
        array[i, j] = temp ;

      }
    }
  }
  return array;
}
int[,] myArray = Create2dArray();
Show2dArray(myArray);
for (int i = 0; i < myArray.GetLength(1) - 1; i++)
{
    Change2dArray(myArray);
}
Console.WriteLine("");
Show2dArray(myArray);


//task56
int [,] Create2dArray() // создание 2-х мерного массива
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] createdArray = new int [rows, columns];  // Cоздание двумерного массива
    for(int i = 0; i < rows; i++)
    {   
        for(int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(minValue, maxValue+1);
        }    
    }
    return createdArray;        
}

void Show2dArray(int [,] array) // вывод 2-х массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumRows(int[,] array)
{
    int[] rowArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма значений в {i + 1} строчке: {sum} ");
        rowArr[i] = sum;
    }
    return rowArr;
}

int[,] addArray = Create2dArray();
Show2dArray(addArray);
int[] sumArray = SumRows(addArray);
int min = sumArray[0];
int minIdx = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (sumArray[i] < min)
    {
        min = sumArray[i];
        minIdx = i;
    }
}



