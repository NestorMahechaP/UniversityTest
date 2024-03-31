using DevExpress.Xpo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using UniversityTest.Persistance;
using UniversityTest.Repository.Interfaces;

namespace UniversityTest.Repository.Repositories
{
	public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected readonly UniversityDbContext _dbContext;

		protected GenericRepository(UniversityDbContext context)
		{
			_dbContext = context;
		}

		public async Task<T> GetById(object id)
		{
			var entity = await _dbContext.Set<T>().FindAsync(id);
			if (entity == null) { return null; }
			//_dbContext.Entry<T>(entity).State = EntityState.Detached;
			return entity;
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await _dbContext.Set<T>().ToListAsync();
		}

		public void Add(T entity)
		{
			_dbContext.Set<T>().Add(entity);
		}

		public void Delete(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
		}

		public void Update(T entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
		}
	}
}