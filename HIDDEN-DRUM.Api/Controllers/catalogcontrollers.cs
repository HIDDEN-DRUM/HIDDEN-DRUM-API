using Micosoft.AspNetCore.Mvc;
using HIDDEN-DRUM.Domain.Catalog;

namespace HIDDEN-DRUM-API.Controllers
{[ApiController]
[RouteController]
public class CatalogController : ControllerBase
{


[HttpGet]
public IActionResult GetItems()
    Var items = new List <Item>(){
        new Item("Shirt", 'Ohio State Shirt" , "Nike", 29.99m")
        new Item("Shorts", 'Ohio State Shorts" , "Nike", 44.99m")
    };
    return Ok (Items);
}
}
