using MySimpleTrade.WPF.State.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrade.WPF.ViewModels
{
   public class MainViewModel:ViewModelBase
    {
        Inavigator navigator {  get; set; }= new Navigator();

    }
}
