
namespace Loops
{
    internal class Oppgave3
    {
        static public void Run()
        {
            bool myCounter = true;
            int number = 0;

            while (myCounter == true)
            {
                if (number > 10)
                {
                    myCounter = false;
                }
                Console.WriteLine("Runde nr:" + number);
                number++;
            }

        }
    }
}
