using System;
Console.WriteLine("你好啊");
Console.WriteLine("要使用計算機還是玩猜數字");
Console.WriteLine("還是玩賓果?");
Console.WriteLine("使用計算機請輸入1");
Console.WriteLine("玩猜數字輸入2");
Console.WriteLine("玩賓果輸入3");
int mode = Convert.ToInt32(Console.ReadLine());
if (mode == 1)
{
    int yn;
    do
    {
        
        Console.WriteLine("請輸入數字");
        double number1 =Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("請輸入運算符號(+)(-)(*)(/)");
        var _ = Console.ReadLine();
        Console.WriteLine("請輸入數字");
        double number2 = Convert.ToDouble(Console.ReadLine());
        if (_ == "+")
        {
            Console.Write("=");
            Console.Write(number1 + number2);
        }
        else if (_ == "-")
        {
            Console.Write("=");
            Console.Write(number1 - number2);
        }
        else if (_ == "*")
        {
            Console.Write("=");
            Console.Write(number1 * number2);
        }
        else if (_ == "/")
        {
            Console.Write("=");
            Console.Write(number1 / number2);
        }
        Console.WriteLine("要繼續計算嗎");
        Console.WriteLine("要繼續填1");
        Console.WriteLine("不要繼續填2");
       yn=Convert.ToInt32(System.Console.ReadLine());
    }
    while (yn != 2);
}
    if (mode == 2)
    {
        Random random = new Random();
        int au2u = random.Next(1, 100);
      
        int answer;
        int time = 5;
        do
        {
            Console.WriteLine("請輸入您猜的數字");
            Console.WriteLine("機會只有5次，請留意");
            answer =Convert.ToInt32(Console.ReadLine());
            time = time - 1;
            Console.WriteLine("剩" + time + "次");
            if (answer < au2u)
            {
                Console.WriteLine("在大一點");
            }
            else if (answer > au2u)
            {
                Console.WriteLine("在小一點");
            }
            else
            {
             Console.WriteLine("恭喜你答對了");
            }
        }
        while (answer != au2u && time != 0);
    }
if (mode==3) 
{
    int x = 0;
    int y = 0;
   
    int[,] ints =new int[3,3];

    do
    {
        Console.WriteLine("請填入" + "第" + (x + 1) + "列" + "第" + (y + 1) + "行" + "數字(1~9)且不重複");
        ints[x, y] = Convert.ToInt32(Console.ReadLine());
        Console.Write($"[{ints[0, 0]}]");
        Console.Write($"[{ints[1, 0]}]");
        Console.WriteLine($"[{ints[2, 0]}]");
        Console.Write($"[{ints[0, 1]}]");
        Console.Write($"[{ints[1, 1]}]");
        Console.WriteLine($"[{ints[2, 1]}]");
        Console.Write($"[{ints[0, 2]}]");
        Console.Write($"[{ints[1, 2]}]");
        Console.WriteLine($"[{ints[2, 2]}]");
        x = x + 1;
        if (x == 3)
        {
            y = y + 1;
            x = 0;
        }
    } while (x >= 1 || y <= 2); 

   Console.WriteLine("正在生成...");
    int[] ints2 = { 2, 1, 9,
                    7, 3, 8, 
                    4, 6, 5 };
    int[,] ints3 = new int[3, 3];
    if (ints[0, 0] == ints2[0])
    {
        ints3[0, 0] = 1;
    }
    if (ints[1, 0] == ints2[1])
    {
        ints3[1, 0] = 1;
    }
    if (ints[2, 0] == ints2[2])
    {
        ints3[2, 0] = 1;
    }
    if (ints[0, 1] == ints2[3])
    {
        ints3[0, 1] = 1;
    }
    if (ints[1, 1] == ints2[4])
    {
        ints3[1, 1] = 1;
    }
    if (ints[2, 1] == ints2[5])
    {
        ints3[2, 1] = 1;
    }
    if (ints[0, 2] == ints2[6])
    {
        ints3[0, 2] = 1;
    }
    if (ints[1, 2] == ints2[7])
    {
        ints3[1, 2] = 1;
    }
    if (ints[2, 2] == ints2[8])
    {
        ints3[2, 2] = 1;
    }
    Console.Write(ints3[0, 0]);
    Console.Write(ints3[1, 0]);
    Console.WriteLine(ints3[2, 0]);
    Console.Write(ints3[0, 1]);
    Console.Write(ints3[1, 1]);
    Console.WriteLine(ints3[2, 1]);
    Console.Write(ints3[0, 2]);
    Console.Write(ints3[1, 2]);
    Console.WriteLine(ints3[2, 2]);
    int bingo = 0;
    if (ints3[0, 0] == 1 && ints3[1, 0] == 1 && ints3[2, 0] == 1)
    {
        bingo++;
    }
    else if (ints3[0, 1] == 1 && ints3[1, 1] == 1 && ints3[2, 1] == 1)
    {
        bingo++;
    }
    else if (ints3[0, 2] == 1 && ints3[1, 2] == 1 && ints3[2, 2] == 1)
    {
        bingo++;
    }
    //橫
    if (ints3[0, 0] == 1 && ints3[0, 1] == 1 && ints3[0, 2] == 1)
    {
        bingo++;
    }
    else if (ints3[1, 0] == 1 &&  ints3[1, 1] == 1 && ints3[1, 2] == 1)
    {
        bingo++;
    }
    else if (ints3[2, 0] == 1 && ints3[2, 1] == 1 && ints3[2, 2] == 1)
    {
        bingo++;
    }
    //縱
    if (ints3[0, 0] == 1 && ints3[1, 1] == 1 && ints3[2, 2] == 1)
    {
        bingo++;
    }
    else if (ints3[2, 0] == 1 && ints3[1, 1] == 1 && ints3[0, 2] == 1)
    {
        bingo++;
    }
    //斜
    if(bingo == 0 ){ Console.WriteLine("沒中獎，真可惜" ); }
    Console.WriteLine($"共有{bingo}條連線");

}










