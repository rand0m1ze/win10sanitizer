﻿Public Class services
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("CMD", "/C sc stop diagnosticshub.standardcollector.service")
        Process.Start("CMD", "/C sc config diagnosticshub.standardcollector.service start=disabled")
        Process.Start("CMD", "/C sc stop DiagTrack ")
        Process.Start("CMD", "/C sc config DiagTrack start=disabled")
        Process.Start("CMD", "/C sc stop dmwappushservice")
        Process.Start("CMD", "/C sc config dmwappushservice start=disabled")
        Process.Start("CMD", "/C sc stop HomeGroupListener")
        Process.Start("CMD", "/C sc config HomeGroupListener start=disabled")
        Process.Start("CMD", "/C sc stop HomeGroupProvider")
        Process.Start("CMD", "/C sc config HomeGroupProvider start=disabled")
        Process.Start("CMD", "/C sc stop lfsvc ")
        Process.Start("CMD", "/C sc config lfsvc start=disabled")
        Process.Start("CMD", "/C sc stop MapsBroker")
        Process.Start("CMD", "/C sc config MapsBroker start=disabled")
        Process.Start("CMD", "/C sc stop NetTcpPortSharing")
        Process.Start("CMD", "/C sc config NetTcpPortSharing start=disabled")
        Process.Start("CMD", "/C sc stop RemoteAccess")
        Process.Start("CMD", "/C sc config RemoteAccess start=disabled")
        Process.Start("CMD", "/C sc stop RemoteRegistry")
        Process.Start("CMD", "/C sc config RemoteRegistry start=disabled")
        Process.Start("CMD", "/C sc stop SharedAccess")
        Process.Start("CMD", "/C sc config SharedAccess start=disabled")
        Process.Start("CMD", "/C sc stop TrkWks ")
        Process.Start("CMD", "/C sc config TrkWks start=disabled")
        Process.Start("CMD", "/C sc stop WbioSrvc")
        Process.Start("CMD", "/C sc config WbioSrvc start=disabled")
        Process.Start("CMD", "/C sc stop WMPNetworkSvc")
        Process.Start("CMD", "/C sc config WMPNetworkSvc start=disabled")
        Process.Start("CMD", "/C sc stop wscsvc ")
        Process.Start("CMD", "/C sc config wscsvc start=disabled")
        Process.Start("CMD", "/C sc stop WSearch")
        Process.Start("CMD", "/C sc config WSearch start=disabled")
        Process.Start("CMD", "/C sc stop XblAuthManager ")
        Process.Start("CMD", "/C sc config XblAuthManager start=disabled")
        Process.Start("CMD", "/C sc stop XblGameSave ")
        Process.Start("CMD", "/C sc config XblGameSave start=disabled")
        Process.Start("CMD", "/C sc stop XboxNetApiSvc")
        Process.Start("CMD", "/C sc config XboxNetApiSvc start=disabled")
        MsgBox("FINISHED")
        Close()
    End Sub
End Class