public enum BadgeTier { Standard, VIP }

public class Badge
{
    public int Id { get; set; }
    public string CredentialNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public BadgeTier Tier { get; set; }

    
    public int AttendeeId { get; set; }
    public Attendee Attendee { get; set; }
}