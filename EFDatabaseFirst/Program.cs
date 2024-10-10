using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.GetMovieList();
            client.GetGenreList();

            Console.Write("Nhap ten phim can tim: ");
            string movieName = Console.ReadLine();
            client.GetMovieInfo(movieName);

            Console.Write("\nNhap ten loai phim muon them: ");
            string genreName = Console.ReadLine();
            client.AddGenre(genreName);
            Console.WriteLine("Da them thanh cong");
            client.GetGenreList();

            Console.Write("\nNhap ID loai phim muon sua: ");
            string genreID = Console.ReadLine();
            Console.Write("\nNhap ten loai phim thay the: ");
            string genreNameUpdate = Console.ReadLine();
            client.UpdateGenre(genreID, genreNameUpdate);
            Console.WriteLine("Da sua thanh cong");
            client.GetGenreList();

            Console.Write("\nNhap ID loai phim muon xoa: ");
            string genreDeleteID = Console.ReadLine();
            client.DeleteGenre(genreDeleteID);
            Console.WriteLine("Da xoa thanh cong");
            client.GetGenreList();
        }
    }
}
