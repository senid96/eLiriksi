using liriksi.WinUI.Helper;
using liriksi.WinUI.PerformerForms;
using liriksi.WinUI.RatingForms;
using liriksi.WinUI.SongForms;
using liriksi.WinUI.SongForms.AlbumForms;
using liriksi.WinUI.SongForms.SongUtilForms;
using liriksi.WinUI.User;
using liriksi.WinUI.UserForms;
using liriksi.WinUI.UtilForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liriksi.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
        public frmIndex()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

    

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails();
            frm.Show();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms(); //close all form first
            frmUser frm = new frmUser();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void SearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmSong frm = new frmSong();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;           
            frm.Show();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void newSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAddSong frm = new frmAddSong();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    
        private void addNewAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAddAlbum frm = new frmAddAlbum();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAddUser frm = new frmAddUser();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAlbum frm = new frmAlbum();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addPerformerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAddPerformer frm = new frmAddPerformer();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmPerformer frm = new frmPerformer();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmAlbumRating frm = new frmAlbumRating();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void songRatingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmSongRating frm = new frmSongRating();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ratingsByUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperMethods.CloseAllForms();
            frmUsersRating frm = new frmUsersRating();
            frm.MdiParent = Application.OpenForms["frmIndex"];
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
