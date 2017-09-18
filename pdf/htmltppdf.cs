
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp;


namespace pdf
{
   

    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PdfDocument pdf = PdfGenerator.GeneratePdf("<h1>tests</h1><p>test para</p>", PageSize.A4, 20, null, null, null);
            pdf.Save(@"C\testPDF.pdf");

        }
    }
}