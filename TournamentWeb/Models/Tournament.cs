using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using static TournamentWeb.Data.CustomDataAnnotation;

namespace TournamentWeb.Models
{
    public class Tournament
    {
        private DateTime _date = DateTime.Now;

        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        [Required]
        public string TournamentInfo { get; set; }
        public DateTime CreationDate { get; set; }

        [CurrentDate(ErrorMessage = "Date must be after or equal to current date")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime TimeFrame
        {
            get { return _date; }

            set  { _date = value; }
        }
    
        public int ParticipantsAmount { get; set; }
        public string UserId { get; set; }
        
        [Required]
        [Range(1, 8)]
        public int Bracketsize { get; set; }
        ///img things
        ///
        [Display(Name = "choose the Image for the Tournament")]
     
        [NotMapped]
        public IFormFile TournamentImageFile { get; set; }

        public string TournamentImage { get; set; }


        public ICollection<Teams> Teams { get; set; } = new List<Teams>();

        public Tournament()
        {
        }
    }
}

