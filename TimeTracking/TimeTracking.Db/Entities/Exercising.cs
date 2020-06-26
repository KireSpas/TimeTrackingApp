﻿using System.Linq;
using TimeTracking.Db.Enums;
using TimeTracking.Db.Interfaces;

namespace TimeTracking.Db.Entities
{
    public class Exercising : BaseActivities ,IActivities
    {
        public ExcercisingType ExcercisingType { get; set; }

        public string GetInfo(User user)
        {
            return $"Today {user.FirstName} was doing {user.Activities.Exercising.ExcercisingType} excercise {StopwatchTimeToString(user.Stopwatch)}";
        }
    }
}