namespace Challenge3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sortedArray = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            Console.WriteLine("Start");
            BinarySearch(sortedArray, 65);
        }
        public static int BinarySearch(int[] array, int key)
        {
            int median = 0;
            int L = 0;
            int R = array.Length - 1;
            while (L <= R)
            {
                median = (L + R) / 2;
                if (array[median] > key)
                {
                    R = median;
                }
                else if (array[median] < key)
                {
                    L = median;
                }
                else if (array[median] == key)
                {
                    Console.WriteLine("Found it!");
                    break;
                }
            }
            Console.WriteLine(median);
            return median;
        }

    }
}