﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.Model
{
    public class LookupItem:INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string DisplayMember{get;set;}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
