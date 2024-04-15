using System.ComponentModel.DataAnnotations;

namespace TheWaterProject.Models;

public class User
{
    [Key]
    public int UserID {  get; set; }
    public string username { get; set; }
}