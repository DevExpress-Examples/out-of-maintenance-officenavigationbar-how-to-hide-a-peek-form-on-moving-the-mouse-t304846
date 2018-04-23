Imports DevExpress.XtraGrid.Views.Grid
Namespace DxExample
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.officeNavigationBar1 = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
            Me.navigationBarItem1 = New DevExpress.XtraBars.Navigation.NavigationBarItem()
            Me.navigationBarItem2 = New DevExpress.XtraBars.Navigation.NavigationBarItem()
            DirectCast(Me.officeNavigationBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' officeNavigationBar1
            ' 
            Me.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.officeNavigationBar1.Items.AddRange(New DevExpress.XtraBars.Navigation.NavigationBarItem() { Me.navigationBarItem1, Me.navigationBarItem2})
            Me.officeNavigationBar1.Location = New System.Drawing.Point(0, 392)
            Me.officeNavigationBar1.Name = "officeNavigationBar1"
            Me.officeNavigationBar1.Size = New System.Drawing.Size(765, 45)
            Me.officeNavigationBar1.TabIndex = 0
            Me.officeNavigationBar1.Text = "officeNavigationBar1"
            ' 
            ' navigationBarItem1
            ' 
            Me.navigationBarItem1.Name = "navigationBarItem1"
            Me.navigationBarItem1.Text = "Item1"
            ' 
            ' navigationBarItem2
            ' 
            Me.navigationBarItem2.Name = "navigationBarItem2"
            Me.navigationBarItem2.Text = "Item2"
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(765, 437)
            Me.Controls.Add(Me.officeNavigationBar1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Main"
            Me.Text = "Auto Hide Peek Forms"
            DirectCast(Me.officeNavigationBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents officeNavigationBar1 As DevExpress.XtraBars.Navigation.OfficeNavigationBar
        Private navigationBarItem1 As DevExpress.XtraBars.Navigation.NavigationBarItem
        Private navigationBarItem2 As DevExpress.XtraBars.Navigation.NavigationBarItem



    End Class
End Namespace

