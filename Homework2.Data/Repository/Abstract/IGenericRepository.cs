using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Data;

public interface IGenericRepository<TEntity> where TEntity : class

{
    TEntity GetByID(int id);  //GET
    void Insert(TEntity entity);  //POST
    void Remove(TEntity entity);  //DELETE
    void Remove(int id);          //DELETE
    void Update(TEntity entity);   //PUT
    List<TEntity> GetAll();      //GET
    List<TEntity> Where(System.Linq.Expressions.Expression<Func<TEntity, bool>> where);

    //where eklenicek

}

