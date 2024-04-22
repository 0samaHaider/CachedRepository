namespace CachedRepository.Repository;

/// <summary>
/// Represents an interface of repository
/// </summary>
/// <typeparam name="TEntity">Generic entity</typeparam>
public interface IRepository<TEntity> 
{
    List<TEntity> List();
}