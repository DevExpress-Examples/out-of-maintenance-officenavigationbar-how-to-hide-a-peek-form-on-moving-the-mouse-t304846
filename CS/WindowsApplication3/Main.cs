using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DxExample {
    public partial class Main : XtraForm {
        OfficeNavigationBarHelper helper;
        public Main() {
            InitializeComponent();
            officeNavigationBar1.PeekFormShowDelay = 100;
            helper = new OfficeNavigationBarHelper(officeNavigationBar1);
            helper.SetPeekFormBehavior(true);
        }
     
        private void officeNavigationBar1_QueryPeekFormContent(object sender, DevExpress.XtraBars.Navigation.QueryPeekFormContentEventArgs e) {
            if(e.Item.Text == "Item1")
                e.Control = new XtraUserControl() { BackColor = Color.Green};
            if (e.Item.Text == "Item2")
                e.Control = new XtraUserControl() { BackColor = Color.DeepSkyBlue };
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            helper.SetPeekFormBehavior(false);
            base.OnFormClosing(e);
        }
    }
}

