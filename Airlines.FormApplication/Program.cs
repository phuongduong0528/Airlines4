using Airlines.FormApplication.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines.FormApplication
{
    public class Program
    {
        private SurveyResultController _surveyResultController;

        public SurveyResultController SurveyResultController => _surveyResultController ??
            (_surveyResultController = new SurveyResultController());

        public static Program Instance;

        public Program()
        {
            _surveyResultController = new SurveyResultController();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Instance = new Program();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Summary());
        }
    }
}
