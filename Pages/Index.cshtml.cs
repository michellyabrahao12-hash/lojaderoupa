using lojaderoupa.Data;
using lojaderoupa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lojaderoupa.Pages;

public class IndexModel : PageModel
{
    
    private readonly Roupasrepositorios _produto;

    public Produto produto {get;set;}

    public IndexModel (Roupasrepositorios repositori)
    {
        _produto = repositori;
    }
    public void OnGet()
    {
       produto = _produto.listaDeProduto ();
    }
}
