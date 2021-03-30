using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery.BusinessLayer
{
    public class WorkModel
    {
        public int ID { get; set; }

        public int ArtistID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Value { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }

        [StringLength(15)]
        public string Type { get; set; }
        public float? Weight { get; set; }

        [StringLength(15)]
        public string Material { get; set; }
        public char WorkType { get; set; }
        public static WorkModel NewWork(char type)
        {
            return new WorkModel()
            {
                WorkType = Char.ToUpper(type),
                Date = DateTime.Now
            };
        }
        public override string ToString()
        {
            return Name + "\t" + Date.ToShortDateString();
        }
    }
}
