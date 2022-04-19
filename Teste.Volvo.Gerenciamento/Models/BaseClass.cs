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
        public virtual bool IsActive { get; set; } = true;
        [Column("DtCreated"), Required]
        public virtual DateTime Created { get; set; } = DateTime.Now;
        [Column("DtChange"), Required]
        public virtual DateTime Change { get; set; } = DateTime.Now;
        [Column("DsChangedBy"), Required]
        public virtual string ChangedBy { get; set; }
    }
}
