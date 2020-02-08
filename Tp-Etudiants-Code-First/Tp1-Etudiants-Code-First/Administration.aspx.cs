using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assembly_apple_methode;

namespace Tp1_Etudiants_Code_First
{
    public partial class Administration : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CHARGERDROP();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void GETFLR()
        {
            GridView1.DataSource = Entity.prd.GetFilieres();
            GridView1.DataBind();
        }
        public void GETGRP()
        {
            GridView1.DataSource = Entity.prd.GetGroupes();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
            //int id = int.Parse(TextBox6.Text);
            //var voi = Entity.v.Filieres.Where(ss => ss.id == id).Count();
            //if (voi == 0)
            //{
            //    Entity.f.id = id;
                Entity.f.Title = TextBox1.Text;
                Entity.prd.add_flr(Entity.f);
                VIER();
                GETFLR();
                DropDownList1.Items.Clear();
                CHARGERDROP();
            //}
            
            
               
            
        }

        public void VIER()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            //TextBox6.Text = "";
        }
        public void CHARGERDROP()
        {
            //DropDownList1.DataSource = v.Groupes.Select(p => new { id = p.VoitureId, name = p.name }).ToList();
            ////DropDownList1.DataSource = from x in v.Voitures select x;
            //DropDownList1.DataTextField = "name";
            //DropDownList1.DataValueField = "id";
            //DropDownList1.DataBind();

            DropDownList1.DataSource = Entity.prd.GetFilieres();
            DropDownList1.DataTextField = "Title";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = Int16.Parse(TextBox7.Text);
                //Entity.g.id = id;
                Entity.g.Title = TextBox3.Text;
                Entity.g.Description = TextBox4.Text;
                Entity.g.idflr = int.Parse(DropDownList1.SelectedValue.ToString());
                Entity.prd.add_group(Entity.g);
                VIER();
                GETGRP();
            }
            catch (Exception)
            {

               
            }
        }

        
    }
}