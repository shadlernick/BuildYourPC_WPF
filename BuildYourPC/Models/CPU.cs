using BuildYourPC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Models
{
    public class CPU : IMyComponent, IPowerConsumptor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }
        public int PowerConsumption { get; set; }

        //Personal
        public int CoresCount { get; set; }
        public int ThreadsCount { get; set; }
        public int CMOS { get; set; }
        public decimal Frequency { get; set; }
        public string Socket { get; set; }

        //RAM
        public string RamAge { get; set; }
        public int RamFrequency { get; set; }

        public bool AddedByUser { get; set; }

        public string PersonalToString()
        {
            return "Power consumption: " + PowerConsumption.ToString() + " \n" +
                   "Cores: " + CoresCount.ToString() + " \n" +
                   "ThreadsCount: " + ThreadsCount.ToString() + " \n" +
                   "Frequency: " + Frequency.ToString() + " \n" +
                   "Socket: " + Socket + " \n" +
                   "RAM: " + RamAge + ", " + RamFrequency.ToString();
        }
    }
}
