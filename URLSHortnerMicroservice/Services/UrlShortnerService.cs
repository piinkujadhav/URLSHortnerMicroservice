namespace URLSHortnerMicroservice.Services

{
    public class UrlShortnerService : IUrlShortnerServices
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQURSTUVWXYZ";
        private Random random = new Random();
        _random.next(); 
        public Task<string?> GetOriginalUrlAsync(string shortCode);
        { 
        throw new NotImplementedException();  


    }
       
        public Task<string> ShortenUrlAsync(string originalUrl)
        {
            //valiation
            //Genrate teh shortner code
            //add prefix if needed
            var shorturl = "newgen.ly" + shortcode;
            var mapping = new UrlMapping(); 
            mapping.shortUrl=shorturl;
            mapping .longurl=shorturl;
            //add into database
            
       
       
  }
        }

}
