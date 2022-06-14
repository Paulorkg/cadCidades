using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadCidades
{
    public partial class cadCidade : Form
    {
        public cadCidade()
        {
            InitializeComponent();
        }

        private void cAD_CidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_CidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadCidadesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadCidadesDataSet.CAD_Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cAD_CidadeTableAdapter.Fill(this.cadCidadesDataSet.CAD_Cidade);

        }

        private void paisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
