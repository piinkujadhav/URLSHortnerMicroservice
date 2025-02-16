using System.ComponentModel.DataAnnotations;

namespace URLSHortnerMicroservice.Model
{
    public class UrlMapping
    {
        [Key]
        public string Id{ get; set; }
        [Required]
        public  string shortUrl { get; set; }=string.Empty;
        [Required]
        public string longUrl{ get; set; }= string.Empty;
    }
}
