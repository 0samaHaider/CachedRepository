using CachedRepository.Dto;
using CachedRepository.Models;
using CachedRepository.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CachedRepository.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private readonly IRepository<Student> _studentRepository;

    public StudentController(IRepository<Student> studentRepository) => _studentRepository = studentRepository;

    [HttpGet]
    public Task<IActionResult> GetProducts()
    {
        var timer = Stopwatch.StartNew();
        var customers = _studentRepository.List();
        timer.Stop();

        var customerList = new StudentListDto
        {
            Students = customers,
            ElapsedTimeMilliseconds = timer.ElapsedMilliseconds
        };

        return Task.FromResult<IActionResult>(Ok(customerList));
    }
}