
void PrintArrayInt(int[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] CreateArray(int numberOfElements, int min, int max)
{
    int[] array = new int[numberOfElements];
    Random rnd = new Random();
    for (int i = 0; i < numberOfElements; i++)
        {
            array[i, i] = rnd.Next(min, max);
        }
    return array;
}

int[] CreateEvenNumbersArray(int[] array)
{
    int[] outArray = new int[0];
    for (int i = 0; i < array.length; i++)
    {
        if(array[i]%2!=0) continue;
        else
        {
            Array.Resize(ref outArray, 1);
            outArray[outArray.Length-1] = array[i];
        }
    }
}

var array = CreateArray(10 , -10, 10);
PrintArrayInt(array);
CreateEvenNumbersArray(array);
