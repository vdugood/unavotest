using System;
using System.Web;
using System.Data;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using DataLayer.CustomerAccount;

namespace CCANALocalWirelessApp
{
    public partial class CustomerInteractonIdMap : System.Web.UI.Page
    {
        private string ClecId = "224";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["audiodata"] != null)
                {
                   CAudioData audiodata = (CAudioData)Session["audiodata"];

                    if (audiodata != null)
                    {
                        lblInteractionIdValue.Text = audiodata.InteractionId;
                        lblToNumberValue.Text = audiodata.TO;
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string script = "window.close()";

            lblErorMessage.Text = "";

            if (string.IsNullOrEmpty(lblInteractionIdValue.Text) == true)
            {
                lblErorMessage.Text = "Interaction Id cannot be empty.";
                return;
            }

            CAudioData audiodata = (CAudioData)Session["audiodata"];
           
            this.btnSubmit.Enabled = false;

            try
            {
                if (audiodata != null)
                {
                 
                    //setup Audio file Upload 
                    new CustomerAccountController().AddCustomerAccount(
                                                 lblInteractionIdValue.Text,
                                                 txtMDN.Text,
                                                 audiodata.TO,
                                                 audiodata.ACD_PRIORITY,
                                                 audiodata.RequestTime,
                                                 audiodata.State,
                                                 audiodata.IntDate,
                                                 audiodata.From,
                                                 audiodata.ProjectId,
                                                 audiodata.IMFirstName,
                                                 audiodata.SystemOfferTime,
                                                 audiodata.UniqueId,
                                                 audiodata.imLastName,
                                                 audiodata.imContactId,
                                                 audiodata.Timezone,
                                                 audiodata.CustomerId,
                                                 audiodata.PhoneNumber,
                                                 audiodata.SystemTransfer,
                                                 audiodata.Priority,
                                                 audiodata.UserName,
                                                 audiodata.ScriptId,
                                                 audiodata.QueueTime,
                                                 audiodata.Offset,
                                                 audiodata.FirstName,
                                                 audiodata.DoNotRecord,
                                                 audiodata.INTID,
                                                 audiodata.SystemEmailSubject,
                                                 audiodata.LastName,
                                                 audiodata.SystemStartTime,
                                                 audiodata.InteractionId,
                                                 audiodata.MCT,
                                                 audiodata.AgentLastName,
                                                 audiodata.FaqId,
                                                 audiodata.CountryCode,
                                                 audiodata.AgentId,
                                                 audiodata.Display,
                                                 audiodata.CompanyName,
                                                 audiodata.WorkgroupId,
                                                 audiodata.PredictiveContactId,
                                                 audiodata.Extension,
                                                 audiodata.ContactId,
                                                 audiodata.Email,
                                                 audiodata.SessionId,
                                                 audiodata.AgentFirstName,
                                                 audiodata.IMCompanyName,
                                                 audiodata.CompanyId,
                                                 audiodata.OtherId,
                                                 audiodata.InteractionType,
                                                 audiodata.AgentCompanyName,
                                                 chkLOA.Checked);

                }
            }
            catch (Exception ex)
            {
                lblErorMessage.Text = "Interaction Id:=" + lblInteractionIdValue.Text + " Error Msg:" + ex.Message;
                this.btnSubmit.Enabled = true;
                return;
            }


            ScriptManager.RegisterStartupScript(this, this.GetType(), "test", script, true);
        }


    }
}
