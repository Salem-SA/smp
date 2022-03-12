using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.EPL;
namespace SMP.PL
{
    public partial class FRM_CAT_ADD : Form
    {
        // init
        //(لازم هنا) 
        // DB_SMPEntities db = new DB_SMPEntities();
        //TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        PL.FRM_CAT fRM_CAT = new FRM_CAT();

       

        public int id;

        public FRM_CAT_ADD()
        {
            InitializeComponent();
        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {

        }
        // add or edit 
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            // Check if add or edit
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
            }
            else
            {
                // Check if add or edit
                if (id == 0)
                {
                    // Add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //(لازم هنا) tb_cat.CAT_Name = edt_name.Text;
                    // tb_CAT_Covet = methods.convert_byte();
                    // db.TB_CAT.Add(tb_cat);
                    // db.SaveChanges();
                    toast.txt_caption.Text = "تم إضافة صنف جديد";
                    toast.Show();
                    // db = new DB_SMPEntities();
                    //fRM_CAT.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();

                }else
                {
                    // Edit
                }
            }

        }
    }
}
