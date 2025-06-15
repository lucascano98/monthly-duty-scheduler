/*
- Name of post (Post 1, Post 2, Rover, etc.)
- How many hours is that post?
- How many days/which days is that post?
*/

public class Post
{
    public string Name { get; set; }
    public int DailyHours { get; set; } // 24-hour post, 12-hour post, 8-hour post?
    public List<DayOfWeek> OperatingDays { get; set; } // [Mon-Fri] or [Mon-Sun]
}