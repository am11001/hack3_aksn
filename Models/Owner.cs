using System.ComponentModel.DataAnnotations;

namespace HACKH.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParkingId { get; set; }
        public int Points { get; set; }
        public Owner() { }

        public Owner(int Id, string Name, int ParkingId, int points=0)
        {
            this.Id = Id;
            this.Name = Name;
            this.ParkingId = ParkingId;
            this.Points = points;

        }

        //public User GetUser()
        //{

        //}
    }
}
