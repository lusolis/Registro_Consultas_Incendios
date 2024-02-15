using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolisLuciaTPLab3
{
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }
        CProvincias provi = new CProvincias();
        CIncendios incendios = new CIncendios();
        CExcepciones erroes = new CExcepciones();
        private void consultar_Load(object sender, EventArgs e)
        {

            dtpAnioConsulta.Format = DateTimePickerFormat.Custom;
            dtpAnioConsulta.CustomFormat = "yyyy"; //para ver solo el año
            dtpAnioConsulta.MinDate = DateTime.Parse("1993-01-01");
            dtpAnioConsulta.MaxDate = DateTime.Parse("2022-01-01");
            dtpAnioConsulta.Value = dtpAnioConsulta.MinDate;//para visualizar el menor año al abrir el form

            cmbProvinciaConsulta.DisplayMember = "provincia";
            cmbProvinciaConsulta.ValueMember = "numero";
            cmbProvinciaConsulta.DataSource = provi.GetProvincias();

            cmbGrafico.Items.Add("Gráfico de Columnas");
            cmbGrafico.Items.Add("Gráfico de Líneas");
            cmbGrafico.SelectedIndex = 0;

            DiseñoDtv(ref dgvConsulta);
        }
        private static void DiseñoDtv(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.FromArgb(64, 64, 64);
            Listado.EnableHeadersVisualStyles = false;
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.RowHeadersVisible = false;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(64, 64, 64);
            cabecera.ForeColor = Color.LightSeaGreen;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;

            Listado.CellMouseEnter += (sender, e) =>
            {
                DataGridView dgv = sender as DataGridView; // Convertir sender a DataGridView
                if (dgv != null && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Limpiar selección de filas
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        row.Selected = false;
                    }
                    // Seleccionar la fila bajo el mouse
                    dgv.Rows[e.RowIndex].Selected = true;
                }
            };
            
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int anio = dtpAnioConsulta.Value.Year;
            string prov = cmbProvinciaConsulta.Text;
            try
            {
                if (optAnio.Checked == true)
                {
                    incendios.GraficarPorAnio(anio, dgvConsulta, chtConsulta, cmbGrafico);
                }
                else
                {
                    incendios.GraficarProv(prov, dgvConsulta, chtConsulta, cmbGrafico);
                }
            }
            catch (Exception ex)
            {

                erroes.RegistrarError(ex); 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
