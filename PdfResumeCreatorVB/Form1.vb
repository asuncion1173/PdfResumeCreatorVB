Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports System.IO

Public Class Form1

    Public location As String = "C:/Users/ASUNCION/source/repos/VB/PdfResumeCreatorVB/Converted.json"

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim openJson As String = File.ReadAllText(location)
        Dim finalJson As datagather = JsonConvert.DeserializeObject(Of datagather)(openJson)
        Dim pdfFile As Document = New Document()
        PdfWriter.GetInstance(pdfFile, New FileStream("C:\Users\ASUNCION\source\repos\VB\PdfResumeCreatorVB\ASUNCION_JACOB.pdf", FileMode.Create))
        pdfFile.Open()

        Dim fullname As Paragraph = New Paragraph(finalJson.FullName)
        fullname.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(fullname)
        Dim address As Paragraph = New Paragraph(finalJson.Address)

        pdfFile.Close()

    End Sub
    Public Class datagather
        Public Property FullName As String
        Public Property Address As String
        Public Property Email As String
        Public Property Number As String
        Public Property EducationTitle As String
        Public Property Education1 As String
        Public Property Education2 As String
        Public Property WorkExperienceTitle As String
        Public Property WorkExperience1 As String
        Public Property SkillsTitle As String
        Public Property Skill1 As String
        Public Property Skill2 As String
        Public Property Skill3 As String
        Public Property Signature As String
        Public Property CareerTitle As String
        Public Property Career As String
    End Class

End Class
