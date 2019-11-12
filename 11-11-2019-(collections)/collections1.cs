using System;
using System.Collections.Generic;

namespace CollectionClass
{
    public class Store : IEquatable<Store>
    {
        public int storeId;
        public string storeEmp;

       
    public override string ToString()
        {
        return "ID: " + storeId + "EMP: "+ storeEmp;
        }
        public override int GetHashCode()
        {
            return this.storeId; 
        }
        public bool Equals(Store o)
        {
            if (o == null)
            {
                return false;
            }
            else return this.storeId.Equals(o.storeId);
        }
    }
    public class Example
    {
		public static void Main(){
        List<Store> list = new List<Store>();
        list.Add(new Store(){ storeId =101, storeEmp = "ismail"});
        list.Add(new Store(){storeId = 102, storeEmp = "pathan"});
        list.Add(new Store(){storeId = 103, storeEmp = "is"});
        list.Add(new Store(){storeId =104, storeEmp = "pa"});

        foreach (var f  in list)
        {
            Console.WriteLine(f);
        }
        Console.WriteLine("Contains: " + list.Contains(new Store{ storeId = 105, storeEmp ="" }));
			Console.WriteLine("Find employee Name:"  + list.Find( a => a.storeEmp.Contains("ismail")));
			Console.WriteLine("Find Emp Id:"+ list.Exists(b => b.storeId == 104));
    }
}
}