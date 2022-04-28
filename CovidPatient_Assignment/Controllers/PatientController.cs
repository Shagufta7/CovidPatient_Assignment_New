using Microsoft.AspNetCore.Mvc;
using CovidPatient_Assignment.Data;
using CovidPatient_Assignment.Models;
using FluentValidation.Results;
using FluentValidation;
using System.Linq;
using CovidPatient_Assignment.Interfaces;

namespace CovidPatient_Assignment.Controllers
{
    public class PatientController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IPatient _patientsRepo;
        public PatientController(ApplicationDbContext context, IPatient patientsRepo)
        {
            _context = context;
            _patientsRepo = patientsRepo;
        }

        public IActionResult Index()
        {
            //IEnumerable<Patient> objCatlist = _context.Patients;
            //return View(objCatlist);
            List<Patient> patients = _patientsRepo.GetPatients();
            return View(patients);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Patient empobj)
        {
            PatientValidator patientValidator = new PatientValidator();
            ValidationResult result = patientValidator.Validate(empobj);

           if(result.IsValid)
            {
                _context.Patients.Add(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Patient Vaccination Details Saved Successfully !";
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var failure in result.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
            }

            return View(empobj);
            //if (ModelState.IsValid)
            //{
            //    _context.Patients.Add(empobj);
            //    _context.SaveChanges();
            //    TempData["ResultOk"] = "Patient Vaccination Details Saved Successfully !";
            //    return RedirectToAction("Index");
            //}

            //return View(empobj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var patfromdb = _context.Patients.Find(id);

            if (patfromdb == null)
            {
                return NotFound();
            }
            return View(patfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Patient empobj)
        {
            if (ModelState.IsValid)
            {
                _context.Patients.Update(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Patient History Updated Successfully !";
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Patients.Find(id);

            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(int? id)
        {
            var deleterecord = _context.Patients.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.Patients.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "Patient Details Deleted Successfully !";
            return RedirectToAction("Index");
        }
    }
}



