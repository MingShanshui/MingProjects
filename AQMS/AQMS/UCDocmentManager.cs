using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraBars.Docking2010.Views;

namespace AQMS
{
    public partial class UCDocmentManager : DevExpress.XtraEditors.XtraUserControl
    {
        public UCDocmentManager()
        {
            InitializeComponent();
            this.widgetView1.QueryControl += widgetView1_QueryControl;
        }
        
        public void AddStackGroups(List<StackGroup> stackGroups)
        {
            this.widgetView1.StackGroups.AddRange(stackGroups);
        }

        public void AddStackGroup(StackGroup stackgroup)
        {
            this.widgetView1.StackGroups.Add(stackgroup);
        }

        public void AddDocuments(List<Document> documents)
        {
            this.widgetView1.Documents.AddRange(documents);
        }

        public void AddDocument(Document document)
        {
            this.widgetView1.Documents.Add(document);
        }

        private void widgetView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document.Caption == "二氧化硫")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "氮氧化物")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "一氧化碳")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "臭氧")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "可吸入颗粒物")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "细颗粒物")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "气象五参数")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "能见度")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "总悬浮颗粒物")
            {
                AQMSUI.DocmentSO2 docSO2 = new AQMSUI.DocmentSO2();
                e.Control = docSO2;
            }
            else if (e.Document.Caption == "系统状态")
            {
                AQMSUI.HomeInfo docHomeInfo = new AQMSUI.HomeInfo();
                e.Control = docHomeInfo;
            }
            else if (e.Document.Caption == "主页曲线")
            {
                AQMSUI.HomeChart docHomeChart = new AQMSUI.HomeChart();
                e.Control = docHomeChart;
            }
        }
    }
}
