/*
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый -
на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] array = { 1, 2, 3, 4, 5 };
int tmp = 0;
for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
{
    tmp = array[i];
    array[i] = array[j];
    array[j] = tmp;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
