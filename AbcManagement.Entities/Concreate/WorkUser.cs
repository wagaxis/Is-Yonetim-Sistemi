using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbcManagement.Entities.Concreate
{
    public class WorkUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long WorkUsersId { get; set; }

        public virtual long UserId { get; set; }
        public virtual long WorkId { get; set; }
    }
}
