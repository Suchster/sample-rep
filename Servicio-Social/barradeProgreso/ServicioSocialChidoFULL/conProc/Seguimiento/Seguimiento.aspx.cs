using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.Configuration;



//[WebService(Namespace="http://sepomex.gob.mx")]
//[WebServiceBinding(ConformsTo=WsiProfiles.BasicProfile1_1)]


//public class AGRWService : System.Web.Services.WebService
//{

//    public AGRWService()
//    {
//        //Uncomment the following line if using designed components 
//        //InitializeComponent(); 

//    }
//    [WebMethod]
//    public string GuardarDatos(string USUARIO, string PASSWORD, string EVT_ITEMCODE, string EVT_CODE, int EVT_RECORDTYPE, DateTime EVT_CREATETIME, string EVT_UNITCEP, string EVT_RECEPTACLE, string EVT_HITUNITCEP, string EVT_RECIBIO)
//    {
//        SqlConnection con;
//        SqlCommand cmd;
//        string DFechaInsercion;
//        string DFechaCreacion;
//        string SConexion;
//        string SPassUser;
//        string STemporal;
//        int ICP;
//        int ICuenta;
//        byte[] BYT;
//        string[] Eventos = { "BDE", "CAR",
//                "CD", "DO", "OEC",
//                "RO" }; //Eventos validos para el agente de reparto
//        // Valida que el evento introducido en EVT_CODE sea valido con respecto al array Eventos
//        string value = EVT_CODE;
//        int pos = Array.IndexOf(Eventos, value);
//        if (pos < 0)
//        {
//            return "6 El evento es invalido: " + EVT_CODE;
//        }
//        //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
//        //SConexion="Cadena conexion";
//        DFechaInsercion = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd HH:mm:ss");
//        DFechaCreacion = Convert.ToDateTime(EVT_CREATETIME).ToString("yyyyMMdd HH:mm:ss");
//        //Verificar que los eventos ingresados sean correctos
//        SConexion = System.Web.Configuration.WebConfigurationManager.AppSettings["TyT"];
//        con = new SqlConnection(@SConexion);
//        con.Open();
//        //Una vez abierta la conexión verifica usuario y contraseña de Inserción, este mismo usuario se insertará en la tabla EVENT_AGRO
//        // Primero se encripta el password para compararlo con la Tabla
//        BYT = System.Text.Encoding.UTF8.GetBytes(PASSWORD);
//        SPassUser = Convert.ToBase64String(BYT);

//        //cmd = new SqlCommand("SELECT USU_CLAVE,USU_PASSWORD FROM USUARIOSWS_AGRO where usu_clave='" + USUARIO + "'", con);
//        STemporal = "NOLA";
//        cmd = new SqlCommand("exec pr_seguimientopiezas 'LO456499375CN'", con);

//        using (SqlDataReader reader = cmd.ExecuteReader())
//        {
//            if (reader.Read())
//            {
//                //Leer la BD y asignar el contenido a diferentes variables
//                STemporal = String.Format("{0}", reader["USU_PASSWORD"]);
//                //Console.WriteLine(String.Format("{0}",reader["USU_PASSWORD"]));
//            }
//        }
//        //con.Close();
//        //Aqui comparo lo traido en la consulta y el parametro PASSWORD asignado en SPassUser
//        if (!(STemporal == SPassUser))
//        {
//            con.Close();
//            return "2 Usuario y/o contraseña no valida de: " + USUARIO;
//        }
//        /*
//           En esta parte debe de validar que la oficina que está insertando es correcta y está dada de alta en el catálogo (debe estar activa)
//           Si no esta dada de alta devolverá un error 5 Oficina incorrecta
//           Checa tanto EVT_UNITCEP como EVT_HITUNITCEP
//        */
//        ICP = 0;
//        if (EVT_UNITCEP == EVT_HITUNITCEP)
//        {
//            ICP = 1;
//        }
//        else
//        {
//            ICP = 2;
//        }
//        cmd = new SqlCommand("select count(d_cve_oficinapostal) as Cuenta from tc_oficina_postal where d_activo='A' and d_cve_oficinapostal in ('" + EVT_UNITCEP.Substring(0, 5) + "','" + EVT_HITUNITCEP.Substring(0, 5) + "')", con);
//        ICuenta = 0;
//        using (SqlDataReader reader = cmd.ExecuteReader())
//        {
//            if (reader.Read())
//            {
//                ICuenta = reader.GetInt32(0);
//            }
//        }
//        if (ICuenta == 0)
//        {
//            con.Close();
//            return "5 Código de oficina no valido en EVT_UNITCEP= " + EVT_UNITCEP.Substring(0, 5) + " o EVT_HITUNITCEP=" + EVT_HITUNITCEP.Substring(0, 5);
//        }
//        if (ICuenta == 1)
//            if (ICP == 2)
//            {
//                con.Close();
//                //.Substring(0, 5)
//                return "5 Código de oficina no valido en EVT_UNITCEP= " + EVT_UNITCEP.Substring(0, 5) + " o EVT_HITUNITCEP=" + EVT_HITUNITCEP.Substring(0, 5);
//            }

