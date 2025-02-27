using GymApp.Enums;
using SQLite;

namespace GymApp.Models;

public class Member
{
    [PrimaryKey, AutoIncrement]
    public int MemberID { get; set; }
    [Ignore]
    public string DisplayInitial { get => FirstName?.ToCharArray()?.FirstOrDefault().ToString() + LastName?.ToCharArray()?.FirstOrDefault(); }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Ignore]
    public string FullName { get => FirstName + " " + LastName; }
    public string Address { get; set; }
    public Sex Sex { get; set; }
    public int Age { get; set; }
    public string ContactNumber { get; set; }
    public string Nationality { get; set; }
    public Plan Plan { get; set; }
    public int Price { get; set;}
    public bool IsDiscounted { get; set; }
    public int GivenPrice { get; set; }
    public int FreeMonths { get; set; }
    public DateTime SignedDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}