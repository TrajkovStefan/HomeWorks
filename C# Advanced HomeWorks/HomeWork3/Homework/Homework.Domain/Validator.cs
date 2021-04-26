using Homework.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Domain
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehcile)
        {
            if (vehcile.Id > 0 && !string.IsNullOrEmpty(vehcile.Type) && vehcile.YearOfProduction > 0)
            {
                return true;
            }
            else
            {
                return false;
                throw new Exception("An error occured");
            }
        }
    }
}
