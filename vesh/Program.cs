Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] nums = new double[size];
FillArray(nums);
Console.WriteLine("Вот наш массив: ");
PrintArray(nums);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
        {
            max = nums[i];
        }
    if (nums[i] < min)
        {
            min = nums[i];
        }
}

Console.WriteLine($"всего {nums.Length} чисел/числа. Максимальное  = {max}, минимальное  = {min}");
Console.WriteLine($"Разница между максимальным и минимальным  = {max - min}");

void FillArray(double[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] nums)
{
    Console.Write("[ ");
    for(int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}