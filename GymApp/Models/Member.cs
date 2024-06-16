using GymApp.Enums;

namespace GymApp.Models;

public class Member
{
    public int MemberID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public Sex Sex { get; set; }
    public string ContactNumber { get; set; }
    public string Nationality { get; set; }
    public int Age { get; set; }
    public Plan Plan { get; set; }
    public int Price { get; set;}
    public bool IsDiscounted { get; set; }
    public int GivenPrice { get; set; }
    public int FreeMonths { get; set; }
    public DateTime SignedDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}
