using System.Xml.Serialization;
using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.SqlServer;
using URLShortnerMicroserivce.Model;
using static System.Net.Mime.MediaTypeNames;


namespace URLSHortnerMicroservice.Data

{
    /// <summary>
    /// Database context class for the CRUD opration on DB  using EF
    /// </summar
    public class UrlshortenerContextxt : DbContext
    {
       
        
            /// <summary>
            /// represent th url mapping table in the database
            /// </summary>
             public DbSet<UrlMapping>UrlMappings { get; set; }
            /// <summary>
            ///  this will configure the  the databse  engine used for the DbContext.
            /// </summary>
            /// <param name="optionsBuilder"></param> Instance of  DbContextOptionBuilder.</param>
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7ANFNK0\\SQLEXPRESS;Initial Catalog=urlMapping;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        
    }
}
