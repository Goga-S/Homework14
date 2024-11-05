using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class FacadeReport
    {
        HTML html = new HTML();
        PDF pdf = new PDF();

        public void getPDFRep()
        {
            pdf.getReport();
        }

        public void getHTMLRep()
        {
            html.getReport();
        }
    }
}
