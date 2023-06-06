// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int ack(int m, int n) {
    if(m == 0) return n + 1;
    else if(n == 0) return ack(m - 1, 1);
return ack(m - 1, ack(m, n - 1));
}

msgStyle("Введиче m: ", "Blue", 0);
int m = Convert.ToInt32(consoleRead(2));
Console.WriteLine();

msgStyle("Введиче n: ", "Blue", 0);
int n = Convert.ToInt32(consoleRead(2));
Console.WriteLine();

msgStyle($"m = {m}, n = {n} -> A({m}, {n}) = {ack(m, n)}", "Green", 0);


