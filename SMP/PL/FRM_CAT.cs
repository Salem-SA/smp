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
    public partial class FRM_CAT : Form
    {
        // DB_SMPEntities db = new DB_SMPEntities();
        //  TB_CAT tb_cat = TB_CAT();
        int id;
        public FRM_CAT()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "إضافة";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // db = new DB_SMPEntities();
            // gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                // var rs ==
                MessageBox.Show("عملية حذف", "هل تريد حذف هذه الرسالة", MessageBoxButtons.YesNo);
                //  if (rs == DialogResult.Yes)
                {
                    // tb_cat = db.TB_CAT.where (x=>x.ID==id).FinstOrDeFault();
                    //db.Entry (tb_cat).State = EntiyState.Deleted;
                    //db.SaveChanges();
                    //Update_data();

                }
            }
            catch
            {

            }
           
            }
        }
    }

