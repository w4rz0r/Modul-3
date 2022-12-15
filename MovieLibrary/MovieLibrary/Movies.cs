namespace MovieLibrary
{
    class Movies
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Playtime { get; set; }
        public string Genre { get; set; }
        public string MainActor { get; set; }
        public string Studio { get; set; }

        private List<Movies> Favorite { get; set; }

        public Movies(string id, string name, string playtime, string genre, string studio, string mainActor)
        {
            Id = id;
            Name = name;
            Playtime = playtime;
            Genre = genre;
            MainActor = mainActor;
            Studio = studio;
            Favorite = new List<Movies>();
        }

        public void ShowFavorite()
        {
            foreach (var fmovie in Favorite)
            {
                Console.WriteLine($"Id: {fmovie.Id}\n Name: {fmovie.Name}\n Playtime: {fmovie.Playtime}\n Genre: {fmovie.Genre}\n Studio: {fmovie.Studio}\n Main Actor: {fmovie.MainActor}\n");
            }
        }

        public void AddFavorrite(Movies movieToAdd)
        {
            Favorite.Add(movieToAdd);
        }

        public void RemoveFavorite(Movies movieToRemove)
        {
            Favorite.Remove(movieToRemove);
        }

    }
}

  
