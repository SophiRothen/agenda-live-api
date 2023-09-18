namespace agenda_live_api.Domain.Models
{
    public class Live
    {
        public string id { get; private set; }
        public string liveName { get; private set; }
        public string channelName { get; private set; }
        public string liveDate { get; private set; }
        public string liveTime { get; private set; }
        public string liveLink { get; private set; }

        //public SafeResourceUrl urlSafe { get; private set; }

        public Live(string id, string liveName, string channelName, string liveDate, string liveTime, string liveLink)
        {
            this.id = id;
            this.liveName = liveName;
            this.channelName = channelName;
            this.liveDate = liveDate;
            this.liveTime = liveTime;
            this.liveLink = liveLink;
        }

        public Live()
        {
        }
    }
}
