﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAccess.Cor.Models
{
    [Table("UserRto")]
    class UserRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumberPrefix { get; set; }
        public string PhoneNumber { get; set; }

    }
}
