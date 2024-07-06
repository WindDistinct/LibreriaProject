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
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objLibroBL.ListarLibro());
            dtv.RowFilter = "Libro like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
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
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
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
                string relativePath = @"Documentos\ListadoLibros.xlsx";
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = Path.Combine(basePath, relativePath);

                // Debug: Check paths
                MessageBox.Show($"Base Path: {basePath}\nRelative Path: {relativePath}\nFull Path: {ruta}", "Debug Info");

                if (!File.Exists(ruta))
                {
                    MessageBox.Show($"File not found: {ruta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dtLibros = (DataTable)e.Result;
                Int16 fila1 = 5;

                using (var pck = new ExcelPackage(new FileInfo(ruta)))
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];
                    if (ws == null)
                    {
                        MessageBox.Show("Worksheet 'Hoja1' not found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (DataRow drLibro in dtLibros.Rows)
                    {
                        ws.Cells[fila1, 1].Value = drLibro["lib_id"].ToString();
                        ws.Cells[fila1, 2].Value = drLibro["Libro"].ToString();
                        ws.Cells[fila1, 3].Value = drLibro["Autor"].ToString();
                        ws.Cells[fila1, 4].Value = drLibro["Genero"].ToString();
                        ws.Cells[fila1, 5].Value = drLibro["Edicion"].ToString();
                        ws.Cells[fila1, 6].Value = drLibro["Ano_de_publicacion"].ToString();
                        ws.Cells[fila1, 7].Value = drLibro["Stock"].ToString();
                        ws.Cells[fila1, 8].Value = drLibro["Editorial"].ToString();
                        ws.Cells[fila1, 9].Value = drLibro["Creado_por"].ToString();
                        ws.Cells[fila1, 10].Value = drLibro["Creado_el"].ToString();
                        ws.Cells[fila1, 11].Value = drLibro["Modificado_por"].ToString();
                        ws.Cells[fila1, 12].Value = drLibro["Modificado_el"].ToString();
                        ws.Cells[fila1, 13].Value = drLibro["Estado"].ToString();
                        fila1 += 1;
                    }

                    ws.Column(1).Width = 5;
                    ws.Column(2).Width = 30;
                    ws.Column(3).Width = 30;
                    ws.Column(4).Width = 15;
                    ws.Column(5).Width = 20;
                    ws.Column(6).Width = 10;
                    ws.Column(7).Width = 5;
                    ws.Column(8).Width = 20;
                    ws.Column(9).Width = 20;
                    ws.Column(10).Width = 10;
                    ws.Column(11).Width = 20;
                    ws.Column(12).Width = 10;
                    ws.Column(13).Width = 5;

                    String filename = "ListadoLibros_" + DateTime.Now.Date.ToString("dd-MM-yy") + ".xlsx";
                    FileStream fs = new FileStream(@"C:\ExcelTest\" + filename, FileMode.Create);
                    pck.SaveAs(fs);

                    pck.Dispose();
                    fs.Dispose();

                    MessageBox.Show("El archivo: " + filename + " se ha generado con éxito", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
