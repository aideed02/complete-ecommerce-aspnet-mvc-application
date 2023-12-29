using E_shoes.Models;
using Microsoft.EntityFrameworkCore;

namespace E_shoes.Data.Services
{
    public class ActorService : IActorService
       
    

        {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public object Actors => throw new NotImplementedException();

        public async Task AddAsync(Actor actor)
        {
         await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync(); 
        }

        public Task AddAsync(int id, Actor actor)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
             _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;  
            
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result =  await _context.Actors.SingleOrDefaultAsync(x => x.Id == id);
            return result;  
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
