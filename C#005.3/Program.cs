Random rand = new Random();
int rand1 = rand.Next(0,99);
int[] mas = new int[rand1];
Random ran = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = ran.Next(-1000,1000);
}
int max = mas[0];
int min = mas[0];
for (int j = 1; j < mas.Length; j++)
  {
    if (max < mas[j])
    {
      max = mas[j];
    }
    if (min > mas[j])
    {
    min = mas[j];
    }
  }
int res = max - min;
Console.Write("Разница между мах и мин элементами массива = " + res);