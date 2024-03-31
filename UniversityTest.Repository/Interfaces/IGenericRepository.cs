using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityTest.Repository.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetById(object id);
		Task<IEnumerable<T>> GetAll();
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}
