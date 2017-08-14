﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace CMMConfiguration
{
    public partial class Overview
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Variable.VariableChanged += Variable_VariableChanged;
            
        }

        private void Variable_VariableChanged(object sender, EventArgs e)
        {
            this.Unprotect();
            this.get_Range("A1").Value2 = string.Format("{0} - {1}", "Project Overview", Variable.Project_Name);
            this.Protect();
            //throw new NotImplementedException();
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.ActivateEvent += new Microsoft.Office.Interop.Excel.DocEvents_ActivateEventHandler(this.Sheet1_ActivateEvent);
            this.Startup += new System.EventHandler(this.Sheet1_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet1_Shutdown);

        }

        #endregion

        private void Sheet1_ActivateEvent()
        {

        }
    }
}