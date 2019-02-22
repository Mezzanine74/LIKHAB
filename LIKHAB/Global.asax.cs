using System;
using System.Globalization;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace LIKHAB
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;

            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;
            DevExpress.Web.Mvc.MVCxReportDesigner.StaticInitialize();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            //TODO: Handle Exception
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            CultureInfo TempCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();

            TempCulture.DateTimeFormat.ShortDatePattern = @"dd/MM/yyyy";

            TempCulture.NumberFormat.NumberDecimalSeparator = ".";
            TempCulture.NumberFormat.NumberGroupSeparator = ",";

            Thread.CurrentThread.CurrentCulture = TempCulture;

        }

    }
}