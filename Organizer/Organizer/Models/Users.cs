using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Organizer.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Nick { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Avatar { get; set; }
        public string CodeLanguage { get; set; }

        public virtual ICollection<Tasks> Tasks { get; set; }

        public Users()
        {
            Tasks = new HashSet<Tasks>();
            this.Avatar = "http://www.teniteatr.ru/assets/no_avatar-e557002f44d175333089815809cf49ce.png";
            this.CodeLanguage = "en";
        }
    }
}