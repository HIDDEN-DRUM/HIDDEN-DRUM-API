using Micosoft.AspNetCore.Mvc;
using HIDDEN-DRUM.Domain.Catalog;

namespace HIDDEN-DRUM-API.Controllers
[ApiController]
[RouteController]
public class CatalogController : ControllerBase
{
[HttpGet]
public IActionResult GetItems(){
    Var items = new List <Item>(){
        new Item("Shirt", 'Ohio State Shirt" , "Nike", 29.99m")
        new Item("Shorts", 'Ohio State Shorts" , "Nike", 44.99m")
    };
    return Ok (Items);
}
[HttpGet]
public IActionResult GetItems()
    Var items = new List <Item>(){
        new Item ("Shirt", 'Ohio State Shirt" , "Nike", 29.99m")
        new Item ("Shorts", 'Ohio State Shorts" , "Nike", 44.99m")
    };
    return Ok (Items);
}
[HttpGet("{id:int}")]
    public IActionResult GetItems(int id){
     var Item = new item("Shirt", 'Ohio State Shirt" , "Nike", 29.99m")
     item.id = id;
     return Ok(Item);
    }
[HttpPost]
public IActionResult Post(Item Item){
    Return Created("/catalog/42". Item)
    }

[HttpPost("{id:int}/ratings")]
     public IActionResult PostRating(int id, [FromBody]Rating rating){
        var Item = new item("Shirt", 'Ohio State Shirt" , "Nike", 29.99m");
        item.id = id;
     Item.AddRating(rating)
     return Ok(Item)
     }
    [HttpPut("{Id:int}")]
    public IActionResult Put(int id, Item item){
        return NoContent();
}
[HttpDelete("{Id:int}")]
    public IActionResult Delete(int id,){
        return NoContent();
    }