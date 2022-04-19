﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Volvo.Gerenciamento.Models
{
    [Table("Truck")]
    public class Truck: BaseClass
    {
        [Column("Id"),Key,DatabaseGenerated(DatabaseGeneratedOption.Identity),Required]
        public Guid? Id { get; set; }
        [Column("Model"), Required]
        [StringLength(2)]
        public string Model { get; set; }
        [Column("ManufactureYear"), Required]
        public DateTime ManufactureYear { get; set; }
        [Column("ModelYear"), Required]
        public DateTime ModelYear { get; set; }
    }
}
