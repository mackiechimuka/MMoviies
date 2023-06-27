using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public enum Ascending
    {
        [Display(Name ="Ascending")]
        asc,
        [Display(Name ="Descending")]
        desc
    }
}
