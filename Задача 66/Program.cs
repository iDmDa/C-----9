// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void msgStyle (string message, string status = "Green", int newLine = 1) {
    //Black, DarkBlue, DarkGreen, DarkCyan, 
    //DarkRed, DarkMagenta, DarkYellow, Gray, 
    //DarkGray, Blue, Green, Cyan, 
    //Red, Magenta, Yellow, White

    var cons_color = new Dictionary<string, int>();
    for (int i = 0; i < 16; i++) cons_color.Add(((ConsoleColor)i).ToString(), i);

    Console.ForegroundColor = (ConsoleColor)cons_color[status];
    if(newLine == 1) Console.WriteLine(message);
    else Console.Write(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

string consoleRead(int len, string charList = "1234567890") {  //Ограничение ввода с клавиатуры
    string str = string.Empty;
    while (true)
    {
        char ch = Console.ReadKey(true).KeyChar;
        if (ch == '\r' && str.Length > 0) break;
        if (ch == 'q' || ch == 'Q') System.Environment.Exit(0);
        if (ch == '\b' && str.Length > 0) {
                str = str.Substring(0, str.Length - 1);
                Console.Write("\b \b");
        }
        else if (str.Length < len && charList.IndexOf(ch) != -1)
        {
            if(ch == '-' && str.Length > 0) continue;
            Console.Write(ch);
            str += ch;
        }
    }
    return str;
}

int numList (int m, int n) {
    if(n == m) return n;
    return (n--)+ numList(m, n) ;
}

msgStyle("Введиче первое число: ", "Blue", 0);
int n = Convert.ToInt32(consoleRead(2));
Console.WriteLine();

msgStyle("Введиче второе число: ", "Blue", 0);
int m = Convert.ToInt32(consoleRead(2));
Console.WriteLine();

if(n > m) msgStyle($"m = {m}; n = {n} -> {numList(m, n)}");
else msgStyle($"n = {n}; m = {m} -> {numList(n, m)}");