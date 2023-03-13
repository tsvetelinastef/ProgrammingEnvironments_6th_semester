using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UserLogin
{
    public enum Activity
    {
        UserLogin, 
        UserChanged,
        UserActiveToChange
    }

    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static Dictionary<Activity, string> ActivityDescriptions = new Dictionary<Activity, string>()
        {
            { Activity.UserLogin, "User logged in" },
            { Activity.UserChanged, "User information changed" },
            { Activity.UserActiveToChange, "User active period changed" }
        }; 

        public static List<string> CurrentSessionActivities = new List<string>();


        public static void LogActivity(Activity activity)
        {
            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserUsername + ";"
                + LoginValidation.currentUserRole + ";"
                + ActivityDescriptions[activity];
            currentSessionActivities.Add(activityLine);
            if (!File.Exists("test.txt"))
            {
                File.Create("test.txt");
            }
            if (File.Exists("test.txt"))
                File.AppendAllText("test.txt", activityLine + "\r\n");
        }

        public static DateTime GetLastLogInInfo(string username)
        {
            DateTime resultDateTime = DateTime.Now;
            foreach (var record in ReadFrom("test.txt"))
            {
                if (record.Contains("Login"))
                {
                    if (record.Contains(username))
                    {
                        String[] splitted = record.Split(";");
                        DateTime.TryParse(splitted[0], out resultDateTime);
                    }
                }
            }

            return resultDateTime;
        }

        private static IEnumerable<string> ReadFrom(string filename)
        {
            string line;
            using (var reader = File.OpenText(filename))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        public static string GetCurrentSessionActivities()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var activities in currentSessionActivities)
            {
                sb.Append(activities);
            }
            return sb.ToString();
        }
    }
}
