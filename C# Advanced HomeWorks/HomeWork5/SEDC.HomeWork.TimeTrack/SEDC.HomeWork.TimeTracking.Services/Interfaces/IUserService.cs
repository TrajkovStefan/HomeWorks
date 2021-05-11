using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;


namespace SEDC.HomeWork.TimeTracking.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeFirstNameAndLastName(int userId, string firstName, string lastName);
        void AddUser(T user);
        void LogIn();
        void ShowMainMenu();
        void ShowActivities();
        void DeactivateAcc(int userId);
        void ActivateAcc(int userId);
        void UserStatistics(int userId);
        void UserOptions();
    }
}
