namespace NSE.WebAPI.Core.Identity
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string ValidAt { get; set; }
        public string Issuer { get; set; }
        public int ExpirationTime { get; set; }
    }
}