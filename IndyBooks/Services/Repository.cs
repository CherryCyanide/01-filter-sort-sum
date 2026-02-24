using IndyBooks.Models;
using IndyBooks.ViewModels;

namespace IndyBooks.Services;

public class Repository
{
    private IndyBooksDataContext _db;

    public Repository(IndyBooksDataContext db)
    {
        _db = db;
    }   
    //Property to return ALL Books on sale (price greater than 90) with the price reduced by 50%
    public decimal sale{ get; set; } = 0.5m; //percentage off for the sale
    private int SaleLimit { get;set; } = 90; // the item price above this amount will be on sale
    //DONE: complete the SaleResults property to show reduced-priced books
    public IEnumerable<Book> SaleResults => _db.Books
        .Where( s => s.Price >= SaleLimit);

    //TODO: complete method to return search results based on the given SearchVM criteria
    public IEnumerable<Book> searchResults(SearchVM searchVM) {
            IQueryable<Book> foundBooks = _db.Books; // start with entire collection

            //Filter the collection using the non-empty Title Field as noted
            if (searchVM.Title != null && searchVM.Title.Trim().Length > 0)
            {
                //Filter the collection by Title which "contains" the given string
                foundBooks = foundBooks
                             .Where(b => b.Title.Contains(searchVM.Title));
                // TODO: Order the results by Title
            }

            //TODO: Add similar logic to filter foundbooks collection by last part of the Author's Name, if given
            // (HINT: consider the EndsWith() method, also adjust the Search View and ViewModel to add items)

            //TODO: Add similar logic to filter foundbooks collection by price, if given
            //       order the results by descending price 
            // (Note: you will need to adjust the Search ViewModel and View to add search fields)


            return foundBooks.ToList();
    }   

};     


