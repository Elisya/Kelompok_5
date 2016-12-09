Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Label1.Left >= Me.Width Then
            Label1.Left = -Label1.Width
        Else
            Label1.Left = Label1 + 100
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Show()
    End Sub

    Private Sub menu_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Button.Click
        
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        GroupBox1.Show()
    End Sub
End Class
