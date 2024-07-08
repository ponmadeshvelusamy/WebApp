using System.ComponentModel.DataAnnotations;

namespace Weblibrary
{
    public class Webmodel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
