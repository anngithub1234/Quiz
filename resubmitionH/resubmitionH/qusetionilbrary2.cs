using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{
    class qusetionilbrary2
    {
        //list of 2nd set
        List<quizQuestionSub2> question2 = new List<quizQuestionSub2>()
            {

                new quizQuestionSub2("Ozone layer which is responsible for the absorption of UV light is in Stratosphere\n","( It is the second layer)", new string[]{"True", "False"}, 0),
                new quizQuestionSub2("largest source of world's commercial energy consumption is Coal\n","( constitutes around 39%)", new string[]{"True", "False"}, 1),
                new quizQuestionSub2("World's largest potential source of biomass energy is Fibrous waste of the sugar industry\n","( Termed as Bagasse)", new string[]{"True", "False"}, 0)
                


            };

        List<quizQuestionSub2> question4 = new List<quizQuestionSub2>()
            {

                new quizQuestionSub2("Green pigment used in photosynthesis is Chorophyll\n","( present in the plant cell)", new string[]{"True", "False"}, 0),
                new quizQuestionSub2("Chlorophyll is mainly located in Barks\n","( In greener areas)", new string[]{"True", "False"}, 1),
                new quizQuestionSub2("Respiration in plants takes place only in evening\n","( Process that is used to release energy from the organic compounds)", new string[]{"True", "False"}, 1)


            };

        public void TestwithHints1()
        {

            int score = 0;
            int testque = 0;
            int qTest = 1;
            // sane steps as first set
            while (testque < question4.Count)
            {
                // Display 
                Console.WriteLine(qTest + ")" + question4[testque].Questions + "Hints:" + question4[testque].Hint);
                for (int i = 0; i < question4[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question4[testque].Answer[i]}");
                }

                // Get input
                Console.Write("Enter the answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                // Check input
                if (userAnswer == question4[testque].CoAnsw)
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                testque++;
                qTest++;

            }

            // Display the final score
            Console.WriteLine($"Final score is: {score}/{question4.Count}");
            if (score == 0)
            {
                Console.WriteLine("Achieved 0 stars");
            }
            else if (score == 1)
            {
                Console.WriteLine("Achieved * stars");
            }
            else if (score == 2)
            {
                Console.WriteLine("Achieved ** stars");
            }
            else if (score == 3)
            {
                Console.WriteLine("Achieved *** stars");
            }


        }

        public void TestwithHints()
        {

            int score = 0;
            int testque = 0;

            while (testque < question2.Count)
            {
                Console.WriteLine(question2[testque].Questions + "Hints:" + question2[testque].Hint);
                for (int i = 0; i < question2[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question2[testque].Answer[i]}");
                }

                Console.Write("Enter the answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                if (userAnswer == question2[testque].CoAnsw)
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

                testque++;
            }

            Console.WriteLine($"Final score is: {score}/{question2.Count}");
            if (score == 0)
            {
                Console.WriteLine("Achieved 0 stars");
            }
            else if (score == 1)
            {
                Console.WriteLine("Achieved * stars");
            }
            else if (score == 2)
            {
                Console.WriteLine("Achieved ** stars");
            }
            else if (score >= 3)
            {
                Console.WriteLine("Achieved *** stars");
            }



        }


        public void addQuizWithHints1()
        {
            Console.WriteLine("Add a new question:");
            string testh = Console.ReadLine();
            Console.WriteLine("Add the four answers");
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            Console.WriteLine("Add the correct answer: ");
            int AnswerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add the Hint:");
            string hint = Console.ReadLine();
            int AnswerIndex1 = AnswerIndex - 1;

            question2.Add(new quizQuestionSub2(testh, hint, new string[] { answer1, answer2 }, AnswerIndex1));

            int testque = 0;


            // Same
            while (testque < question2.Count)
            {
                Console.WriteLine(question2[testque].Questions + "Hint:" + question2[testque].Hint);
                for (int i = 0; i < question2[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question2[testque].Answer[i]}");
                }


                testque++;
            }

        }
        public void addQuizWithHints2()
        {
            Console.WriteLine("Add a new question:");
            string testh = Console.ReadLine();
            Console.WriteLine("Add the four answers");
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            Console.WriteLine("Add the correct answer: ");
            int AnswerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add the Hint:");
            string hint = Console.ReadLine();
            int AnswerIndex1 = AnswerIndex - 1;

            question4.Add(new quizQuestionSub2(testh, hint, new string[] { answer1, answer2 }, AnswerIndex1));

            int testque = 0;

            while (testque < question4.Count)
            {

                Console.WriteLine(question4[testque].Questions + "Hint:" + question4[testque].Hint);
                for (int i = 0; i < question4[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question4[testque].Answer[i]}");

                }

                testque++;
            }

        }

        public void updateQusetion1(int numq)
        {
            question2.RemoveAt(numq - 1);
        }
        public void updateQusetion(int numq)
        {
            
            question4.RemoveAt(numq - 1);
        }

       

        

    }
}

