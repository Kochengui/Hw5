Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArray(nums);
Console.WriteLine("Вот наш массив: ");
PrintArray(nums);
int sum = 0;

for (int i = 0; i < nums.Length; i+=2)
    sum = sum + nums[i];

    Console.WriteLine($"всего {nums.Length} чисел/числа, сумма элементов на нечётных позициях = {sum}");

void FillArray(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] nums)
{
    Console.Write("[ ");
    for(int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}