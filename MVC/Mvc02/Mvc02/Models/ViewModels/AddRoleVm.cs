using System.ComponentModel.DataAnnotations;

namespace Mvc02.Models.ViewModels
{
    public class AddRoleVm
    {
        [Required]
        public string RoleName { get; set; }
        [Required]
        [RegularExpression(@"^[A-ZÅÄÖa-zåäö0-9]+@[A-ZÅÄÖa-zåäö0-9]+.[A-Za-z]+$", ErrorMessage = "Invalid email-adress")]
        public string Email { get; set; }

    }
}
