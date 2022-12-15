using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    internal class MovieList
    {
        private List<Movies> ListOfMovies { get; set; }
        private Movies user;
        private bool IsProgramRunning = true;

        public MovieList()
        {
            user = new Movies("0", "a", "2", "b", "c", "d");

            ListOfMovies = new List<Movies>();
            ListOfMovies.Add(new Movies("1", "Deadpool", "1.54", "Comedy","Disney", "Bestest Ryan"));
            ListOfMovies.Add(new Movies("2","Bullet Train","2.32","Action", "Sony Pictures", "Mary Vernieu"));
            ListOfMovies.Add(new Movies("3","Beast","1.33","Thriller","Universal Studios", "Idris Elba"));
            ListOfMovies.Add(new Movies("4","Wolfwalkers","1.43","Adventure","Apple", "Eva Whittaker"));
            ListOfMovies.Add(new Movies("5","Nope","2.15","Horror","Universal Studios", "Mubutu Mukeke"));
            ListOfMovies.Add(new Movies("6","Where The Crawdads Sing","2.06","Mystery","Sony Pictures", "Daisy Edgar Jones"));
            ListOfMovies.Add(new Movies("7", "Orphan: First Kill", "1.39", "Horror", "ParamountPlayers", "Isabelle Fuhrman"));
            ListOfMovies.Add(new Movies("8", "Vortex", "2.15", "Drama", "Wild Bunch", "Dario Argento"));
            ListOfMovies.Add(new Movies("9", "Annette", "2.19", "Musical", "Amazon Studios", "ingen da FAEN"));
            ListOfMovies.Add(new Movies("10", "The Black Phone", "1.47", "Horror", "Universal Studios", "Ethan Hawke"));
            ListOfMovies.Add(new Movies("11", "The Survivor", "2.12", "Drama", "HBO Films", "Ben Foster"));
            ListOfMovies.Add(new Movies("12", "Belle", "2.02", "Adventure","Toho","Kaho Nakamura"));
            ListOfMovies.Add(new Movies("13", "Beautiful Beings","2.03","Drama","her var det jo INGENTING", "Blær Hinriksson"));
            ListOfMovies.Add(new Movies("14", "The Northman", "2.20","Action","Universal Studios","Anya Taylor Joy"));
            ListOfMovies.Add(new Movies("15", "Memoria","2.16","Fantasy","Neon","UEKSISTERENDE"));

            while (IsProgramRunning == true)
            {
                PrintOptions();
                var userInput = Console.ReadLine();
                HandleMenuOptions(userInput);
            }
        }

        private void ShowMovies()
        {
            foreach (var movie in ListOfMovies)
            {
                Console.WriteLine($"Id: {movie.Id},\n Name: {movie.Name},\n Playtime: {movie.Playtime}\n Genre: {movie.Genre}\n Studio: {movie.Studio}\n Main Actor: {movie.MainActor}\n");
                
            }


        }

        private void PrintOptions()
        {
            Console.WriteLine("Welcome to our movie library, please choose an option:");
            Console.WriteLine("1. List up all current movies");
            Console.WriteLine("2. Search for a movie");
            Console.WriteLine("3. Choose a movie to add to favorite");
            Console.WriteLine("4. Choose a movie to Remove from Favorite");
            Console.WriteLine("5. Show Favorite");
            Console.WriteLine("6. Exit");
        }

        private void HandleMenuOptions(string menuOption)
        {
            if (menuOption == "1") { ShowMovies(); }
            else if (menuOption == "3") { AddMovie(); }
            else if (menuOption == "4") { RemoveMovie(); }
            else if (menuOption == "5")
            {
                Console.WriteLine("\n Your favorite are \n");
                user.ShowFavorite();
            }
            else if (menuOption == "6") { IsProgramRunning = false; }
        }

        private Movies GetFavoritList(string id)
        {
            return ListOfMovies.FirstOrDefault(movie => movie.Id == id);
        }

        private void AddMovie()
        {
            var chosenMovieId = Console.ReadLine();
            var movieFavorite = GetFavoritList(chosenMovieId);
            user.AddFavorrite(movieFavorite);
            Console.WriteLine($"we have added {movieFavorite.Name} to your favorites!");
        }

        private void RemoveMovie()
        {
            user.ShowFavorite();
            var movieId = Console.ReadLine();
            var movieToRemove = GetFavoritList(movieId);
            user.RemoveFavorite(movieToRemove);
            Console.WriteLine($"We have removed {movieToRemove.Name} from your favorites!");
        }
    }


}
