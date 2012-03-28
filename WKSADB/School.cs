using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WKSADB
{
    partial class School
    {
        public string FullName { get { return string.Format("{0} ({1})", SchoolName, SchoolCode ); } }
    }
}