//        //Si el usuario y contraseña es correcta pasara a este punto, si no regresa un codigo 2 (Usuario incorrecto)
//        cmd = new SqlCommand("insert into EVENT_AGRO values  ('" + EVT_ITEMCODE + "','" + EVT_CODE + "'," + EVT_RECORDTYPE + ",'" + DFechaCreacion + "','" + DFechaInsercion + "','" + EVT_UNITCEP + "'," + "101" + ",'" + EVT_RECEPTACLE + "','" + EVT_HITUNITCEP + "','" + EVT_RECIBIO + "','" + USUARIO + "',NULL)", con);
//        try
//        {
//            int temp = cmd.ExecuteNonQuery();
//            con.Close();
//            //return temp;
//            return "1 Inserción correcta";
//        }
//        catch (Exception e)
//        {
//            con.Close();
//            return "0 Error en la insercion; comando ejecutado: " + cmd.CommandText;
//        }
//    }
//    [WebMethod]
//    public string HelloWorld()
//    {
//        return "Hola a todos";
//    }
//}


public partial class Seguimiento : System.Web.UI.Page
{
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //dv.Visible = false;
            cuadroSeguimiento.Visible = false;
        }
    }
    protected void btnInicial_Click(object sender, EventArgs e)
    {
        //Pondría los comandos que va a hacer el boton
        //lblInicial.Text = "Aqui estoy cambiando el nombre de la etiqueta";
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        
        string guia;
        guia = txtGuia.Text.ToUpper();       
        lblGuiaObtenida.Text = guia;
        //dv.Visible = true;
        cuadroSeguimiento.Visible = true;
        DateTime now= DateTime.Now;
        string nowAsString;
        nowAsString = now.ToString("dd/MM/yyyy");
        lblDate.Text = nowAsString;
        int events = RandomNumber(1, 2);
        pRecibe.Visible = false;
        //int pad = 40 / events;
        //string pad_string = pad.ToString();
        //pad_string = pad_string + "%";
        //progressbar.Style.Add("padding-left", pad_string);
        /*for (int i = 0; i < events; i++)
        {
            progressbar.Controls.Add(new LiteralControl("<li class='step0'></li>"));
        }*/
        //string proc = "exec pr_seguimientopiezas '" + guia + "';";
        //lblOutput.Text = proc;
        //string SConexion;
        //SConexion = System.Web.Configuration.WebConfigurationManager.AppSettings["TyT"];
        //lblOutput.Text = SConexion;
        //List<storedDates> list = new List<storedDates>();
        string strcon = ConfigurationManager.ConnectionStrings["TyT"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("SELECT Evento, Fecha = CONVERT(varchar(20),[Fecha],103), Hora = CONVERT(varchar(20),[Fecha],108), Recibe FROM dbo.TrackAndTrace  WHERE EventCode='" + txtGuia.Text + "' Order By Fecha ASC;", con); //Comando junto con la conexion.
        SqlCommand cmd = new SqlCommand("exec pr_seguimientopiezas '" + txtGuia.Text + "'", con); //Comando junto con la conexion.

        con.Open();

        /*-----Using Grid view- Displays table with data consulted-----*/
        SqlDataAdapter da = new SqlDataAdapter(cmd); //Adaptamos los datos
        DataTable dt = new DataTable();              //Creamos una tabla de datos donde almacenaremos los resultados de query
        da.Fill(dt);                                 //Llenamos a la tabla de datos.
        gridView.DataSource = dt;                    //Ligamos el gridview con la tabla de datos. Nota: Esto era para Prueba.
        gridView.DataBind();                         //Ligamos los datos para que se muestren.
        // Aqui comenzamos con la parte de guardar los datos de la consulta
        int totalRows = dt.Rows.Count;               //Contamos el numero de filas del data Table dt.
        Object[] storedDates = new Object[totalRows];//Creamos un arreglo de objetos con el numero total de filas obtenidas.
        Object[] storedTimes = new object[totalRows];//Otra para la columna de horas.
        int totalColumns = dt.Columns.Count;         //Contamos el numero de Columnas, Esto tal vez sea innecesario.
        Object[] storedEvents = new Object[totalRows];//Creamos un arreglo con el numero de Columnas, igual innecesario. Pero Ahora guardara los eventos que son los mismos que las filas asique...Le ponemos el tamano de totalRows en lugar de totalCoumns.
        Object[] quienRecibe = new Object[1];
        
        //lblPruebas.Text = Convert.ToString(totalRows);//Para Mostrar el numero de filas.
        //lblPruebas2.Text = Convert.ToString(totalColumns);//Para mostrar el numero de columnas.
        //Object o = dt.Rows[0]["Fecha"];               //Asi se asigna el primer valor de la columna Fecha a nuestro Objeto.
        //lblFecha.Text = Convert.ToString(o);          //Mostrar.
        //o = dt.Rows[1]["Fecha"];                      //Cambiamos el valor del objeto https://www.w3schools.com/sql/func_sqlserver_convert.asp
        //lblOutput.Text = Convert.ToString(o);         //Lo mostramos.
        int liWidth = 0;
        bool lastEvent = false;
        if (Convert.ToString(dt.Rows[totalRows-1]["Evento"]) == "Entrega")
        {
            liWidth = 100 / (totalRows);
            lastEvent = true;
        }
        else
        {
            liWidth = 100 / (totalRows + 1);
            lastEvent = false;
        }
        
        for (int i = 0; i < totalRows; i++)
        {
            storedDates[i] = dt.Rows[i]["FechaRecibe"];  //Recordar que son tipo Objeto, debemos convertir a String.
            storedTimes[i] = dt.Rows[i]["HoraRecibe"];
            storedEvents[i] = dt.Rows[i]["Evento"];
            //quienRecibe[0] = dt.Rows[4]["Recibe"];
            //progressbar.Controls.Add(new LiteralControl("<li class='active step0'>" + Convert.ToString(storedDates[i]) + "<br />" + Convert.ToString(storedTimes[i]) + "<br />" + Convert.ToString(storedEvents[i]) + "</li>"));
            progressbar.Controls.Add(new LiteralControl("<li class='active step0' style='width:"+ liWidth +"%'>" + Convert.ToString(storedDates[i]) + "<br />" + Convert.ToString(storedTimes[i]) + "<br />" + Convert.ToString(storedEvents[i]) + "</li>"));
            //eventsListPar.Controls.Add(new LiteralControl("<li style='float: left; font-size: 16px;'>" + Convert.ToString(storedEvents[i]) + "</li>"));
            //eventsListImpar.Controls.Add(new LiteralControl("<li style='float: left; font-size: 16px;'>" + Convert.ToString(storedEvents[i]) + "</li>"));
            /*if (i == totalRows-1 && Convert.ToString(storedEvents[i]) != "Entrega") 
            {
                progressbar.Controls.Add(new LiteralControl("<li class='step0' style='width:"+ liWidth +"%'></li>"));
            }*/
            if (i == totalRows-1 && !lastEvent)
            {
                progressbar.Controls.Add(new LiteralControl("<li class='step0' style='width:" + liWidth + "%'></li>"));
            }
            if (dt.Rows[i]["Recibe"] != "" && quienRecibe[0] == null)
            {
                quienRecibe[0] = dt.Rows[i]["Recibe"];
                lblRecibe.Text = Convert.ToString(quienRecibe[0]);
                pRecibe.Visible = true;
            }
            /*if (dt.Rows[0]["Recibe"] == "")
            {
                lblRecibe.Text = "Aun no se";
            }
            else
            {
                lblRecibe.Text = Convert.ToString(quienRecibe[0]);
            }*/
        }
        //lblPruebas.Text = Convert.ToString(storedEvents[2]);
        //lblPruebas2.Text = Convert.ToString(storedDates[2]);
        /*for (int j = 0; j < totalRows; j++)
        {
            progressbar.Controls.Add(new LiteralControl("<li class='active step0'>" + Convert.ToString(storedDates[j]) + "</li>"));
        }*/
        /*for (int i = 0; i < events; i++)
        {
            progressbar.Controls.Add(new LiteralControl("<li class='step0'></li>"));
        }*/

        //Termina Conexion con Base de datos//
        con.Close();


            /*Using Reader*/
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        string column = reader[0].ToString();
            //        storedEvents[storedCounter] = column;
            //        string fcolumn = reader["Fecha"].ToString();
            //        storedDates[storedCounter] = fcolumn;
            //        storedCounter = storedCounter + 1;
            //        //lblOutput.Text = column;
            //        //lblFecha.Text = fcolumn;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No rows found.");
            //}
            //reader.Close();





            //Repeater.DataSource = storedEvents;
            //Repeater.DataBind();
            //lblOutput.Text = storedEvents[0];


            
        //DataTable dataTable = new DataTable();
        //SqlDataAdapter sqlDA;
        //
        //lblOutput.Text = "ya se conecto";
        //cmd.CommandText = "select Evento from dbo.TrackAndTrace where EventCode='EE123456789MX';";
        //cmd.CommandType = CommandType.Text;
        //cmd.Connection = con;
        //sqlDA = new SqlDataAdapter(cmd);
        //sqlDA.Fill(dataTable);
        //foreach (datarow dr in dataTable.Rows)
        //{

        //    lblOutput.Text = dataTable["Evento"].tostring();

        //}
        //cmd = new SqlCommand(proc, con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlDataAdapter da = new SqlDataAdapter();
        //da.SelectCommand = cmd;
        //DataSet ds = new DataSet();
        //da.Fill(ds, "dbo.TrackAndTrace");
        //this.GridView1.DataSource = ds;
        //this.GridView1.DataBind();

    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        int events = RandomNumber(1, 5);
        string numevents = events.ToString();
        txtGuia.Text = "";
        lblGuiaObtenida.Text = "";
        //dv.Visible = false;
        cuadroSeguimiento.Visible = false;
    }
    public int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}