using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksStoreDAL;
using Entities;

namespace BooksStoreBL
{
    public class BookStoreBL
    {
        List<BookDetails> ListOfBooks;
        List<BookDetails> ListExpensiveBook;
        List<BookDetails> orderList;
        List<int> ComicsList;
        List<string> Books9List;
        FileConnection fileConnection;
        public BookStoreBL()
        {
            fileConnection = new FileConnection();
            ListOfBooks = fileConnection.ReadAllBooks();
            ListExpensiveBook = fileConnection.ExpensiveBook();
            orderList = fileConnection.BookOrderById();
            ComicsList = fileConnection.ComicsBook();
            Books9List = fileConnection.Book9();

        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return ListOfBooks;
        }
        public IEnumerable<BookDetails> GetExpensiveBooks()
        {
            return ListExpensiveBook;
        }
        public IEnumerable<BookDetails> GetOrderBooks()
        {
            return orderList;
        }
        public IEnumerable<int> GetComicBooks()
        {
            return ComicsList;
        }
        public IEnumerable<string> Get9Books()
        {
            return Books9List;
        }
    }
}
