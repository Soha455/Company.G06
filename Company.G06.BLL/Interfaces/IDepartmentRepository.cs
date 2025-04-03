using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.G06.DAL.Modules;

namespace Company.G06.BLL.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department? Get(int id);
        int Add (Department department);
        int Update (Department department);
        int Delete (Department department);

    }
}
