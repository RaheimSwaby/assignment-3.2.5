namespace assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {                 //0   1  2
            int[] array1 = { 1, 5, 3 };
            int[] array2 = { 9, 8, 3 };
            int[] array3 = { 1, 2, 3 };

            Console.WriteLine("the first array");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("|");
                Console.Write($"{array1[i]}");
                Console.Write("|");
            }

            Console.WriteLine("\nEnter a number to search in the first array:");
            int searchNumber1 = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(array1, searchNumber1);
            if (index >= 0)
            {
                Console.WriteLine($"The number {searchNumber1} is found at index ==> {index}");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber1} is not in the array. Returning -1.");
                index = -1; 
            }

            Console.WriteLine("the second array");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("|");
                Console.Write($"{array2[i]}");
                Console.Write("|");
            }
            Console.WriteLine("\nenter a number to search in the second array");
            int searchnumber2 = Convert.ToInt32(Console.ReadLine());
            int index1 = Array.IndexOf(array2, searchnumber2);
            if (index1 >= 0)
            {
                Console.WriteLine($"The number {searchnumber2} is found at index ==> {index1}");
            }
            else
            {
                Console.WriteLine($"The number {searchnumber2} is not in the array. Returning -1.");
                index1 = -1;
            }

            Console.WriteLine("the second array");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write("|");
                Console.Write($"{array3[i]}");
                Console.Write("|");
            }
            Console.WriteLine("\nenter a number to search in the second array");
            int searchnumber3 = Convert.ToInt32(Console.ReadLine());
            int index2 = Array.IndexOf(array3, searchnumber3);
            if (index2 >= 0)
            {
                Console.WriteLine($"The number {searchnumber3} is found at index ==> {index2}");
            }
            else
            {
                Console.WriteLine($"The number {searchnumber3} is not in the array. Returning -1.");
                index2 = -1;
            }




             




        }
    }
}
