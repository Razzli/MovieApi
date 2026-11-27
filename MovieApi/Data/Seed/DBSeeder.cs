using MovieApi.Models;

namespace MovieApi.Data.Seed
{
    public class DBSeeder
    {
        public static void Initialize(MovieApiContext context) { 

            if (context.Movie.Any())
            {
                return;   // Databasen är redan seedad
            }
            
            var movies = new Movie[]
            {
                new Movie("De hänsynslösa (Reservoir Dogs)", 1992, 99)
                {
                    MovieDetails = new MovieDetails (
                        "Efter ett misslyckat rån där polisen överraskar dem, flyr en grupp kriminella till en lagerlokal.",
                        "Engelska",
                        3000000),
                    Actors = new Actor[]
                    {
                        new Actor("Harvey Keitel", 1939),
                        new Actor("Tim Roth", 1961)
                    },

                    Genres = new Genre[] {
                        new Genre("Crime"),
                        new Genre ("Thriller")
                    },
                    Reviews = new Review[] {
                        new Review("Adam Brannon", "After last year’s bitterly disappointing Once Upon A Time in Hollywood bla bla.", 4)
                    }
                },
                new Movie("Monty Python's Life of Brian", 1979, 94)
                {
                    MovieDetails = new MovieDetails(
                        "The film's themes of religious satire were controversial at the time of its release, " +
                        "drawing accusations of blasphemy and protests from some religious groups..",
                        "Engelska",
                        4000000
                    ),

                    Actors = new Actor[]
                    {
                        new Actor("Graham Chapman", 1941),
                        new Actor("John Cleese", 1939),
                        new Actor("Erid Idle", 1943),
                    },
                    Genres = new Genre[] {
                        new Genre("Comedy"),
                        new Genre("Satire")
                    },
                    Reviews = new Review[] {
                        new Review("Adam Brannon", "After last year’s bitterly disappointing Once Upon A Time in Hollywood bla bla.", 4)
                    }
                },
                new Movie("Django Unchained", 2012, 165) 
                {
                    MovieDetails = new MovieDetails(
                        "The film is a highly stylized, revisionist tribute to spaghetti Westerns, with its title referring particularly "
                         + "to the 1966 Italian film Django by Sergio Corbucci. Development of Django Unchained began in 2007, when Tarantino was writing "
                         + "a book on Corbucci. By April 2011, Tarantino sent his final draft of the script to the Weinstein Company (TWC).",
                         "Engelska",
                         4000000
                    ),
                    Actors = new Actor[]
                    {
                        new Actor("Jamie Foxx", 1967),
                        new Actor("Christopher Waltz", 1956)
                    },

                    Genres = new Genre[] {
                        new Genre ("Crime"),
                        new Genre ("Thriller")
                    },
                    Reviews = new Review[] {
                        new Review ("Adam Brannon", "After last year’s bitterly disappointing Once Upon A Time in Hollywood bla bla.", 4)
                    }
                },
            };

            context.Movie.AddRange(movies);
            context.SaveChanges();
        }
    }
}
