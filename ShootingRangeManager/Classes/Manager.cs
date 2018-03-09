using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeManager.Classes
{
    public static class Manager
    {
        public static List<Shooter> ShootersList = GetShooters();

        private static List<Shooter> GetShooters()
        {
            //TODO: Pobranie użytkowników z bazy
            List<Shooter> retList = new List<Shooter>();
            retList.Add(new Shooter() { ShooterId = 1, CardNumber = 100001, FirstName = "Piotr", Surname = "Sowiak" });

            return retList;
        }

    }
}
