﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mywebproject_core.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace Mywebproject_core.Controllers
{
    public class CandidatesController : Controller
    {
        // GET: CandidatesController
        HttpClient httpClient;

        static string BASE_URL = "https://api.open.fec.gov/v1";
        static string API_KEY = "ZEksIdffy3B73CsLvN2kl7YZB5nEu5mBpwP9BFC6";
        //ZEksIdffy3B73CsLvN2kl7YZB5nEu5mBpwP9BFC6
        public ActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string FEDERAL_ELECTORAL_API_PATH = BASE_URL + "/candidates?limit=20";
            string candidatesData = "";

            CandidateDetail candidates = null;

            httpClient.BaseAddress = new Uri(FEDERAL_ELECTORAL_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FEDERAL_ELECTORAL_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    candidatesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!candidatesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    candidates = JsonConvert.DeserializeObject<CandidateDetail>(candidatesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(candidates);
            //  return View();
        }

        // GET: CandidatesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandidatesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidatesController/Create
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

        // GET: CandidatesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandidatesController/Edit/5
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

        // GET: CandidatesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CandidatesController/Delete/5
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
    }
}




