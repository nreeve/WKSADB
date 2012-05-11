using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WKSADB
{
    partial class Competitor
    {
        //TODO: Change this to a dictionary keyed off DivisionTypeId
        public List<CompetitorDivision> Divisions { get; set; }
    }
}
