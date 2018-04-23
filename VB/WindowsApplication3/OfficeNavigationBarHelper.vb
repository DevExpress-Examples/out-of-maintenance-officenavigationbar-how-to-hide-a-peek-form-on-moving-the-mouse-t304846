Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation

Namespace DxExample
    Public Class OfficeNavigationBarHelper
        Private _timer As Timer
        Private _currentPeekForm As FlyoutPanelBeakForm
        Private _officeNavigationBar As OfficeNavigationBar
        Public Sub New(ByVal _officeNavigationBar As OfficeNavigationBar)
            Me._officeNavigationBar = _officeNavigationBar
        End Sub
        Private ReadOnly Property Timer() As Timer
            Get
                If _timer Is Nothing Then
                    SetUpTimer()
                End If
                Return _timer
            End Get
        End Property
        Private Sub SetUpTimer()
            _timer = New Timer()
            _timer.Interval = 200
            AddHandler _timer.Tick, AddressOf timer_Tick
        End Sub
        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim point As Point = Control.MousePosition
            If CanHidePeekForm Then
                _officeNavigationBar.HidePeekForm()
                Timer.Stop()
            End If
        End Sub
        Private ReadOnly Property CanHidePeekForm() As Boolean
            Get
                Dim screenPoint As Point = Control.MousePosition
                Dim clientPoint As Point = _officeNavigationBar.Parent.PointToClient(Control.MousePosition)
                Return (Not _currentPeekForm.Bounds.Contains(screenPoint)) AndAlso Not _officeNavigationBar.Bounds.Contains(clientPoint)
            End Get
        End Property
        Public Sub SetPeekFormBehavior(ByVal autoHideOnMouseLeave As Boolean)
            RemoveHandler _officeNavigationBar.PeekFormShown, AddressOf OnPeekFormShown
            If _timer IsNot Nothing Then
                RemoveHandler _timer.Tick, AddressOf timer_Tick
                _timer.Dispose()
                _timer = Nothing
            End If
            If autoHideOnMouseLeave Then
                AddHandler _officeNavigationBar.PeekFormShown, AddressOf OnPeekFormShown
            End If
        End Sub
        Private Sub OnPeekFormShown(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Navigation.NavigationPeekFormEventArgs)
            _currentPeekForm = TryCast(e.Control.FindForm(), FlyoutPanelBeakForm)
            Timer.Stop()
            Timer.Start()
        End Sub
    End Class
End Namespace
