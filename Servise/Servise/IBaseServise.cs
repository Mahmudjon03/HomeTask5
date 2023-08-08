namespace Servise.Servise;
using Domain.Models;

public interface IBaseServise<T> where T : class
{
     List<T> GetAll();
     Response<T> Add(T t);
     void GetById( int id );
     Response<T> Update( T t);
     Response<T> Remove(int id);
     Response<T> AddMore(List<T> t);
}
