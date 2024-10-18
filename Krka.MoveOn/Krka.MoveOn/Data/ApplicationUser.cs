using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Krka.MoveOn.Services.Pages;

namespace Krka.MoveOn.Data {
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser {
        [Column("first_name", TypeName = "nvarchar"), StringLength(100)]
        public string? FirstName { get; set; }
        [Column("lst_name", TypeName = "nvarchar"), StringLength(100)]
        public string? LastName { get; set; }
        [Column("title_before", TypeName = "nvarchar"), StringLength(50)]
        public string? TitleBefore { get; set; }
        [Column("title_after", TypeName = "nvarchar"), StringLength(50)]
        public string? TitleAfter { get; set; }
    }
    public class ApplicationEditUser
    {
        public required string Id { get; set; }
        public required string UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TitleBefore { get; set; }
        public string? TitleAfter { get; set; }
        public string? Phone { get; set; }
        public RoleObject Role { get; set; } = new RoleObject() { Name = "Doctor" };
        public string? FullName { get { return string.Join(" ", new[] { TitleBefore, FirstName, LastName, TitleAfter }.Where(i => !string.IsNullOrWhiteSpace(i))); } }
    }
}