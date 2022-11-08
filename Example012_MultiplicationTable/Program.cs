// Вид 4 Таблица умножения (что-то принимает, что-то возвращает) через цикл FOR
    string result = String.Empty; // равно пустой строке
    for (int i=2; i<=10; i++)
    {
        for (int j=2; j<=10; j++)
        {
            Console.WriteLine($"{i}*{j}={i*j}");
        }
        Console.WriteLine();
    }