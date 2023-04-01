using DogGo.Models;
using System.Collections.Generic;
using DogGo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DogGo.Models.ViewModels;
using System.Linq;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace DogGo.Controllers
{
    public class WalkersController : Controller
    {
        private readonly IWalkerRepository _walkerRepo;
        private readonly IWalkRepository _walkRepo;
        private readonly IOwnerRepository _ownerRepo;
        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalkersController(IWalkerRepository walkerRepository, IWalkRepository walkRepository, IOwnerRepository ownerRepository)
        {
            _walkerRepo = walkerRepository;
            _walkRepo = walkRepository;
            _ownerRepo = ownerRepository;
        }
        // GET: WalkersController

        public ActionResult Index()
        {
            List<Walker> walkers = _walkerRepo.GetAllWalkers();

            return View(walkers);
        }

        // GET: WalkersController/Details/5
        public ActionResult Details()
        {
            int walkerId = GetCurrentUserId();
            Walker walker = _walkerRepo.GetWalkerById(walkerId);
            List<Walks> walks = _walkRepo.GetWalksByWalkerId(walker.Id);
            
            WalkerProfileViewModel vm = new WalkerProfileViewModel()
            {
                Walker = walker,
                Walks = walks,
                
            };

            return View(vm);
        }

        // GET: WalkersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalkersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Edit/5
        public ActionResult Edit(int id)
        {
            Walker walker = _walkerRepo.GetWalkerById(id);

            if (walker == null)
            {
                return NotFound();
            }

            return View(walker);
        }

        // POST: WalkersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Walker walker)
        {
            try
            {
                _walkerRepo.UpdateWalker(walker);

                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View(walker);
            }
        }

        // GET: WalkersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalkersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id == null)
            {
                return 0;
            }
            else
            {
                return int.Parse(id);
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel viewModel)
        {
            Walker walker = _walkerRepo.GetWalkerByEmail(viewModel.Email);

            if (walker == null)
            {
                return Unauthorized();
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, walker.Id.ToString()),
                new Claim(ClaimTypes.Email, walker.Email),
                new Claim(ClaimTypes.Role, "DogWalker"),
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Walkers");
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //GET: Walkers/ManageMyWalks
        public ActionResult ManageWalks()
        {
            int walkerId = GetCurrentUserId();
            List<Walks> walks = _walkRepo.GetWalksByWalkerId(walkerId);

            return View(walks);
        }

        //POST: Walkers/ManageMyWalks
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManageWalks(Walks walk)
        {
            try
            {
                Walks confirmWalk = _walkRepo.GetWalkById(walk.Id);
                confirmWalk.WalkStatusId = 2;
                _walkRepo.UpdateWalk(confirmWalk);

                return RedirectToAction("ManageWalks");
            }
            catch (Exception)
            {
                return View();
            }
        }
        //GET: Walkers/CompleteWalk/5
        public ActionResult CompleteWalk(int id)
        {
            Walks walk = _walkRepo.GetWalkById(id);
            if (walk == null)
            {
                return NotFound();
            }

            return View(walk);
        }

        //POST: Walkers/CompleteWalk/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompleteWalk(int id, Walks walk)
        {
            try
            {
                Walks confirmWalk = _walkRepo.GetWalkById(walk.Id);
                confirmWalk.WalkStatusId = 3;
                confirmWalk.Duration = walk.Duration;
                _walkRepo.UpdateWalk(confirmWalk);

                return RedirectToAction("ManageWalks");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
