using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlanA
{
    public class EFCoreSource<TDbContext, TPersistentData>
        where TPersistentData : class
        where TDbContext : DbContext, new()
    {

        public async Task<List<TPersistentData>> Load()
        {
            using (var context = new TDbContext())
            {
                return await context.Set<TPersistentData>().ToListAsync();
            }
        }

        public async Task<int> Create(TPersistentData obj)
        {
            using (var context = new TDbContext())
            {
                await context.Set<TPersistentData>().AddAsync(obj);
                context.SaveChanges();
                return obj.Key; // TODO
            }
        }

        public async Task<TPersistentData> Read(int key)
        {
            using (var context = new TDbContext())
            {
                return await context.Set<TPersistentData>().FindAsync(key);
            }
        }

        public async Task Update(int key, TPersistentData obj)
        {
            using (var context = new TDbContext())
            {
                TPersistentData oldObj = await context.Set<TPersistentData>().FindAsync(key);
                if (oldObj != null)
                {
                    context.Set<TPersistentData>().Remove(oldObj);
                    obj.Key = key;
                    await context.Set<TPersistentData>().AddAsync(obj);
                    context.SaveChanges();
                }
            }
        }

        public async Task Delete(int key)
        {
            using (var context = new TDbContext())
            {
                TPersistentData obj = await context.Set<TPersistentData>().FindAsync(key);
                if (obj != null)
                {
                    context.Set<TPersistentData>().Remove(obj);
                    context.SaveChanges();
                }
            }
        }
    }
}
