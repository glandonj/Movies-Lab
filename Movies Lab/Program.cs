
using Movies_Lab;
using Validation;

List<Movie> movies = new List<Movie>()
{
    new Movie("Shawshank Redemption", "drama"),
    new Movie("The Dark Knight", "action"),
    new Movie("Run Hide Fight", "action"),
    new Movie("Zootopia", "animated"),
    new Movie("How to Train Your Dragon", "animated"),
    new Movie("The Terminal List", "action"),
    new Movie("Instant Family", "drama"),
    new Movie("La Misma Luna", "drama"),
    new Movie("Pilgrim's Progress", "animated"),
    new Movie("Insanity of God", "historical"),
    new Movie("Swiss Family Robinson", "adventure"),
    new Movie("Harriet", "historical"),
    new Movie("The Green Book", "historical"),
    new Movie("News of the World", "drama"),
    new Movie("Lord of the Rings", "adventure"),
    new Movie("The Princess Bride", "adventure"),
    new Movie("Big Hero 6", "animated"),
    new Movie("Little Women", "historical"),
    new Movie("Avengers: Endgame", "adventure"),
    new Movie("Wednesday", "action"),
    new Movie("Grease", "historical"),
    new Movie("Carter", "action"),
    new Movie("White Noise", "drama"),
    new Movie("Spider Head", "sci-fi"),
    new Movie("Pacific Rim", "sci-fi"),
    new Movie("Star Wars", "sci-fi")
};
List<Movie> sortedCategory = movies.OrderBy(movie => movie.Category).ThenBy(movie => movie.Title).ToList();
List<Movie> sortedTitle = movies.OrderBy(movie => movie.Title).ThenBy(movie => movie.Category).ToList();
Console.WriteLine("Welcome to the Tiny Movie Database (TMDB)\n");
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1: View All Sorted By Category");
    Console.WriteLine("2: View All Sorted By Title");
    Console.WriteLine("3: View By Category");
    Console.WriteLine("4: Select By Title");

    int choice = Validator.GetNumberInRangeInt(1, 4);

    switch (choice)
    {
        case 1:
            Console.Clear();
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
            foreach (Movie m in sortedCategory)
            {
                Console.WriteLine(m.GetDetails());
            }
            break;
        case 2:
            Console.Clear();
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
            foreach (Movie m in sortedTitle)
            {
                Console.WriteLine(m.GetDetails());
            }
            break;
        case 3:
            Console.WriteLine("What category would you like to view? Action, Adventure, Animated, Drama, Historical, Sci-Fi");
            string category = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
          
            foreach (Movie m in sortedCategory.Where(m => m.Category.ToLower() == category))
            {
                Console.WriteLine(m.GetDetails());
            }
            if (movies.Where(m=> m.Category.Contains(category)).ToList().Count == 0)
            {
                Console.Clear();
                Console.WriteLine($"No categories found containing '{category}'.");
            }
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("What is the movie title?");
            string movieinput = Console.ReadLine().Trim();
            Console.Clear();
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "Title", "Category"));
            Console.WriteLine(String.Format("{0,-25} {1,-25}", "========", "========"));
            foreach (Movie m in sortedTitle.Where(m => m.Title.Contains(movieinput)))
            {
                Console.WriteLine(m.GetDetails());
            }
            if (movies.Where(m => m.Title.Contains(movieinput)).ToList().Count == 0)
            {
                Console.Clear();
                Console.WriteLine($"No categories exist for '{movieinput}'.");
            }
            break;
    }
    runProgram = Validator.GetContinue("\nWould you like to go again?");
}


Console.Clear();
Console.WriteLine("Goodbye!");



Console.ReadLine();