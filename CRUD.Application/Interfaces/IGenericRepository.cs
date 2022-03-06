using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Interfaces
{
    public interface IGenericRepository<Pd> where Pd : class
    {
        Product<Pd> Get(int Id);
        Product<IEnumerable<Pd>> GetAll();
        Product<int> Create(Pd entity);
        Product<int> Delete(int Id);
        Product<int> Update(Pd entity);
    }
}
