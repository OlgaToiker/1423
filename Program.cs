string[] array1 = new string[16] { "У Лукоморья ", "дуб", " зелёный,", "Златая ", "цепь ", "на", " дубе ", "том", ", И днём,", "и ночью", "кот ", "учёный", "Всё", " ходит", "по цепи ", "кругом." };
string[] array2 = new string[array1.Length];
int n = 3;

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= n)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
