using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginDemo.Web.Models
{

    //This is View Model. 
    //Diff and can have more property compare to model.
    //Viewmodel can have collection of diff entities.
    //Look up view(Details) - While we are editing we need more like - not only one raw from one talbe but all data from other table as well.

    //ViewModel name here is AppSetting Because we are accessing Key from config file so, to indicate it. 
    public class AppSettingViewModel
    {
        public string Message { get; set; }
        public string Name { get; set; }
    }
}