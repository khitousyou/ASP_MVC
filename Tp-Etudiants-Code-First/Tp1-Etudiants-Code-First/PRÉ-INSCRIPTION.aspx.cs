using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assembly_apple_methode;

namespace Tp1_Etudiants_Code_First
{
    public partial class PRÉ_INSCRIPTION : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            //TextBox4.Text = DateTime.Now.ToString("MMMM dd,yyyy");
            if (!IsPostBack)
            {
                CHARGERDROP();
                CHARGERDROPBYGROUP();


            }
        }

        public void VIER()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
           
        }

        public void CHARGERDROP()
        {
            DropDownList1.DataSource = Entity.prd.GetGroupes();
            DropDownList1.DataTextField = "Title";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        public void CHARGERDROPBYGROUP()
        {
            DropDownList2.DataSource = Entity.prd.GetFilieres();
            DropDownList2.DataTextField = "Title";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entity.e.Prenom = TextBox1.Text;
            Entity.e.nom = TextBox2.Text;
            Entity.e.Adress = TextBox3.Text;
            Entity.e.date = DateTime.Parse(Calendar1.SelectedDate.ToString());
            Entity.e.groupid =int.Parse(DropDownList1.SelectedValue.ToString());
            Entity.prd.Add_Etudiants(Entity.e);
            VIER();
            GridView1.DataSource = Entity.prd.GetEtudiants();
            GridView1.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int id = int.Parse(DropDownList2.SelectedValue.ToString());
                TextBox1.Text = id.ToString();
                GridView2.DataSource = Entity.v.Etudiants.Where(ww => ww.id == id).Select(p => new { id = p.id, name = p.nom, Prenom = p.Prenom, date = p.date, Group_Affecter = p.groupes.Title }).ToList();
                GridView2.DataBind();

            
        }
    }
}