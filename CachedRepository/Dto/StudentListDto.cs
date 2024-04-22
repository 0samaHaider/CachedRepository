using CachedRepository.Models;

namespace CachedRepository.Dto;

public class StudentListDto
{
    public long ElapsedTimeMilliseconds { get; set; }
    public List<Student> Students { get; set; }
}