using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace ConsumoTC
{
    /// <summary>
/// Elaborado por Scott Martinez con ayuda de google y Ejemplos de consumo de servicio banco central de nicaragua
/// </summary>

    public partial class XfrmTipoCambio:DevExpress.XtraEditors.XtraForm
    {

        public XfrmTipoCambio( )
        {
            InitializeComponent();
        }
        public bool IsConnectedToInternet( )//mas rapido sin conexion, mas lento con conexion puesto que se hace ping a dos hosts a  los dns de google y los de one.one.one.one  
        {
            string host = "8.8.8.8";
            string host2="1.1.1.1";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 1250);
                PingReply reply2 = p.Send(host2, 1250);
                if((reply.Status == IPStatus.Success) || ((reply2.Status == IPStatus.Success)))
                    return true;
            }
            catch(Exception ex) { }
            return result;
        }
        public static bool HayConexionInternet( )
        {
            try
            {
                using(var cliente = new WebClient())
                {
                    using(cliente.OpenRead("http://google.com/generate_204"))

                        return true;
                }
            }
            catch
            {
                return false;
            }
        }//muylento sino hay conexion.
        public static DateTime Obtener_Fecha_Hora( )
        {
            using HttpClient httpClient = new HttpClient();
            try
            {
                return httpClient.GetAsync("https://www.google.com",HttpCompletionOption.ResponseHeadersRead).Result.Headers.Date.Value.DateTime;
            }
            catch
            {
                return DateTime.Now;
            }
        }
        public static bool ServicioArrriba( )
        {
            try
            {
                if(new XfrmTipoCambio().ObtenerTCDia(Obtener_Fecha_Hora().Date) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
        public double ObtenerTCDia(DateTime Fecha)
        {
            var Servicio= new ServicioTipoCambio.Tipo_Cambio_BCNSoapClient();
            try
            {
                return Servicio.RecuperaTC_Dia(Fecha.Year,Fecha.Month,Fecha.Day);
            }
            catch(Exception ex)
            {

                XtraMessageBox.Show($"Lo Sentimo ha ocurrido el siguiente error \nError:{ex.Message}");
                return 0.00;
            }
        }
        public DataTable Obtener_Meses(DateTime Desde,DateTime Hasta)
        {
            var servicio =new ServicioTipoCambio.Tipo_Cambio_BCNSoapClient();
            XmlElement xmlElement;
            XmlNodeList xmlNodos;
            DataTable dt= new DataTable();
            try
            {
                while(Desde < Hasta)
                {
                    var UltimodiaMes = DateTime.DaysInMonth(Desde.Year, Desde.Month);
                    var cantidadDias = UltimodiaMes - Desde.Day;
                    var MesFechaFinal=Desde.AddDays(cantidadDias);
                    if(!(Hasta <= MesFechaFinal))
                    {
                        xmlElement = servicio.RecuperaTC_Mes(Desde.Year,Desde.Month).ConvertirAxmlElement();
                        xmlNodos = xmlElement.GetElementsByTagName("Tc");

                        if(dt.Columns.Count <= 0)//si datatable no tiene columnas las agrega
                        {
                            foreach(XmlNode nodo in xmlNodos.Item(0).ChildNodes)    //asigna Nombres a las Columnas 
                            {
                                if(nodo.Name.ToLower() == "fecha") //Solo tomo la fecha 
                                {

                                    dt.Columns.Add(new DataColumn(nodo.Name,Type.GetType(" System.DateTime")));
                                }
                                else if(nodo.Name.ToLower() == "valor")//y el valor
                                {

                                    DataColumn columna = new DataColumn(nodo.Name,Type.GetType("System.Decimal"));
                                    dt.Columns.Add(columna);
                                }
                            }
                        }
                        for(int i = 0;i < xmlNodos.Count;i++)
                        {
                            DataRow fila = dt.NewRow();
                            for(int columna = 0;columna < dt.Columns.Count;columna++)
                            {
                                if(!DBNull.Value.Equals(xmlNodos.Item(i).ChildNodes[columna].InnerText))
                                {
                                    fila[columna] = xmlNodos.Item(i).ChildNodes[columna].InnerText;
                                }
                                else
                                {
                                    fila[columna] = null;
                                }
                            }
                            dt.Rows.Add(fila);
                        }
                    }

                    Desde = MesFechaFinal.AddDays(1);
                }
            }
            catch(Exception)
            {

                throw;
            }
            return dt;
        }
        public DataTable ObtenerTCMes(DateTime Fecha)
        {

            var servicio =new ServicioTipoCambio.Tipo_Cambio_BCNSoapClient();
            XmlElement xmlElement;
            XmlNodeList xmlNodos;
            DataTable dt= new DataTable();
            try
            {

                xmlElement = servicio.RecuperaTC_Mes(Fecha.Year,Fecha.Month).ConvertirAxmlElement();
                xmlNodos = xmlElement.GetElementsByTagName("Tc");

                if(dt.Columns.Count <= 0)//si datatable no tiene columnas las agrega
                {
                    foreach(XmlNode nodo in xmlNodos.Item(0).ChildNodes)    //asigna Nombres a las Columnas 
                    {
                        if(nodo.Name.ToLower() == "fecha") //Solo tomo la fecha 
                        {

                            dt.Columns.Add(new DataColumn(nodo.Name,Type.GetType(" System.DateTime")));
                        }
                        else if(nodo.Name.ToLower() == "valor")//y el valor
                        {

                            DataColumn columna = new DataColumn(nodo.Name,Type.GetType("System.Decimal"));
                            dt.Columns.Add(columna);
                        }
                    }
                }
                for(int i = 0;i < xmlNodos.Count;i++)
                {
                    DataRow fila = dt.NewRow();
                    for(int columna = 0;columna < dt.Columns.Count;columna++)
                    {
                        if(!DBNull.Value.Equals(xmlNodos.Item(i).ChildNodes[columna].InnerText))
                        {
                            fila[columna] = xmlNodos.Item(i).ChildNodes[columna].InnerText;
                        }
                        else
                        {
                            fila[columna] = null;
                        }
                    }
                    dt.Rows.Add(fila);
                }
                return dt;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show($"Lo sentimos ha ocurrido el siguiente error {ex.Message}");

                return null;

            }

        }
        private void radioGroup1_SelectedIndexChanged(object sender,EventArgs e)
        {
            switch(radioGroup1.SelectedIndex)
            {
                case 0:
                    dt_fecha.Enabled = true;
                    dt_fecha.Properties.Mask.EditMask = "y";
                    dt_fecha.Properties.Mask.UseMaskAsDisplayFormat = true;
                    dt_fecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                    dt_desde.Enabled = dt_hasta.Enabled = false;

                    break;
                case 1:
                    dt_fecha.Enabled = true;
                    dt_fecha.Properties.Mask.EditMask = "d";
                    dt_fecha.Properties.Mask.UseMaskAsDisplayFormat = true;
                    dt_fecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.Default;
                    dt_desde.Enabled = dt_hasta.Enabled = false;
                    break;
                case 2:
                    dt_desde.Enabled = dt_hasta.Enabled = true;
                    dt_desde.Properties.Mask.EditMask = dt_hasta.Properties.Mask.EditMask = "y";
                    dt_desde.Properties.Mask.UseMaskAsDisplayFormat = dt_hasta.Properties.Mask.UseMaskAsDisplayFormat = true;
                    dt_desde.Properties.VistaCalendarViewStyle = dt_hasta.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                    dt_fecha.Enabled = false;

                    break;

                default:
                    break;
            }

        }
        private void XfrmTipoCambio_Load(object sender,EventArgs e)
        {
            radioGroup1.SelectedIndex = 1;
            dt_desde.DateTime = DateTime.Now.AddMonths(-1);
            dt_hasta.DateTime = DateTime.Now;
            dt_fecha.DateTime = DateTime.Now;
        }
        private void btn_Consultar_Click(object sender,EventArgs e)
        {
            if(IsConnectedToInternet())
            {
                if(ServicioArrriba())
                {

                    switch(radioGroup1.SelectedIndex)
                    {
                        case 0:
                            DataView Dv= ObtenerTCMes(dt_fecha.DateTime).DefaultView;
                            Dv.Sort = "Fecha DESC";

                            grid_resultados.DataSource = Dv;

                            break;
                        case 1:
                            txt_tc_dia.EditValue = ObtenerTCDia(dt_fecha.DateTime);
                            break;
                        case 2:
                            DataView DvMeses=Obtener_Meses(dt_desde.DateTime.Date,dt_hasta.DateTime.Date.AddMonths(1)).DefaultView;
                            DvMeses.Sort = "Fecha DESC";
                            grid_resultados.DataSource = DvMeses;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    XtraMessageBox.Show($"No se puede conectar con el servicio https://servicios.bcn.gob.ni/TC_Servicio/ServicioTC.asmx, " +
                        $"\n por favor vrifique su conexión e o verifique que el servicio este arriba e intente nuevamente","Error de Conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show($"No se puede conectar a internet, por favor verifique su conexión e intente nuevamente\n Servicio Web:https://servicios.bcn.gob.ni/TC_Servicio/ServicioTC.asmx","Error de Conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        private void simpleButton1_Click(object sender,EventArgs e)
        {
            Exportar_Grid_A_Excel(grid_resultados);
        }
        public void Exportar_Grid_A_Excel(GridControl grilla)
        {
            try
            {
                string text = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos Excel (.xls, .xlsx) |*.xlsx;*.xls";
                saveFileDialog.Title = "Pr favor elija un ubicacion para guardar el archivo";
                if(saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    if(!string.IsNullOrWhiteSpace(text))
                    {
                        grilla.ExportToXlsx(text);
                    }
                }
                if(!saveFileDialog.FileName.Equals(""))
                {
                    text = saveFileDialog.FileName;
                    if(!string.IsNullOrWhiteSpace(text))
                    {
                        grilla.ExportToXlsx(text);
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show($"No se ha podido exportar a excel.\nError:{ex.Message.ToString()}","Error de exportación",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
        private void simpleButton2_Click(object sender,EventArgs e)
        {
            if(radioGroup1.SelectedIndex == 1)
            {
                Clipboard.Clear();
                Clipboard.SetText(txt_tc_dia.Text);
            }
            else
            {
                if(gv_resultados.RowCount > 0)
                {
                    gv_resultados.OptionsSelection.MultiSelect = true;
                    gv_resultados.SelectAll();
                    gv_resultados.CopyToClipboard();
                }
            }
        }
    }
    public static class extensiones
    {
        public static XmlElement ConvertirAxmlElement(this XElement elemento)
        {
            var nuevo=new XmlDocument();
            nuevo.Load(elemento.CreateReader());
            return nuevo.DocumentElement;
        }
    }
}