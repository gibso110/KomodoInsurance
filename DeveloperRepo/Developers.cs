using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperRepo
{
    
    public class Developers
    {
        

        public string Names { get; set; }
        public int IDNum { get; set; }
        public string TeamName { get; set; }

        public bool Pluralsight { get; set; }

        

        public Developers(string names, int iDNum, string teamName, bool pluralsight)
        {
            Names = names;
            IDNum = iDNum;
            TeamName = teamName;
            Pluralsight = pluralsight;

        }

        public Developers()
        {
        }
    }
    public class KomodoRepo
    {
        static void Main(string[] args)
        {
        }
            //Field for developers
            private readonly List<Developers> _developers = new List<Developers>();

        //Field for developer Ids
        private int _developerID = 0;


        //Create
        public bool CreateDeveloper(Developers developer)
        {
            if (developer == null)
            {
                return false;
            }
            _developerID++;
            developer.IDNum = _developerID;
            _developers.Add(developer);
            return true;


        }



        //Read
        public List<Developers> Getdevelopers()
        {
            return _developers;
        }

        public Developers GetDeveloperByID(int id)
        {
            foreach (Developers developer in _developers)
            {
                if (id == developer.IDNum)
                {
                    return developer;
                }

            }
            return null;
        }

        //Update
        public bool UpdateDeveloper(int id, Developers newDeveloperInfo)
        {
            Developers oldDeveloperInfo = GetDeveloperByID(id);
            if (oldDeveloperInfo != null)
            {
                oldDeveloperInfo.IDNum = newDeveloperInfo.IDNum;
                oldDeveloperInfo.Names = newDeveloperInfo.Names;
                oldDeveloperInfo.Pluralsight = newDeveloperInfo.Pluralsight;
                oldDeveloperInfo.TeamName = newDeveloperInfo.TeamName;
                return true;

            }
            return false;
        }




        //Delete

        public bool deleteDeveloper(int id)
        {
            Developers developerToDelete = GetDeveloperByID(id);
            if (developerToDelete == null)
            {
                return false;
            }
            else
            {
                _developers.Remove(developerToDelete);
                return true;
            }

        }

    }
}


