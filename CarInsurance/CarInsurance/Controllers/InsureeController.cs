﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            // In the InsureeController, add logic to calculate a quote based on these guidelines:

            // Start with base of $50 / month
            decimal basePrice = 50;
            decimal totalPrice = basePrice;
            //If the user is 18 or under, add $100 to the monthly total.
            //If the user is from 19 to 25, add $50 to the monthly total.
            //If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.
            DateTime now = DateTime.Today;
            int age = now.Year - insuree.DateOfBirth.Year;

            // Age logic
            if (age <= 18)
            {
                totalPrice += 100;
            }
            else if (age >= 19 && age <= 25)
            {
                totalPrice += 50;
            }
            else if (age >= 26)
            {
                totalPrice += 25;
            }

            // car year logic
            
            //If the car's year is before 2000, add $25 to the monthly total.
            //If the car's year is after 2015, add $25 to the monthly total.

            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                totalPrice += 25;
            }

            //car make logic

            //If the car's Make is a Porsche, add $25 to the price.
            //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)

            if (insuree.CarMake.ToLower() == "porsche")
            {
                totalPrice += 25;

                // Additional check for 911 Carrera
                if (insuree.CarMake.ToLower() == "911 carrera")
                {
                    totalPrice += 25; // total of $50 extra for Porsche 911 Carrera
                }
            }

            // Speeding ticket logic 
            // add $10 per ticket

            totalPrice += (insuree.SpeedingTickets * 10);

            // DUI logic
            // add 25% if user has ever had a DUI

            if (insuree.DUI == true)
            {
                totalPrice *= 1.25m; // 25% increase
            }

            // full coverage logic
            // full coverage, add 50% to the total

            if (insuree.CoverageType == true)
            {
                totalPrice *= 1.50m; // 50% increase
            }

            // return total calculated price
            insuree.Quote = totalPrice;

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            using (var db = new InsuranceEntities())
            {
                var insurees = db.Insurees.ToList();
                return View(insurees);
            }
        }
    }
}
