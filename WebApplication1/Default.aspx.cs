using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["addressList"] == null)
            {
                AdressService service = new AdressService();
                Session.Add("addressList", service.list());
            }
            dgvAddresses.DataSource = Session["addressList"];
            dgvAddresses.DataBind();
        }

        protected void dgvAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvAddresses.SelectedDataKey.Value.ToString();
            Response.Redirect("AddressForm.aspx?id=" + id);
        }

        protected void dgvAddresses_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = dgvAddresses.DataKeys[e.RowIndex].Value.ToString();
            var myList = Session["addressList"] as List<Address>;
            myList.RemoveAll(item => item.Id == int.Parse(id));
            Response.Redirect("Default.aspx");
        }
    }
}