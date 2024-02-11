using System;
namespace myProject
{
        class Movies
        {
            private int _Id;  
            private string _Title;  
            private int _ReleaseDate; 

            //Default Constructor
            public Movies()
            {
                _Id = 0;
                _Title = "";
                _ReleaseDate = 0;
            }

            //Parameterized Constructor
            public Movies(int i, string Title, int ReleaseDate)
            {
                _Id = i;
                _Title = Title;
                _ReleaseDate = ReleaseDate;
            }
            //Get Methods

            public int GetId()
            {
                return _Id;
            }
            public string GetTitle()
            {
                return _Title;
            }
            public int GetReleaseDate()
            {
                return _ReleaseDate;
            }
            //Set Methods
            public void SetId(int identification)
            {
                _Id = identification;
            }

            public void SetTitle(string title)
            {
                _Title = title;
            }

            public void SetReleaseDate(int releaseDate)
            {
                _ReleaseDate = releaseDate;
            }
        }

        class myLibrary
        {
            static void Main(string[] args)
            {
                //Movie object w/ default constructor
                Movies movie1 = new Movies();
                movie1.SetId(1);
                movie1.SetTitle("Harry Potter and the Sorcerer's Stone");
                movie1.SetReleaseDate(2001);

            //Movie object w/ default constructor (prompt user)
                Movies movie2 = new Movies();
                Console.WriteLine("Please enter the ID: ");
                movie2.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter the title of the movie:");
                movie2.SetTitle(Console.ReadLine());
                Console.WriteLine("Please enter the year the movie was released:");
                movie2.SetReleaseDate(int.Parse(Console.ReadLine()));

            //book object w/ parameterized constructor
                Movies movie3 = new Movies(3, "Fantastic Beasts and Where to Find Them", 2016);

            //book object w/ parameterized constructor(prompt user)
                Console.WriteLine("Please enter the ID: ");
                int tempID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the title of the Movie: ");
                string tempTitle = Console.ReadLine();
                Console.WriteLine("Please enter the year the movie was released: ");
                int tempReleaseDate = int.Parse(Console.ReadLine());
                Movies movie4 = new Movies(tempID, tempTitle, tempReleaseDate);

            //Call movie
                displayMovie(movie1);
                displayMovie(movie2);
                displayMovie(movie3);
                displayMovie(movie4);

        }
            //Name the method displayMovies

            static void displayMovie(Movies movie)
            {
                Console.WriteLine("Here's the Movie's information");
                Console.WriteLine($"Movie ID: {movie.GetId()}");
                Console.WriteLine($"Movie Title: {movie.GetTitle()}");
                Console.WriteLine($"Movie Release Date: {movie.GetReleaseDate()}");
                Console.ReadKey();
            }
        }
    }

