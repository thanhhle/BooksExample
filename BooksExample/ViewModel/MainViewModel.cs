using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Linq;
using System.Windows.Input;

namespace BooksExample.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        // Entity Framework DBContext
        private BooksEntities _dbcontext = new BooksEntities();

        private string _output;

        public string Output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
                RaisePropertyChanged(() => Output);
            }
        }

        /// <summary>
        /// The command that triggers adding a new member.
        /// </summary>
        public ICommand ButtonACommand { get; private set; }

        /// <summary>
        /// The command that triggers exiting the application.
        /// </summary>
        public ICommand ButtonBCommand { get; private set; }

        /// <summary>
        /// The command that triggers changing a member.
        /// </summary>
        public ICommand ButtonCCommand { get; private set; }

        /// <summary>
        /// The command that triggers exiting the application.
        /// </summary>
        public ICommand ExitCommand { get; private set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ButtonACommand = new RelayCommand(ButtonAMethod);
            ButtonBCommand = new RelayCommand(ButtonBMethod);
            ButtonCCommand = new RelayCommand(ButtonCMethod);
            ExitCommand = new RelayCommand<IClosable>(ExitMethod);
        }

        /// <summary>
        /// Shows a new add screen.
        /// </summary>
        public void ButtonAMethod()
        {
            Output = "";
            // get authors and titles of each book they co-authored
            // ordered by title
            var authorsAndTitles1 =
                from book in _dbcontext.Titles
                from author in book.Authors
                orderby book.Title1
                select new
                {
                    author.FirstName,
                    author.LastName,
                    book.Title1
                };

            Output += (" Authors and titles (ordered by titles):");

            // display authors and titles in tabular format
            foreach (var element in authorsAndTitles1)
            {
                Output += String.Format("\r\n\t{0,-15}\t{1,-15}\t{2}", element.FirstName, element.LastName, element.Title1);
            } // end foreach
            Output += "\n";
        }

        /// <summary>
        /// Opens the change window.
        /// </summary>
        public void ButtonBMethod()
        {
            Output = "";

            // get authors and titles of each book they co-authored
            // ordered by title, author's last name, and author's first name
            var authorsAndTitles2 =
               from book in _dbcontext.Titles
               from author in book.Authors
               orderby book.Title1, author.LastName, author.FirstName
               select new
               {
                   author.FirstName,
                   author.LastName,
                   book.Title1
               };

            Output += " Authors and titles (ordered by titles, author's last name, and author's first name):";

            // display authors and titles in tabular format
            foreach (var element in authorsAndTitles2)
            {
                Output += String.Format("\r\n\t{0,-15}\t{1,-15}\t{2}", element.FirstName, element.LastName, element.Title1);
            } // end foreach
            Output += "\n";
        }

        /// <summary>
        /// Opens the change window.
        /// </summary>
        public void ButtonCMethod()
        {
            Output = "";

            // get authors and titles of each book they co-authored
            // group by title
            // sorted by title, author's last name, and author's first name
            var authorsByTitle =
                from book in _dbcontext.Titles
                orderby book.Title1
                select new
                {
                    Titles = book.Title1,
                    Authors = from author in book.Authors
                              orderby author.LastName, author.FirstName
                              select new
                              {
                                  author.LastName,
                                  author.FirstName
                              }
                };

            Output += " Authors grouped by title:";

            // display titles written by each author
            // grouped by title
            // sorted by title, lastname, firstname
            foreach (var title in authorsByTitle)
            {
                // display book's title
                Output += "\r\n\t" + title.Titles + ":";

                // display authors who co-authored the book
                foreach (var author in title.Authors)
                {
                    Output += String.Format("\r\n\t\t{0}\t{1}", author.FirstName, author.LastName);
                } // end inner foreach
                Output += "\n";
            } // end outer foreach
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void ExitMethod(IClosable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}