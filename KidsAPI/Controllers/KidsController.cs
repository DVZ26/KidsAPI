using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KidsAPI.DBContext;
using KidsAPI.Entitys.OneToMany;

namespace KidsAPI.Controllers
{
    public class KidsController : Controller
    {
        private readonly KidsDBContext _context;

        public KidsController(KidsDBContext context)
        {
            _context = context;
        }

    }

       
}
