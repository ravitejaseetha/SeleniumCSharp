using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReadJSON
{
    public interface IDataProvider<T>
    {
        Patient GetFirstRecord();
    }
}
