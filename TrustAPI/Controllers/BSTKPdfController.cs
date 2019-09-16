using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace TrustAPI.Controllers
{
    public class BSTKPdfController : ApiController
    {
        public HttpResponseMessage Post(string version, string environment, string filetype)
        {
            LocalReport lr = new LocalReport();
            var path = System.Web.Hosting.HostingEnvironment.MapPath("~/Report/ContractReceipt.rdlc");
            if (File.Exists(path))
            {
                lr.ReportPath = path;
            }

            //Dim List = db.sp_PrintContractReceipt(id).ToList
            //Dim count = List.Count
            //Dim rd = New ReportDataSource("DS", List)
            //lr.DataSources.Add(rd)
            var reportType = "PDF";
            String MimeType = MimeMapping.GetMimeMapping(path);
            String endcoding;
            String fileNameExtension = ".pdf";

            var deviceInfo =
            "<DeviceInfo>" +
            " <OutputFormat>" + "PDF" + "</OutputFormat>" +
            " <PageWidth>29.7cm</PageWidth>" +
            " <PageHeight>21cm</PageHeight>" +
            " <MarginTop>2.54cm</MarginTop>" +
            " <MarginLeft>2.54cm</MarginLeft>" +
            " <MarginRight>2.54cm</MarginRight>" +
            " <MarginBottom>2.54cm</MarginBottom>" +
            "</DeviceInfo>";
            string[] streams = null;
            Warning[] warnings = null;
            byte[] renderedBytes  = null;
            renderedBytes = lr.Render(
            reportType,
            deviceInfo,
            out MimeType,
            out endcoding,
            out fileNameExtension,
            out streams,
            out warnings);


            //var path = @"C:\Temp\test.exe";
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return result;
        }

    }
}
