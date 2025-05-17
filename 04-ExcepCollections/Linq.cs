
partial class Program
{
    static void Linq()
    {

        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];


        //Filtro normal sin linq
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        foreach (var item in evenNumbers)
        {
            WriteLine($"evenNumbers {item}");
        }

        //Linq
        //Sintaxis de consulta
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        foreach (var item in evenNumbersQuery)
        {
            WriteLine($"evenNumbersQuer {item}");
        }

        //Sintaxis de método
        var evenNumberMethod = numbers.Where(n => n % 2 == 0);
        foreach (var item in evenNumberMethod)
        {
            WriteLine($"evenNumberMethod {item}");
        }

        //Consultas simples

        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
          new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
          new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
          new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
          new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
          new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
          new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
         };

        WriteLine("Personajes que son Avengers");

        IEnumerable<MarvelCharacter> avengers = from c in characters
                                                where c.Team == "Avengers"
                                                select c;

        ShowListCharacter("Avengers", avengers);

        IEnumerable<MarvelCharacter> avengersMethod = characters.Where(c => c.Team == "Avengers");

        ShowListCharacter("Avengers avengersMethod", avengersMethod);


        //Ordenar
        IEnumerable<MarvelCharacter> sortedQuery = from c in characters
                                                   orderby c.Name descending
                                                   select c;

        ShowListCharacter("Avengers sortedQuery", sortedQuery);

        IEnumerable<MarvelCharacter> sortedMethod = characters.OrderBy(c => c.Name);

        ShowListCharacter("Avengers sortedMethod", sortedMethod);

        //Mostrar los primeros 3 elementos
        var firstThreeQuery = (from c in characters select c).Take(3);

        ShowListCharacter("Avengers firstThreeQuery", firstThreeQuery);

        var firstThreeMethod = characters.Take(3);

        ShowListCharacter("Avengers firstThreeMethod", firstThreeMethod);



    }

    static void ShowListCharacter(string message, IEnumerable<MarvelCharacter> list)
    {
        WriteLine($"\n\n---- {message} ----\n");

        foreach (var item in list)
        {
            WriteLine(item.ToString());
        }
    }
}