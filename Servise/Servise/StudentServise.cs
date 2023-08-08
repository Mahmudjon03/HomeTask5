using Domain.Models;

namespace Servise.Servise;
public class StudentServise : IBaseServise<Student>
{
    List<Student> _student = new List<Student>();
    public Response<Student> Add(Student t)
    {
        _student.Add(t);
        return new Response<Student>("Успешно добавлено");
    }

    public Response<Student> AddMore(List<Student> t)
    {
        foreach (var item in t)
        {
            _student.Add(item);
        }
        return new Response<Student>("Успешно добавлено");
    }

    public List<Student> GetAll()
    {
        return _student;
    }

    public void GetById(int id)
    {
        var st = _student.FirstOrDefault(x => x.Id == id);
        if (st != null){
          System.Console.WriteLine();
            System.Console.Write("ID: ");
            System.Console.WriteLine(st.Id );
            System.Console.Write("FirstName: ");
            System.Console.WriteLine(st.firstName);
            System.Console.Write("LastName: ");
            System.Console.WriteLine(st.lastName);
            System.Console.Write("BirthDay: ");
            System.Console.WriteLine(st.birthDay);
            System.Console.Write("EveregeGrande :");
            System.Console.WriteLine(st.Everage(st.Grande));
            System.Console.WriteLine("================================================");
        }
        
    }


    public Response<Student> Remove(int id)
    {
        var std = _student.FirstOrDefault(x => x.Id == id);
        if (std != null)
        {
            _student.Remove(std);
        }
        return new Response<Student>("Успешно удалено");
    }

    public Response<Student> Update(Student t)
    {
        var st = _student.FirstOrDefault(x => x.Id == t.Id);
        if (st != null)
        {
            st.firstName = t.firstName;
            st.lastName = t.lastName;
            st.birthDay = t.birthDay;
            st.Grande = t.Grande;

        }
        return new Response<Student>("успешно изменит даннии");
    }

}

