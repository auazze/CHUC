string[] fruits = { "апельсин", "яблоко", "клубника" };

//по отдельности
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);

Console.WriteLine(fruits[^1]);
Console.WriteLine(fruits[^2]);
Console.WriteLine(fruits[0]);

//в разные строки и просто
for (int i = 0; i < fruits.Length; i++)
    Console.WriteLine($"Циклом for в правильном порядке: {fruits[i]}");

int j = 0;
while (j  < fruits.Length)
{
    Console.WriteLine($"Циклом while в правильном порядке: {fruits[j]}");
    j++;
}

for (int ii = fruits.Length - 1; ii >= 0; ii--)
    Console.WriteLine($"Циклом for в обратном порядке: {fruits[ii]}");

int jj = fruits.Length - 1;
while (jj >= 0)
{
    Console.WriteLine($"Циклом while в обратном порядке: {fruits[jj]}");
    jj--;
}

// в одну строку и тяжелее
string result_for1 = "";
for (int iii = 0; iii < fruits.Length; iii++)
{
    result_for1 += fruits[iii] + (iii < fruits.Length - 1 ? ", " : "");
}
Console.WriteLine(result_for1);

string result_while1 = "";
int jjj = 0;
while (jjj < fruits.Length)
{
    result_while1 += fruits[jjj] + (jjj < fruits.Length - 1 ? ", " : "");
    jjj++;
}
Console.WriteLine(result_while1);

string result_for2 = "";
for (int iiii = fruits.Length - 1; iiii >= 0; iiii--)
{
    result_for2 += fruits[iiii] + (iiii > 0 ? ", " : "");
}
Console.WriteLine(result_for2);

string result_while2 = "";
int jjjj = fruits.Length - 1;
while (jjjj >= 0)
{
    result_while2 += fruits[jjjj] + (jjjj > 0 ? ", " : "");
    jjjj--;
}
Console.WriteLine(result_while2);