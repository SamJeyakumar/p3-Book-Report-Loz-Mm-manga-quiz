    using System;

    namespace p3_Book_Report_Loz_Mm_mang_quiz
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to a quiz of: ");
                Console.WriteLine("====The Legend of Zelda, Majora's Mask====");
                Console.WriteLine("====Manga by Akira Himekawa====");
                Console.Write("Start?: ");
                Console.ReadLine();
                Console.Clear();
                bool Valid = true;
                int playernum = 0;
                string PlayerNum = "If you see this, there's a bug";       
                while(Valid)
                {
                    Console.Write("Number of players (must be between 2-4): ");
                    PlayerNum = Console.ReadLine();
                    if (PlayerNum == "2")
                    {
                        Valid = false;
                        playernum = 2;
                    }
                    else if (PlayerNum == "3")
                    {
                        Valid = false;
                        playernum = 3;
                    }
                    else if (PlayerNum == "4")
                    {
                        Valid = false;
                        playernum = 4;
                    }
                    if(Valid)
                    {
                        Console.WriteLine("Please insert valid number of players.");
                        Console.ReadLine();
                    }
                    Console.Clear();
                }
                Console.WriteLine("You are playing with " + PlayerNum + " players.");
                Console.ReadLine();
                Console.Clear();
                string Player1 = "If you see this, then there's a bug.";
                string Player2 = "If you see this, then there's a bug.";
                string Player3 = "If you see this, then there's a bug.";
                string Player4 = "If you see this, then there's a bug.";
                Console.Write("Player 1's name: ");
                Player1 = Console.ReadLine();
                Console.Write("Player 2's name: ");
                Player2 = Console.ReadLine();
                if(playernum > 2)
                {
                    Console.Write("Player 3's name: ");
                    Player3 = Console.ReadLine();
                }
                if(playernum == 4)
                {
                    Console.Write("Player 4's name: ");
                    Player4 = Console.ReadLine();
                }
                Console.Clear();
                Valid = true;
                bool rules = false;
                string Srules = "If you see this, then there's a bug.";
                while (Valid)
                {
                    Console.WriteLine("Would you like to read the rules?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.Write("Answer: ");
                    Srules = Console.ReadLine();
                    if (Srules == "1")
                    {
                        Valid = false;
                        rules = true;
                    }
                    else if (Srules == "2")
                    {
                        Valid = false;
                    }
                    if (Valid)
                    {
                        Console.WriteLine("Please insert valid answer.");
                        Console.ReadLine();
                    }
                    Console.Clear();
                }
                if(rules)
                {
                    Console.WriteLine("The rules are simple. Every player takes turns and answers 4 questions (per player) about the book. These 8-16 questions (number of questions depend on the amount of players) will be multiple choice with 4 possible answers. At the end of the game, the amount of questions answered right will be tallied up and a winner will be decided (draws may also happen if 2 more players share the amount of correct answers).");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine("Let the game begin...");
                Console.ReadLine();
                Console.Clear();
                int Player1score = 0;
                int Player2score = 0;
                int Player3score = 0;
                int Player4score = 0;
                int q1 = 0;
                int q2 = 0;
                int q3 = 0;
                int q4 = 0;
                int q5 = 0;
                int q6 = 0;
                int q7 = 0;
                int q8 = 0;
                int q9 = 0;
                int q10 = 0;
                int q11 = 0;
                int q12 = 0;
                int q13 = 0;
                int q14 = 0;
                int q15 = 0;
                int q16 = 0;
                bool QValid = false;
                Random rnd = new Random();
                //q1 DONE
                q1 = rnd.Next(1, 17);
               QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player1 + "'s turn.");
                    if (q1 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q1 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q1 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q1 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q1 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q1 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q1 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q1 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q1 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q1 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q1 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q1 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q1 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q1 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q1 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q1 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q1 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q1 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q1 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q1 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q1 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q1 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q1 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q1 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                //q2 DONE
                Valid = true;
                while(Valid)
                {
                    q2 = rnd.Next(1, 17);
                    Valid = false;
                    if(q2 == q1)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player2 + "'s turn.");
                    if (q2 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q2 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q2 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q2 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q2 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q2 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q2 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q2 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q2 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q2 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q2 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q2 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q2 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q2 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q2 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q2 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q2 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q2 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q2 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q2 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q2 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q2 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q2 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }



                //q3  DONE
                Valid = true;
                while (Valid)
                {
                    q3 = rnd.Next(1, 17);
                    Valid = false;
                    if (q3 == q1)
                    {
                        Valid = true;
                    }
                    if (q3 == q2)
                    {
                        Valid = true;
                    }
                }
                if (playernum > 2)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player3 + "'s turn.");
                        if (q3 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q3 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q3 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q3 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q3 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q3 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q3 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q3 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q3 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q3 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q3 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q3 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q3 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q3 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q3 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q3 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q3 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q3 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q3 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q3 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q3 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q3 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q3 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }
                //q4  DONE
                Valid = true;
                while (Valid)
                {
                    q4 = rnd.Next(1, 17);
                    Valid = false;
                    if (q4 == q1)
                    {
                        Valid = true;
                    }
                    if (q4 == q2)
                    {
                        Valid = true;
                    }
                    if (q4 == q3)
                    {
                        Valid = true;
                    }
                }
                if (playernum == 4)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player4 + "'s turn.");
                        if (q4 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q4 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q4 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q4 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q4 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q4 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q4 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q4 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q4 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q4 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q4 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q4 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q4 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q4 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q4 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q4 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q4 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q4 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q4 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q4 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q4 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q4 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q4 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }



                //q5 DONE
                Valid = true;
                while (Valid)
                {
                    q5 = rnd.Next(1, 17);
                    Valid = false;
                    if (q5 == q1)
                    {
                        Valid = true;
                    }
                    if (q5 == q2)
                    {
                        Valid = true;
                    }
                    if (q5 == q3)
                    {
                        Valid = true;
                    }
                    if (q5 == q4)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player1 + "'s turn.");
                    if (q5 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q5 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q5 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q5 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q5 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q5 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q5 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q5 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q5 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q5 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q5 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q5 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q5 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q5 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q5 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q5 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q5 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q5 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q5 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q5 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q5 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q5 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q5 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


                //q6 DONE
                Valid = true;
                while (Valid)
                {
                    q6 = rnd.Next(1, 17);
                    Valid = false;
                    if (q6 == q1)
                    {
                        Valid = true;
                    }
                    if (q6 == q2)
                    {
                        Valid = true;
                    }
                    if (q6 == q3)
                    {
                        Valid = true;
                    }
                    if (q6 == q4)
                    {
                        Valid = true;
                    }
                    if (q6 == q5)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player2 + "'s turn.");
                    if (q6 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q6 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q6 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q6 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q6 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q6 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q6 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q6 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q6 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q6 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q6 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q6 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q6 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q6 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q6 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q6 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q6 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q6 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q6 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q6 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q6 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q6 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q6 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


                //q7 DONE
                Valid = true;
                while (Valid)
                {
                    q7 = rnd.Next(1, 17);
                    Valid = false;
                    if (q7 == q1)
                    {
                        Valid = true;
                    }
                    if (q7 == q2)
                    {
                        Valid = true;
                    }
                    if (q7 == q3)
                    {
                        Valid = true;
                    }
                    if (q7 == q4)
                    {
                        Valid = true;
                    }
                    if (q7 == q5)
                    {
                        Valid = true;
                    }
                    if (q7 == q6)
                    {
                        Valid = true;
                    }
                }
                if (playernum > 2)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player3 + "'s turn.");
                        if (q7 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q7 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q7 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q7 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q7 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q7 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q7 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q7 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q7 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q7 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q7 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q7 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q7 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q7 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q7 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q7 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q7 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q7 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q7 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q7 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q7 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q7 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q7 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }
                //q8 DONE
                Valid = true;
                while (Valid)
                {
                    q8 = rnd.Next(1, 17);
                    Valid = false;
                    if (q8 == q1)
                    {
                        Valid = true;
                    }
                    if (q8 == q2)
                    {
                        Valid = true;
                    }
                    if (q8 == q3)
                    {
                        Valid = true;
                    }
                    if (q8 == q4)
                    {
                        Valid = true;
                    }
                    if (q8 == q5)
                    {
                        Valid = true;
                    }
                    if (q8 == q6)
                    {
                        Valid = true;
                    }
                    if (q8 == q7)
                    {
                        Valid = true;
                    }
                }
                if (playernum == 4)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player4 + "'s turn.");
                        if (q8 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q8 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q8 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q8 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q8 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q8 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q8 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q8 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q8 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q8 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q8 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q8 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q8 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q8 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q8 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q8 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q8 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q8 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q8 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q8 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q8 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q8 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q8 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }



                //q9 DONE
                Valid = true;
                while (Valid)
                {
                    q9 = rnd.Next(1, 17);
                    Valid = false;
                    if (q9 == q1)
                    {
                        Valid = true;
                    }
                    if (q9 == q2)
                    {
                        Valid = true;
                    }
                    if (q9 == q3)
                    {
                        Valid = true;
                    }
                    if (q9 == q4)
                    {
                        Valid = true;
                    }
                    if (q9 == q5)
                    {
                        Valid = true;
                    }
                    if (q9 == q6)
                    {
                        Valid = true;
                    }
                    if (q9 == q7)
                    {
                        Valid = true;
                    }
                    if (q9 == q8)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player1 + "'s turn.");
                    if (q9 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q9 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q9 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q9 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q9 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q9 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q9 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q9 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q9 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q9 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q9 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q9 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q9 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q9 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q9 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q9 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q9 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q9 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q9 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q9 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q9 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q9 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q9 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


                //q10 DONE
                Valid = true;
                while (Valid)
                {
                    q10 = rnd.Next(1, 17);
                    Valid = false;
                    if (q10 == q1)
                    {
                        Valid = true;
                    }
                    if (q10 == q2)
                    {
                        Valid = true;
                    }
                    if (q10 == q3)
                    {
                        Valid = true;
                    }
                    if (q10 == q4)
                    {
                        Valid = true;
                    }
                    if (q10 == q5)
                    {
                        Valid = true;
                    }
                    if (q10 == q6)
                    {
                        Valid = true;
                    }
                    if (q10 == q7)
                    {
                        Valid = true;
                    }
                    if (q10 == q8)
                    {
                        Valid = true;
                    }
                    if (q10 == q9)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player2 + "'s turn.");
                    if (q10 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q10 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q10 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q10 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q10 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q10 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q10 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q10 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q10 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q10 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q10 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q10 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q10 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q10 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q10 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q10 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q10 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q10 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q10 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q10 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q10 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q10 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q10 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


                //q11 DONE
                Valid = true;
                while (Valid)
                {
                    q11 = rnd.Next(1, 17);
                    Valid = false;
                    if (q11 == q1)
                    {
                        Valid = true;
                    }
                    if (q11 == q2)
                    {
                        Valid = true;
                    }
                    if (q11 == q3)
                    {
                        Valid = true;
                    }
                    if (q11 == q4)
                    {
                        Valid = true;
                    }
                    if (q11 == q5)
                    {
                        Valid = true;
                    }
                    if (q11 == q6)
                    {
                        Valid = true;
                    }
                    if (q11 == q7)
                    {
                        Valid = true;
                    }
                    if (q11 == q8)
                    {
                        Valid = true;
                    }
                    if (q11 == q9)
                    {
                        Valid = true;
                    }
                    if (q11 == q10)
                    {
                        Valid = true;
                    }
                }
                if (playernum > 2)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player3 + "'s turn.");
                        if (q11 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q11 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q11 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q11 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q11 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q11 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q11 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q11 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q11 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q11 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q11 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q11 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q11 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q11 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q11 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q11 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q11 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q11 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q11 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q11 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q11 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q11 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q11 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }
                //q12 DONE
                Valid = true;
                while (Valid)
                {
                    q12 = rnd.Next(1, 17);
                    Valid = false;
                    if (q12 == q1)
                    {
                        Valid = true;
                    }
                    if (q12 == q2)
                    {
                        Valid = true;
                    }
                    if (q12 == q3)
                    {
                        Valid = true;
                    }
                    if (q12 == q4)
                    {
                        Valid = true;
                    }
                    if (q12 == q5)
                    {
                        Valid = true;
                    }
                    if (q12 == q6)
                    {
                        Valid = true;
                    }
                    if (q12 == q7)
                    {
                        Valid = true;
                    }
                    if (q12 == q8)
                    {
                        Valid = true;
                    }
                    if (q12 == q9)
                    {
                        Valid = true;
                    }
                    if (q12 == q10)
                    {
                        Valid = true;
                    }
                    if (q12 == q11)
                    {
                        Valid = true;
                    }
                }
                if (playernum == 4)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player4 + "'s turn.");
                        if (q12 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q12 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q12 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q12 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q12 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q12 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q12 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q12 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q12 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q12 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q12 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q12 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q12 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q12 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q12 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q12 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q12 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q12 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q12 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q12 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q12 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q12 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q12 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }


                //q13 DONE
                Valid = true;
                while (Valid)
                {
                    q13 = rnd.Next(1, 17);
                    Valid = false;
                    if (q13 == q1)
                    {
                        Valid = true;
                    }
                    if (q13 == q2)
                    {
                        Valid = true;
                    }
                    if (q13 == q3)
                    {
                        Valid = true;
                    }
                    if (q13 == q4)
                    {
                        Valid = true;
                    }
                    if (q13 == q5)
                    {
                        Valid = true;
                    }
                    if (q13 == q6)
                    {
                        Valid = true;
                    }
                    if (q13 == q7)
                    {
                        Valid = true;
                    }
                    if (q13 == q8)
                    {
                        Valid = true;
                    }
                    if (q13 == q9)
                    {
                        Valid = true;
                    }
                    if (q13 == q10)
                    {
                        Valid = true;
                    }
                    if (q13 == q11)
                    {
                        Valid = true;
                    }
                    if (q13 == q12)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player1 + "'s turn.");
                    if (q13 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q13 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q13 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q13 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q13 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q13 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q13 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q13 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q13 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q13 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q13 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q13 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q13 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q13 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q13 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q13 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q13 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q13 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q13 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q13 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q13 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q13 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else if (q13 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


                //q14 DONE
                Valid = true;
                while (Valid)
                {
                    q14 = rnd.Next(1, 17);
                    Valid = false;
                    if (q14 == q1)
                    {
                        Valid = true;
                    }
                    if (q14 == q2)
                    {
                        Valid = true;
                    }
                    if (q14 == q3)
                    {
                        Valid = true;
                    }
                    if (q14 == q4)
                    {
                        Valid = true;
                    }
                    if (q14 == q5)
                    {
                        Valid = true;
                    }
                    if (q14 == q6)
                    {
                        Valid = true;
                    }
                    if (q14 == q7)
                    {
                        Valid = true;
                    }
                    if (q14 == q8)
                    {
                        Valid = true;
                    }
                    if (q14 == q9)
                    {
                        Valid = true;
                    }
                    if (q14 == q10)
                    {
                        Valid = true;
                    }
                    if (q14 == q11)
                    {
                        Valid = true;
                    }
                    if (q14 == q12)
                    {
                        Valid = true;
                    }
                    if (q14 == q13)
                    {
                        Valid = true;
                    }
                }
                QValid = true;
                while (QValid)
                {
                    Console.WriteLine("It is " + Player2 + "'s turn.");
                    if (q14 == 1)
                    {
                        Console.WriteLine("Who is the author of this book?");
                        Console.WriteLine("A. J.K Rowling.");
                        Console.WriteLine("B. Akira Himekawa.");
                        Console.WriteLine("C. Shinzo Abe.");
                        Console.WriteLine("D. shigeru miyamoto");
                    }
                    if (q14 == 2)
                    {
                        Console.WriteLine("Who is the main character?");
                        Console.WriteLine("A. Chain.");
                        Console.WriteLine("B. Mario.");
                        Console.WriteLine("C. Link.");
                        Console.WriteLine("D. Skull Kid.");
                    }
                    if (q14 == 3)
                    {
                        Console.WriteLine("How did Skull Kid get Majora's Mask?");
                        Console.WriteLine("A. He made it.");
                        Console.WriteLine("B. He stole it.");
                        Console.WriteLine("C. He bought it.");
                        Console.WriteLine("D. It was given to him by the 4 giants.");
                    }
                    if (q14 == 4)
                    {
                        Console.WriteLine("Which one of these statements is correct?");
                        Console.WriteLine("A. Link was born in Termina.");
                        Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                        Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                        Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                    }
                    if (q14 == 5)
                    {
                        Console.WriteLine("How did Link get the Deku mask?");
                        Console.WriteLine("A. The happy mask salesman gave it to him.");
                        Console.WriteLine("B. He found it in a chest.");
                        Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                        Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                    }
                    if (q14 == 6)
                    {
                        Console.WriteLine("Who made Majora’s Mask?");
                        Console.WriteLine("A. Skull Kid.");
                        Console.WriteLine("B. Link.");
                        Console.WriteLine("C. A traveler with a drum.");
                        Console.WriteLine("D. Majora.");
                    }
                    if (q14 == 7)
                    {
                        Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                        Console.WriteLine("A. Eternal life.");
                        Console.WriteLine("B. Whatever you desire.");
                        Console.WriteLine("C. Infinite strength.");
                        Console.WriteLine("D. Infinite wealth.");
                    }
                    if (q14 == 8)
                    {
                        Console.WriteLine("Which one of these quotes is from the 4 giants?");
                        Console.WriteLine("A. “Call for me.”");
                        Console.WriteLine("B. “To be or not to be.”");
                        Console.WriteLine("C. “Summon us.”");
                        Console.WriteLine("D. “The little demon is calling the moon.”");
                    }
                    if (q14 == 9)
                    {
                        Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                        Console.WriteLine("A. Navi and Midna.");
                        Console.WriteLine("B. Hermione and Ron.");
                        Console.WriteLine("C. Gossip and Hearsay.");
                        Console.WriteLine("D. Tatl and Tael.");
                    }
                    if (q14 == 10)
                    {
                        Console.WriteLine("What is the biggest threat to Termina in this book?");
                        Console.WriteLine("A. Ganondorf.");
                        Console.WriteLine("B. The sun.");
                        Console.WriteLine("C. The moon.");
                        Console.WriteLine("D. Kafei being turned into a child.");
                    }
                    if (q14 == 11)
                    {
                        Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                        Console.WriteLine("A. A.Honda and A.Nagano.");
                        Console.WriteLine("B. S.Nagano.");
                        Console.WriteLine("C. E. Aonuma.");
                        Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                    }
                    if (q14 == 12)
                    {
                        Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                        Console.WriteLine("A. Anju.");
                        Console.WriteLine("B. Anju’s grandma.");
                        Console.WriteLine("C. The happy mask salesman.");
                        Console.WriteLine("D. One of the guards at the wall of Clock town.");
                    }
                    if (q14 == 13)
                    {
                        Console.WriteLine("How did Link get the Fierce Deity mask?");
                        Console.WriteLine("A. From the happy mask salesman.");
                        Console.WriteLine("B. From the 4 giants.");
                        Console.WriteLine("C. From Majora’s Mask.");
                        Console.WriteLine("D. From the children in the moon.");
                    }
                    if (q14 == 14)
                    {
                        Console.WriteLine("On what day were Anju and Kafei going to marry?");
                        Console.WriteLine("A. The 1st day.");
                        Console.WriteLine("B. The 2nd day.");
                        Console.WriteLine("C. The 3rd day (day of the carnival).");
                        Console.WriteLine("D. The 4th day (day after the carnival).");
                    }
                    if (q14 == 15)
                    {
                        Console.WriteLine("What breed is Sandy (the author's dog)?");
                        Console.WriteLine("A. Golden retriever.");
                        Console.WriteLine("B. Miniature Dachshund.");
                        Console.WriteLine("C. Pitbull.");
                        Console.WriteLine("D. Pembroke Welsh Corgi.");
                    }
                    if (q14 == 16)
                    {
                        Console.WriteLine("How many masks does Link have (that transform him)?");
                        Console.WriteLine("A. 1.");
                        Console.WriteLine("B. 2.");
                        Console.WriteLine("C. 3.");
                        Console.WriteLine("D. 4.");
                    }
                    Console.Write("Answer: "); ;
                    string ans1 = Console.ReadLine();
                    if (ans1 == "A")
                    {
                        QValid = false;
                        if (q14 == 8)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 12)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q14 == 11)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "B")
                    {
                        QValid = false;
                        if (q14 == 1)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 3)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 7)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 15)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "C")
                    {
                        QValid = false;
                        if (q14 == 2)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 14)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player1score = Player1score + 1;
                        }
                        else if (q14 == 5)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 6)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 10)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 13)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else if (ans1 == "D")
                    {
                        QValid = false;
                        if (q14 == 4)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 9)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else if (q14 == 16)
                        {
                            Console.WriteLine("This is the correct answer.");
                            Player2score = Player2score+1;
                        }
                        else
                        {
                            Console.WriteLine("This is not the correct answer.");
                        }
                    }
                    else
                    {
                        QValid = true;
                        Console.WriteLine("Please insert valid answer.");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


                //q15 DONE
                Valid = true;
                while (Valid)
                {
                    q15 = rnd.Next(1, 17);
                    Valid = false;
                    if (q15 == q1)
                    {
                        Valid = true;
                    }
                    if (q15 == q2)
                    {
                        Valid = true;
                    }
                    if (q15 == q3)
                    {
                        Valid = true;
                    }
                    if (q15 == q4)
                    {
                        Valid = true;
                    }
                    if (q15 == q5)
                    {
                        Valid = true;
                    }
                    if (q15 == q6)
                    {
                        Valid = true;
                    }
                    if (q15 == q7)
                    {
                        Valid = true;
                    }
                    if (q15 == q8)
                    {
                        Valid = true;
                    }
                    if (q15 == q9)
                    {
                        Valid = true;
                    }
                    if (q15 == q10)
                    {
                        Valid = true;
                    }
                    if (q15 == q11)
                    {
                        Valid = true;
                    }
                    if (q15 == q12)
                    {
                        Valid = true;
                    }
                    if (q15 == q13)
                    {
                        Valid = true;
                    }
                    if (q15 == q14)
                    {
                        Valid = true;
                    }
                }
                if (playernum > 2)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player3 + "'s turn.");
                        if (q15 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q15 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q15 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q15 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q15 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q15 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q15 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q15 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q15 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q15 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q15 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q15 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q15 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q15 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q15 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q15 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q15 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q15 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q15 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q15 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q15 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q15 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else if (q15 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player3score = Player3score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }


                }
                //q16 DONE
                Valid = true;
                while (Valid)
                {
                    q16 = rnd.Next(1, 17);
                    Valid = false;
                    if (q16 == q1)
                    {
                        Valid = true;
                    }
                    if (q16 == q2)
                    {
                        Valid = true;
                    }
                    if (q16 == q3)
                    {
                        Valid = true;
                    }
                    if (q16 == q4)
                    {
                        Valid = true;
                    }
                    if (q16 == q5)
                    {
                        Valid = true;
                    }
                    if (q16 == q6)
                    {
                        Valid = true;
                    }
                    if (q16 == q7)
                    {
                        Valid = true;
                    }
                    if (q16 == q8)
                    {
                        Valid = true;
                    }
                    if (q16 == q9)
                    {
                        Valid = true;
                    }
                    if (q16 == q10)
                    {
                        Valid = true;
                    }
                    if (q16 == q11)
                    {
                        Valid = true;
                    }
                    if (q16 == q12)
                    {
                        Valid = true;
                    }
                    if (q16 == q13)
                    {
                        Valid = true;
                    }
                    if (q16 == q14)
                    {
                        Valid = true;
                    }
                    if (q16 == q15)
                    {
                        Valid = true;
                    }
                }
                if (playernum == 4)
                {
                    QValid = true;
                    while (QValid)
                    {
                        Console.WriteLine("It is " + Player4 + "'s turn.");
                        if (q16 == 1)
                        {
                            Console.WriteLine("Who is the author of this book?");
                            Console.WriteLine("A. J.K Rowling.");
                            Console.WriteLine("B. Akira Himekawa.");
                            Console.WriteLine("C. Shinzo Abe.");
                            Console.WriteLine("D. shigeru miyamoto");
                        }
                        if (q16 == 2)
                        {
                            Console.WriteLine("Who is the main character?");
                            Console.WriteLine("A. Chain.");
                            Console.WriteLine("B. Mario.");
                            Console.WriteLine("C. Link.");
                            Console.WriteLine("D. Skull Kid.");
                        }
                        if (q16 == 3)
                        {
                            Console.WriteLine("How did Skull Kid get Majora's Mask?");
                            Console.WriteLine("A. He made it.");
                            Console.WriteLine("B. He stole it.");
                            Console.WriteLine("C. He bought it.");
                            Console.WriteLine("D. It was given to him by the 4 giants.");
                        }
                        if (q16 == 4)
                        {
                            Console.WriteLine("Which one of these statements is correct?");
                            Console.WriteLine("A. Link was born in Termina.");
                            Console.WriteLine("B. Link was instructed to go to Termina by his old friend.");
                            Console.WriteLine("C. Link was instructed to go to Termina by Zelda.");
                            Console.WriteLine("D. Link fell to Termina after following Skull kid.");
                        }
                        if (q16 == 5)
                        {
                            Console.WriteLine("How did Link get the Deku mask?");
                            Console.WriteLine("A. The happy mask salesman gave it to him.");
                            Console.WriteLine("B. He found it in a chest.");
                            Console.WriteLine("C. He got it after playing the Ocarina on the clock tower");
                            Console.WriteLine("D. Skull Kid gave it to him as a reward for Link getting his Ocarina back.");
                        }
                        if (q16 == 6)
                        {
                            Console.WriteLine("Who made Majora’s Mask?");
                            Console.WriteLine("A. Skull Kid.");
                            Console.WriteLine("B. Link.");
                            Console.WriteLine("C. A traveler with a drum.");
                            Console.WriteLine("D. Majora.");
                        }
                        if (q16 == 7)
                        {
                            Console.WriteLine("What wish is said to be granted by the creature (chapter 10)?");
                            Console.WriteLine("A. Eternal life.");
                            Console.WriteLine("B. Whatever you desire.");
                            Console.WriteLine("C. Infinite strength.");
                            Console.WriteLine("D. Infinite wealth.");
                        }
                        if (q16 == 8)
                        {
                            Console.WriteLine("Which one of these quotes is from the 4 giants?");
                            Console.WriteLine("A. “Call for me.”");
                            Console.WriteLine("B. “To be or not to be.”");
                            Console.WriteLine("C. “Summon us.”");
                            Console.WriteLine("D. “The little demon is calling the moon.”");
                        }
                        if (q16 == 9)
                        {
                            Console.WriteLine("What are the names of the fairy siblings that were separated in chapter 2?");
                            Console.WriteLine("A. Navi and Midna.");
                            Console.WriteLine("B. Hermione and Ron.");
                            Console.WriteLine("C. Gossip and Hearsay.");
                            Console.WriteLine("D. Tatl and Tael.");
                        }
                        if (q16 == 10)
                        {
                            Console.WriteLine("What is the biggest threat to Termina in this book?");
                            Console.WriteLine("A. Ganondorf.");
                            Console.WriteLine("B. The sun.");
                            Console.WriteLine("C. The moon.");
                            Console.WriteLine("D. Kafei being turned into a child.");
                        }
                        if (q16 == 11)
                        {
                            Console.WriteLine("Akira Himekawa is just a pen name. What is/are the name(s) of the author(s)?");
                            Console.WriteLine("A. A.Honda and A.Nagano.");
                            Console.WriteLine("B. S.Nagano.");
                            Console.WriteLine("C. E. Aonuma.");
                            Console.WriteLine("D. Y. Koizumi and M. Sakurai.");
                        }
                        if (q16 == 12)
                        {
                            Console.WriteLine("Who took care of Link while he was stuck in his Deku form?");
                            Console.WriteLine("A. Anju.");
                            Console.WriteLine("B. Anju’s grandma.");
                            Console.WriteLine("C. The happy mask salesman.");
                            Console.WriteLine("D. One of the guards at the wall of Clock town.");
                        }
                        if (q16 == 13)
                        {
                            Console.WriteLine("How did Link get the Fierce Deity mask?");
                            Console.WriteLine("A. From the happy mask salesman.");
                            Console.WriteLine("B. From the 4 giants.");
                            Console.WriteLine("C. From Majora’s Mask.");
                            Console.WriteLine("D. From the children in the moon.");
                        }
                        if (q16 == 14)
                        {
                            Console.WriteLine("On what day were Anju and Kafei going to marry?");
                            Console.WriteLine("A. The 1st day.");
                            Console.WriteLine("B. The 2nd day.");
                            Console.WriteLine("C. The 3rd day (day of the carnival).");
                            Console.WriteLine("D. The 4th day (day after the carnival).");
                        }
                        if (q16 == 15)
                        {
                            Console.WriteLine("What breed is Sandy (the author's dog)?");
                            Console.WriteLine("A. Golden retriever.");
                            Console.WriteLine("B. Miniature Dachshund.");
                            Console.WriteLine("C. Pitbull.");
                            Console.WriteLine("D. Pembroke Welsh Corgi.");
                        }
                        if (q16 == 16)
                        {
                            Console.WriteLine("How many masks does Link have (that transform him)?");
                            Console.WriteLine("A. 1.");
                            Console.WriteLine("B. 2.");
                            Console.WriteLine("C. 3.");
                            Console.WriteLine("D. 4.");
                        }
                        Console.Write("Answer: "); ;
                        string ans1 = Console.ReadLine();
                        if (ans1 == "A")
                        {
                            QValid = false;
                            if (q16 == 8)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 12)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q16 == 11)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "B")
                        {
                            QValid = false;
                            if (q16 == 1)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 3)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 7)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 15)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "C")
                        {
                            QValid = false;
                            if (q16 == 2)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 14)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player1score = Player1score + 1;
                            }
                            else if (q16 == 5)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 6)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 10)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 13)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else if (ans1 == "D")
                        {
                            QValid = false;
                            if (q16 == 4)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 9)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else if (q16 == 16)
                            {
                                Console.WriteLine("This is the correct answer.");
                                Player4score = Player4score+1;
                            }
                            else
                            {
                                Console.WriteLine("This is not the correct answer.");
                            }
                        }
                        else
                        {
                            QValid = true;
                            Console.WriteLine("Please insert valid answer.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine("That was the last question. Time for the results.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Player1+" got " + Player1score + " questions right!");
                Console.WriteLine(Player2 + " got " + Player2score + " questions right!");
                if(playernum > 2)
                {
                    Console.WriteLine(Player3 + " got " + Player3score + " questions right!");
                }
                if (playernum == 4)
                {
                    Console.WriteLine(Player4 + " got " + Player4score + " questions right!");
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
            }
        }
    }

