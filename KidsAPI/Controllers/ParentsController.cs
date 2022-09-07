using KidsAPI.DBContext;
using KidsAPI.Entitys.OneToMany;
using Microsoft.AspNetCore.Mvc;

namespace KidsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController : Controller
    {
        private readonly KidsDBContext _kidsDbContext;
        public ParentsController(KidsDBContext kidsDBContext)
        {
            _kidsDbContext = kidsDBContext;
        }

        [HttpGet]
        public List<Parent> GetAllParents()
        {
            return _kidsDbContext.Parents.ToList();
        }

        [HttpPost]
        public bool AddParent(Parent parent)
        {
          
            _kidsDbContext.Parents.Add(parent);
            _kidsDbContext.SaveChanges();           
          
            return true;
        }

        [HttpDelete]
        public bool DeleteParent(int id)
        {
            var parent = _kidsDbContext.Parents.FirstOrDefault(x => x.Id == id);
            _kidsDbContext.Remove(parent);
            _kidsDbContext.SaveChanges();
            return true;
        }

        [HttpPut]
        public bool UpdateParent(Parent parent) { 
            _kidsDbContext.Update(parent);
            _kidsDbContext.SaveChanges();
            return true;
        }
    }
}
