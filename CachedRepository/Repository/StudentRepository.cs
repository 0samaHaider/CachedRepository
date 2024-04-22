using CachedRepository.Data;
using CachedRepository.Models;

namespace CachedRepository.Repository;

public class StudentRepository : IRepository<Student>
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext dbContext) => _context = dbContext;

    public List<Student> List() => _context.Student.ToList();
}