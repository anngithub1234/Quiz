using System;
using System.Collections.Generic;
using System.Text;

namespace resubmitionH
{


    class qusetionilbrary1 
    {
        private static qusetionilbrary2 qusetionilbrary2 = new qusetionilbrary2();
        List<Students> student1 = new List<Students>();
        List<Tutor> tutor1 = new List<Tutor>();
        List<Examinator> examinator1 = new List<Examinator>();
        public qusetionilbrary1()
        { //list all of users
            student1.Add(new Students("Lisa"));
            student1.Add(new Students("Peter"));
            student1.Add(new Students("Elsa"));
            student1.Add(new Students("Ron"));

            tutor1.Add(new Tutor("Chris"));
            tutor1.Add(new Tutor("Alvin"));
            tutor1.Add(new Tutor("Julian"));

            examinator1.Add(new Examinator("Eric"));
            examinator1.Add(new Examinator("Jackson"));
        }


        List<quizQusetionsSub1> question1 = new List<quizQusetionsSub1>()
            {

                new quizQusetionsSub1("Ozone layer which is responsible for the absorption of UV light is in Stratosphere", new string[]{ "True", "False"}, 0),
                new quizQusetionsSub1("largest source of world's commercial energy consumption is Coal", new string[]{"True", "False", "Natural Gas", "Nuclear"}, 1),
                new quizQusetionsSub1("World's largest potential source of biomass energy is Fibrous waste of the sugar industry", new string[]{"True", "False"}, 0)

            };

