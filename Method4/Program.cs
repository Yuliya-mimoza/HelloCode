// Вид 4 (что-то принимает, что-то возвращает)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // равно пустой строке

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// Вызов
string res=Method4(10, "asdf");
Console.WriteLine(res);