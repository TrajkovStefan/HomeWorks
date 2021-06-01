using SEDC.HomeWork.TimeTracking.Domain.Modules;

namespace SEDC.HomeWork.TimeTracking.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId);
        void ChangeFirstName(int userId);
        void ChangeLastName(int userId);
        void AddUser(T user);
        T LogIn(string username, string password);
        void DeactivateAcc(int userId);
        void ActivateAcc(int userId);
        void CheckStatus(int userId);
        T Register(T newUser);
        void AddingReadingActivity(int userId);
        void AddingExercisingActivity(int userId);
        void AddingWorkingActivity(int userId);
        void AddingHobbyActivity(int userId);
        void UserReadingStatistics(int userId);
        void UserExercisingStatistics(int userId);
        void UserWorkingStatistics(int userId);
        void UserHobbiesStatistics(int userId);
        void UserGlobalStatistics(int userId);
    }
}
