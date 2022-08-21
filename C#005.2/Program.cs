Random rand = new Random();
int rand1 = rand.Next(0,99);
int[] mas = new int[rand1];
Random ran = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = ran.Next(-300,300);
}
int j = mas.Length;
int index = 0;
int sum = 0;
while (j > 0)
{
    if (mas[index] % 2 == 0)
    {
        index++;
        j--;
    }
    else
    {
        sum += mas[index];
        index++;
        j--;
    }
}
Console.Write("Сумма элементов, стоящих на нечетных позициях = " + sum);