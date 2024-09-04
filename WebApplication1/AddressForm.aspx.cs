using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;

namespace WebApplication1
{
    public partial class AddressForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Address> temp = (List<Address>)(Session["addressList"]);
                Address selected = temp.Find(x  => x.Id == id);
                txtId.Text = selected.Id.ToString();
                txtNumber.Text = selected.Number.ToString();
                txtStreet.Text = selected.Street.ToString();
                txtId.ReadOnly = true;
            }
            }
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Address a = new Address();
                a.Id = int.Parse(txtId.Text);
                a.Street = txtStreet.Text;
                a.Number = int.Parse(txtNumber.Text);

                ((List<Address>)Session["addressList"]).Add(a);
                Response.Redirect("Default.aspx");
            }
            else
            {
                
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Address> temp = (List<Address>)(Session["addressList"]);
                Address selected = temp.Find(x => x.Id == id);

                selected.Id = int.Parse(txtId.Text);
                selected.Number = int.Parse(txtNumber.Text);
                selected.Street = txtStreet.Text;

               

                Response.Redirect("Default.aspx");

                
            }
        }
    }
}