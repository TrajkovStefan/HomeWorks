using SEDC.HomeWork.TimeTracking.Domain.Enums;
using SEDC.HomeWork.TimeTracking.Domain.Modules;
using SEDC.HomeWork.TimeTracking.Services.Implementations;
using SEDC.HomeWork.TimeTracking.Services.Interfaces;

namespace SEDC.HomeWork.TimeTracking.Services.DataBase
{
    public static class DataBase
    {
        public static IUserService<User> _users = new UserService<User>();
        public static ITrackService<Exercising> _exercisingTrack = new TrackService<Exercising>();
        public static ITrackService<Reading> _readingTrack = new TrackService<Reading>();
        public static ITrackService<Working> _workingTrack = new TrackService<Working>();
        public static ITrackService<Hobbies> _hobbyTrack = new TrackService<Hobbies>();
        public static IUIService _uiService = new UIService();
        public static User _currentUser = null;

        static DataBase()
        {
            _users.AddUser(new User()
            {
                FirstName = "Marko",
                LastName = "Markovski",
                Age = 20,
                Password = "M123456",
                Username = "mmarkovski",
                Status = UserAccStatus.Activate
            });

            _users.AddUser(new User()
            {
                FirstName = "Stefan",
                LastName = "Stefanovski",
                Age = 23,
                Password = "S123456",
                Username = "sstefanovski",
                Status = UserAccStatus.Activate
            });

            _users.AddUser(new User()
            {
                FirstName = "Petko",
                LastName = "Petkovski",
                Age = 28,
                Password = "P123456",
                Username = "ppetkovski",
                Status = UserAccStatus.Activate
            });

            _readingTrack.AddTrack(new Reading(0, TrackType.ReadingType.Belles_Lettres));
            _readingTrack.AddTrack(new Reading(0, TrackType.ReadingType.Fiction));
            _readingTrack.AddTrack(new Reading(0, TrackType.ReadingType.Professional_Literature));

            _exercisingTrack.AddTrack(new Exercising(TrackType.ExercisingType.General));
            _exercisingTrack.AddTrack(new Exercising(TrackType.ExercisingType.Running));
            _exercisingTrack.AddTrack(new Exercising(TrackType.ExercisingType.Sport));

            _workingTrack.AddTrack(new Working(TrackType.WorkingType.Office));
            _workingTrack.AddTrack(new Working(TrackType.WorkingType.Home));

            _hobbyTrack.AddTrack(new Hobbies(TrackType.HobbiesType.Photography));
            _hobbyTrack.AddTrack(new Hobbies(TrackType.HobbiesType.Bartender));
            
        }
    }
}