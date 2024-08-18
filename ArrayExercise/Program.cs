

using System.Threading.Channels;

int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    Random random = new Random();
    numbers[i] = random.Next(0,1000);
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

Console.Write("\nAdd a number: ");
numbers2[10] = Convert.ToInt32(Console.ReadLine());
Array.Sort(numbers2);
Array.Reverse(numbers2);

foreach (int number in numbers2)
{
    Console.Write(number + ", ");
}

