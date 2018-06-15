using System;
using System.Collections.Generic;
using RPAPI.Models;

namespace RPAPI.Dtos
{
    public class UserForDetailDto
    {
        public int Id  { get; set; }
        public string Username  {get; set; }
        public string IDNum { get; set; }
        public string emailAddr { get; set; }
        public string cellNum { get; set; }
        public string role { get; set; }
        public bool isEnabled { get; set; }
        //public GeoCoordinate homeLoc { get; set; }
        //public GeoCoordinate lastKnownLoc { get; set; }
        public string Gender {get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailDto> Photos { get; set; }
    }
}