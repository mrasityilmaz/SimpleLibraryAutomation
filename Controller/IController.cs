using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.Controller
{
     interface IController<T> where T : class
    {
        IQueryable<T> GetAll();


        T GetById(int ID);

        void Add(T Entity);
        void Update(T Entity);
        void Delete(int ID);


    }
}
