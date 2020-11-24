using System;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using Entidades;
using System.Collections.Generic;

namespace LocalForms
{
    public partial class MainForm : Form
    {
        public delegate void RefreshDataGridDelegate();
        List<Thread> listaHilosRefresh;
        RefreshDataGridDelegate actRefresh;
        bool isRefreshing;
        public MainForm()
        {
            InitializeComponent();
            this.isRefreshing = false;
            listaHilosRefresh = new List<Thread>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += Negocio.NombreNegocio;
            this.dtaGridPreparacion.DataSource = Negocio.ListaPedidos;
            this.dtaGridEntregados.DataSource = Negocio.ListaPedidos.GetPedidosByEstado(EEstadoPedido.Entregado);
            this.PrepararDataGridViewPreparacion();
            this.PrepararDataGridViewEntregados();

            this.IniciarRefreshDataGrid();
            
        }
        public void IniciarRefreshDataGrid()
        {
            if(this.isRefreshing == false) { 
                listaHilosRefresh.Add(new Thread(() => RebindDataGridView(this.dtaGridPreparacion, EEstadoPedido.EnPreparacion)));
                listaHilosRefresh.Add(new Thread(() => RebindDataGridView(this.dtaGridEntregados, EEstadoPedido.Entregado)));
                listaHilosRefresh.ComenzarHilos();
            }
        }
        private void RebindDataGridView(DataGridView dataGrid, EEstadoPedido estado)
        {
            this.isRefreshing = true;
            while (Negocio.ListaPedidos.GetPedidosByEstado(EEstadoPedido.EnPreparacion).Count >= 0) {
                actRefresh = new RefreshDataGridDelegate(() => dataGrid.DataSource = Negocio.ListaPedidos.GetPedidosByEstado(estado));
                dataGrid.Invoke(actRefresh);
                Thread.Sleep(1000);
            }
            this.isRefreshing = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            listaHilosRefresh.DetenerHilos();
            Negocio.DetenerPedidos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPedidoForm agregarForm = new AgregarPedidoForm();
            agregarForm.enviarRefresh += IniciarRefreshDataGrid;
            agregarForm.ShowDialog();
        }


    }
}
