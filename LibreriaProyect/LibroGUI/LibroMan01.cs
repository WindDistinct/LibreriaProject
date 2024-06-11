using Libreria_BL;
using Libreria_GUI.LibroGUI;
using LibreriaProyect;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_GUI.Libro
{

    public partial class LibroMan01 : Form
    {

        LibroBL objLibroBL = new LibroBL();
        DataView dtv;

        public LibroMan01()
        {
            InitializeComponent();
        }

        private void LibroMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objLibroBL.ListarLibro());
            dtv.RowFilter = "Libro like '%" + strFiltro + "%'";
            dgvDatos.DataSource = dtv;
            lblRegistros.Text = dgvDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtBuscador.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                LibroMan02 formulario = new LibroMan02();
                formulario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LibroMan03 objLibroMan03 = new LibroMan03();
                String strCodigo = dgvDatos.CurrentRow.Cells[0].Value.ToString();
                objLibroMan03.Codigo = strCodigo;

                objLibroMan03.ShowDialog();

                CargarDatos(txtBuscador.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Iniciando la creación del excel");
                bkgDatos.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bkgDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataTable dtLibros = new DataTable();
                dtLibros = objLibroBL.ListarLibro();
                bkgDatos.ReportProgress(100);
                e.Result = dtLibros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bkgDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                String ruta = @"C:\ExcelTest\ListadoLibros.xlsx";
                DataTable dtLibros = (DataTable)e.Result;
                Int16 fila1 = 5;

                using (var pck = new ExcelPackage(new FileInfo(ruta)))
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];
                    foreach (DataRow drLibro in dtLibros.Rows) {
                        ws.Cells[fila1,1].Value = drLibro["lib_id"].ToString();
                        ws.Cells[fila1, 2].Value = drLibro["lib_nom"].ToString();
                        ws.Cells[fila1, 3].Value = drLibro["aut_id"].ToString();
                        ws.Cells[fila1, 4].Value = drLibro["gen_id"].ToString();
                        ws.Cells[fila1, 5].Value = drLibro["lib_edi"].ToString();
                        ws.Cells[fila1, 6].Value = drLibro["lib_fec_pub"].ToString();
                        ws.Cells[fila1, 7].Value = drLibro["lib_disp_stock"].ToString();
                        ws.Cells[fila1, 8].Value = drLibro["edi_id"].ToString();
                        ws.Cells[fila1, 9].Value = drLibro["lib_user_reg"].ToString();
                        ws.Cells[fila1, 10].Value = drLibro["lib_fec_reg"].ToString();
                        ws.Cells[fila1, 11].Value = drLibro["lib_user_mod"].ToString();
                        ws.Cells[fila1, 12].Value = drLibro["lib_fec_mod"].ToString();
                        ws.Cells[fila1, 13].Value = drLibro["lib_state"].ToString();
                        fila1 += 1;
                    }

                    ws.Column(1).Width = 10;
                    ws.Column(2).Width = 50;
                    ws.Column(3).Width = 10;
                    ws.Column(4).Width = 10;
                    ws.Column(5).Width = 90;
                    ws.Column(6).Width = 30;
                    ws.Column(7).Width = 30;
                    ws.Column(8).Width = 30;
                    ws.Column(9).Width = 30;
                    ws.Column(10).Width = 30;
                    ws.Column(11).Width = 30;
                    ws.Column(12).Width = 30;
                    ws.Column(13).Width = 30;
                    String filename = "ListadoLibros_test.xlsx";
                    FileStream fs = new FileStream(@"C:\ExcelTest\" + filename, FileMode.Create);
                    pck.SaveAs(fs);

                    pck.Dispose();
                    fs.Dispose();

                    MessageBox.Show("El archivo: " + filename + "se ha generado con éxito", "Mensaje", 
                        MessageBoxButtons.OK,MessageBoxIcon.Information );
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
