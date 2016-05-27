
Module Module1

    Sub Main()
        Try
            Dim File As String = My.Settings("ErrorLog").ToString()
            Using Writer As New IO.StreamWriter(File, True, Text.Encoding.UTF8)
                Writer.WriteLine("ChkShtError" & DateTime.Now.ToString())
                Writer.WriteLine()
                Writer.Close()
            End Using


        Catch ex As Exception

        End Try


    End Sub

End Module
