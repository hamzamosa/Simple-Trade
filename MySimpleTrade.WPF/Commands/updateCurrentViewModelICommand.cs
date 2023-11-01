using MySimpleTrade.WPF.State.Navigator;
using MySimpleTrade.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleTrade.WPF.Commands
{
    public class updateCurrentViewModelICommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Inavigator _Inavigator;
        public updateCurrentViewModelICommand(Inavigator inavigator)
        {
            _Inavigator = inavigator;
                
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter is ViewType) 
            {
            
            ViewType viewType = (ViewType)parameter;

                switch (viewType) 
                {

                    case ViewType.Home:
                        _Inavigator.currentViewModel = new HomeViewModel();
                          break;

                    case ViewType.Protofolio:
                        _Inavigator.currentViewModel = new ProtofolioViewModel();
                          break;
                    default:break;


                }
            
            }
        }
    }
}
