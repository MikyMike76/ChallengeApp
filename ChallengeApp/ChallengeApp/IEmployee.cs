
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade(string grade);

        void AddGrade(float grade);
        Statistics GetStatistics();
    }
}
