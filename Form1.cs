using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Découverte_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Création d'une nouvelle ligne de DataGridView vide
            var row = new DataGridViewRow();

            // Ajout de nouvelles cellules dans la ligne crée ci dessus
            // en utilisant le contenu des textbox Title et Message
            row.CreateCells(dgvListeMessages, txtTitle.Text, txtMessage.Text);

            // Et ajout de la ligne dans le DataGridView
            dgvListeMessages.Rows.Add(row);
        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            // Vidage de toutes les lignes du DataGridView
            dgvListeMessages.Rows.Clear();
        }
    }
}
