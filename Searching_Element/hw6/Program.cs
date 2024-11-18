using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int index = 5;
            int[] A = new int[index];
            Console.WriteLine("Index\tElement");
            for(int i =0; i < index; i++)
            {
                Console.Write(i + "\t");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What elemet you are searching for?");
            int key = int.Parse(Console.ReadLine());
            int result = Search(A, key);
            if(result != -1)
            {
                Console.WriteLine("The index of searching socre postion is {0}", result);
            }
            else
            {
                Console.WriteLine("Not find it");
            }
          
            /*const int numOfStudents = 4;
            int[] scores = new int[numOfStudents];
            bool valid;

            for (int i = 0; i < numOfStudents; i++)
            {
                do
                {
                    Console.Write("Enter score for student #{0}: ", i + 1);
                    valid = int.TryParse(Console.ReadLine(), out scores[i]);
                    if (!valid)
                        Console.WriteLine("Invalid! Please re-enter.");
                } while (!valid);
 
            }

            
            int key;
            Console.WriteLine("What number you are searching for?");
            key = int.Parse(Console.ReadLine());
            
            int position = Array.IndexOf(scores, key);
                if (position != -1)
                {
                    Console.WriteLine("Found the searching score index #{0} the score is {1}", position + 1, key);

                }
                else
                {
                    Console.WriteLine("Not Found it");

                }*/


            /* bool found = false;
             for (int i = 0; i < numOfStudents; i++)
             {
                 if (scores[i] == 100)
                 {
                     Console.WriteLine("Student #{0} earns 100%.", i + 1);
                     found = true;

                 }
             }

             if (!found)
             {
                 Console.WriteLine("None of the students earn 100%.");
             }*/


            Console.Read();
        }

        static int Search(int[] A, int key)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
            
            
            
        
  