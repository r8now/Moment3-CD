namespace Moment3_CD.Models
{
    public class Cd
    {
        public int CdId { get; set; }

        public string? Title { get; set; }

        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}
