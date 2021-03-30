using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery.BusinessLayer
{
    public class ArtistModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Speciality { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public IList<WorkModel> Works { get; set; }

    }
}
