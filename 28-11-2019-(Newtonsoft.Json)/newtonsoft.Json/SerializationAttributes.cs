using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSerializationExample
{

 class Accounts
 {
     //types
     public string FirstName{get; set;}
     public string AccountName{get; set;}
     public string userName{get; set;}

     [JsonExtensionData]
    private IDictionary<string, JToken> _additionalData;

    [OnDeserialized]
    private void OnDeserialized(StreamingContext context)
    {
        string accountName = (string)_additionalData["accountName"];

        Domain = accountName.Split(' ')[0];
        UserName = accountName.Split(' ')[1];
    }

    public DirectoryAccount()
    {
        _additionalData = new Dictionary<string, JToken>();
    }
 }

    //usage
   
      string json = @"{
  'FirstName': 'John',
  'AccountName': 'ANDB5425515',
      'userName':'john14'
           }";
   Accounts account = JsonConvert.DeserializeObject<Accounts>(json);

    Console.WriteLine(account.FirstName);
  Console.WriteLine(account.AccountName);
   Console.WriteLine(account.UserName);
    }
}