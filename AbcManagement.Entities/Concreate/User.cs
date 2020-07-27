using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcManagement.Entities.Concreate
{
    [Table("Users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long UserId { get; set; }

        [StringLength(50), Required]
        public virtual string UserName { get; set; }

        [StringLength(50), Required]
        public virtual string FirstName { get; set; }

        [StringLength(50), Required]
        public virtual string LastName { get; set; }

        [StringLength(150), Required]
        public virtual string Email { get; set; }

        [StringLength(256), Required]
        public virtual string Password { get; set; }

        [StringLength(1000)]
        public virtual string UserAbout { get; set; }

        [StringLength(int.MaxValue)]
        public virtual string Avatar { get; set; }

        [Required]
        public virtual bool IsActive { get; set; }

        [Required]
        public virtual bool IsAdmin { get; set; }

    }
}
