/*
- Define the shift
*/

public class ShiftBlock
{
    public string Name { get; set; }
    public int Day { get; set; }
    public ShiftType Shift { get; set; }
    public string? AssignedMarine { get; set; }
    public bool IsManualOverride { get; set; } = false;
}