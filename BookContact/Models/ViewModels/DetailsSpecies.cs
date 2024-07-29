using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookContact.Models.ViewModels
{
    public class DetailsSpecies
    {
        public SpeciesDto SelectedSpecies { get; set; }
        public IEnumerable<AnimalDto> RelatedAnimals { get; set; }
    }
}