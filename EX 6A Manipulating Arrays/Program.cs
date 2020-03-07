using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A_Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            countsNumOFElements(); // calling the method to see the result
            Console.ReadLine();

            reversingArray();
            Console.ReadLine();

            RotatingArrB();

            RotatingArrA();

            RotatingArrC();

            sortingArray();
            Console.ReadLine();         
        }

        // Problem #1. Write a method counts the number of elements in an integer array, and then sums the elements in an integer array
        public static void countsNumOFElements()
        {
            int sum = 0;
            int[] arrA = { 0, 2, 4, 6, 8, 10 }; // defining the array
            int[] arrB = { 1, 3, 5, 7, 9 };
            int[] arrC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            
            for (int i = 0; i < arrA.Length; i++) // inputing the array parameters
            {
                sum += arrA[i];  // sum = sum + arrA[i]             
            }
            int avg = sum / arrA.Length; // calculating the average of the sum and array
            Console.WriteLine($"The average is {avg}"); // printing the average to the screen

            for (int i = 0; i < arrB.Length; i++) // inputing the array parameters
            {
                sum += arrB[i]; // sum = sum + arrB[i]

            }
            int avg2 = sum / arrB.Length; // calculating the average of the sum and array
            Console.WriteLine($"The average is {avg2}"); // printing the average to the screen

            for (int i = 0; i < arrC.Length; i++) // inputing the array parameters
            {
                sum += arrC[i]; // sum = sum + arrC[i]

            }
            int avg3 = sum / arrC.Length; // calculating the average of the sum and array
            Console.WriteLine($"The average is {avg3}"); // printing the average to the screen
        }

        // Problem #2. Write a method that accepts an array as an argument and prints the reversed array.
        public static void reversingArray()
        {
            //  length( 1, 2, 3, 4, 5)       
            int[] B = { 1, 3, 5, 7, 9 };
            //  index ( 0, 1, 2, 3, 4)

            //solution will = (9, 7, 5, 3, 1)

            int revB = 0;          
       
            for (int i = 0; i < B.Length; i++)
            {                
                revB = B[Math.Abs(i-4)]; // revB = array B |i-4| 
                Console.WriteLine($"Print the reverse array {revB}");
            }           

        }
        // Problem #3. Write a method that accepts three parameters, a direction (right or left), a number of places, and an array, which prints the appropriate rotation.
        public static void RotatingArrB()
        {
            
            int[] arrB = { 1, 3, 5, 7, 9 }; // move 2 places to the right
            Console.WriteLine("Please enter a value to rotate the array to the right");
            int uinput = int.Parse(Console.ReadLine());
            int roB = 0;
            
            int roC = 0;
            for (int i = 0; i < arrB.Length; i++)
            {             
                roB = arrB[(i + (uinput+1)) % arrB.Length];
                Console.WriteLine($"Rotating Array B two places to the right equals {roB}");
            }         

        }
        public static void RotatingArrA() // Rotating Array A to the left two times
        {
            int[] arrA = { 0, 2, 4, 6, 8, 10 }; // move 2 places to the left = 4, 6, 8, 10, 0, 2
            int roA = 0;
            Console.WriteLine("Please enter a value to rotate the array to the left");
            int uinput = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrA.Length; i++)
            {
                roA = arrA[(i + uinput) % arrA.Length];
                Console.WriteLine($"Rotating Array A two places to the right equals {roA}");
            }
        }
       public static void RotatingArrC() // Rotating Array C to the left four times
        {
            int[] arrC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }; // move 4 places to the left
            int roC = 0;
            Console.WriteLine("Please enter a value to rotate the array to the left");
            int uinput = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrC.Length; i++)
            {
                roC = arrC[(i + uinput) % arrC.Length];
                Console.WriteLine($"Rotating Array A two places to the right equals {roC}");
            }
        }

        public static void sortingArray()
        {               
            int[] arrC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };              
            int sortC;  // temp variable to store arrC[k]       

            for (int i =0; i < arrC.Length; i++) // checking the value of i 
            {
                for(int k = i + 1; k < arrC.Length; k++) // Checking the values of k if k = i adding one
                {
                    if (arrC[i] > arrC[k]) // If Array C [i] is less than Array C [k] then perform the below formula.
                    {                       
                        // this formula sorts the numbers in the array.
                        sortC = arrC[i];
                        arrC[i] = arrC[k];
                        arrC[k] = sortC;                        
                    }
                }                
            }
            foreach (int value in arrC) // this prints all elements of an array
            {
                Console.WriteLine(value + " ");
            }
        }
    }
}
