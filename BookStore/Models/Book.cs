using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Створіть додаток «Книгарня». Основне завдання проєкту
 * — враховувати поточний асортимент книг в магазині.
 * Необхідно зберігати наступну інформацію про книги: 
 * назва книги, ПІБ автора, назва видавництва, кількість 
 * сторінок, жанр, рік видання, собівартість, ціна для 
 * продажу, чи є книга продовженням якоїсь іншої книги 
 * (наприклад, друга частина дилогії). Додаток має
 * дозволяти: додавати книги, видаляти книги, редагувати
 * параметри книг, продавати книги, списувати книги,
 * вносити книги в акції (наприклад, тиждень книг 
 * новорічної тематики зі знижкою 10%), відкласти 
 * книги для конкретного покупця. Додаток має 
 * надати функціональність пошуку книг за такими параметрами: 
 * назва книги, автор, жанр. Додаток має надавати можливість
 * переглядати список новинок, список найпопулярніших книг,
 * список найпопулярніших авторів, список найпопулярніших жанрів
 * за підсумками дня, тижня, місяця, року. Необхідно передбачити
 * можливість входу за логіном і паролем.*/
namespace BookStore.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Pages { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
        public int PablisherYear { get; set; }

        public DateOnly TimeOfAdd { get; set; }

        public int? IdPreviousBook { get; set; }

        public int AvtorId { get; set; }
        public Avtor? Avtor { get; set; }


        public int GenreId { get; set; }
        public Genre? Genre { get; set; }


        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }


        public List<Promotion> Promotions { get; set; }
    }
}
