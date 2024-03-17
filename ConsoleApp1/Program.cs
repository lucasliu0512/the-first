// See https://aka.ms/new-console-template for more information
Console.WriteLine("數字()中有幾個6的倍數但不是5的倍數?");
int z = Convert.ToInt32(Console.ReadLine());
int a6 = z / 6;
Console.WriteLine($"5的倍數有{a6}個");
int a30 = z / 30;
Console.WriteLine($"共同的倍數有{a30}個");
Console.WriteLine($"A:{a6-a30}個");
