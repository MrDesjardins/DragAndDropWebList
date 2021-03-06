﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DragAndDropWebList.Models;
using DragAndDropWebList.ViewModel.Templates;
using DragAndDropWebList.ViewModel.Templates.DragAndDropMultiSelector;

namespace DragAndDropWebList.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Person/Create
        public ActionResult Create()
        {
            var person = new Person();
            person.Attitudes.AvailableItems = new List<MultiSelectorWithSingleValueExtendedItem>{
            
            new MultiSelectorWithSingleValueExtendedItem{ID = Guid.NewGuid().ToString(),Description = "Choice #1", ExtendedProperty = "Property1"}
            ,new MultiSelectorWithSingleValueExtendedItem{ID = Guid.NewGuid().ToString(),Description = "Choice #2", ExtendedProperty = "Property2"}
            ,new MultiSelectorWithSingleValueExtendedItem{ID = Guid.NewGuid().ToString(),Description = "Choice #3", ExtendedProperty = "Property3"}
            };
            return View(person);
        }

        //
        // POST: /Person/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
