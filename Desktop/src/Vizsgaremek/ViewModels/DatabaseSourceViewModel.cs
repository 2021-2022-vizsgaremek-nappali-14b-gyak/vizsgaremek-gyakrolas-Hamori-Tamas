using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    public class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabaseSources;
        private string selectedDatabaseSource;
        private string displayedDatabaseSource;
        private DbSource dbSource;
        DatabaseSources repoDatabaseSources;

        public ObservableCollection<string> DisplayedDatabaseSources
        {
            get => displayedDatabaseSources;
        }
        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set => selectedDatabaseSource = value;
        }

        public DbSource DbSource
        {
            get
            {
                // TDD fejlesztés
                // return DbSource.NONE;
                if (selectedDatabaseSource == "localhost")
                {
                    return DbSource.LOCALHOST;
                }
                else if (selectedDatabaseSource == "devops")
                {
                    return DbSource.DEVOPS;
                }
                return DbSource.NONE;
            }
        }

        public string DisplayedDatabaseSource 
        {
            get
            {
                switch(dbSource)
                {
                    case DbSource.DEVOPS:
                        return "devops adatforrás.";
                        break;
                    case DbSource.LOCALHOST:
                        return "localhost adatforrás.";
                        break;
                    case DbSource.NONE:
                        return "beépített teszt adatok.";
                        break;
                    default:
                        return "";
                }
            }  
        }

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
        }
    }
}
