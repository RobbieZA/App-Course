using RPAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace RPAPI.Models
{
    public class User
    {
        public int Id  { get; set; }
        public string Username  {get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string IDNum { get; set; }
        public string emailAddr { get; set; }
        public string cellNum { get; set; }
        public string role { get; set; }
        public bool isEnabled { get; set; }
        //public GeoCoordinate homeLoc { get; set; }
        //public GeoCoordinate lastKnownLoc { get; set; }
        public string Gender {get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<photo> Photos { get; set; }
        public User()
        {
            Photos = new Collection<photo>();
        }

    }
}

//[
//  '{{repeat(5)}}',
//  {
//    Username: '{{firstName("female")}}',
//    IDNum: '123456789012',
//    emailAddr: '{{email()}}',
//    cellNum: '0111231234',
//    role: 'guest',
//    isEnabled: true,
//    Gender: 'female',
//    DateOfBirth: '{{date(new Date(1950,0,1), new Date(1999, 11, 31), "YYYY-MM-dd")}}',
//    Password: 'password',
//    KnownAs: function(){ return this.Username; },
//    Created: '{{date(new Date(2017,0,1), new Date(2017, 7, 31), "YYYY-MM-dd")}}',
//    LastActive: function(){return this.DateCreated; },
//    City: '{{city()}}',
//    Country: '{{country()}}',
//    Photos: [
//        {
//          url: function(num) {
//          return 'https://randomuser.me/api/portraits/women/' + num.integer(1,99) + '.jpg';
//        },
//        isMain: true,
//        description: '{{lorem()}}'
//      }
//    ]
//  }
//]