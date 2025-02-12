using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Vetoquinol.Sales.Importer
{
    public partial class AppForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

    #region Members

        /// <summary>
        /// Resorce manager for local string resources
        /// </summary>
        protected ResourceManager? myResourceManager;
        private string myLogPath = string.Empty;

    #endregion

    #region Constructor

        public AppForm()
        {
            InitializeComponent();
        }

    #endregion

    #region Form event handlers

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            myLogPath = string.Format(@"{0}\stamp.dat", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        #endregion

        #region Helper methods


        #endregion

    }
}
