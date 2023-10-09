namespace DemoWeek7.Models.ViewModels
{
    /// <summary>
    /// ViewModel for a Model
    /// </summary>
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURI { get; set; }
        public bool AtCapacity { get; set; }

        public RoomViewModel() { }

        public RoomViewModel(Room room)
        {
            this.Id = room.Id;
            this.Name = room.Name;
            this.ImageURI = room.ImageURI;

            //
            CalculateCapacity();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Room ToRoom()
        {
            return new()
            {
                Id = this.Id,
                Name = this.Name,
                ImageURI = this.ImageURI,
            };
        }

        private void CalculateCapacity()
        {
            AtCapacity = Name.ToLower().Contains('a');
        }
    }
}
