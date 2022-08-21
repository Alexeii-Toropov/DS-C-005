Random rand = new Random();
int rand1 = rand.Next(0,99);
int[] mas = new int[rand1];
Random ran = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = ran.Next(0,100);
}
int j = 1;
int l = 0;
int count = 0;
int del = mas.Length/2;
while (del > 0)
{
    count = mas[l] * mas[mas.Length-j];
    Console.Write(count + " ");
    del--;
    j++;
    l++;
    count = 0;
}
