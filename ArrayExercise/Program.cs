

using System.Threading.Channels;

int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    numbers[i] = i + 1;
}

foreach (var number in numbers)
{
    Console.Write(number + ", ");
}

int[] numbers2 = new int[11];

for (int i = 0; i < 10; i++)
{
    numbers2[i] = numbers[i];
}


numbers2[10] = Convert.ToInt32(Console.ReadLine());
Array.Sort(numbers2);

for (int i = 10; i > -1; i--)
{
    if (i == 0)
        Console.Write(numbers2[i]);
    else
    {
        Console.Write(numbers2[i] + ", ");
    }
}

