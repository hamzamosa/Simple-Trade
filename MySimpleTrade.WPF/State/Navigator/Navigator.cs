using MySimpleTrade.WPF.Commands;
using MySimpleTrade.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleTrade.WPF.State.Navigator
{
    public class Navigator : Inavigator
    {
        public ViewModelBase currentViewModel { get; set; }

        public ICommand updateCurrentViewModelICommand => new updateCurrentViewModelICommand(this);
    }
}
