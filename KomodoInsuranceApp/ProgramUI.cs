using DeveloperRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceApp
{
    class ProgramUI
    {
        private KomodoRepo _developerRepo = new KomodoRepo();
        public void Run() {
            Menu();
        }


        //Menu
        private void Menu()
        {
            bool KeepRunning = true;
            while (KeepRunning)
            {




                //Display Options
                Console.WriteLine("Hello. Please Select a menu option:\n" +
                    "1. Create New Developer\n" +
                    "2. View All Developers\n" +
                    "3. View Developer By ID\n" +
                    "4. Update Existing Developer\n" +
                    "5. Delete Existing Developer\n" +
                    "6. Exit");

                // Get user input
                string input = Console.ReadLine();

                //Evaluate input and act
                switch (input)
                {
                    case "1":
                        CreateNewDeveloper();
                        break;
                    case "2":
                        DisplayAllDevs();
                        break;

                    case "3":
                        DisplayDevByID();
                        break;

                    case "4":
                        UpdateDev();
                        break;

                    case "5":
                        DeleteDev();
                        break;

                    case "6":
                        Console.WriteLine("Goodbye!");
                        KeepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                
            }
            }
        //New Developer
        private void CreateNewDeveloper()
        {
            Developers newDev = new Developers();

            //Dev Name
            Console.WriteLine("Enter Developers Name");
            newDev.Names = Console.ReadLine();
            //Team Name
            Console.WriteLine("Enter Developers Team");
            newDev.TeamName = Console.ReadLine();
            //Can access Pluralsight
            Console.WriteLine("Can the developer access Pluralsight? Y/N");
            string UserAnswer = Console.ReadLine().ToLower();
            if(UserAnswer == "y") { newDev.Pluralsight = true; }
            else { newDev.Pluralsight = false; }

            _developerRepo.CreateDeveloper(newDev);


        }

        //Dispay All Developers
        private void DisplayAllDevs ()
        {
            List<Developers> listOfDevs = _developerRepo.Getdevelopers();
            foreach (Developers devs in listOfDevs)
            {
                Console.WriteLine($"Developer: {devs.Names}\n" +
                    $"Developer ID: {devs.IDNum}\n" +
                    $"Team Name: {devs.TeamName}\n" +
                    $"Can access Pluralsight: {devs.Pluralsight}");
            };

        }
        //Display Developer By ID
        private void DisplayDevByID()
        {
            Console.Clear();
            Console.WriteLine("Enter Devs' ID:");
            int id = int.Parse(Console.ReadLine());
            Developers developer = _developerRepo.GetDeveloperByID(id);
            if (developer != null)
            {
                Console.WriteLine($"Developer: {developer.Names}\n" +
                    $"Developer ID: {developer.IDNum}\n" +
                    $"Team Name: {developer.TeamName}\n" +
                    $"Can access Pluralsight: {developer.Pluralsight}");
            }
            else
            {
                Console.WriteLine("No Developer with that ID");
            }

        }
        //Update Existing Dev
        private void UpdateDev()
        {
            DisplayAllDevs();
            Console.WriteLine("Enter the ID of the User you would like to update:");
            int oldID = int.Parse(Console.ReadLine());
            Developers newDev = new Developers();

            //New Dev ID
            Console.WriteLine("What is the developers new ID Number");
            int newID = int.Parse(Console.ReadLine());
            newDev.IDNum = newID;
            //Dev Name
            Console.WriteLine("Enter Developers Name");
            newDev.Names = Console.ReadLine();
            //Team Name
            Console.WriteLine("Enter Developers Team");
            newDev.TeamName = Console.ReadLine();
            //Can access Pluralsight
            Console.WriteLine("Can the developer access Pluralsight? Y/N");
            string UserAnswer = Console.ReadLine().ToLower();
            if (UserAnswer == "y") { newDev.Pluralsight = true; }
            else { newDev.Pluralsight = false; }

            
            

          bool wasUpdated =  _developerRepo.UpdateDeveloper(oldID, newDev);
        if(wasUpdated)
          {
                Console.WriteLine("The Dev was successfully updated.");
          }
            else
            {
                Console.WriteLine("The update was unsuccessful");
            }
        }
        //Delete Dev
        private void DeleteDev()
        {
            Console.Clear();
            DisplayAllDevs();
            Console.WriteLine("Which Dev Would you like to remove? Enter ID below:");
            int input = int.Parse(Console.ReadLine());
            bool wasDeleted =_developerRepo.deleteDeveloper(input);

            if(wasDeleted)
            {
                Console.WriteLine("The Dev was deleted.");
            }
            else
            {
                Console.WriteLine("The Dev could not be deleted");

            }
        }
        





    }
    
}
