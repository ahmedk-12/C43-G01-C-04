namespace assingment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter a number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num1; i++)
            //{
            //    Console.Write(i + (i < num1 ? ", " : "\n"));
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter a number for multiplication table: ");
            //int num2 = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num2} x {i} = {num2 * i}");
            //}
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a number to print even numbers: ");
            //int num3 = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= num3; i += 2)
            //{
            //    Console.Write(i + (i < num3 - 1 ? " " : "\n"));
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.Write("Enter base number: ");
            //int baseNum = int.Parse(Console.ReadLine());
            //Console.Write("Enter power: ");
            //int power = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= baseNum;
            //}
            //Console.WriteLine($"Result: {result}");
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //int total = 0;
            //Console.WriteLine("Enter marks for 5 subjects:");
            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter a string to reverse: ");
            //string inputString = Console.ReadLine();
            //char[] chars = inputString.ToCharArray();
            //Array.Reverse(chars);
            //Console.WriteLine(new string(chars));
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter an integer to reverse: ");
            //int num4 = int.Parse(Console.ReadLine());
            //int reversedNum = 0;
            //while (num4 > 0)
            //{
            //    reversedNum = reversedNum * 10 + num4 % 10;
            //    num4 /= 10;
            //}
            //Console.WriteLine($"Reversed Number: {reversedNum}");
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Enter the start of the range: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter the end of the range: ");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine("Prime numbers in the range:");
            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;
            //    if (i < 2) isPrime = false;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime) Console.Write(i + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert to binary: ");
            //int num5 = int.Parse(Console.ReadLine());
            //string binary = "";
            //while (num5 > 0)
            //{
            //    binary = (num5 % 2) + binary;
            //    num5 /= 2;
            //}
            //Console.WriteLine($"Binary: {binary}");
            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter three points (x1, y1), (x2, y2), (x3, y3):");
            //Console.Write("x1: "); int x1 = int.Parse(Console.ReadLine());
            //Console.Write("y1: "); int y1 = int.Parse(Console.ReadLine());
            //Console.Write("x2: "); int x2 = int.Parse(Console.ReadLine());
            //Console.Write("y2: "); int y2 = int.Parse(Console.ReadLine());
            //Console.Write("x3: "); int x3 = int.Parse(Console.ReadLine());
            //Console.Write("y3: "); int y3 = int.Parse(Console.ReadLine());
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a straight line.");
            //}
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter size of identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write((i == j ? 1 : 0) + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];
            //int sum = 0;
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //    sum += array[i];
            //}
            //Console.WriteLine($"Sum of all elements: {sum}");
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter the size of the arrays: ");
            //int size13 = int.Parse(Console.ReadLine());
            //int[] array1 = new int[size13];
            //int[] array2 = new int[size13];
            //int[] mergedArray = new int[2 * size13];
            //Console.WriteLine("Enter elements of the first array in sorted order:");
            //for (int i = 0; i < size13; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter elements of the second array in sorted order:");
            //for (int i = 0; i < size13; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Copy(array1, mergedArray, size13);
            //Array.Copy(array2, 0, mergedArray, size13, size13);
            //Array.Sort(mergedArray);
            //Console.WriteLine("Merged and sorted array:");
            //Console.WriteLine(string.Join(" ", mergedArray));
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine("Enter the size of the array: ");
            //int size14 = int.Parse(Console.ReadLine());
            //int[] freqArray = new int[size14];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size14; i++)
            //{
            //    freqArray[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Frequency of each element:");
            //for (int i = 0; i < size14; i++)
            //{
            //    if (Array.IndexOf(freqArray, freqArray[i]) == i)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < size14; j++)
            //        {
            //            if (freqArray[i] == freqArray[j]) count++;
            //        }
            //        Console.WriteLine($"{freqArray[i]}: {count}");
            //    }
            //}
            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.WriteLine("Enter the size of the array: ");
            //int size15 = int.Parse(Console.ReadLine());
            //int[] array15 = new int[size15];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size15; i++)
            //{
            //    array15[i] = int.Parse(Console.ReadLine());
            //}
            //int max = array15[0], min = array15[0];
            //for (int i = 1; i < size15; i++)
            //{
            //    if (array15[i] > max) max = array15[i];
            //    if (array15[i] < min) min = array15[i];
            //}
            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine("Enter the size of the array: ");
            //int size16 = int.Parse(Console.ReadLine());
            //int[] array16 = new int[size16];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size16; i++)
            //{
            //    array16[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(array16);
            //Console.WriteLine($"Second largest element: {array16[size16 - 2]}");
            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as in this Example
            //Console.WriteLine("Enter the size of the array: ");
            //int size17 = int.Parse(Console.ReadLine());
            //int[] array17 = new int[size17];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size17; i++)
            //{
            //    array17[i] = int.Parse(Console.ReadLine());
            //}
            //int maxDistance = 0;
            //for (int i = 0; i < size17; i++)
            //{
            //    for (int j = i + 1; j < size17; j++)
            //    {
            //        if (array17[i] == array17[j])
            //        {
            //            maxDistance = Math.Max(maxDistance, j - i);
            //        }
            //    }
            //}
            //Console.WriteLine($"Longest distance: {maxDistance}");
            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("Enter a sentence: ");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine($"Reversed sentence: {string.Join(" ", words)}");
            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.WriteLine("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());
            //int[,] array19 = new int[rows, cols];
            //int[,] copyArray19 = new int[rows, cols];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array19[i, j] = int.Parse(Console.ReadLine());
            //        copyArray19[i, j] = array19[i, j];
            //    }
            //}
            //Console.WriteLine("Copied array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(copyArray19[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("Enter the size of the array: ");
            //int size20 = int.Parse(Console.ReadLine());
            //int[] array20 = new int[size20];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size20; i++)
            //{
            //    array20[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(array20);
            //Console.WriteLine($"Reversed array: {string.Join(" ", array20)}");
            #endregion

        }
    }
}
