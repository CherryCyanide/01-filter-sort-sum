using IndyBooks.Services;
using IndyBooks.Models;
using IndyBooks.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace IndyBooks.Tests;

public class SearchTests
{
    private DbContextOptions<IndyBooksDataContext> _dbContextOptions;
    private Repository repository;

    public SearchTests()
    {
         _dbContextOptions = new DbContextOptionsBuilder<IndyBooksDataContext>()
           .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
           .Options;

        using(var context = new IndyBooksDataContext(_dbContextOptions))
        {
            context.Database.EnsureCreated();
            // Seed the in-memory database with test data
            context.Books.AddRange(
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 16m },
            new Book { Id = 2, Title = "To Know These Days", Author = "Hae Jee", Price = 60m },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Price = 96m },
            new Book { Id = 4, Title = "Two Towers", Author = "J.R.R. Tolkien", Price = 23m }
            );
            context.SaveChanges();
        }
    }
    [Fact]
    public void SaleResultCorrectlyCalculatesPrice()
    {
        // Arrange
        using var context = new IndyBooksDataContext(_dbContextOptions);
        repository = new Repository(context);
        var price = 101m;
        var sale = 0.20m;
        repository.SaleLimit = 100;
        repository.sale = sale;

        var book = context.Books.Where(b => b.Id == 4).Single();
        book.Price = price;
        context.Books.Update(book);
        context.SaveChanges();

        // Act
        var results = repository.SaleResults.ToList();

        // Assert
        Assert.Equal(results[0].Price, price * sale);
    }
    [Fact]
    public void SearchContainsBooksWithTitleContainingSearchTerm()
    {
        // Arrange
        using var context = new IndyBooksDataContext(_dbContextOptions);
        repository = new Repository(context);
        var searchVM = new SearchVM { Title = "Great" };

        // Act
        var results = repository.searchResults(searchVM).ToList();

        // Assert
        Assert.Single(results);
        Assert.Equal("The Great Gatsby", results[0].Title);
    }
    
    //TODO: Add Additional tests to get 100% coverage of Repository
    [Fact]
    public void SearchContainsAllBooksLessThanMaxPrice()
    {
        // Arrange
        using var context = new IndyBooksDataContext(_dbContextOptions);
        repository = new Repository(context);
        var searchVM = new SearchVM { MaxPrice = 25m };

        // Act
        var results = repository.searchResults(searchVM).ToList();

        // Assert
        Assert.Equal(2, results.Count);
        Assert.All(results, b => Assert.True(b.Price <= 25m));
        Assert.True(results[0].Price >= results[1].Price);
    }


    [Fact]
    public void SearchContainsBooksWithinMinAndMaxPriceRangeInDescendingOrder()
    {
        // Arrange
        using var context = new IndyBooksDataContext(_dbContextOptions);
        repository = new Repository(context);
        var searchVM = new SearchVM { MinPrice = 20m, MaxPrice = 100m };

        // Act
        var results = repository.searchResults(searchVM).ToList();

        // Assert
        Assert.Equal(3, results.Count);
        Assert.Equal("1984", results[0].Title);
        Assert.Equal("To Know These Days", results[1].Title);
        Assert.Equal("Two Towers", results[2].Title);
        Assert.True(results[0].Price >= results[1].Price);
        Assert.True(results[1].Price >= results[2].Price);
    }
    
}
