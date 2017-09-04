using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CCANALocalWirelessApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["UniqueId"] == null)
                {
                    Application["UniqueId"] = 1;
                }
                else
                {
                    Application["UniqueId"] = Convert.ToInt32(Application["UniqueId"]) + 1;
                }

                CAudioData audiodata = new CAudioData();

                if (Request["interactionId"] != null)
                {
                    audiodata.InteractionId = Request["interactionId"].ToString();
                }
              
                if (Request["to"] != null)
                {
                    audiodata.TO = Request["to"].ToString();
                }

                if (Request["ACD_PRIORITY"] != null)
                {
                    audiodata.ACD_PRIORITY = Request["ACD_PRIORITY"].ToString();
                }
               
                if (Request["requestTime"] != null)
                {
                    audiodata.RequestTime = Request["requestTime"].ToString();
                }

                if (Request["state"] != null)
                {
                    audiodata.State = Request["state"].ToString();
                }
                
                if (Request["INTDATE"] != null)
                {
                    audiodata.IntDate = Request["INTDATE"].ToString();
                }
                
                if (Request["from"] != null)
                {
                    audiodata.From = Request["from"].ToString();
                }

                if (Request["projectId"] != null)
                {
                    audiodata.ProjectId = Request["projectId"].ToString();
                }
            
                if (Request["imFirstName"] != null)
                {
                    audiodata.IMFirstName = Request["imFirstName"].ToString();
                }
       
                if (Request["systemOfferTime"] != null)
                {
                    audiodata.SystemOfferTime = Request["systemOfferTime"].ToString();
                }
        
                if (Request["uniqueId"] != null)
                {
                    audiodata.UniqueId = Request["uniqueId"].ToString();
                }
       
                if (Request["imLastName"] != null)
                {
                    audiodata.imLastName = Request["imLastName"].ToString();
                }

                if (Request["imContactId"] != null)
                {
                    audiodata.imContactId = Request["imContactId"].ToString();
                }
      
                if (Request["timezone"] != null)
                {
                    audiodata.Timezone = Request["timezone"].ToString();
                }
              
                if (Request["customerId"] != null)
                {
                    audiodata.CustomerId = Request["customerId"].ToString();
                }
       
                if (Request["phoneNumber"] != null)
                {
                    audiodata.PhoneNumber = Request["phoneNumber"].ToString();
                }

                if (Request["systemTransfer"] != null)
                {
                    audiodata.SystemTransfer = Request["systemTransfer"].ToString();
                }
                
                if (Request["priority"] != null)
                {
                    audiodata.Priority = Request["priority"].ToString();
                }
        
                if (Request["userName"] != null)
                {
                    audiodata.UserName = Request["userName"].ToString();
                }
        
                if (Request["scriptId"] != null)
                {
                    audiodata.ScriptId = Request["scriptId"].ToString();
                }
        
                if (Request["queueTime"] != null)
                {
                    audiodata.QueueTime = Request["queueTime"].ToString();
                }
                
                if (Request["offset"] != null)
                {
                    audiodata.Offset = Request["offset"].ToString();
                }
      
                if (Request["firstName"] != null)
                {
                    audiodata.FirstName = Request["firstName"].ToString();
                }
        
                if (Request["doNotRecord"] != null)
                {
                    audiodata.DoNotRecord = Request["doNotRecord"].ToString();
                }
                
                if (Request["INTID"] != null)
                {
                    audiodata.INTID = Request["INTID"].ToString();
                }
       
                if (Request["systemEmailSubject"] != null)
                {
                    audiodata.SystemEmailSubject = Request["systemEmailSubject"].ToString();
                }
        
                if (Request["lastName"] != null)
                {
                    audiodata.LastName = Request["lastName"].ToString();
                }

                if (Request["systemStartTime"] != null)
                {
                    audiodata.SystemStartTime = Request["systemStartTime"].ToString();
                }
        
                if (Request["MCT"] != null)
                {
                    audiodata.MCT = Request["MCT"].ToString();
                }
                
                if (Request["agentLastName"] != null)
                {
                    audiodata.AgentLastName = Request["agentLastName"].ToString();
                }
        
                if (Request["faqId"] != null)
                {
                    audiodata.FaqId = Request["faqId"].ToString();
                }

                if (Request["countryCode"] != null)
                {
                    audiodata.CountryCode = Request["countryCode"].ToString();
                }
            
                if (Request["agentId"] != null)
                {
                    audiodata.AgentId = Request["agentId"].ToString();
                }

                if (Request["display"] != null)
                {
                    audiodata.Display = Request["display"].ToString();
                }

                if (Request["companyName"] != null)
                {
                    audiodata.CompanyName = Request["companyName"].ToString();
                }

                if (Request["workgroupId"] != null)
                {
                    audiodata.WorkgroupId = Request["workgroupId"].ToString();
                }

                if (Request["predictiveContactId"] != null)
                {
                    audiodata.PredictiveContactId = Request["predictiveContactId"].ToString();
                }
        
                if (Request["extension"] != null)
                {
                    audiodata.Extension = Request["extension"].ToString();
                }

                if (Request["contactId"] != null)
                {
                    audiodata.ContactId = Request["contactId"].ToString();
                }

                if (Request["email"] != null)
                {
                    audiodata.Email = Request["email"].ToString();
                }

                if (Request["sessionId"] != null)
                {
                    audiodata.SessionId = Request["sessionId"].ToString();
                }

                if (Request["agentFirstName"] != null)
                {
                    audiodata.AgentFirstName = Request["agentFirstName"].ToString();
                }

                if (Request["imCompanyName"] != null)
                {
                    audiodata.IMCompanyName = Request["imCompanyName"].ToString();
                }

                if (Request["companyId"] != null)
                {
                    audiodata.CompanyId = Request["companyId"].ToString();
                }

                if (Request["otherId"] != null)
                {
                    audiodata.OtherId = Request["otherId"].ToString();
                }

                if (Request["interactionType"] != null)
                {
                    audiodata.InteractionType = Request["interactionType"].ToString();
                }

                if (Request["agentCompanyName"] != null)
                {
                    audiodata.AgentCompanyName = Request["agentCompanyName"].ToString();
                }

                Session["audiodata"] = audiodata;
       
                string title = "MyWindow" + Application["UniqueId"].ToString();

                string script = "window.open('CustomerInteractonIdMap.aspx', '" + title + "', 'left=250,top=200,directories=no,titlebar=no,toolbar=no,location=no,status=no,menubar=no,scrollbars=no,resizable=no,height=200,width=400,z-index: 100;')";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "test", script, true);
            }

        }
        
    }
}
