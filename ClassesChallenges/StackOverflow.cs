namespace CSharpIntermediateChallenges.ClassesChallenges
{
    public class StackOverflow
    {
        public static void RunApplication(){
            Post p = new Post("Test Post", "This is just a test");
            int opc = -1;
            do
            {
                System.Console.WriteLine("[1] Show Post");
                System.Console.WriteLine("[2] Up-vote");
                System.Console.WriteLine("[3] Down-vote");
                System.Console.WriteLine("[0] Exit");
                System.Console.Write("option > ");
                opc = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine();
                System.Console.WriteLine();

                switch (opc)
                {
                    case 1:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine($"\t\t      Title: {p.Title}      ");
                        System.Console.WriteLine($"\t\t      Desc: {p.Description}      ");
                        System.Console.WriteLine($"\t\t      Votes: {p.Votes}      ");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\n\n");
                        break;
                    case 2:
                        p.IncrementVotes();
                        break;
                    case 3:
                        p.DecrementVotes();
                        break;
                    case 0:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\t\t|      See you!!! :D      |");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\n\n");
                        break;
                    default:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\t\t|    Invalid Option!!!    |");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\n\n");
                        break;
                }
            } while (opc != 0);
        }
    }

    class Post {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDate { get; private set; }
        public int Votes { get; private set; } = 0;

        public Post (string title, string description) {
            Title = title;
            Description = description;
            CreationDate = DateTime.Now;
        }

        public void IncrementVotes(){
            Votes++;
        }

        public void DecrementVotes(){
            Votes--;
        }
    }
}