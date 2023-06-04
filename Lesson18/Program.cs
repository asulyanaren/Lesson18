namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i < 70; i++)
            {
                for (int j = i; j >= 1;) {
                   
                    if (j % 2 == 0)
                    {
                        j = j / 2;
                     }
                    else
                    {
                        j = (j *3 +1) / 2;
                     }
                    if (j==1) {
                        Console.WriteLine(j);
                        break;
                    }
                 }
               
            }
        }
    }
}