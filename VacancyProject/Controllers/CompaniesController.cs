﻿using Microsoft.AspNetCore.Mvc;
using VacancyProject.Context;
using VacancyProject.Entities;
using VacancyProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacancyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly VacancyDbContext _db;
        public CompaniesController(VacancyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Companies.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_db.Companies.Find(id));
        }

        [HttpPost]
        public void Post(CompanyPostModel company)
        {
            if (company.ProfileImage == null)

            Company newCompany = new()
            {
                ProfileImage = company.ProfileImage,
                Name = company.Name,
                About = company.About,
                Address = company.Address,
                ContactPhone = company.ContactPhone,
                ContactEmail = company.ContactEmail,
                Website = company.Website
            };

            _db.Companies.Add(newCompany);
            _db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, CompanyPostModel company)
        {
            Company updateaCompany = _db.Companies.Find(id);
            updateaCompany.Name = company.Name;
            updateaCompany.About = company.About;
            updateaCompany.Address = company.Address;
            updateaCompany.ContactPhone = company.ContactPhone;
            updateaCompany.ContactEmail = company.ContactEmail;
            updateaCompany.Website = company.Website;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Company deleteCompany = _db.Companies.Find(id);
            _db.Companies.Remove(deleteCompany);
            _db.SaveChanges();
        }
    }
}