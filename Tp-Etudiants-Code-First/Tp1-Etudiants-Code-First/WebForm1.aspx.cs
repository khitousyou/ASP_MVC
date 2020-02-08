using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assembly_apple_methode;

namespace Tp1_Etudiants_Code_First
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Etudiants e1 = new Etudiants();
            EtudiantsDBContext v = new EtudiantsDBContext();
            Etudinats_Repositoy prd = new Etudinats_Repositoy();
            int id = int.Parse(TextBox1.Text);
            e1.nom = TextBox2.Text;
            e1.Prenom = TextBox3.Text;
            e1.Adress = TextBox4.Text;
            e1.date = Calendar1.SelectedDate;
            prd.Add_Etudiants(e1);
            GridView1.DataSource= prd.GetEtudiants();
            GridView1.DataBind();
        }
    }
}