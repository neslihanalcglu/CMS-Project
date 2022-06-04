using Cms.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.DataContext
{
    public class ContactForm: IContactForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameSurname { get; set; }
        
        public string Email { get; set; }
        public string Tel { get; set; }
        public string FormContent { get; set; }
        public bool IsReaded { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsDeleted { get; set; }
    }
}
