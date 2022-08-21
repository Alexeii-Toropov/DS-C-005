Random ran = new Random();
int ran1 = ran.Next(0,99);
int[] array = new int[ran1];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100,999);
}
int count = 0;
int j = 0;
while (j < array.Length)
{
    if (array[j] % 2 == 0)
    {
        count++;
        j++;
    }
    else
    {
     j++;
    }
}
Console.Write("Количествго четных элементов массива составляет: " + count);