using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularGemStore.Models;

namespace AngularGemStore.Controllers
{
    public class GemsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var gems = new[]
            {
                new Gem{Name = "Dodecahedron",Price = 2.95, Description = "Some description", CanPurchase = true, IsSoldOut = false, Reviews = new[]{new Review{Author = "a@b.c", Body = "I love it", Stars = 5}}},
                new Gem{Name = "Pentagon",Price = 3.95, Description = "Some description", CanPurchase = true, IsSoldOut = false, Reviews = new[]{new Review{Author = "a@b.c", Body = "I like it", Stars = 3}}},
                new Gem{Name = "Cube",Price = 0.95, Description = "Some description", CanPurchase = true, IsSoldOut = false, Reviews = new[]{new Review{Author = "a@b.c", Body = "I hate it", Stars = 1}}}
            };

            return Request.CreateResponse(HttpStatusCode.OK, gems);
        }
    }
}