        List<quizQusetionsSub1> question3 = new List<quizQusetionsSub1>()
            {


                new quizQusetionsSub1("Green pigment used in photosynthesis is Chorophyll", new string[]{ "True", "False"}, 0),
                new quizQusetionsSub1("Chlorophyll is mainly located in Barks", new string[]{"True", "False"}, 1),
                new quizQusetionsSub1("Respiration in plants takes place only in evening", new string[]{"True", "False"}, 1)

            };
        //validate all the users
        public void ValidatStId()
        {
            Console.WriteLine("Students Please Enter your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = student1.Find(student1 => student1.stid == id);
            if (st1 != null)
            {
                hints();
            }
            else { Console.WriteLine("Error: Input cannot be detected"); }
        }

        public void ValidatStId1()
        {
            Console.WriteLine("Students Please Enter your id::");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = student1.Find(student1 => student1.stid == id);
            if (st1 != null)
            {
                hints1();
            }
            else { Console.WriteLine("Error: Input cannot be detected"); }
        }

        public void ValidatTutId()
        {
            Console.WriteLine("Tutors Please Enter your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = tutor1.Find(tutor1 => tutor1.tutId == id);
            if (st1 != null)
            {
                Console.WriteLine("Enter 1 - Demo Quiz");
                Console.WriteLine("Enter 2 - Add Questions");
                Console.WriteLine("Enter 3 - Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints();
                        break;
                    case 2:
                        giveHints();
                        break;
                    case 3:
                        break;

                }


            }
            else { Console.WriteLine("Error: Input cannot be detected"); }
        }

        public void ValidatTutId1()
        {
            Console.WriteLine("Tutors Please Enter your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = tutor1.Find(tutor1 => tutor1.tutId == id);
            if (st1 != null)
            {
                Console.WriteLine("Enter 1 - Demo Quiz");
                Console.WriteLine("Enter 2 - Add Questions");
                Console.WriteLine("Enter 3 - Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints1();
                        break;
                    case 2:
                        giveHints1();
                        break;
                    case 3:
                        break;
                }


            }
            else { Console.WriteLine("Error: Input cannot be detected"); }
        }

        public void ValidatExId()
        {
            Console.WriteLine("Examinators Please Enter your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = examinator1.Find(examinator1 => examinator1.exId == id);
            if (st1 != null)
            {
                Console.WriteLine("Enter 1 - take Demo Quiz");
                Console.WriteLine("Enter 2 - Update Quiz");
                Console.WriteLine("Enter 3 - Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints();
                        break;
                    case 2:
                        updateQusetion();
                        break;
                    case 3:
                        break;

                }


            }
            else { Console.WriteLine("Error: Input cannot be detected"); }
        }


        public void ValidatExId1()
        {
            Console.WriteLine("Examinators Please Enter your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = examinator1.Find(examinator1 => examinator1.exId == id);
            if (st1 != null)
            {
                Console.WriteLine("Enter 1 - Demo Quiz");
                Console.WriteLine("Enter 2 - Update Quiz");
                Console.WriteLine("Enter 3 - Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints1();
                        break;
                    case 2:
                        updateQusetion1();
                        break;
                    case 3:
                        break;

                }

            }

        }

        // display quiz
        public void Test()
        {

            int score = 0;
            int testque = 0;
            int qTest = 1;
            // lop to dispay quiz
            while (testque < question1.Count)
            {
                // Display default ques and answ
                Console.WriteLine(qTest + ")" + question1[testque].Questions);
                for (int i = 0; i < question1[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question1[testque].Answer[i]}");
                }

                // Get User input and Check User input
                Console.Write("Enter the answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                if (userAnswer == question1[testque].CoAnsw)
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
            Console.WriteLine($"Final score is: {score}/{question1.Count}");
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

        public void Test1()
        {

            int score = 0;
            int testque = 0;
            int qTest = 1;
            // Same steps for quiz with hints
            while (testque < question3.Count)
            {
                Console.WriteLine(qTest + ")" + question3[testque].Questions);
                for (int i = 0; i < question3[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question3[testque].Answer[i]}");
                }

                Console.Write("Enter your answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                if (userAnswer == question3[testque].CoAnsw)
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
            Console.WriteLine($"Final score is: {score}/{question3.Count}");
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

        public void hints()
        {
            //hints menu
            Console.WriteLine(" 1) Quiz with Hints\n 2) General Quiz");
            int hint1 = Convert.ToInt32(Console.ReadLine());
            if (hint1 == 1)
            {

                qusetionilbrary2.TestwithHints();

            }
            else if (hint1 == 2)
            {

                Test();

            }
        }

        public void hints1()
        {
            Console.WriteLine(" 1) Quiz with Hints\n 2) General Quiz");
            int hint1 = Convert.ToInt32(Console.ReadLine());
            if (hint1 == 1)
            {

                qusetionilbrary2.TestwithHints1();

            }
            else if (hint1 == 2)
            {

                Test1();

            }
        }

       

        public void giveHints()
        {
            Console.WriteLine(" 1) Add Hints to the Quiz\n 2) General Quiz");
            string y = Console.ReadLine();
            if (y == "1")
            {
                qusetionilbrary2.addQuizWithHints1();
            }
            else
            {

                AddQuiz();


            }
        }

        public void giveHints1()
        {
            Console.WriteLine(" 1) Add Hints to the Quiz\n 2) General Quiz");
            string y = Console.ReadLine();
            if (y == "1")
            {
                qusetionilbrary2.addQuizWithHints2();
            }
            else
            {

                AddQuiz1();


            }
        }

        public void AddQuiz()
        {


            Console.WriteLine("Add a new question:");
            string testh = Console.ReadLine();
            Console.WriteLine("Add the four answers");
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            Console.WriteLine("Add the correct answer: ");
            int AnswerIndex = Convert.ToInt32(Console.ReadLine());
            int AnswerIndex1 = AnswerIndex - 1;

            question1.Add(new quizQusetionsSub1(testh, new string[] { answer1, answer2 }, AnswerIndex1));

            int testque = 0;
            // Loop the Quiz

            while (testque < question1.Count)
            {
                // Display Quiz to add
                Console.WriteLine(question1[testque].Questions);
                for (int i = 0; i < question1[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question1[testque].Answer[i]}");
                }

                testque++;
            }


        }

        public void AddQuiz1()
        {


            Console.WriteLine("Add a new question:");
            string testh = Console.ReadLine();
            Console.WriteLine("Add the four answers");
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            Console.WriteLine("Add the correct answer: ");
            int AnswerIndex = Convert.ToInt32(Console.ReadLine());
            int AnswerIndex1 = AnswerIndex - 1;

            question3.Add(new quizQusetionsSub1(testh, new string[] { answer1, answer2 }, AnswerIndex1));

            int testque = 0;

            // sane steps
            while (testque < question3.Count)
            {
                Console.WriteLine(question3[testque].Questions);
                for (int i = 0; i < question3[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question3[testque].Answer[i]}");
                }

                testque++;
            }


        }

        public void updateQusetion()
        {
            int qTest = 1;
            int testque = 0;
            Console.WriteLine("Enter the Question number to update  \n Menu - Enter 0 ");
            while (testque < question1.Count)
            {
                // Display Quiz to update
                Console.WriteLine(qTest + ")" + question1[testque].Questions);
                for (int i = 0; i < question1[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question1[testque].Answer[i]}");
                }

                testque++;
                qTest++;
            }
            int Numq = Convert.ToInt32(Console.ReadLine());
            if (Numq == 0)
            {
                ValidatExId();
            }
            else if (Numq <= question1.Count)
            {
                qusetionilbrary2.updateQusetion1(Numq);
                question1.RemoveAt(Numq - 1);


            }
            else
            {
                Console.WriteLine("Error: Input cannot be detected");
                ValidatExId();

            }


        }

        public void updateQusetion1()
        {
            int qTest = 1;
            int testque = 0;
            Console.WriteLine("Enter the Question number to update  \n Menu - Enter 0");
            while (testque < question3.Count)
            {
                Console.WriteLine(qTest + ")" + question3[testque].Questions);
                for (int i = 0; i < question3[testque].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question3[testque].Answer[i]}");
                }

                testque++;
                qTest++;
            }
            int Numq = Convert.ToInt32(Console.ReadLine());
            if (Numq == 0)
            {
                ValidatExId1();
            }
            else if (Numq <= question3.Count)
            {
                question3.RemoveAt(Numq - 1);
                qusetionilbrary2.updateQusetion(Numq);
            }
            else
            {
                Console.WriteLine("Error: Input cannot be detected");
                ValidatExId1();
            }

        }

    }

}
