/*
- Name of Marine
- Days they are working
- Dates of unavailability (leave, special liberty, etc.)
*/

public class Marine
{
    public string Name { get; set; }
    public List<ShiftAssignmentRange> ShiftSchedule { get; set; } = new();
    public List<int> UnavailableDays { get; set; } = new(); //leave, special liberty, inbound, outbound, PTAD
}