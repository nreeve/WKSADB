using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WKSADB
{
    [MetadataType(typeof(TournamentMetaData))]
    partial class Tournament
    {
        public int[] SelectedDivisionIds { get; set; }
        public int[] SelectedGrandChampionIds { get; set; }
    }

    public class TournamentMetaData
    {
        [Required]
        public string TournamentName { get; set; }

        [Required]
        public int VenueId { get; set; }
    }
}
