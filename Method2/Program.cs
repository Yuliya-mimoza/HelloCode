// Вид2
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Вызов
Method2("Текст сообщения");*/




// Вид21
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Вызов
//Method21("Текст сообщения", 4);
Method21(count:4,msg:"Текст"); // конкретно прописываем для переменных