using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ftsm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenarEstados(); 
        }

        private void llenarEstados()
        {
            DataTable estados = new DataTable();
            estados = classDataBaseManager.runSelectQuery("select idClient, state from tclient group by tclient.state order by tclient.state asc");
            comboBox_estado.DataSource = estados;
            comboBox_estado.DisplayMember = "state";
            comboBox_estado.ValueMember = "idClient";
        }

        private void comboBox_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarGerentes();
        }

        private void llenarGerentes()
        {
            if(comboBox_cliente.SelectedValue==null)            
                return; 
            
            string query = string.Format("SELECT c.idUser, c.userName " 
            + "from tclient a "
            + "inner join `manager-enterprise` b "
                + "on a.idEnterprise=b.idEnterprise "
            + "inner join tuser c "
                + "on c.idUser=b.idManager "
            + "where a.idClient='{0}' order by c.userName", comboBox_cliente.SelectedValue.ToString()); 

            DataTable gerentes = new DataTable();
            gerentes = classDataBaseManager.runSelectQuery(query);
            comboBox_gerente.DataSource = gerentes;
            comboBox_gerente.DisplayMember = "userName";
            comboBox_gerente.ValueMember = "idUser";
        }

        private void comboBox_gerente_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarOperadores(); 
        }

        private void comboBox_operador_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void llenarOperadores()
        {
            if (comboBox_gerente.SelectedValue == null)
                return;
            
            string query = string.Format("SELECT a.idUser, a.userName "
            + "from tuser a "
            + "inner join `manager-operative` b "
                + "on a.idUser=b.idOperative "            
            + "where b.idManager='{0}' order by a.userName", comboBox_gerente.SelectedValue.ToString());
            
            DataTable operadores = new DataTable();
            operadores = classDataBaseManager.runSelectQuery(query);
            comboBox_operador.DataSource = operadores;
            comboBox_operador.DisplayMember = "userName";
            comboBox_operador.ValueMember = "idUser";
        }

        private void csomboBox_estado_SelectedValueChanged(object sender, EventArgs e)
        {
            //Obtenemos el estado, hacemos una nueva búsqueda y llenamos los clients. 
            llenarClientes(); 
        }

        private void llenarClientes()
        {
            DataTable clientes = new DataTable();
            string query = string.Format("select idClient, clientName from tclient where tclient.state like '%{0}%'order by tclient.clientName asc", comboBox_estado.Text);
            clientes = classDataBaseManager.runSelectQuery(query);
            comboBox_cliente.DataSource = clientes;
            comboBox_cliente.DisplayMember = "clientName";
            comboBox_cliente.ValueMember = "idClient";
        }
    }
}
