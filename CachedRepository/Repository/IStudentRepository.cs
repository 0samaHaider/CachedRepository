using CachedRepository.Models;

namespace CachedRepository.Repository;

public interface IStudentRepository: IRepository<Student>
{
    Task<List<Student>> GetAllAsync();
}
