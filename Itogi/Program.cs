// Итоговый проект
// Из имеющегося массива создать массив из строк менее 3 символов

Console.Clear();

String[] base_array = {"hello","2","world",":-)"};

int k = 0;

for (int i = 0; i < base_array.Length; i++)
{
    if (base_array[i].Length <= 3)
        k = k + 1;

}    

Console.WriteLine(k);
