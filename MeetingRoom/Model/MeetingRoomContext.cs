using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Model
{
    public class MeetingRoomContext : DbContext
    {
        public MeetingRoomContext(DbContextOptions<MeetingRoomContext> options) : base(options)
        {
            
        }

        public DbSet<MeetingRoomModel> MeetingRooms { get; set; }
    }
}
