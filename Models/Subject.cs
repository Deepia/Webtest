using System.ComponentModel.DataAnnotations;

namespace Webtest.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectTerm { get; set; }
        public string SubjectCredets { get; set; }

    }
}
