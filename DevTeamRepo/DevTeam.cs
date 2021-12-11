using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DevTeamRepo
{
    public class DevTeam
    {
        private Dictionary<int, DevTeam> _devTeamList = new Dictionary<int, DevTeam>();

        public string Developers { get; set; }
        public string TeamName { get; set; }
        public int TeamID { get; set; }

        public DevTeam()
        {
        }

        public DevTeam(string developers, string teamName, int teamID)
        {
            Developers = developers;
            TeamName = teamName;
            TeamID = teamID;
        }
    }

    public class DevTeamProgram
    {
        private readonly List<DevTeam> _teamID = new List<DevTeam>();
        private readonly List<DevTeam> _devTeamList = new List<DevTeam>();

        private int _devTeamID = 0;

        //create new dev team
        public bool CreateDevTeam(DevTeam TeamID)
        {
            if (TeamID == null)
            {
                return false;
            }
            else
            {
                _devTeamID++;
                TeamID.TeamID = _devTeamID;
                _teamID.Add(TeamID);


                return true;
            }
        }

        //add dev to dev team
        public bool AddToDevTeam(DevTeam developer)
        {
            if (developer == null)
            {
                return false;
            }
            _devTeamList.Add(developer);


            return true;


        }


        //read current dev teams
        public List<DevTeam> GetDevTeam()
        {
            return _devTeamList;
        }

        public DevTeam GetDevTeamByID(int id)
        {
            foreach (DevTeam devTeam in _devTeamList)
            {
                if (id == devTeam.TeamID)
                {
                    return devTeam;
                }

            }
            return null;
        }


        //update update dev team



        //delete delete dev team
        public bool deleteDevTeam(int id)
        {
            DevTeam devTeamToDelete = GetDevTeamByID(id);
            if (devTeamToDelete == null)
            {
                return false;
            }
            else
            {
                _devTeamList.Remove(devTeamToDelete);
                return true;
            }

        }

    }



}



