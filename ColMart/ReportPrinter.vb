Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports Microsoft.Reporting.WinForms
Public Class ReportPrinter
    Public Sub Print(report As LocalReport)
        ' print
        export(report)
        printReport(report)
    End Sub

    Private _currentPageIndex As Integer
    Private _streams As IList(Of Stream)

    Private Function createStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        _streams.Add(stream)
        Return stream
    End Function

    Private Sub export(ByVal report As LocalReport)
        Dim settings As ReportPageSettings = report.GetDefaultPageSettings()
        Dim pageInfo As String
        If Not settings.IsLandscape Then
            pageInfo =
                String.Format("<PageWidth>{0}</PageWidth>" &
                              "<PageHeight>{1}</PageHeight>",
                              toInches(settings.PaperSize.Width),
                              toInches(settings.PaperSize.Height))
        Else
            pageInfo =
                String.Format("<PageHeight>{0}</PageHeight>" &
                              "<PageWidth>{1}</PageWidth>",
                              toInches(settings.PaperSize.Width),
                              toInches(settings.PaperSize.Height))
        End If
        Dim deviceInfo As String =
            String.Format("<DeviceInfo>" &
                            "<OutputFormat>EMF</OutputFormat>" &
                            "{0}" &
                            "<MarginTop>{1}</MarginTop>" &
                            "<MarginLeft>{2}</MarginLeft>" &
                            "<MarginRight>{3}</MarginRight>" &
                            "<MarginBottom>{4}</MarginBottom>" &
                            "</DeviceInfo>",
                            pageInfo,
                            toInches(settings.Margins.Top),
                            toInches(settings.Margins.Left),
                            toInches(settings.Margins.Right),
                            toInches(settings.Margins.Bottom))
        Dim warnings As Warning() = Nothing
        _streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf createStream, warnings)
        For Each stream As Stream In _streams
            stream.Position = 0
        Next
    End Sub

    Private Function toInches(hundrethsOfInch As Integer) As String
        Dim inches As Double = hundrethsOfInch / 100.0
        Return inches.ToString(CultureInfo.InvariantCulture) + "in"
    End Function

    Private Sub printPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As Metafile = New Metafile(_streams(_currentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As System.Drawing.Rectangle =
            New System.Drawing.Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX),
                                         ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY),
                                         ev.PageBounds.Width,
                                         ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(System.Drawing.Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        _currentPageIndex += 1
        ev.HasMorePages = (_currentPageIndex < _streams.Count)
    End Sub

    Private Sub printReport(report As LocalReport)
        If _streams Is Nothing OrElse _streams.Count = 0 Then
            Throw New Exception("No stream to print.")
        End If

        Dim printDoc As New PrintDocument()
        printDoc.DocumentName = report.DisplayName
        printDoc.DefaultPageSettings.Landscape = report.GetDefaultPageSettings().IsLandscape
        printDoc.PrintController = New StandardPrintController()
        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, AddressOf printPage
            _currentPageIndex = 0
            printDoc.Print()
        End If
    End Sub
End Class
