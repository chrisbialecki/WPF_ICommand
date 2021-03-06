﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_ICommand
{
    public class NameList : INotifyPropertyChanged
    {

        //event
        public event PropertyChangedEventHandler PropertyChanged;


        //invoke event method
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        //add command
        AddCommand _addCommand = new AddCommand();
        public AddCommand AddNameCommand
        {
            get { return _addCommand; }
        }

        //remove command
        RemoveCommand _removeCommand = new RemoveCommand();
        public RemoveCommand RemoveNameCommand
        {
            get { return _removeCommand; }
        }

        //list
        public ObservableCollection<string> Names
        {
            get;
            private set;

        }

        //constructor
        public NameList()
        {
            Names = new ObservableCollection<string>();
            MessageBox.Show("Hi from NameList constructor");
        }


        //command instance and property
        InfoCommand _infoCommand = new InfoCommand();
        public InfoCommand InformationCommand
        {
            get { return _infoCommand; }
        }


        // variables
        string _firstName = "";
        string _lastName = "";
        string _selectedName;

        //properties
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    OnPropertyChanged("SelectedName");
                }
            }
        }





    }
}
