
namespace CSharpIntermediateChallenges.AdvanceCourse.Lectures.Generics
{
    public class GenericsApplication : ChallengeApplication
    {
        public void RunApplication()
        {
            // var book =  new Book {Isbn = "1782-2453-9476", Title = "C# Advanced" };

            // var numbers = new GenericList<int>();
            // numbers.Add(10);

            // var books = new GenericList<Book>();
            // books.Add(book);

            // var dictionary = new GenericDictionary<string, Book>();
            // dictionary.Add("First Book", book); 

            var number = new Nulleable<int>();
            System.Console.WriteLine("Has value? " + number.HasValue);
            System.Console.WriteLine("Value: " + number.GetValueOrDefault());

        }
    }
}