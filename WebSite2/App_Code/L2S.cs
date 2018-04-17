using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

/// <summary>
/// Сводное описание для L2S
/// </summary>
/// 


    public class L2S
    {

    [Table(Name = "UserData")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Username")]
        public string Username { get; set; }
        [Column(Name = "Password")]
        public string Password { get; set; }
    }
}
