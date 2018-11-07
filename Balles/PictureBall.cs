using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balles
{

    class PictureBall : PictureBox
    {
        Timer tm = new Timer();
        

        public Int32 VitesseX { get; set; }
        public Int32 VitesseY { get; set; }

        public PictureBall(int VitesseX, int VitesseY)
        {
          
            VitesseX = this.VitesseX;
            VitesseY = this.VitesseY;
            tm.Interval = 50;
            tm.Tick += bouger;
          
        }

        public PictureBall()
        {
            tm.Interval = 50;
            tm.Tick += bouger;
          
        }
    
        public void animer()
        {
            tm.Enabled = true;
        }
        public void bouger(Object sender, EventArgs e)
        {
            if (this.Left < 0) { VitesseX = -VitesseX; }
            if (this.Left > Form.ActiveForm.Width - this.Width - 15)
            { VitesseX = -VitesseX; }
            if (this.Top < 0) { VitesseY = -VitesseY; }
            if (this.Top >Form.ActiveForm.Height - this.Height - 38)
            { VitesseY = -VitesseY; }
            this.Left = this.Left + VitesseX;
            this.Top = this.Top + VitesseY;
        }
    }
    

   

}
