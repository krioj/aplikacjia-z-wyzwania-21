
using ClassStatistics;

namespace Wyzwanie21dn
{// co?
    public interface IEmployee                      // "public" i "private" niema w interfejsah
    {
        string Name { get; }
        
        string Surname { get; }

        string Age { get; }

        public void AddScore(float number);

        public void AddScore(string number);

        public void AddScore(char number);

        Statistics GetAnEstimate();                 








    }
}
