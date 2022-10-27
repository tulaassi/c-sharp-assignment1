using System;
namespace studentMarks
{
    public class student
    {
        public static void main()
        {
            try
            {


                int[] marks = new int[6];
                int sum = 0;
                float average;
                int highest = 0;
                Console.WriteLine("enter marks");
                for (int i = 0; i < marks.Length; i++)
                {
                    marks[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < marks.Length; i++)
                {
                    sum += marks[i];
                    if (marks[i] > highest)
                    {
                        highest = marks[i];

                    }
                }
                average = sum / 6;
                Console.WriteLine("average={0} highest{1}", average, highest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.ReadLine();

        }



    }
}



        

        
        
   

