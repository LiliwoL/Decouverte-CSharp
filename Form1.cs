using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Découverte_C__et_Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lecture des contneus des textboxes Titre et Message
            DataGridViewRow row = (DataGridViewRow) dgvListeMessages.RowTemplate.Clone();

            // Création de nouvelles cellules dans la DataGridView dgvListeMessages
            row.CreateCells(dgvListeMessages, txtTitle.Text, txtMessage.Text);

            // Et ajout dans la DGV
            dgvListeMessages.Rows.Add(row);

        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            dgvListeMessages.Rows.Clear();
        }
    }
}
