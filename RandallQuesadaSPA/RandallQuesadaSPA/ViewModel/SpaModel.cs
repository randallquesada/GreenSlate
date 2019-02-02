using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RandallQuesadaSPA.Interfaces;

namespace RandallQuesadaSPA.ViewModel
{
    public class SpaModel
    {
        public List<UserProjectViewBase> UserBaseProjectList{ get; set; }
        public UserBase User { get; set; }

    }
}