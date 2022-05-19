using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Player
    {
        string LastName, FirstName, Gender, Email, CountryCode;
        double Height, Weight;
        int TeamId, PlayerId, ShirtNumber;

        public void setPalyerAll(int PlayerId, string LastName, string FirstName, string Gender, double Height, double Weight, int ShirtNumber, string Email,
        string CountryCode, int TeamId)
        {
            this.PlayerId = PlayerId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Gender = Gender;
            this.Height = Height;
            this.Weight = Weight;
            this.ShirtNumber = ShirtNumber;
            this.Email = Email;
            this.CountryCode = CountryCode;
            this.TeamId = TeamId;
        }
        public void SetName(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public int GetPlayerId()
        {
            return PlayerId;
        }
        public string GetName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetGendr()
        {
            return Gender;
        }
        public double GetHeight()
        {
            return Height;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public int GetShirtNumber()
        {
            return ShirtNumber;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetCountryCode()
        {
            return CountryCode;
        }
        public int GetTeamId()
        {
            return TeamId;
        }
    }
}
