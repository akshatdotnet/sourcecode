using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.DAL
{
    public interface _I_AllRepository<T> where T: class
    {
        IEnumerable<T> GetModel();

        T GetModelById(int modelId);

        void InsertModel(T Model);

        void DeleteModel(int modelId);

        void UpdateModel(T model);

        void save();
    }
}
