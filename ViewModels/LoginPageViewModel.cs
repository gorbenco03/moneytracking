﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.ViewModels
{
    public partial class LoginPageViewModel : BasicViewModel
    {
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;


        [RelayCommand]
        public void Login()
        {
            return; 
        }
    }
}
