using System.ComponentModel.DataAnnotations;

namespace agenda_live_api.Domain.DTOs
{
    public class LiveDTO
    {
        private LiveDTO live;
      
        public string LiveName { get; set; }
        public string ChannelName { get; set; }
        public string LiveDate { get; set; }
        public string LiveTime { get; set; }
        public string LiveLink { get; set; }

        public LiveDTO()
        {
        }


        public LiveDTO(LiveDTO live)
        {
            this.live = live;
        }

        
    }
}
