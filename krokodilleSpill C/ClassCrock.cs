using System;

namespace krokodilleSpill_C
{
    internal class ClassCrock
    {
        private int firstBite = 0;
        private int secondBite = 0;
        private int points = 0;
        private string greaterLesser = "";  

        public void Main()
        {
            Console.WriteLine("Krokodille Spill");
            Console.WriteLine("Skriv '<', '>' eller '=' for å sammenligne tallene");
            RandomNumber();
        }


        public void SubmitBtn()
        {
            CorrectWrongAnswer();
            RandomNumber();  
        }

        public void CorrectWrongAnswer()
        {
            bool isCorrect = false;

            if ((greaterLesser == "<" && firstBite < secondBite) ||
                (greaterLesser == "=" && firstBite == secondBite) ||
                (greaterLesser == ">" && firstBite > secondBite))
            {
                isCorrect = true;
                points++;
                Console.WriteLine($"Riktig! Poeng: {points}");
            }
            else
            {
                points--;
                Console.WriteLine($"Feil! Poeng: {points}");
            }
        }

        public void RandomNumber()
        {
            Random random = new Random();
            firstBite = random.Next(1, 11);  
            secondBite = random.Next(1, 11);
            Console.WriteLine($"Tallene er: {firstBite} og {secondBite}");
            greaterLesser = Console.ReadLine();
        }
    }
}
