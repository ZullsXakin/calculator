double a;
double b;
double total;
char oper;


while (true)
{
    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());
    
    
    switch (oper.ToString())
    {
        case "+":
            total = a + b;
            Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            break;
    
        case "-":
            total = a - b;
            Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            break;
    
        case "*":
            total = a * b;
            Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            break;
    
        case "/":
            total = a * b;
            Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            break;
        default:
            Console.WriteLine("Неизвестный оператор.");
            break;
    }
    Console.WriteLine("Нажмите Entr чтобы очистить.");
    Console.ReadLine();
    Console.Clear();
}
    
