using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MTech.Models
{
    public enum EmployeeStatus
    {
        [Display(Name = "NotSet")]
        NotSet = 0,
        [Description("Active")]
        Active = 1,
        [Description("Inactive")]
        Inactive = 2,
    }
}
