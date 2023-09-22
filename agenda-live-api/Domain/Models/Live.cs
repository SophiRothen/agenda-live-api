namespace agenda_live_api.Domain.Models
{
    public class Live
    {
        public string Id { get;  set; }
        public string LiveName { get;  set; }
        public string ChannelName { get;  set; }
        public string LiveDate { get;  set; }
        public string LiveTime { get;  set; }
        public string LiveLink { get;  set; }

        //public SafeResourceUrl urlSafe { get; private set; }

        public Live()
        {
        }

        public Live(string id, string liveName, string channelName, string liveDate, string liveTime, string liveLink)
        {
            Id = id;
            LiveName = liveName;
            ChannelName = channelName;
            LiveDate = liveDate;
            LiveTime = liveTime;
            LiveLink = liveLink;
        }
    }
}
