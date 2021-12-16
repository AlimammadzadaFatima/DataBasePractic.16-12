using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class HomeViewModel
    {
        
            public List<Services> Services { get; set; }
            public List<Testimonials> Testimonials { get; set; }

        public List<Client> Clients { get; set; }
    }
}
