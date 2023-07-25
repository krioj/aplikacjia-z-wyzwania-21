using ClassStatistics;

namespace Wyzwanie21dn
{
    public interface IEmployee                      // "public" i "private" niema w interfejsah
    {
        string Name { get; }
        
        string Surname { get; }

        string Age { get; }

        public void AddGrade(float grade);

        public void AddGrade(string grade);

        public void AddGrade(char grade);

        public void AddGrade(int grade);

        public void AddGrade(double grade);
        
        Statistics GetStatistics();
    }
}
