using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace LocalForms
{
    public partial class AgregarPedidoForm : Form
    {
        public delegate void EnviarRefreshDelegate();

        public event EnviarRefreshDelegate enviarRefresh;
        public AgregarPedidoForm()
        {
            InitializeComponent();
            this.cmboBoxOpcionPedido.DataSource = Enum.GetValues(typeof(EOpciones));
        }
        private void AgregarPedidoForm_Load(object sender, EventArgs e)
        {
            this.btnAgregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            this.lblNumero.Text += Pedido.IdPedidoClase;
        }
        private void btnAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.btnAgregar.Enabled) { 
            this.btnAgregar.BackColor = Color.DodgerBlue;
            this.btnAgregar.ForeColor = Color.White;
            }
        }
        private void btnAgregar_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.btnAgregar.Enabled)
            {
                this.btnAgregar.ForeColor = Color.DodgerBlue;
                this.btnAgregar.BackColor = Color.White;
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.cmboBoxOpcionPedido.SelectedItem == null)
                    throw new InvalidOpcionException();

                if (this.chckBoxDelivery.Checked && this.txtBoxInfoDelivery.Text != string.Empty)
                {
                    Negocio.AgregarPedido(new Pedido((EOpciones)this.cmboBoxOpcionPedido.SelectedItem, this.txtBoxInfoDelivery.Text));
                }
                else
                {
                    Negocio.AgregarPedido(new Pedido((EOpciones)this.cmboBoxOpcionPedido.SelectedItem));
                }
            }
            catch(InvalidOpcionException opcionExcp){
                MessageBox.Show(opcionExcp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception excp){
                MessageBox.Show(excp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.lblNumero.Text = $"El siguiente pedido sera el N°{Pedido.IdPedidoClase}";
            this.txtBoxInfoDelivery.Text = string.Empty;
            this.txtBoxInfoDelivery.Enabled = false;
            this.chckBoxDelivery.Checked = false;
            enviarRefresh?.Invoke();
        }
        private void cmboBoxOpcionPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblDemora.Text = $"Demora del Pedido - { TimeSpan.FromSeconds((int)this.cmboBoxOpcionPedido.SelectedItem).ToString(@"mm\:ss") } minutos.";
        }

        private void chckBoxDelivery_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chckBoxDelivery.Checked) 
                this.txtBoxInfoDelivery.Enabled = true;
            else {
                this.txtBoxInfoDelivery.Text = string.Empty;
                this.txtBoxInfoDelivery.Enabled = false;
            }

        }
    }
}
