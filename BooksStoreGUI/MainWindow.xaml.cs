using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksStoreBL.BookStoreBL booksStoreBL; 
        public MainWindow()
        {
            booksStoreBL = new BooksStoreBL.BookStoreBL();
            
            InitializeComponent();
            /*var res = booksStoreBL.GetAllBooks();
            BooksDataGrid.ItemsSource = res;*/

            //תרגיל 1
            /*var res=booksStoreBL.GetExpensiveBooks();
            BooksDataGrid.ItemsSource = res;*/

            //תרגיל 2
            /*var res = booksStoreBL.GetOrderBooks();
            BooksDataGrid.ItemsSource = res;*/

            //תרגיל 3
            /*var res = booksStoreBL.GetComicBooks();
            BooksDataGrid.ItemsSource = res;*/

            //תרגיל 4
            var res = booksStoreBL.Get9Books();
            BooksDataGrid.ItemsSource = res;
        }
    }
}
