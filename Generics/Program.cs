using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);
            books.Add(new Book());

            var dictionary = new GenericDictionaryByAJ<string, Book>();
            dictionary.Add("1234", new Book());

            var discountBook = new DiscountCalculator<Book>();
            discountBook.CalculateDiscount(new Book());

            var discountProduct = new DiscountCalculator<Product>();
            discountProduct.CalculateDiscount(new Book());
            discountProduct.CalculateDiscount(new Product());

            var number = new Nullable<int>();
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            Console.WriteLine();

            number = new Nullable<int>(5);
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
