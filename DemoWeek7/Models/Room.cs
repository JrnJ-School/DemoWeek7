using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DemoWeek7.Models
{
    /// <summary>
    /// Database Model
    /// </summary>
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURI { get; set; }
    }
}
