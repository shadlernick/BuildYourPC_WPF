using BuildYourPC.Database;
using BuildYourPC.Interfaces;
using BuildYourPC.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace BuildYourPC.ViewModels
{
    public class BuildingVM : INotifyPropertyChanged
    {
        private bool _IsShowUserAdded;
        public bool IsShowUserAdded
        {
            get => _IsShowUserAdded;
            set
            {
                _IsShowUserAdded = value;
                UpdateCollections();
                OnPropertyChanged(nameof(IsShowUserAdded));
            }
        }

        #region CPU

        private string _CPUfilter;
        public string CPUfilter
        {
            get => _CPUfilter;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _CPUfilter = value;
                    CPUs = new ObservableCollection<CPU>(CPUs.Where(x => x.Name.Contains(_CPUfilter)));
                }
                else
                {
                    CPUs = DatabaseLists.GetDatabaseLists().CPUs;
                }
                OnPropertyChanged(nameof(CPUfilter));
            }
        }

        private CPU _TempCPU;
        public CPU TempCPU
        {
            get => _TempCPU;
            set
            {
                if (value != null)
                {
                    _TempCPU = value;
                    CPUinfo = _TempCPU.PersonalToString();
                    OnPropertyChanged(nameof(TempCPU));
                }
            }
        }
        private string _CPUinfo;
        public string CPUinfo
        {
            get => _CPUinfo;
            set
            {
                if (value != null)
                {
                    _CPUinfo = value;
                    OnPropertyChanged(nameof(CPUinfo));
                }
            }
        }
        #endregion

        #region GraphicCard
        private GraphicCard _TempGraphicCard;
        public GraphicCard TempGraphicCard
        {
            get => _TempGraphicCard;
            set
            {
                if (value != null)
                {
                    _TempGraphicCard = value;
                    GraphicCardinfo = _TempGraphicCard.PersonalToString();
                    OnPropertyChanged(nameof(TempGraphicCard));
                }
            }
        }
        private string _GraphicCardinfo;
        public string GraphicCardinfo
        {
            get => _GraphicCardinfo;
            set
            {
                if (value != null)
                {
                    _GraphicCardinfo = value;
                    OnPropertyChanged(nameof(GraphicCardinfo));
                }
            }
        }
        #endregion

        #region RAM
        private RAM _TempRAM;
        public RAM TempRAM
        {
            get => _TempRAM;
            set
            {
                _TempRAM = value;
                if (_TempRAM != null)
                    RAMinfo = _TempRAM.PersonalToString();
                else
                    RAMinfo = null;
                OnPropertyChanged(nameof(TempRAM));
            }
        }
        private string _RAMinfo;
        public string RAMinfo
        {
            get => _RAMinfo;
            set
            {
                _RAMinfo = value;
                OnPropertyChanged(nameof(RAMinfo));
            }
        }
        #endregion

        #region Memory
        private Memory _TempMemory;
        public Memory TempMemory
        {
            get => _TempMemory;
            set
            {
                if (value != null)
                {
                    _TempMemory = value;
                    Memoryinfo = _TempMemory.PersonalToString();
                    OnPropertyChanged(nameof(TempMemory));
                }
            }
        }
        private string _Memoryinfo;
        public string Memoryinfo
        {
            get => _Memoryinfo;
            set
            {
                if (value != null)
                {
                    _Memoryinfo = value;
                    OnPropertyChanged(nameof(Memoryinfo));
                }
            }
        }
        #endregion

        #region PowerSupply
        private PowerSupply _TempPowerSupply;
        public PowerSupply TempPowerSupply
        {
            get => _TempPowerSupply;
            set
            {
                if (value != null)
                {
                    _TempPowerSupply = value;
                    PowerSupplyinfo = _TempPowerSupply.PersonalToString();
                    OnPropertyChanged(nameof(TempPowerSupply));
                }
            }
        }
        private string _PowerSupplyinfo;
        public string PowerSupplyinfo
        {
            get => _PowerSupplyinfo;
            set
            {
                if (value != null)
                {
                    _PowerSupplyinfo = value;
                    OnPropertyChanged(nameof(PowerSupplyinfo));
                }
            }
        }
        #endregion

        #region Motherboard
        private Motherboard _TempMotherboard;
        public Motherboard TempMotherboard
        {
            get => _TempMotherboard;
            set
            {
                if (value != null)
                {
                    _TempMotherboard = value;
                    Motherboardinfo = _TempMotherboard.PersonalToString();
                    OnPropertyChanged(nameof(TempMotherboard));
                }
            }
        }
        private string _Motherboardinfo;
        public string Motherboardinfo
        {
            get => _Motherboardinfo;
            set
            {
                if (value != null)
                {
                    _Motherboardinfo = value;
                    OnPropertyChanged(nameof(Motherboardinfo));
                }
            }
        }
        #endregion


        #region Collections
        private ObservableCollection<CPU> _CPUs;
        public ObservableCollection<CPU> CPUs
        {
            get => _CPUs;
            set
            {
                _CPUs = value;
                OnPropertyChanged(nameof(CPUs));
            }
        }

        private ObservableCollection<GraphicCard> _GraphicCards;
        public ObservableCollection<GraphicCard> GraphicCards
        {
            get => _GraphicCards;
            set
            {
                _GraphicCards = value;
                OnPropertyChanged(nameof(GraphicCards));
            }
        }

        private ObservableCollection<Memory> _Memories;
        public ObservableCollection<Memory> Memories
        {
            get => _Memories;
            set
            {
                _Memories = value;
                OnPropertyChanged(nameof(Memories));
            }
        }

        private ObservableCollection<Motherboard> _Motherboards;
        public ObservableCollection<Motherboard> Motherboards
        {
            get => _Motherboards;
            set
            {
                _Motherboards = value;
                OnPropertyChanged(nameof(Motherboards));
            }
        }

        private ObservableCollection<PowerSupply> _PowerSupplies;
        public ObservableCollection<PowerSupply> PowerSupplies
        {
            get => _PowerSupplies;
            set
            {
                _PowerSupplies = value;
                OnPropertyChanged(nameof(PowerSupplies));
            }
        }

        private ObservableCollection<RAM> _RAMs;
        public ObservableCollection<RAM> RAMs
        {
            get => _RAMs;
            set
            {
                _RAMs = value;
                OnPropertyChanged(nameof(RAMs));
            }
        }
        #endregion

        private RelayCommand _addCPUCommand;
        public RelayCommand AddCPUCommand
        {
            get => _addCPUCommand;
        }

        public BuildingVM(User tempUser)
        {
            UpdateCollections();
            _addCPUCommand = new RelayCommand(AddCPUOpenWindow);
        }

        public void AddCPUOpenWindow()
        {
            var addComponentWindow = new AddComponentWindow(new AddCPUVM());
            addComponentWindow.ShowDialog();
        }

        public void MakeFiltration()
        {
            if (TempCPU != null)
            {
                RAMs = new ObservableCollection<RAM>(DatabaseLists.GetDatabaseLists().RAMs.Where(x => x.Age == TempCPU.RamAge));

                if (TempRAM != null)
                    if (TempRAM.Age != TempCPU.RamAge)
                        TempRAM = null;
            }
        }

        private void UpdateCollections()
        {
            if (!IsShowUserAdded)
            {
                CPUs = new ObservableCollection<CPU>(DatabaseLists.GetDatabaseLists().CPUs.Where(x => x.AddedByUser == IsShowUserAdded));
                GraphicCards = new ObservableCollection<GraphicCard>(DatabaseLists.GetDatabaseLists().GraphicCards.Where(x => x.AddedByUser == IsShowUserAdded));
                Memories = new ObservableCollection<Memory>(DatabaseLists.GetDatabaseLists().Memories.Where(x => x.AddedByUser == IsShowUserAdded));
                Motherboards = new ObservableCollection<Motherboard>(DatabaseLists.GetDatabaseLists().Motherboards.Where(x => x.AddedByUser == IsShowUserAdded));
                PowerSupplies = new ObservableCollection<PowerSupply>(DatabaseLists.GetDatabaseLists().PowerSupplies.Where(x => x.AddedByUser == IsShowUserAdded));
                RAMs = new ObservableCollection<RAM>(DatabaseLists.GetDatabaseLists().RAMs.Where(x => x.AddedByUser == IsShowUserAdded));
            }
            else
            {
                CPUs = DatabaseLists.GetDatabaseLists().CPUs;
                GraphicCards = DatabaseLists.GetDatabaseLists().GraphicCards;
                Memories = DatabaseLists.GetDatabaseLists().Memories;
                Motherboards = DatabaseLists.GetDatabaseLists().Motherboards;
                PowerSupplies = DatabaseLists.GetDatabaseLists().PowerSupplies;
                RAMs = DatabaseLists.GetDatabaseLists().RAMs;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
