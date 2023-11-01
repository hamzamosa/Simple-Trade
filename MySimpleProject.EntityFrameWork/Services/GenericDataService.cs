using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MySimpleTrader.Domain.Models;
using MySimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleProject.EntityFrameWork.Services
{
    public class GenericDataService<T> : IDataServices<T> where T : DomainObject
    {
        private readonly DesignTimeDbContextFactory _dbContextFactory;

        public GenericDataService(DesignTimeDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public async Task<T> Create(T entity)
        {
            using (MySimpleTraderDbContext context=_dbContextFactory.CreateDbContext()) 
            {
             EntityEntry<T> createdEntity=  await context.Set<T>().AddAsync(entity);

                await context.SaveChangesAsync();

                return createdEntity.Entity;  
            
            }

               
        }

        public async Task<bool> Delete(int id)
        {
            using (MySimpleTraderDbContext context = _dbContextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e)=>e.Id==id);

                context.Set<T>().Remove(entity);

                return true;

            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (MySimpleTraderDbContext context = _dbContextFactory.CreateDbContext())
            {
              IEnumerable<T> entities = await context.Set<T>().ToListAsync();


                return entities;

            }
        }

        public async Task<T> GetById(int id)
        {
            using (MySimpleTraderDbContext context = _dbContextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);


                return entity;

            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (MySimpleTraderDbContext context = _dbContextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);

                await context.SaveChangesAsync();
                return entity;

            }

        }
    }
}
