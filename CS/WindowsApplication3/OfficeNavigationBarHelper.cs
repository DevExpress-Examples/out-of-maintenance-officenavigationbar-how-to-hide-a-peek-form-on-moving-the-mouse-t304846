using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;

namespace DxExample {
    public class OfficeNavigationBarHelper {
        Timer _timer;
        FlyoutPanelBeakForm _currentPeekForm;
        OfficeNavigationBar _officeNavigationBar;
        public OfficeNavigationBarHelper(OfficeNavigationBar _officeNavigationBar) {
            this._officeNavigationBar = _officeNavigationBar;
        }
        Timer Timer {
            get {
                if (_timer == null)
                    SetUpTimer();
                return _timer;
            }
        }
        void SetUpTimer() {
            _timer = new Timer();
            _timer.Interval = 200;
            _timer.Tick += timer_Tick;
        }
        void timer_Tick(object sender, EventArgs e) {
            Point point = Control.MousePosition;
            if (CanHidePeekForm) {
                _officeNavigationBar.HidePeekForm();
                Timer.Stop();
            }
        }
        bool CanHidePeekForm {
            get {
                Point screenPoint = Control.MousePosition;
                Point clientPoint = _officeNavigationBar.Parent.PointToClient(Control.MousePosition);
                return !_currentPeekForm.Bounds.Contains(screenPoint) && !_officeNavigationBar.Bounds.Contains(clientPoint);
            }
        }
        public void SetPeekFormBehavior(bool autoHideOnMouseLeave) {
            _officeNavigationBar.PeekFormShown -= OnPeekFormShown;
            if (_timer != null) {
                _timer.Tick -= timer_Tick;
                _timer.Dispose();
                _timer = null;
            }
            if (autoHideOnMouseLeave)
                _officeNavigationBar.PeekFormShown += OnPeekFormShown;
        }
        void OnPeekFormShown(object sender, DevExpress.XtraBars.Navigation.NavigationPeekFormEventArgs e) {
            _currentPeekForm = e.Control.FindForm() as FlyoutPanelBeakForm;
            Timer.Stop();
            Timer.Start();
        }
    }
}
