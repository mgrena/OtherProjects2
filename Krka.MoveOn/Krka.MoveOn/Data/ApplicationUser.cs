using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Krka.MoveOn.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser {

    [Required]
    [Column("id_workplace")]
    public int WorkplaceId { get; set; } = 1;

    [Column("first_name", TypeName = "nvarchar"), StringLength(100)]
    public string? FirstName { get; set; }
    [Column("lst_name", TypeName = "nvarchar"), StringLength(100)]
    public string? LastName { get; set; }
    [Column("title_before", TypeName = "nvarchar"), StringLength(50)]
    public string? TitleBefore { get; set; }
    [Column("title_after", TypeName = "nvarchar"), StringLength(50)]
    public string? TitleAfter { get; set; }
    [NotMapped]
    public string? Password { get; set; }
    [NotMapped]
    public string? ConfirmPassword { get; set; }
    [NotMapped]
    public string? FullName { get { return string.Join(" ", new[] { TitleBefore, FirstName, LastName, TitleAfter }.Where(i => !string.IsNullOrWhiteSpace(i))); } }
    [NotMapped]
    public IdentityRole? Role { get; set; }
    [NotMapped]
    public WorkPlace? WorkPlace { get; set; }
}