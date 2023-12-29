using E_shoes.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_shoes.Data.Services
{
    public interface IActorService 
    {
        object Actors { get; }

       Task<IEnumerable<Actor>> GetAllAsync();

       Task<Actor> GetByIdAsync(int id);

        Task AddAsync(int id, Actor actor);

       Task<Actor> UpdateAsync(int id, Actor newActor);
        
     
        Task AddAsync(Actor actor);
        Task DeleteAsync(int id);
    }
}
