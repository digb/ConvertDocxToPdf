Imports System.IO
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Flow.Model

Module Module1

    Sub Main()
        Dim path As String = "test.docx"
        File.SetAttributes(path, FileAttributes.Normal)

        Dim document As RadFlowDocument

        Using stream As Stream = New FileStream(path, FileMode.Open)
            document = New DocxFormatProvider().Import(stream)
        End Using

        Dim formatProvider As IFormatProvider(Of RadFlowDocument) = New PdfFormatProvider()

        Using stream As Stream = New FileStream("test.pdf", FileMode.CreateNew)
            formatProvider.Export(document, stream)
        End Using

    End Sub

End Module
