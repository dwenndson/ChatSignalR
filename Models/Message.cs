using System;

namespace chat_app.Models
{
    public class Message
    {
        public string clientuniqueid { get; set; }
        public string tye { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}