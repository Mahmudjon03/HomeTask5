namespace Domain.Models;

public class Student
{
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthDay { get; set; }
    public int[] Grande { get; set; }
    public int Everage(int[] n)
    {
        int g = 0;
        for (int i = 0; i < n.Length; i++)
        {
            g += n[i];
        }
        return g / 4;
    }

}
