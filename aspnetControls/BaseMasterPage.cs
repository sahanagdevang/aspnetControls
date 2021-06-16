using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace aspnetControls
{
    //It is going to be an abstract class because it is going to inherent some abstract properties and inherited 
    //from MasterPage class by default
    public abstract class BaseMasterPage: System.Web.UI.MasterPage
    {
        public abstract Panel searchPanel { get; }
        public abstract String SearchTerm { get; }
        public abstract Button SearchButton { get; }
    }
}