using CachedRepository.Models;
using Microsoft.Extensions.Caching.Memory;

namespace CachedRepository.Repository;

public class CachedStudentRepository : IRepository<Student>
{
    private readonly StudentRepository _studentRepository;
    private readonly IMemoryCache _memoryCache;
    private const string MyModelCacheKey = "Authors";
    private readonly MemoryCacheEntryOptions _cacheOptions;

    public CachedStudentRepository(StudentRepository studentRepository,IMemoryCache memoryCache)
    {
        _studentRepository = studentRepository;
        _memoryCache = memoryCache;
        // 20 second cache
        _cacheOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(relative: TimeSpan.FromSeconds(20));
    }
        
    public List<Student> List()
    {
        return _memoryCache.GetOrCreate(MyModelCacheKey, entry =>
        {
            entry.SetOptions(_cacheOptions);
            return _studentRepository.List();
        })!;
    }
}