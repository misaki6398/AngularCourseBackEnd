using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Model
{
    public class DbInitializer
    {
        public static void Initilze(MeetingRoomContext context)
        {
            context.Database.EnsureCreated();
            if (context.MeetingRooms.Any()) return;
            MeetingRoomModel[] meetingRooms = {
                new MeetingRoomModel
                {
                Name = "馬德里",
                Size = 10,
                Projector = true,
                TV = true
                },new MeetingRoomModel
                {
                Name = "里約",
                Size = 15,
                Projector = true,
                TV = true
                },new MeetingRoomModel
                {
                Name = "戈多滑",
                Size = 20,
                Projector = false,
                TV = true
                },new MeetingRoomModel
                {
                Name = "馬德里2",
                Size = 11,
                Projector = true,
                TV = false
                },
            };

            context.MeetingRooms.AddRange(meetingRooms);
            context.SaveChanges();
        }
    }
}
