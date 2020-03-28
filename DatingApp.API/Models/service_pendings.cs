using System;

namespace DatingApp.API.Models
{
    public class service_pending
    {
        public int Id { get; set; }
        public int service_id { get; set; }
        public DateTime pending_start { get; set; }
        public DateTime pending_end { get; set; }
        public int pending_repeat { get; set; }
        public int repeat_cnt { get; set; }
        public DateTime date_updated { get; set; }
        public string user_updated { get; set; }
    }
}
