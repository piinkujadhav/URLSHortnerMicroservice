namespace URLSHortnerMicroservice.Model
{/// <summary>
 /// Requestoing data from object generate short url method
 /// 
 /// </summary>
    public class GenerateShortUrlRequest
    {/// <summary>
    /// Instance of the string requesting longUrl
    /// </summary>
        public String Url{ get; set; }
    }
}
