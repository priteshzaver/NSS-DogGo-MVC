using System;
using System.Collections.Generic;
using DogGo.Models;
using DogGo.Models.ViewModels;
using DogGo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DogGo.Controllers
{
    public class WalksController : Controller
    {
        private readonly IWalkRepository _walksRepo;
        private readonly IDogRepository _dogRepo;
        private readonly IWalkerRepository _walkerRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalksController(IWalkRepository walksRepository, IDogRepository dogRepository,IWalkerRepository walkerRepository)
        {
            _walksRepo = walksRepository;
            _dogRepo = dogRepository;
            _walkerRepo = walkerRepository;
        }
        // GET: WalksController
        public ActionResult Index()
        {
            List<Walks> walks = _walksRepo.GetAllWalks();

            return View(walks);
        }

        // GET: WalksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WalksController/Create
        public ActionResult Create()
        {
            List<Dog> dogs = _dogRepo.GetAllDogs();
            List<Walker> walkers = _walkerRepo.GetAllWalkers();
            
            ViewBag.SelectedDogs = new MultiSelectList(dogs, "Id", "Name");
            WalkFormViewModel vm = new WalkFormViewModel()
            {
                Walk = new Walks(),
                Dogs = dogs,
                Walkers = walkers,
            };

            return View(vm);
        }

        // POST: WalksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WalkFormViewModel viewModel)
        {
            try
            {
                foreach(int dogId in viewModel.SelectedDogs)
                {
                    _walksRepo.AddWalk(new Walks()
                    {
                        Date = viewModel.Walk.Date,
                        Duration = viewModel.Walk.Duration,
                        WalkerId = viewModel.Walk.WalkerId,
                        DogId = dogId
                    });
                }

                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View(viewModel);
            }
        }

        // GET: WalksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: WalksController/Delete/5
        public ActionResult Delete(int id)
        {
            Walks walk = _walksRepo.GetWalkById(id);

            return View(walk);
        }

        // POST: WalksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Walks walk)
        {
            try
            {   foreach(int walkId in walk.AreChecked)
                {
                    _walksRepo.DeleteWalk(walkId);
                }
                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View(walk);
            }
        }
    }
}
