using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BE
{
    public interface ICrud<T>
    {
        int Add(T objAlta);
        bool Delete(T objBaja);
        bool Update(T objUpdate);
        T SelectById(T objSelect);
        List<T> SelectAll();
        DataTable SelectAlldt();
    }
}
