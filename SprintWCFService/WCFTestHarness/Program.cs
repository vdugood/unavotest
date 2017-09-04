using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFTestHarness.SprintWCFService;


namespace WCFTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SprintMVNEClient client = new SprintMVNEClient();
                DataSet ds  = client.QuerySubscriptionByMDN("2563749876");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
        
}
