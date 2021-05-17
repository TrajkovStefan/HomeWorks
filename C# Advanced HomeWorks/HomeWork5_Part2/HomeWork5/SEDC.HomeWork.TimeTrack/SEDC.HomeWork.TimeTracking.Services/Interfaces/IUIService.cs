using SEDC.HomeWork.TimeTracking.Domain.Modules;
using System.Collections.Generic;

namespace SEDC.HomeWork.TimeTracking.Services.Interfaces
{
    public interface IUIService
    {
        int ChooseMenuItem(List<string> menuItems);
        int ActivityMenu();
        int LogInMenu();
        int UserStatisticsMenu();
        int AccountManagementMenu();
        User CheckUserData();
        int UserMenu();
        int ReadingMenu();
        int ExercisingMenu();
        int WorkingMenu();
        int HobbyMenu();

    }
}
