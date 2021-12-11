using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepo
{
    public class DevTeam
    {

        public string Developer { get; set; }
        public string TeamName { get; set; }
        public int TeamID { get; set; }

        public DevTeam()
        {
        }

        public DevTeam(string developer, string teamName, int teamID)
        {
            Developer = developer;
            TeamName = teamName;
            TeamID = teamID;
        }
    }
}
