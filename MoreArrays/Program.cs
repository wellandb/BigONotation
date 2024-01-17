namespace MoreArrays
{
    internal class Program
    {
        public static int SumArray(int[] arr)
        {
            int total = 0;
            foreach (int i in arr)
            {
                total += i;
            }
            return total;
        }
        public static int SequentialSearch(int[] arr, int val)
        {
            int index = 0;
            foreach(int i in arr)
            {
                if (i == val)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int val)
        {
            int mid;
            int low = 0, high = arr.Length - 1;
            while(low <= high)
            {
                mid = (low + high) / 2;
                if (arr[mid] == val)
                {
                    return mid;
                }else if (arr[mid] < val)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr =new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int i in arr)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\nSum of values in array:"+ SumArray(arr));
            Console.ReadLine();
            int search = 5;
            Console.WriteLine("SequentialSearch for index of 5: {0}", SequentialSearch(arr, search));
            Console.ReadLine();
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10, 11, 12, 13, 15, 20};
            search = 15;
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\nBinarySearch for index of 15: {0}", BinarySearch(arr, search));
            Console.ReadLine();
            
        }
    }
}
