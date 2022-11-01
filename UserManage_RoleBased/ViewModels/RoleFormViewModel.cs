using System.ComponentModel.DataAnnotations;

namespace UserManage_RoleBased.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}
