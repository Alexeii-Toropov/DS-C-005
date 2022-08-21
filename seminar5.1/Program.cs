int[] array = new int[123];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0,1000);
}
int count = 0;
int j = 0;
while (j < array.Length)
{
    if (array[j] > 10 && array[j] < 99)
    {
        count++;
        j++;
    }
    else
    {
     j++;
    }
}
Console.Write("Количествго элементов массива на отрезке от 10 до 99 составляет: " + count);