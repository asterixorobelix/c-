using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingApplications.Data
{
    class BuildingApplicationsDb:DbContext
    {
        public BuildingApplicationsDb():base("BuildingApplications.Data.Properties.Settings.DefaultConnection")//Name of connection string defined in App.Config
        {
                
        }
    }
}
