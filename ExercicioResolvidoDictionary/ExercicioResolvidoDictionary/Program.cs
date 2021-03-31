using System;
using System.Collections.Generic;


namespace ExercicioResolvidoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["User"] = "maria";
            cookies["Email"] = "Maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["Email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("Email");
            if (cookies.ContainsKey("Email"))
            {

            }
            else
            {
                Console.WriteLine(" There is no 'Email' key ");
            }
            Console.WriteLine("Size : " +cookies.Count);

            Console.WriteLine("All COOKIES :");
            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key +":" + item.Value);
            }
        }
    }
}
