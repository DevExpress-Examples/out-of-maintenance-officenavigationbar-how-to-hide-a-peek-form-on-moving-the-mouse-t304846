Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DxExample
    Partial Public Class Main
        Inherits XtraForm

        Private helper As OfficeNavigationBarHelper
        Public Sub New()
            InitializeComponent()
            officeNavigationBar1.PeekFormShowDelay = 100
            helper = New OfficeNavigationBarHelper(officeNavigationBar1)
            helper.SetPeekFormBehavior(True)
        End Sub

        Private Sub officeNavigationBar1_QueryPeekFormContent(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Navigation.QueryPeekFormContentEventArgs) Handles officeNavigationBar1.QueryPeekFormContent
            If e.Item.Text = "Item1" Then
                e.Control = New XtraUserControl() With {.BackColor = Color.Green}
            End If
            If e.Item.Text = "Item2" Then
                e.Control = New XtraUserControl() With {.BackColor = Color.DeepSkyBlue}
            End If
        End Sub
        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            helper.SetPeekFormBehavior(False)
            MyBase.OnFormClosing(e)
        End Sub
    End Class
End Namespace

