Console.WriteLine("Укажите целое число отличное от нуля - количество элементов для проверки");
string? x = Console.ReadLine();
bool check1 = int.TryParse(x, out int x1);
if(check1 != true || x1 < 1) 
{
Console.WriteLine("Ваш ввод не соответствует условию, попробуйте снова");
return;
}

string[] array1 = new string[x1];
#nullable disable
for(int i = 0; i < x1; i ++) // Заполняем массив элементами
{
    Console.WriteLine($"Введите {i + 1} элемент для проверки");
    array1[i] = Console.ReadLine();
}

int counter = 0; // Ищем число элементов соответствующих условию
for(int j = 0; j < x1; j ++)
{
    if(array1[j].Length <= 3)
    {
        counter ++;
    }
}

if(counter < 1)
{
   Console.WriteLine("Не найдено ни одного элемента");
   return; 
}

string[] array2 = new string[counter]; // Создаём массив и заполняем его нужными нам элементами

int u = 0;
for(int k = 0; k < x1; k ++)
{
    if(array1[k].Length <= 3)
    {
        array2[u] = array1[k];
        u ++;
    }
}

void PrintArray(string[] array, int lenght) // Метод вывода одномерного массива
{
    Console.Write("[");
    for(int o = 0; o < lenght; o++)
    {
        Console.Write(array[o]);
        if(o < lenght - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write("]");
        }
    }
}

PrintArray(array2, counter); // Выводим ответ
