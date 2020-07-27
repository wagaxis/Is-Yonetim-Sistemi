using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcManagement.Entities.Concreate
{
    [Table("Works")]
    public class Work
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long WorkId { get; set; }

        [StringLength(50), Required]
        public virtual string WorkName { get; set; }

        [StringLength(1000)]
        public virtual string WorkDesc { get; set; }

        public virtual int Progress { get; set; }

        public virtual bool SyncProgress { get; set; }

        [Required]
        public virtual int Category { get; set; }


    }
}
