using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Team
    {
       public int TeamId;
       public string Name, Abbr, Logo;
        public void SetTeamAll(int TeamId ,string Name,string Abbr,string Logo)
        {
            this.TeamId = TeamId;
            this.Name = Name;
            this.Abbr = Abbr;
            this.Logo = Logo;
        }
        public int GetTeamId()
        {
            return this.TeamId;
        }
        public string GetTeamName()
        {
            return this.Name;
        }
        public string GetTeamAbbr()
        {
            return this.Abbr;
        }
        public string GetTeamLogo()
        {
            return this.Logo;
        }

    }
}
