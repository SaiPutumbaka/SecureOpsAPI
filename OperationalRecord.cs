namespace SecureOpsAPI;

public class OperationalRecord
{
    public int Id { get; set; }
    public string LocationName { get; set; } = string.Empty;
    public double Revenue { get; set; }
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}