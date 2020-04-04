using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Room: Entity
    {
        public Room()
        {
            RoomImages = new HashSet<RoomImage>();
        }
        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int FloorID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public int? RoomOwnerID { get; set; }
        public string PhoneExtension { get; set; }
        public string DataExtension { get; set; }
        public string PowerCode { get; set; }
        public string Remark { get; set; }
        public byte? Inactive { get; set; }

        public Floor Floor { get; set; }
        public RoomOwner RoomOwner { set; get; }
        public RoomType RoomType { get; set; }

        public ICollection<RoomImage>  RoomImages { get; set; }
    }
}
