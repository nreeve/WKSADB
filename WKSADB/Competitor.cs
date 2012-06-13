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

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Postcode { get; set; }
        public int? CountryId { get; set; }
    }
}
