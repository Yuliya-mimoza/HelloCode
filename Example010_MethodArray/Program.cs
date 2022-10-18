// программа, поиска заданного элемента в массиве
int[] array = { 1, 29, 31, 18, 4, 53, 62, 7, 18 };
int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}