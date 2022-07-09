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

        pdfFile.Open()
        Dim separator As LineSeparator = New LineSeparator(3.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim fullname As Paragraph = New Paragraph(finalJson.FullName)
        fullname.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(fullname)
        Dim address As Paragraph = New Paragraph(finalJson.Address)
        address.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(address)
        Dim number As Paragraph = New Paragraph(finalJson.Number)
        number.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(number)
        Dim email As Paragraph = New Paragraph(finalJson.Email & vbLf & vbLf)
        email.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(email)
        pdfFile.Add(separator)
        Dim careerTitle As Paragraph = New Paragraph(finalJson.CareerTitle & vbLf)
        careerTitle.Font.Size = 18
        careerTitle.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(careerTitle)
        Dim career As Paragraph = New Paragraph(finalJson.Career & vbLf & vbLf)
        career.IndentationLeft = 40
        career.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(career)
        pdfFile.Add(separator)
        Dim educTitle As Paragraph = New Paragraph(finalJson.EducationTitle)
        educTitle.Font.Size = 18
        educTitle.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(educTitle)
        Dim educ1 As Paragraph = New Paragraph(finalJson.Education1)
        educ1.IndentationLeft = 40
        educ1.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(educ1)
        Dim educ2 As Paragraph = New Paragraph(finalJson.Education2 & vbLf & vbLf)
        educ2.IndentationLeft = 40
        educ2.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(educ2)
        pdfFile.Add(separator)
        Dim workExpTitle As Paragraph = New Paragraph(finalJson.WorkExperienceTitle & vbLf)
        workExpTitle.Font.Size = 18
        workExpTitle.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(workExpTitle)
        Dim workExp1 As Paragraph = New Paragraph(finalJson.WorkExperience1 & vbLf & vbLf)
        workExp1.IndentationLeft = 40
        workExp1.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(workExp1)
        pdfFile.Add(separator)
        Dim skillsTitle As Paragraph = New Paragraph(finalJson.SkillsTitle & vbLf)
        skillsTitle.Font.Size = 18
        skillsTitle.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(skillsTitle)
        Dim skill1 As Paragraph = New Paragraph(finalJson.Skill1)
        skill1.IndentationLeft = 40
        skill1.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(skill1)
        Dim skill2 As Paragraph = New Paragraph(finalJson.Skill2)
        skill2.IndentationLeft = 40
        skill2.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(skill2)
        Dim skill3 As Paragraph = New Paragraph(finalJson.Skill3 & vbLf & vbLf)
        skill3.IndentationLeft = 40
        skill3.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(skill3)
        pdfFile.Add(separator)
        Dim signatureimg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(finalJson.Signature)
        signatureimg.ScalePercent(5.0F)
        signatureimg.Alignment = iTextSharp.text.Image.UNDERLYING Or iTextSharp.text.Image.ALIGN_RIGHT
        signatureimg.IndentationRight = 50
        pdfFile.Add(signatureimg)
        Dim fullname1 As Paragraph = New Paragraph(finalJson.FullName)
        fullname1.Alignment = Element.ALIGN_RIGHT
        pdfFile.Add(fullname1)
        pdfFile.Close()
        MessageBox.Show("PDF has been created! Check folder!")


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
