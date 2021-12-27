using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMPersona
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
            setControl(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int ID;
            int i;
            int maxID;            
            
            limpiar();
            
            txtModo.Text = "1";

            //Busco el máximo ID
            ID = 0;
            maxID = 0;
            
            for (i = 0; i < dg1.Rows.Count -1; i++)
            {
                ID = (String.IsNullOrEmpty(dg1.Rows[i].Cells[0].Value.ToString())?0:Convert.ToInt32(dg1.Rows[i].Cells[0].Value.ToString())); 
                if (maxID > ID)
                {
                    ID = maxID;
                }            
            }

            ID = ID + 1;
            txtID.Text = ID.ToString();
            setControl(1);
            txtApellido.Focus();            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int modo = 0;
            modo = Convert.ToInt32(txtModo.Text.Trim());
            switch (modo)
            {
                case 1:
                    alta();
                    break;
                case 2:
                    modificar();
                    break;
                default:
                    break;
            }

            limpiar();
            setControl(0);
        }

        private void alta ()
        {
            int index = dg1.Rows.Add();
           
                dg1.Rows[index].Cells[0].Value = txtID.Text;
                dg1.Rows[index].Cells[1].Value = txtApellido.Text;
                dg1.Rows[index].Cells[2].Value = txtNombre.Text;
                dg1.Rows[index].Cells[3].Value = txtDni.Text;
                dg1.Rows[index].Cells[4].Value = (cboEmp.Text == "Sí") ? "true" : "false";
               
        }

        private void modificar()
        {
            int ID = 0;
            int i = 0;
            int index = 0;

            for (i = 0; i < dg1.Rows.Count - 1; i++)
            {
                ID = (String.IsNullOrEmpty(dg1.Rows[i].Cells[0].Value.ToString()) ? 0 : Convert.ToInt32(dg1.Rows[i].Cells[0].Value.ToString()));
                if (ID == Convert.ToInt32(txtID.Text.Trim()))
                {
                    index = i;
                    dg1.Rows[index].Cells[0].Value = txtID.Text;
                    dg1.Rows[index].Cells[1].Value = txtApellido.Text;
                    dg1.Rows[index].Cells[2].Value = txtNombre.Text;
                    dg1.Rows[index].Cells[3].Value = txtDni.Text;
                    dg1.Rows[index].Cells[4].Value = (cboEmp.Text == "Sí") ? "true" : "false";
                    setControl(1);
                    return;
                }
            }
        }

        private void eliminar()
        {
            int ID = 0;
            int i = 0;
            int index = 0;

            for (i = 0; i < dg1.Rows.Count - 1; i++)
            {
                ID = (String.IsNullOrEmpty(dg1.Rows[i].Cells[0].Value.ToString()) ? 0 : Convert.ToInt32(dg1.Rows[i].Cells[0].Value.ToString()));
                if (ID == Convert.ToInt32(txtID.Text.Trim()))
                {
                    index = i;
                    dg1.Rows.Remove(dg1.Rows[index]);
                    limpiar();
                    setControl(1);
                    return;
                }
            }
            
            setControl(3);
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            txtModo.Text = "2";
            setControl(2);
        }

        private void setControl(int modo)
        {
            switch (modo)
            {
                // modo inicio
                case 0: 
                    txtID.Enabled = true;
                    btnAdd.Enabled = true;
                    btnModi.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGrabar.Enabled = false;
                    txtApellido.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    txtDni.ReadOnly = true;
                    cboEmp.Enabled = false;
                    btnBuscar.Enabled = true; 
                    break;

                // modo alta
                case 1:
                    txtID.Enabled = false;
                    panel1.Enabled = true;
                    btnAdd.Enabled = false;
                    btnModi.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGrabar.Enabled = false;
                    txtApellido.ReadOnly = false;
                    txtNombre.ReadOnly = false;
                    txtDni.ReadOnly = false;
                    cboEmp.Enabled = true;
                    btnGrabar.Enabled = true;
                    break;
                // modo modificar    
                case 2:
                    panel1.Enabled = true;
                    btnAdd.Enabled = false;
                    btnModi.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnGrabar.Enabled = true;
                    txtApellido.ReadOnly = false;
                    txtNombre.ReadOnly = false;
                    txtDni.ReadOnly = false;
                    cboEmp.Enabled = true;
                    btnGrabar.Enabled = true;
                    break;
                // modo eliminar
                case 3:
                    panel1.Enabled = true;
                    btnAdd.Enabled = true;
                    btnModi.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnGrabar.Enabled = true;
                    txtApellido.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    txtDni.ReadOnly = true;
                    cboEmp.Enabled = false;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int i = 0;
            int index = 0;

            MessageBoxButtons btnOK = MessageBoxButtons.OK;
            MessageBoxIcon iconInf = MessageBoxIcon.Information;

            for (i = 0; i < dg1.Rows.Count - 1; i++)
            {
                ID = (String.IsNullOrEmpty(dg1.Rows[i].Cells[0].Value.ToString()) ? 0 : Convert.ToInt32(dg1.Rows[i].Cells[0].Value.ToString()));
                if (ID == Convert.ToInt32(txtID.Text.Trim())  )
                {
                    index = i; 
                    buscar(index);
                    btnAdd.Enabled = false;
                    btnModi.Enabled = true;
                    btnEliminar.Enabled = true;
                    return;
                }                
            }
            MessageBox.Show("No se encontraron coincidencias","Atención", btnOK, iconInf);

            limpiar();
        }

        private void buscar(int index)
        {       
            txtApellido.Text  = dg1.Rows[index].Cells[1].Value.ToString();
            txtNombre.Text = dg1.Rows[index].Cells[2].Value.ToString();
            txtDni.Text = dg1.Rows[index].Cells[3].Value.ToString();
            cboEmp.SelectedIndex = (dg1.Rows[index].Cells[4].Value.ToString()=="true"?0:1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon iconQuest = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show("Va a eliminar un registro, desea continuar?","Atención",buttons, iconQuest); 
            if (result == DialogResult.OK)
            {
                eliminar();
              
            }
            setControl(3);
            limpiar();

        }
             

        private void limpiar() 
        {
            txtID.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            cboEmp.Text = cboEmp.Items[0].ToString();
            txtID.Enabled = true;

        }

    }
        
}
