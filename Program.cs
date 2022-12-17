
/*
Задача 1.  Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
/*
int[] CreateRandomArray(int size)
{
    int[]array = new int[size];
    for(int i = 0; i < size; i++)
    {
        int minValue = 100;
        int maxValue = 999;
        array[i] = new Random().Next(minValue, maxValue);
    }  
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

int EvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;        
}

Console.Write("Введите количество элементов массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(Length);
ShowArray(myArray);
int result = EvenNum(myArray);
Console.Write($"В данном массиве четных чисел: {result}");
*/





/*
Задача 2.  Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/        
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }      
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

int OddPozition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
            sum = sum + array[i];   
    }
    return sum;
}

Console.Write("Введите количество элементов: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
int result = OddPozition(myArray);
Console.Write($"Сумма элементов, стоящих на нечетных позициях равна: {result}");
*/




/*
Задача 3.  Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.   
*/    
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[]array = new double[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + rand.NextDouble();
    }
    return array;
}


void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {    
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];       
    }
    double diff = max - min;
    
    return diff;
}



Console.Write("Введите количество элементов: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine()); 

double[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);

double resulte = Difference(myArray);
Console.WriteLine($"Разность между максимальным и минимальным значением массива = {resulte}");
