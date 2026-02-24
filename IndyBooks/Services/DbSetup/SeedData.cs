using System;
using System.Linq;
using System.Threading.Tasks;
using IndyBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IndyBooks.Services
{
    internal class SeedData
    {
        internal static void Initialize(IndyBooksDataContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            if (dbContext.Books.Any()) return;

            //  DONE : Create two additional books in the seed data 
            //         then update the database using dotnet-ef database commands
            //
            var Books = new Book[] {
                new Book
                {
                    Title = "I Have No Mouth and I Must Scream",
                    Author = "Harlan Ellison",
                    Price = 2.00M,
                    Year = "1967"
                },
                new Book
                {
                    Title = "No Longer Human",
                    Author = "Osamu Dazai",
                    Price = 22.00M,
                    Year = "1948"
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    Author = "Jane Austin",
                    Price = 9.99M,
                    Year = "1813"
                },
                new Book
                {
                    Title = "Northanger Abbey",
                    Author = "Jane Austin",
                    Edition = "3",
                    Price = 12.95M,
                    Year = "1817"
                },
                new Book
                {
                    Title = "David Copperfield",
                    Author = "Charles Dickens",
                    Edition = "1",
                    Price = 150.00M
                },
                new Book
                {
                    Title = "The Wizard of EarthSea",
                    Author = "Ursula Le Guin",
                    Price = 8.95M
                },
                new Book
                {
                    Title = "The Tombs of Atuan",
                    Author = "Ursula Le Guin",
                    Price = 7.95M
                },
                new Book
                {
                    Title = "The Farthest Shore",
                    Author = "Ursula Le Guin",
                    Edition = "1",
                    Price = 53.00M
                },
                new Book
                {
                    Title = "The Odyssey",
                    Author = "Doris Lessing",
                    Edition = "",
                    Price = 36.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Madame Bovary",
                    Author = "Barbara Cartland",
                    Edition = "",
                    Price = 2.00M,
                    Year = ""
                },
                new Book
                {
                    Title = " Oedipus at Colonus",
                    Author = "Franz Kafka",
                    Edition = "",
                    Price = 14.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Vanity Fair",
                    Author = "Horatio Alger",
                    Edition = "",
                    Price = 67.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Oedipus",
                    Author = "C.S. Lewis",
                    Edition = "",
                    Price = 22.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    Author = "Bella Forrest",
                    Edition = "",
                    Price = 8.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Gargantua and Pantagruel",
                    Author = "Jin Yong",
                    Edition = "",
                    Price = 54.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Scarlet Letter",
                    Author = "Nathaniel Hawthorne",
                    Edition = "",
                    Price = 79.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Gone With the Wind",
                    Author = "Flannery O'Connor",
                    Edition = "",
                    Price = 27.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Grapes of Wrath",
                    Author = "Carolyn Brown",
                    Edition = "",
                    Price = 36.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "One Hundred Years of Solitude",
                    Author = "Flannery O'Connor",
                    Edition = "",
                    Price = 48.00M,
                    Year = ""
                },
                new Book
                {
                    Title = " Oedipus at Colonus",
                    Author = "Rachel Hollis",
                    Edition = "",
                    Price = 69.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Tristram Shandy",
                    Author = "Barbara Cartland",
                    Edition = "",
                    Price = 87.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Tess of the d'Urbervilles",
                    Author = "Franz Kafka",
                    Edition = "",
                    Price = 75.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Scarlet Letter",
                    Author = "Tennessee Williams",
                    Edition = "",
                    Price = 91.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Great Expectations",
                    Author = "Walt Whitman",
                    Edition = "",
                    Price = 48.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "William Faulkner",
                    Edition = "",
                    Price = 10.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Lord of The Rings",
                    Author = "Henry James",
                    Edition = "",
                    Price = 71.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "To the Lighthouse",
                    Author = "Mark Twain",
                    Edition = "",
                    Price = 6.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Magic Mountain",
                    Author = "Ray Bradbury",
                    Edition = "",
                    Price = 63.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "To the Lighthouse",
                    Author = "Alexandre Dumas",
                    Edition = "",
                    Price = 39.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Tess of the d'Urbervilles",
                    Author = "J. K. Rowling",
                    Edition = "",
                    Price = 21.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Gargantua and Pantagruel",
                    Author = "Walt Whitman",
                    Edition = "",
                    Price = 78.00M,
                    Year = ""
                },
                new Book
                {
                    Title = " Oedipus at Colonus",
                    Author = "Alexander Pushkin",
                    Edition = "",
                    Price = 52.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Great Gatsby",
                    Author = "Margaret Atwood",
                    Edition = "",
                    Price = 50.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Oedipus",
                    Author = "Guillaume Musso",
                    Edition = "",
                    Price = 9.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Anna Karenina",
                    Author = "Oscar Wilde",
                    Edition = "",
                    Price = 89.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Red and the Black",
                    Author = "T. S. Eliot",
                    Edition = "",
                    Price = 83.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Grapes of Wrath",
                    Author = "Horatio Alger",
                    Edition = "",
                    Price = 93.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "Ulysses",
                    Author = "Oscar Wilde",
                    Edition = "",
                    Price = 45.00M,
                    Year = ""
                },
                new Book
                {
                    Title = "The Sound and the Fury",
                    Author = "Stephen King",
                    Edition = "",
                    Price = 8.00M,
                    Year = "1978"
                },
                new Book
                {
                    Title = "Wuthering Heights",
                    Author = "Henry James",
                    Edition = "",
                    Price = 41.00M,
                    Year = "1957"
                },
                new Book
                {
                    Title = "To the Lighthouse",
                    Author = "Jack London",
                    Edition = "",
                    Price = 90.00M,
                    Year = "1851"
                },
                new Book
                {
                    Title = "The Handmaid's Tale",
                    Author = "Kurt Vonnegut",
                    Edition = "",
                    Price = 60.00M,
                    Year = "1948"
                },
                new Book
                {
                    Title = "The Handmaid's Tale",
                    Author = "Kurt Vonnegut",
                    Edition = "",
                    Price = 67.00M,
                    Year = "1871"
                },
                new Book
                {
                    Title = "Invisible Man",
                    Author = "Ralph Ellison",
                    Edition = "1",
                    Price = 101.00M,
                    Year = "1952"
                },
                new Book
                {
                    Title = "One Hundred Years of Solitude",
                    Author = "Robert Frost",
                    Edition = "",
                    Price = 72.00M,
                    Year = "1839"
                },
                new Book
                {
                    Title = "Anna Karenina",
                    Author = "Nathaniel Hawthorne",
                    Edition = "",
                    Price = 59.00M,
                    Year = "1973"
                },
                new Book
                {
                    Title = "One Hundred Years of Solitude",
                    Author = "J. K. Rowling",
                    Edition = "",
                    Price = 71.00M,
                    Year = "1979"
                },
                new Book
                {
                    Title = "The Flowers of Evil",
                    Author = "Mary Shelley",
                    Edition = "",
                    Price = 39.00M,
                    Year = "1871"
                },
                new Book
                {
                    Title = "The Red and the Black",
                    Author = "Paulo Coelo",
                    Edition = "",
                    Price = 0.00M,
                    Year = "1821"
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "Stephenie Meyer",
                    Edition = "",
                    Price = 60.00M,
                    Year = "1989"
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    Author = "Flannery O'Connor",
                    Edition = "",
                    Price = 34.00M,
                    Year = "1856"
                },
                new Book
                {
                    Title = "In Search of Lost Time",
                    Author = "Ralph Waldo Emerson",
                    Edition = "",
                    Price = 9.00M,
                    Year = "1814"
                },
                new Book
                {
                    Title = "The Odyssey",
                    Author = "William Shakespeare",
                    Edition = "",
                    Price = 68.00M,
                    Year = "1847"
                },
                new Book
                {
                    Title = "Alice Adventures in Wonderland",
                    Author = "Franz Kafka",
                    Edition = "",
                    Price = 53.00M,
                    Year = "1922"
                },
                new Book
                {
                    Title = "The Grapes of Wrath",
                    Author = "Franz Kafka",
                    Edition = "",
                    Price = 39.00M,
                    Year = "1808"
                },
                new Book
                {
                    Title = "Nineteen Eighty Four",
                    Author = "Robert Frost",
                    Edition = "",
                    Price = 98.00M,
                    Year = "1806"
                },
                new Book
                {
                    Title = "Wuthering Heights",
                    Author = "Jin Yong",
                    Edition = "",
                    Price = 44.00M,
                    Year = "1974"
                },
                new Book
                {
                    Title = "The Brothers Karamazov ",
                    Author = "Jin Yong",
                    Edition = "",
                    Price = 82.00M,
                    Year = "1872"
                },
                new Book
                {
                    Title = "Robinson Crusoe",
                    Author = "Guillaume Musso",
                    Edition = "",
                    Price = 95.00M,
                    Year = "1900"
                },
                new Book
                {
                    Title = "The Sound and the Fury",
                    Author = "Stephen King",
                    Edition = "",
                    Price = 69.00M,
                    Year = "1999"
                },
                new Book
                {
                    Title = "Moby Dick",
                    Author = "Doris Lessing",
                    Edition = "",
                    Price = 0.00M,
                    Year = "1987"
                },
                new Book
                {
                    Title = "Hamlet",
                    Author = "Jin Yong",
                    Edition = "",
                    Price = 61.00M,
                    Year = "1997"
                },
                new Book
                {
                    Title = "War and Peace",
                    Author = "Ernest Hemingway",
                    Edition = "",
                    Price = 36.00M,
                    Year = "1948"
                },
                new Book
                {
                    Title = "Oedipus",
                    Author = "Tennessee Williams",
                    Edition = "",
                    Price = 69.00M,
                    Year = "1854"
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    Author = "Jin Yong",
                    Edition = "",
                    Price = 65.00M,
                    Year = "1845"
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "Alexander Pushkin",
                    Edition = "",
                    Price = 73.00M,
                    Year = "1842"
                },
                new Book
                {
                    Title = "Ulysses",
                    Author = "Walt Whitman",
                    Edition = "",
                    Price = 47.00M,
                    Year = "1968"
                },
                new Book
                {
                    Title = "The Grapes of Wrath",
                    Author = "Jin Yong",
                    Edition = "",
                    Price = 87.00M,
                    Year = "1969"
                },
                new Book
                {
                    Title = "The Sound and the Fury",
                    Author = "Emily Dickinson",
                    Edition = "2",
                    Price = 91.00M,
                    Year = "1803"
                },
                new Book
                {
                    Title = "One Thousand and One Nights",
                    Author = "Stephen King",
                    Edition = "2",
                    Price = 76.00M,
                    Year = "1968"
                },
                new Book
                {
                    Title = "The Scarlet Letter",
                    Author = "Edgar Allan Poe",
                    Edition = "2",
                    Price = 5.00M,
                    Year = "1954"
                },
                new Book
                {
                    Title = "Great Expectations",
                    Author = "Nathaniel Hawthorne",
                    Edition = "1",
                    Price = 39.00M,
                    Year = "1937"
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "Carlos Ruiz Zafon",
                    Edition = "2",
                    Price = 61.00M,
                    Year = "1946"
                },
                new Book
                {
                    Title = "The Handmaid's Tale",
                    Author = "Alexandre Dumas",
                    Edition = "2",
                    Price = 62.00M,
                    Year = "1901"
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "Nathaniel Hawthorne",
                    Edition = "2",
                    Price = 20.00M,
                    Year = "1901"
                },
                new Book
                {
                    Title = "Ulysses",
                    Author = "J. K. Rowling",
                    Edition = "2",
                    Price = 97.00M,
                    Year = "1847"
                },
                new Book
                {
                    Title = "Gargantua and Pantagruel",
                    Author = "Bella Forrest",
                    Edition = "1",
                    Price = 37.00M,
                    Year = "1871"
                },
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    Author = "F. Scott Fitzgerald",
                    Edition = "1",
                    Price = 30.00M,
                    Year = "1853"
                },
                new Book
                {
                    Title = "Game of Thrones",
                    Author = "Stephenie Meyer",
                    Edition = "2",
                    Price = 23.00M,
                    Year = "1889"
                },
                new Book
                {
                    Title = "Moby Dick",
                    Author = "Dr. Seuss",
                    Edition = "2",
                    Price = 48.00M,
                    Year = "1990"
                },
                new Book
                {
                    Title = "Moby Dick",
                    Author = "Oscar Wilde",
                    Edition = "1",
                    Price = 51.00M,
                    Year = "1983"
                },
                new Book
                {
                    Title = "Paradise Lost",
                    Author = "Paulo Coelo",
                    Edition = "2",
                    Price = 68.00M,
                    Year = "1973"
                },
                new Book
                {
                    Title = "Great Expectations",
                    Author = "Herman Melville",
                    Edition = "1",
                    Price = 27.00M,
                    Year = "2004"
                },
                new Book
                {
                    Title = "Great Expectations",
                    Author = "Stephenie Meyer",
                    Edition = "2",
                    Price = 30.00M,
                    Year = "1975"
                },
                new Book
                {
                    Title = "Gone With the Wind",
                    Author = "Leo Tolstoy",
                    Edition = "1",
                    Price = 56.00M,
                    Year = "1867"
                },
                new Book
                {
                    Title = "Vanity Fair",
                    Author = "Jane Austen",
                    Edition = "2",
                    Price = 41.00M,
                    Year = "1876"
                },
                new Book
                {
                    Title = "Nineteen Eighty Four",
                    Author = "T. S. Eliot",
                    Edition = "2",
                    Price = 24.00M,
                    Year = "1911"
                },
                new Book
                {
                    Title = "Lolita",
                    Author = "Ray Bradbury",
                    Edition = "1",
                    Price = 8.00M,
                    Year = "1995"
                },
                new Book
                {
                    Title = "Anna Karenina",
                    Author = "Mary Shelley",
                    Edition = "2",
                    Price = 83.00M,
                    Year = "1809"
                },
                new Book
                {
                    Title = "Gulliver's Travels",
                    Author = "Robert Frost",
                    Edition = "1",
                    Price = 17.00M,
                    Year = "1812"
                },
                new Book
                {
                    Title = "The Good Soldier",
                    Author = "Jack London",
                    Edition = "1",
                    Price = 19.00M,
                    Year = "1914"
                },
                new Book
                {
                    Title = "The Brothers Karamazov ",
                    Author = "Horatio Alger",
                    Edition = "1",
                    Price = 89.00M,
                    Year = "1906"
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "John Steinbeck",
                    Edition = "1",
                    Price = 45.00M,
                    Year = "1945"
                },
                new Book
                {
                    Title = "The Odyssey",
                    Author = "J. K. Rowling",
                    Edition = "2",
                    Price = 35.00M,
                    Year = "1971"
                },
                new Book
                {
                    Title = "One Hundred Years of Solitude",
                    Author = "Leo Tolstoy",
                    Edition = "1",
                    Price = 83.00M,
                    Year = "1861"
                },
                new Book
                {
                    Title = "Les Misérables",
                    Author = "Jin Yong",
                    Edition = "1",
                    Price = 78.00M,
                    Year = "1912"
                },
                new Book
                {
                    Title = "The Old Man and the Sea",
                    Author = "Flannery O'Connor",
                    Edition = "1",
                    Price = 46.00M,
                    Year = "1987"
                },
                new Book
                {
                    Title = "The Red and the Black",
                    Author = "Jane Austen",
                    Edition = "2",
                    Price = 30.00M,
                    Year = "1808"
                },
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    Author = "J. K. Rowling",
                    Edition = "1",
                    Price = 33.00M,
                    Year = "1898"
                },
                new Book
                {
                    Title = "Wuthering Heights",
                    Author = "Herman Melville",
                    Edition = "2",
                    Price = 60.00M,
                    Year = "1950"
                },
                new Book
                {
                    Title = "Vanity Fair",
                    Author = "Oscar Wilde",
                    Edition = "1",
                    Price = 75.00M,
                    Year = "1971"
                },
                new Book
                {
                    Title = "The Canterbury Tales",
                    Author = "Ernest Hemingway",
                    Edition = "1",
                    Price = 67.00M,
                    Year = "1806"
                },
                new Book
                {
                    Title = "The Good Soldier",
                    Author = "Ernest Hemingway",
                    Edition = "1",
                    Price = 77.00M,
                    Year = "1824"
                },
                new Book
                {
                    Title = "Tess of the d'Urbervilles",
                    Author = "Paulo Coelo",
                    Edition = "2",
                    Price = 13.00M,
                    Year = "1805"
                },
                new Book
                {
                    Title = "The Invisible Man",
                    Author = "H.G. Wells",
                    Edition = "2",
                    Price = 87.00M,
                    Year = "1899"
                },
                new Book
                {
                    Title = "The Sound and the Fury",
                    Author = "Emily Dickinson",
                    Edition = "2",
                    Price = 38.00M,
                    Year = "1996"
                },
                new Book
                {
                    Title = "Tristram Shandy",
                    Author = "Margaret Atwood",
                    Edition = "2",
                    Price = 13.00M,
                    Year = "1858"
                },
                new Book
                {
                    Title = "The Good Soldier",
                    Author = "Oscar Wilde",
                    Edition = "1",
                    Price = 30.00M,
                    Year = "1994"
                }
            };

            //Add to DbContext and update Database
            foreach(var book in Books)
                dbContext.Books.Add(book);

            dbContext.SaveChanges();
        }
    }
}
