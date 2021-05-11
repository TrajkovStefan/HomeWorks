using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.HomeWork.TimeTracking.Domain.Enums
{
    public class TrackType
    {
        public enum ExercisingType
        {
            General = 1,
            Running,
            Sport
        }

        public enum WorkingType
        {
            Office = 1,
            Home
        }

        public enum ReadingType
        {
            Belles_Lettres = 1,
            Fiction,
            Professional_Literature
        }
    }
}