using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
       public enum userDetails    {   Alive,Male, Unmarried}
    public class User
{
      public string username{ get; set;}

      [JsonConverter(typeof(StringEnumConverter))]
      public userDetails  details {get; set;}
}
}

