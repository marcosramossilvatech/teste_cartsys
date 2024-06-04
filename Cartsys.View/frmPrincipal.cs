using Cartsys.Domain.Entities;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cartsys.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(Pessoa? pessoa = null)
        {
            InitializeComponent();
            pnlEsquerdo.Width = 250;

            if (pessoa != null)
                lblUsuario.Text = pessoa.Nome;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
    
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
           
        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {

            if (pnlEsquerdo.Width == 250)
            {
                pnlEsquerdo.Width = 80;
            }
            else
                pnlEsquerdo.Width = 250;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCadastroPessoa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPessoa());
        }
        private void AbrirFormEnPanel(object form)
        {
            if (this.pnlCentral.Controls.Count > 0)
                this.pnlCentral.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(fh);
            this.pnlCentral.Tag = fh;
            fh.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
