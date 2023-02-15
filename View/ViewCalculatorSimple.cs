class ViewCalculatorSimple
{
    CalculatorSimple model = new CalculatorSimple();

    // вывод панели калькулятора в консоль
    public void inputPanel()
    {
        Console.WriteLine();
        Console.WriteLine("Панель ввода калькулятора");
        Console.WriteLine("=====================================");
        foreach (int number in model.getNumberButtons())
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Операции:");
        foreach (string s in model.getActionButtons())
        {
            Console.Write($"{s}\t");
        }
        Console.WriteLine();
        Console.WriteLine("=====================================");
    }

    // запрос ввода числа
    public float enterNumber()
    {
        float number = 0;
        while (number == 0)
        {
            Console.WriteLine("Введи число");
            number = (float)Convert.ToDouble(Console.ReadLine());
        }
        return number;
    }

    // запрос ввода операции
    public string enterAction()
    {
        Console.WriteLine("Введи операцию");
        string? action = Console.ReadLine();
        if (action == null)
        {
            action = "-1";
        }
        else
        {
           return action;
        }
        return action;
    }

    public void resultDisplay(String display)
    {
        Console.WriteLine("Результат:");
        Console.WriteLine(display);
    }
}