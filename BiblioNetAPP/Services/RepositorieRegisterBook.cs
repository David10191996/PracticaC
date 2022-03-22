using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{
    public interface IRepositorieBook
    {
        void RegisterBook(Book book);
    }
    public class RepositorieBook : IRepositorieBook
    {
        private readonly string connectionString;

        public RepositorieBook(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void RegisterBook(Book book)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO Books (Name_book, Cant,Price,Author,Gender,Editorial)
                                    VALUES (@BookName,@Cant,@Price,@Author,@Gender,@Editorial); SELECT SCOPE_IDENTITY();", book);

            book.Id = id;

        }
    }
}
