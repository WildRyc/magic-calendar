using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagicCalendar.Models;

namespace MagicCalendar.Data
{
    public class MagicCalendarContext : DbContext
    {
        public MagicCalendarContext (DbContextOptions<MagicCalendarContext> options)
            : base(options)
        {
        }

        public DbSet<MagicCalendar.Models.Game> Game { get; set; } = default!;
        public DbSet<MagicCalendar.Models.Format> Format { get; set; } = default!;
        public DbSet<MagicCalendar.Models.Organizer> Organizer { get; set; } = default!;
        public DbSet<MagicCalendar.Models.Event> Event { get; set; } = default!;
            }
}
