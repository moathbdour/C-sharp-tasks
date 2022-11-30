using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using MathLibrary;

namespace test5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Response.Write("My Name Is Moath");
        //    CreataLabel();
          
           
        //}
        //public string[] mybirth = new string[3];
        
       
        protected void Submit(object sender, EventArgs e)
        {
            Class1 moath = new Class1();
            string name = txtName.Value;
            double fn = Convert.ToDouble(name);
            string email = txtEmail.Value;
            double sn = Convert.ToDouble(email);
           
            Label1.Text = Convert.ToString( moath.Devide(fn,sn));

            //string[] mybirth = Request["birthdate"].Split('/');
            //Response.Write(mybirth[0]);

            //MathLibrary.Class1    Multiply(float a, float b)

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 moath = new Class1();
            string name = txtName.Value;
            double fn = Convert.ToDouble(name);
            string email = txtEmail.Value;
            double sn = Convert.ToDouble(email);

            Label1.Text = Convert.ToString(moath.Multiply(fn, sn));

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 moath = new Class1();
            string name = txtName.Value;
            double fn = Convert.ToDouble(name);
            string email = txtEmail.Value;
            double sn = Convert.ToDouble(email);

            Label1.Text = Convert.ToString(moath.Add(fn, sn));

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 moath = new Class1();
            string name = txtName.Value;
            double fn = Convert.ToDouble(name);
            string email = txtEmail.Value;
            double sn = Convert.ToDouble(email);

            Label1.Text = Convert.ToString(moath.Substract(fn, sn));

        }

       
        //private void CreataLabel()

        //{



        //    //limit to Label textbox

        //    int a = 15;

        //    for (int i = 0; i < a; i++)

        //    {

        //        Label lblDynamic = new Label();



        //        //Declaring the textbox ID name



        //        lblDynamic.ID = "lbl" +  i ;



        //        lblDynamic.Width = 400;

        //        lblDynamic.Height = 20;

        //        lblDynamic.Text = "Label" +  i ;



        //        lblDynamic.BorderStyle = BorderStyle.Solid;

        //        lblDynamic.Style["Top"] = "25px";

        //        lblDynamic.Style["Left"] = "100px";

        //        lblDynamic.BackColor = Color.DarkKhaki;

        //        lblDynamic.BorderColor = Color.DarkOliveGreen;



        //        form1.Controls.Add(lblDynamic);

        //    }
        //}

    }
}
