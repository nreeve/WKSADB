using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WKSADB
{
    [MetadataType(typeof(CompetitorDivisionMetaData))]
    partial class CompetitorDivision
    {
        
    }

    public class CompetitorDivisionMetaData
    {
        [Range(0,5)]
        public int? Result { get; set; }
    }
}
