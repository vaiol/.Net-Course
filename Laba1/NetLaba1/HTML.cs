using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLaba1
{
    static class HTML
    {
        private static string _path;

        public static string Path
        {
            set { _path = value; }
            get { return _path; }
        }

        private static string _html;

        public static string newHtml
        {
            get { return _html; }
        }

        public static void GenerateNewHtml()
        {
            MainForm m = Program.Form;
            string result = "";
            result += html1;
            result += m.ProjectName;
            result += html2;
            result += m.CustomerFirst;
            result += html3;
            result += m.CustomerLast;
            result += html4;
            result += m.CustomerJob;
            result += html5;
            result += m.PerformerFirst;
            result += html6;
            result += m.PerformerLast;
            result += html7;
            result += m.PerformerJob;
            result += html8;
            result += m.VersionNumeric;
            result += html9;
            result += m.VersionDescription;
            result += html10;
            result += Program.Spec.getTerms();
            result += html11;
            result += m.InfoDescription;
            result += html12;
            result += m.TeamDescription;
            result += html13;
            result += Program.Spec.getTasks();
            result += html14;
            _html = result;
        }

        private static string html1 = "<!DOCTYPE html>\n" +
                "<html>\n" +
                "<head>\n" +
                "\t<meta charset=\"UTF-8\">\n" +
                "\t<title>Specifications</title>\n" +
                "\t<style>\n" +
                "\t\tbody {\n" +
                "\t\t\tfont-family: verdana;\n" +
                "\t\t\tfont-size: 20px;\n" +
                "\t\t\tbackground: #F0F0F0;\n" +
                "\t\t\tmargin: 0;\n" +
                "\t\t\tpadding: 0;\n" +
                "\t\t}\n" +
                "\n" +
                "\t\t#pageName {\n" +
                "\t\t\theight: 50px;\n" +
                "\t\t\twidth: 100%;\n" +
                "\t\t\tbackground: #242424;\n" +
                "\t\t\tcolor: #7B9DC4;\n" +
                "\t\t\ttext-align: center;\n" +
                "\t\t\tline-height: 50px;\n" +
                "\t\t\tfont-size: 35px;\n" +
                "\t\t}\n" +
                "\n" +
                "\t\t#projectName {\n" +
                "\t\t\theight: 40px;\n" +
                "\t\t\twidth: 100%;\n" +
                "\t\t\tbackground: #333333;\n" +
                "\t\t\tcolor: #7B9DC4;\n" +
                "\t\t\ttext-align: center;\n" +
                "\t\t\tline-height: 40px;\n" +
                "\t\t}\n" +
                "\n" +
                "\t\t#projectName h3 {\n" +
                "\t\t\tdisplay: inline;\n" +
                "\t\t\tcolor: #ED762E;\n" +
                "\t\t\tfont-size: 1.1em;\n" +
                "\t\t}\n" +
                "\n" +
                "\t\t#mainBlock {\n" +
                "\t\t\twidth: 700px;\n" +
                "\t\t\tmin-height: 680px;\n" +
                "\t\t\tbackground: #F0F0F0;\n" +
                "\t\t\tmargin: 0 auto;\n" +
                "\t\t}\n" +
                "\n" +
                "\n" +
                "\t\t.head {\n" +
                "\t\t\tbackground: #B9D1EA;\n" +
                "\t\t\tdisplay: block;\n" +
                "\t\t\twidth: inherit;\n" +
                "\t\t\theight: 35px;\n" +
                "\t\t\tline-height: 35px;\n" +
                "\t\t\tfont-weight: 700;\n" +
                "\t\t\tmargin-bottom: 3px;\n" +
                "\t\t}\n" +
                "\n" +
                "\t\ttable th {\n" +
                "\t\t\tbackground: #F19863; \n" +
                "\t\t}\n" +
                "\n" +
                "\t\ttable td {\n" +
                "\t\t\tbackground: #8B8B8B;\n" +
                "\t\t}\n" +
                "\n" +
                "\n" +
                "\t\t#footer {\n" +
                "\t\t\theight: 50px;\n" +
                "\t\t\twidth: 100%;\n" +
                "\t\t\tbackground: #242424;\n" +
                "\t\t\tcolor: #7B9DC4;\n" +
                "\t\t\ttext-align: center;\n" +
                "\t\t\tline-height: 50px;\n" +
                "\t\t}\n" +
                "\t</style>\n" +
                "</head>\n" +
                "<body>\n" +
                "\t<!-- Code: 3005a -->\n" +
                "\t<div id=\"pageName\">Technical Specification</div>\n" +
                "\t<div id=\"projectName\">For the project: \n" +
                "\t\t<h3>";
        //ProjectName
        private static string html2 = "</h3>\n" +
                "\t</div>\n" +
                "\t<div id=\"mainBlock\">\n" +
                "\t\t<div class=\"head\">Customer</div>\n" +
                "\t\t<b>First Name:</b> ";
        //CustomerFirstName
        private static string html3 = "<br>\n" +
                "\t\t<b>Last Name:</b> ";
        //CustomerLastName
        private static string html4 = "<br>\n" +
                "\t\t<b>Job Tittle:</b> ";
        //CustomerJob
        private static string html5 = "<br>\n" +
                "\t\t<div class=\"head\">Performer</div>\n" +
                "\t\t<b>First Name:</b> ";
        //PerformerFirstName
        private static string html6 = "<br>\n" +
                "\t\t<b>Last Name:</b> ";
        //PerformerLastName
        private static string html7 = "<br>\n" +
                "\t\t<b>Job Tittle:</b> ";
        //PerformerJob
        private static string html8 = "<br>\n" +
                "\t\t<div class=\"head\">Document version</div>\n" +
                "\t\t<b>Version:</b> ";
        //DocumentVersion
        private static string html9 = "<br>";
        //DocumentDescription
        private static string html10 = "<div class=\"head\">Terms and Definitions</div>\n" +
                "\t\t<table>\n" +
                "\t\t\t<tr>\n" +
                "\t\t\t\t<th>Terms</th>\n" +
                "\t\t\t\t<th>Definitions</th>\n" +
                "\t\t\t</tr>";
        //Terms
        private static string html11 = "</table>\n" +
                "\n" +
                "\t\t<div class=\"head\">General Information</div>\n" +
                "\t\t<div>";
        //Info
        private static string html12 = "</div>\n" +
                "\t\t<div class=\"head\">About Team</div>\n" +
                "\t\t<div>";
        //Team
        private static string html13 = "</div>\n" +
                "\t\t<div class=\"head\">Timeline</div>\n" +
                "\t\t<table>\n" +
                "\t\t\t<tr>\n" +
                "\t\t\t\t<th>Date</th>\n" +
                "\t\t\t\t<th>Task</th>\n" +
                "\t\t\t</tr>";
        //Tasks
        private static string html14 = "</table>\n" +
                                       "\t</div>\n" +
                                       "\t<div id=\"footer\">\n" +
                                       "\t\t2015 @Stepanov Alexander\n" +
                                       "\t</div>\n" +
                                       "</body>\n" +
                                       "</html>";


    }

    
}
