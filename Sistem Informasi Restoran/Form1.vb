Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Label1.Left >= Me.Width Then
            Label1.Left = -Label1.Width
        Else
            Label1.Left = Label1 + 100
        End If
    End Sub
   
End Class
