using BuildYourPC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Models
{
    public class Memory : IMyComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }

        //Personal
        public string Amount { get; set; }
        public string Type { get; set; }
        public string ConnectionInterface { get; set; }
        public string FormFactor { get; set; }
        public int ShpindelSpeed { get; set; }
        public decimal AverageFoundingSpeed { get; set; }

        public bool AddedByUser { get; set; }

        public string PersonalToString()
        {
            return "Amount: " + Amount.ToString() + " \n" +
                   "Type: " + Type.ToString() + " \n" +
                   "FormFactor: " + FormFactor.ToString() + " \n" +
                   "ShpindelSpeed: " + ShpindelSpeed.ToString() + " \n" +
                   "AverageFoundingSpeed: " + FormFactor.ToString() + " \n" +
                   "ConnectionInterface: " + ConnectionInterface.ToString();
        }
    }
}
