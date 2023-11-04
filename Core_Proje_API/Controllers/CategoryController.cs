using Core_Proje_API.API.ApiContext;
using Core_Proje_API.API.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //API Controller olduğunu bildiren attribute
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new Context();
            return Ok(c.Categories.ToList()); // Ok,  o metodun başarılı döndüğünü simgeler.

        }

        [HttpGet("{id}")] // id'ye göre getirme işlemi yapmak

        public IActionResult CategoryGet(int id)
        {
            using var c=new Context();    
            var values=c.Categories.Find(id);

            if (values == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            using var c=new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);

        }

        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c=new Context();
            var values=c.Categories.Find(id);   

            if(values == null)
            {
                return NotFound();  
            }

            else
            {
                c.Remove(values);
                c.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult CategoryUpdate(Category p)
        {
            using var c = new Context();
            var values = c.Find<Category>(p.CategoryID);

            if(values == null) {
                return NotFound();
            }

            else
            {
                values.CategoryName = p.CategoryName;
                c.Update(values);
                c.SaveChanges();
                return NoContent();
            }
        }

    }
}
