<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Seguimiento.aspx.cs" Inherits="Seguimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>SISEMEXPOST|SEPOMEX</title>
    <!-- CSS -->
    <link href="sepomex.ico" rel="shortcut icon" />
    <link href="Estilos/bootstrap.min.css" rel="stylesheet" /> 
    <link href="Estilos/all.css" rel="stylesheet" />
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    
    <link rel="stylesheet" href="Estilos/style.css"/>
    <link href="Estilos/main.css" rel="stylesheet" />
    <!-- Respond.js soporte de media queries para Internet Explorer 8 -->
    <!-- ie8.js EventTarget para cada nodo en Internet Explorer 8 -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/ie8/0.2.2/ie8.js"></script>
    <![endif]-->
    <script src="./js/jquery.min.js"></script>
    <script src="./js/bootstrap.min.js"></script>
<%--    <script type="text/javascript" src="js/jquery.js"></script>--%>
    <script type="text/javascript">
        $(document).ready(function () {
            // Muestra y oculta los menús
            $('ul li:has(ul)').hover(
            function (e) {
                $(this).find('ul').css({ display: "block" });
            },
                function (e) {
                    $(this).find('ul').css({ display: "none" });
                }
   );
        });
    </script>
</head>

<body>
    <header>
		<nav class="navbar navbar-inverse navbar-fixed-top navbar">
            <div class="container">
                <div class="navbar-header">
                    <button class="navbar-toggle collapsed" type="button" data-toggle="collapse" data-target="#navbarMainCollapse">
                        <span class="sr-only">Interruptor de Navegación</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a title="Ir a la página inicial" class="navbar-brand " style="padding: 1px 3px 3px;" href="/">
                   <div style="margin-top: 0px; margin-left: -2px;" class="large">Servicio Postal Mexicano
                       <img class="logo_footer" style="margin-top: 8px; margin-left: 107px; max-width: 15%;" alt="logo SEPOMEX" src="/imagenes/LogoCorreos.jpg" />
                   </div>
                   
                   </a>
                </div>
            </div>
        </nav>
    </header>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-8">
                    <div class="vertical-buffer">
                        <h3>
                            <asp:Label ID="lblSistema" runat="server" Text="Seguimiento"></asp:Label></h3>
                    </div>
                </div>

                
          
            </div>
            <div class="row d-inline-block">
                <div class="col-md-12">
                    <div id="validaciones">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El número de guía no puede estar en blanco" ControlToValidate="txtGuia" ForeColor="red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Introduce un número de Guía Válido" ControlToValidate="txtGuia" ValidationExpression="([a-zA-Z]{2})\d{9}([a-zA-Z]{2})"></asp:RegularExpressionValidator>
                        <br />
                    </div>
                </div>
            </div>
            <div class="row">
                    <div class="col-sm-12">
                        <asp:Label ID="lblGuia" runat="server" Text="Ingrese el número de guía:"></asp:Label>
                        <asp:TextBox ID="txtGuia" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        <asp:Button ID="btnLimpiar" class="btn btn-default" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
                    </div>
             </div>
             <br />


            <asp:Panel ID="cuadroSeguimiento" runat="server">
                <%--<div style="font-family: 'Montserrat';">--%>
                    <!--<div class="container px-1 px-md-4 py-5 mx-auto">-->
                    <div id="dv" class="card" runat="server">
                        <div class="row d-flex justify-content-between px-3 top">
                            <div class="d-flex flex-column">
                                <h5>ORDEN <span class="text-primary font-weight-bold">#<asp:Label ID="lblGuiaObtenida" runat="server" Text=""></asp:Label></span></h5>
                                <p id="pRecibe" runat="server">Recibe: <span><asp:Label ID="lblRecibe" runat="server" Text=""></asp:Label></span></p>
                            </div>
                            <div class="d-flex flex-column text-sm-right">
                                <p class="mb-0" style="margin-top:12.5px; margin-bottom:12.5px;">Fecha De Consulta: <span>
                                    <asp:Label ID="lblDate" runat="server" Text=""></asp:Label></span></p>
                                <p>Correos De M&eacute;xico
                                    <img src="Imagenes/LogoCorreos.jpg" style="max-width: 8%;" /></p>
                            </div>
                        </div>

                        <!-- Add class 'active' to progress -->
                        <div class="row d-flex justify-content-center">
                            <div class="col-md-12 mt-4 mb-1" style="text-align: center">
                                <%--<div class="container mt-6" style="text-align:center">--%>
                                <%--<ul id="eventsListPar" class="text-center" runat="server" style="list-style-type: none"></ul>--%>
                                <ul id="progressbar" class="text-center" runat="server">
                                    <%--<li class="active step0">Hora<br />Fecha</li>--%>
                                    <!--<li class="step0"></li>-->
                                </ul>
                                <%--<ul id="eventsListImpar" class="text-center" runat="server" style="list-style-type: none"></ul>--%>
                                <%--</div>--%>
                            </div>
                        </div>
                        <!-- Fin de barra de progreso -->


                        <!-- Tabla -->
                        <div class="row d-flex justify-content-center">  
                            <div class="col-md-12 mb-1">
                                <div style="width:400px; margin-left:auto; margin-right:auto;">
                                    <asp:GridView ID="gridView" runat="server" HeaderStyle-BackColor="#B9D577" AutoGenerateColumns="False" Font-Size="Small">
                                        <Columns>
                                            <asp:BoundField DataField="Evento" HeaderText="Evento" SortExpression="Evento" ItemStyle-Width="200" />
                                            <asp:BoundField DataField="FechaRecibe" HeaderText="Fecha" ReadOnly="True" SortExpression="Fecha" ItemStyle-Width="100" ItemStyle-HorizontalAlign="Center" />
                                            <asp:BoundField DataField="HoraRecibe" HeaderText="Hora" ReadOnly="True" SortExpression="Hora" ItemStyle-Width="100" ItemStyle-HorizontalAlign="Center" />
 <%--                                           <asp:BoundField DataField="Recibe" HeaderText="Recibe" SortExpression="Recibe" />--%>
                                        </Columns>
                                        <HeaderStyle BackColor="#AAD7B0" />
                                    </asp:GridView>
                                    <br />
                                </div>
                            </div>          
                        </div>
                        <!-- Fin de Tabla -->


                    </div>
                    <!-- div de card -->   
                <%--</div>--%>
            </asp:Panel>
        </div>
        <!-- Fin del Container-->
        <%--<asp:Label ID="lblOutput" runat="server" Text="This is lblOutput"></asp:Label>--%>
        <br />
        <%--<asp:Label ID="lblFecha" runat="server" Text="This is lblFecha"></asp:Label>--%>
        <%--<asp:Repeater ID="Repeater" runat="server"><ItemTemplate><asp:Label ID="lbl" runat="server" /></ItemTemplate></asp:Repeater>--%>
        <%--<br />--%>
        <%--<asp:Label ID="lblPruebas" runat="server" Text="This is lblPruebas"></asp:Label>--%>
        <%--<br />--%>
        <%--<asp:Label ID="lblPruebas2" runat="server" Text="This is lblPruebas2"></asp:Label>--%>
    </form>




    <%--Una parte que el footer--%>
    
            <br />
    <footer class="main-footer" style="width:100%; bottom:0; position:relative;">
        <div class="list-info">
	        <div class="container">
		        <div class="row">
			        <div class="col-sm-4">
                        <img class="logo_footer" style="margin-top: 12px; margin-left: -27px; max-width: 70%;" alt="logo gobierno de méxico" src="https://framework-gb.cdn.gob.mx/landing/img/logoheader.svg" />
                        
				    </div>
			        <div class="col-sm-4 col-sm-offset-4 small">@Servicio Postal Mexicano 2020 (DR) DCIT/SADS
			        </div>
		        </div>
	        </div>
        </div>
        <img max-width: 70%;" alt="logo gobierno de méxico" src="imagenes/pleca plumaje_con fondo.svg" />
    </footer>
</body>

</html>