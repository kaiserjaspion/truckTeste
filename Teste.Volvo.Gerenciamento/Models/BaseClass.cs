using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Volvo.Gerenciamento.Models
{
    public class BaseClass
    {
        [Column("IsActive"), Required]
        public bool IsActive { get; set; } = true;
        [Column("DtCreated"), Required]
        public DateTime Created { get; set; } = DateTime.Now;
        [Column("DtChange"), Required]
        public DateTime Change { get; set; } = DateTime.Now;
        [Column("DsChangedBy"), Required]
        public string ChangedBy { get; set; }
    }
}
