int[] array = new int[] { 1, 2, 3, 4 };

int[] result;

if (array.Length % 2 == 0)
{
    result = new int[array.Length / 2];
}
else
{
    result = new int[array.Length / 2 + 1];
}

for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
{
    result[i] = array[i] * array[j];
}

if (array.Length % 2 != 0)
{
    result[result.Length - 1] = array[array.Length / 2];
}

for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

