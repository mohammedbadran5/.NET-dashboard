using Microsoft.AspNetCore.Mvc;
using dashboard.Models; // Import your models
using dashboard.Data; // Import your data context

public class CardController : Controller
{
    private readonly AppDbContext _context;

    public CardController(AppDbContext context)
    {
        _context = context;
    }

    // Display cards (Read)
    public IActionResult Index()
    {
        var cards = _context.Cards.ToList();
        return View(cards);
    }

    // Add a new card (Create)
    // GET: /Card/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Card/Create
    [HttpPost]
    public IActionResult Create(Card card)
    {
        if (ModelState.IsValid)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(card);
    }


    // Edit a card (Update)
    public IActionResult Edit(int id)
    {
        var card = _context.Cards.Find(id);
        if (card == null)
        {
            return NotFound();
        }
        return View(card);
    }

    [HttpPost]
    public IActionResult Edit(Card card)
    {
        if (ModelState.IsValid)
        {
            _context.Cards.Update(card);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(card);
    }

    // Delete a card (Delete)
    public IActionResult Delete(int id)
    {
        var card = _context.Cards.Find(id);
        if (card != null)
        {
            _context.Cards.Remove(card);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public IActionResult UserIndex()
    {
        var cards = _context.Cards.ToList();
        return View(cards);
    }
}
