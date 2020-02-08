using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assembly_apple_methode;

namespace test_code
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CHARGERDROP1();
            }
        }
        public void CHARGERDROP1()
        {
            //String f=  ConfigurationManager.ConnectionStrings["A123"].ConnectionString;
            //DropDownList2.DataSource = Entity.v.Filieres.Select(p=> new {id=p.id,nom=p.Title }).ToList();
            DropDownList2.DataSource = Entity.prd.GetFilieres();
            DropDownList2.DataTextField = "Title";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = int.Parse(DropDownList1.SelectedValue.ToString());
            //TextBox1.Text = id.ToString();
            //GridView1.DataSource = v.pieces.Where(w => w.VoitureId == id).Select(oo => new { id = oo.Id, name = oo.name }).ToList();
            //GridView1.DataBind();
            int id = int.Parse(DropDownList2.SelectedValue.ToString());
            Label1.Text = id.ToString();
             
        }
        public void VIDER()
        {
            TextBox9.Text = "";
            TextBox8.Text = "";
            TextBox12.Text = "";
            TextBox11.Text = "";
            TextBox10.Text = "";
        }
        public void CHARERFLR()
        {
            GridView1.DataSource = Entity.prd.GetFilieres();
            GridView1.DataBind();
        }
        public void CHARGERGRP()
        {
            GridView1.DataSource = Entity.prd.GetGroupes();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(TextBox8.Text);
            Entity.f.id = id;
            Entity. f.Title = TextBox9.Text;
            Entity.prd.add_flr(Entity.f);
            VIDER();
            CHARERFLR();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox10.Text);
            Entity.g.id = id;
            Entity.g.Title = TextBox11.Text;
            Entity.g.Description = TextBox12.Text;
            Entity.g.idflr =int.Parse(DropDownList2.SelectedValue.ToString());
            Entity.prd.add_group(Entity.g);
            CHARGERGRP();
        }
    }
}