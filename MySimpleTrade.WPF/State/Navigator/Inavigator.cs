using MySimpleTrade.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleTrade.WPF.State.Navigator
{
    public enum ViewType 
    {
     Home,
     Protofolio
    
    }
   public interface Inavigator
    {
        ViewModelBase currentViewModel { get; set; }
        ICommand updateCurrentViewModelICommand { get; }
    }
}
