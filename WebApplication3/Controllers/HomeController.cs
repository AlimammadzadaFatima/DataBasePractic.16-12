using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        private List<Services> _services;

        private List<Testimonials> _testimonials;

        private List<Client> _clients;

        
        //public homecontroller()
        //{
        //    _services = new list<services>
        //    {
        //        new services{id=1,icon="",title="main title",text="is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s,"},
        //        new services{id=2,icon="",title="lorem ipsum",text="it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
        //        new services{id=3,icon="",title="ipsum lorem",text="contrary to popular belief, lorem ipsum is not simply random text. it has roots in a piece of classical latin literature from 45 bc,"},
        //        new services{id=4,icon="",title="main text",text="there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some form"}

        //    };

        //    _testimonials = new list<testimonials>
        //    {
        //        new testimonials
        //        {id=1, image="",name="fatime", position="ceo",text="there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some"},
        //         new testimonials
        //         {id=2, image="",name="elnur", position="ceo",text="there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some"},
        //          new testimonials
        //          {id=3, image="",name="eyyub", position="ceo",text="there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some"},
        //       new testimonials
        //       {id=4, image="",name="eli", position="ceo",text="there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some"}

        //    };


        //}
        public ActionResult Index()
        {
            HomeViewModel HMW = new HomeViewModel
            {
                Services = _context.Services.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Clients = _context.Clients.ToList()
            };
            return View(HMW);
        }

      
    }
   


}
