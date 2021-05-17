namespace SEDC.HomeWork.TimeTracking.Services.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateUsername(string username)
        {
            if (username.Length <= 5)
            {
                return false;
            }
            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (password.Length <= 6)
            {
                return false;
            }
            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    return true;
                }
            }
            foreach (char ch in password)
            {
                if (char.IsNumber(ch))
                {
                    return true;
                }
            }
            return false;
        }

        //public static bool ValidateFirstNameAndLastName(string firstName, string lastName)
        //{
        //    if (firstName.Length <= 2 && lastName.Length <= 2)
        //    {
        //        return false;
        //    }
        //    foreach(char ch in firstName)
        //    {
        //        foreach(char c in lastName)
        //        {
        //            if(char.IsNumber(ch) || char.IsNumber(c))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        public static bool ValidateName(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }
            foreach(char ch in name)
            {
                if(char.IsNumber(ch) || char.IsNumber(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateAge(int age)
        {
            if(age < 18 || age > 120)
            {
                return false;
            }
            return true;
        }

        public static int ValidateNumber(string numberInput, int range)
        {
            bool isNumber = int.TryParse(numberInput, out int number);
            if (!isNumber)
            {
                return -1;
            }
            if (number < 1 || number > range)
            {
                return -1;
            }
            return number;
        }
    }
}
