using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.Contracts
{
    public interface ILanguage
    {
        [Key]
        public int Id { get; set; }
        public string LanguageTag { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
    }
}
