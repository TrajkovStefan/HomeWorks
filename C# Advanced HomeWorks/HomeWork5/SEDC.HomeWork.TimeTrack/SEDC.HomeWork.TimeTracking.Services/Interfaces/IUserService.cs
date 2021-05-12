
using SEDC.HomeWork.TimeTracking.Domain.Modules;


namespace SEDC.HomeWork.TimeTracking.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId);
        void ChangeFirstNameAndLastName(int userId);
        void AddUser(T user);
        void LogIn();
        void ShowMainMenu();
        void ShowActivities();
        void DeactivateAcc(int userId);
        void ActivateAcc(int userId);
        void UserStatistics(int userId);
        void UserOptions();
        void CheckStatus();
    }
}
