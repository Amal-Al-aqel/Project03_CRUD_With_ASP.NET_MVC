﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuwaiq_Student_Life.Data;

namespace Tuwaiq_Student_Life.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDBContext _db;

        public InstructorController(AppDBContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var Instructors = _db.Instructors.ToList();
            var Subjects = _db.Subjects.ToList();
            ViewData["Instructors"] = Instructors;
            ViewData["Subjects"] = Subjects;
            return View();
        }
    }
}
