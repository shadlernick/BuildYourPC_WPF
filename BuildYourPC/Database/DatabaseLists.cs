using BuildYourPC.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Database
{
    public class DatabaseLists
    {
        private DBContext _DBContext;

        public ObservableCollection<CPU> CPUs { get; set; }
        public ObservableCollection<GraphicCard> GraphicCards { get; set; }
        public ObservableCollection<Memory> Memories { get; set; }
        public ObservableCollection<Motherboard> Motherboards { get; set; }
        public ObservableCollection<PowerSupply> PowerSupplies { get; set; }
        public ObservableCollection<RAM> RAMs { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Computer> Computers { get; set; }

        private static DatabaseLists _instance;

        public static DatabaseLists GetDatabaseLists()
        {
            if (_instance == null)
                _instance = new DatabaseLists();
            return _instance;
        }

        private DatabaseLists()
        {
            _DBContext = new DBContext();
            try
            {
                CPUs = new ObservableCollection<CPU>(_DBContext.CPUs.ToList());
                GraphicCards = new ObservableCollection<GraphicCard>(_DBContext.GraphicCards.ToList());
                Memories = new ObservableCollection<Memory>(_DBContext.Memories.ToList());
                Motherboards = new ObservableCollection<Motherboard>(_DBContext.Motherboards.ToList());
                PowerSupplies = new ObservableCollection<PowerSupply>(_DBContext.PowerSupplies.ToList());
                RAMs = new ObservableCollection<RAM>(_DBContext.RAMs.ToList());
                Users = new ObservableCollection<User>(_DBContext.Users.ToList());
                Computers = new ObservableCollection<Computer>(_DBContext.Computers.ToList());
            }
            catch(Exception ex)
            {
                //todo: logger
                CPUs = new ObservableCollection<CPU>();
                GraphicCards = new ObservableCollection<GraphicCard>();
                Memories = new ObservableCollection<Memory>();
                Motherboards = new ObservableCollection<Motherboard>();
                PowerSupplies = new ObservableCollection<PowerSupply>();
                RAMs = new ObservableCollection<RAM>();
                Users = new ObservableCollection<User>();
                Computers = new ObservableCollection<Computer>();
            }

        }
    }
}
