using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikDataGridIBindingListExample
{
    public interface IDataSourceRequirements<T> : IBindingList
    {
        new T this[int index] { get; set; }
    }
}
