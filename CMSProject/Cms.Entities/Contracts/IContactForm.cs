using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.Contracts
{
    public interface IContactForm
    {
        [Key]
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
