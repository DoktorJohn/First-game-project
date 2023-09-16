using System.Text;
using System.Xml.Schema;

namespace Mit_spil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the text-based RPG " + "The Game" + " made by Doktor John");
            Console.WriteLine("Press any key to continue to the game");
            Console.ReadKey();
            Console.Clear();

            if (true)
            {
                character userPlayer = new character();
                int delayMilliseconds = 30;

                string introduktion = "You find yourself waking up on some wet cobblestones outside of a big castle gate.";

                TextWriter.WriteSlowly(introduktion, delayMilliseconds);

                string introduktion2 = "A guard comes up to you and tells you that to get access to the castle beyond the gates, you must tell him your name";

                TextWriter.WriteSlowly(introduktion2, delayMilliseconds);

                bool kør = true;

                while (kør == true)
                {

                    Console.WriteLine("Do you remember your name? (press 1 for yes, or 2 for no)");
                    string svar = Console.ReadLine();
                    int svaret;

                    if (int.TryParse(svar, out svaret))
                    {
                        switch (svaret)
                        {
                            case 1:
                                string menusvar1 = "What is your name then?";
                                TextWriter.WriteSlowly(menusvar1, delayMilliseconds);
                                
                                userPlayer.name = Console.ReadLine();
                                Console.WriteLine("What a nice choice done by your parents, " + userPlayer.name);
                                Console.WriteLine("Press any button to continue your adventure");
                                Console.ReadKey();
                                Console.Clear();
                                kør = false;
                                break;

                            case 2:
                                string menusvar2 = "Everyone must have a name in this damned world!";
                                TextWriter.WriteSlowly(menusvar2, delayMilliseconds);
                                Console.WriteLine("Press any button to continue your adventure");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            default:
                                
                                Console.WriteLine("Please answer 1 or 2");
                                Console.WriteLine("Press any key to return to name selection...");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                
                        }
                         
                       
                    }

                    else
                    {
                        Console.WriteLine("Ugyldigt tegn");
                        Console.WriteLine("Press any key to return to name selection...");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }

                String dialogue1 = (userPlayer.name + " now that you have told me your name...");
                TextWriter.WriteSlowly (dialogue1, delayMilliseconds);

                string dialogue2 = ("... I also need to know what you're made of... When you served the army, what did you specialize in?");
                TextWriter.WriteSlowly(dialogue2, delayMilliseconds);
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();

                bool classelection = true;
                while (classelection == true)
                {



                    string dialoguesvar = "Select a class. Think twice, because your playerclass is PERMANENT.";
                    TextWriter.WriteSlowly(dialoguesvar, delayMilliseconds);


                    Console.WriteLine("1. Warrior (a balanced class)");
                    Console.WriteLine("2. Glasscannon (high damage, low health)");
                    Console.WriteLine("3. Tank (low damage, high health");

                    Console.Write("Select a class by entering 1, 2 or 3 here: ");
                    string classvalget = Console.ReadLine();
                    int classvalg;



                    if (int.TryParse(classvalget, out classvalg))
                    {
                        switch (classvalg)
                        {
                            case 1:
                                Warrior warrior = new Warrior(userPlayer.name, 10, 10, 10, 1);
                                string choice1 = "So it is.. warrior " + userPlayer.name + "!";
                                TextWriter.WriteSlowly(choice1, delayMilliseconds);
                                Console.WriteLine("Enter any button to continue your adventure");
                                Console.ReadKey();
                                Console.Clear();
                                classelection = false;
                                break;

                            case 2:
                                Glasscannon glasscannon = new Glasscannon(userPlayer.name, 5, 15, 5, 1);
                                string choice2 = "So it is.. glasscannon " + userPlayer.name + "!";
                                TextWriter.WriteSlowly(choice2, delayMilliseconds);
                                Console.WriteLine("Enter any button to continue your adventure");
                                Console.ReadKey();
                                Console.Clear();
                                classelection = false;
                                break;

                            case 3:
                                Tank tank = new Tank(userPlayer.name, 15, 5, 15, 1);
                                string choice3 = "So it is.. tank " + userPlayer.name + "!";
                                TextWriter.WriteSlowly(choice3, delayMilliseconds);
                                Console.WriteLine("Enter any button to continue your adventure");
                                Console.ReadKey();
                                Console.Clear();
                                classelection = false;
                                break;

                            default:
                                Console.WriteLine("You need to enter 1, 2 or 3...");
                                Console.WriteLine("Press any key to return to class selection");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You need to write 1, 2 or 3...");
                        Console.WriteLine("Press any button to return to class selection!");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                string dialoguecastle = "The guard looks at you with a grin on his face.";
                string dialoguecastle1 = "He proceeds: " + "'Well i guess that's it, welcome to the city of Eidenherg'";

                TextWriter.WriteSlowly(dialoguecastle, delayMilliseconds);
                TextWriter.WriteSlowly(dialoguecastle1, delayMilliseconds);

                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();

                string intro = "The guard pulls the lever and you enter the gates of Eidenherg";
                TextWriter.WriteSlowly(intro, delayMilliseconds);

            }

            
        }
    }
}