Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArray(nums);
Console.WriteLine("Это ваш массив: ");
PrintArray(nums);
int crex = 0;

for (int i = 0; i < nums.Length; i++)
if (nums[i] % 2 == 0)
crex ++;

Console.WriteLine($"всего {nums.Length} чисел/числа, {crex} из них чётные");

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

