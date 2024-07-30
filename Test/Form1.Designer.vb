<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Book = New Button()
        Article = New Button()
        ConfPapers = New Button()
        Label1 = New Label()
        Label2 = New Label()
        AuthorsNum = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label10 = New Label()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' Book
        ' 
        Book.Location = New Point(139, 251)
        Book.Name = "Book"
        Book.Size = New Size(163, 103)
        Book.TabIndex = 0
        Book.TabStop = False
        Book.Text = "Book"
        Book.UseVisualStyleBackColor = True
        ' 
        ' Article
        ' 
        Article.Location = New Point(425, 250)
        Article.Name = "Article"
        Article.Size = New Size(163, 103)
        Article.TabIndex = 1
        Article.Text = "Article"
        Article.UseVisualStyleBackColor = True
        ' 
        ' ConfPapers
        ' 
        ConfPapers.Location = New Point(722, 250)
        ConfPapers.Name = "ConfPapers"
        ConfPapers.Size = New Size(163, 103)
        ConfPapers.TabIndex = 2
        ConfPapers.Text = "Conference Papers"
        ConfPapers.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(381, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 51)
        Label1.TabIndex = 3
        Label1.Text = "Source Type?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(381, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(361, 51)
        Label2.TabIndex = 4
        Label2.Text = "How Many Authors?"
        Label2.Visible = False
        ' 
        ' AuthorsNum
        ' 
        AuthorsNum.Location = New Point(250, 234)
        AuthorsNum.Name = "AuthorsNum"
        AuthorsNum.Size = New Size(100, 23)
        AuthorsNum.TabIndex = 5
        AuthorsNum.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(113, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 6
        Label3.Text = "Author (Last Name) * :"
        Label3.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(113, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 15)
        Label4.TabIndex = 7
        Label4.Text = "Author (First Name) * :"
        Label4.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(971, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 45)
        Button1.TabIndex = 8
        Button1.Text = "?"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(113, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 9
        Label5.Text = "Title * :"
        Label5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(113, 363)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 15)
        Label6.TabIndex = 10
        Label6.Text = "Publisher (*) :"
        Label6.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(113, 315)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 11
        Label7.Text = "Date (*) :"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(113, 403)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 12
        Label8.Text = "DOI / URL :"
        Label8.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(250, 199)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 13
        TextBox1.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(250, 275)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 14
        TextBox2.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(250, 315)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 15
        TextBox3.Visible = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(250, 360)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 16
        TextBox4.Visible = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(250, 403)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 17
        TextBox5.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(381, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(289, 51)
        Label9.TabIndex = 18
        Label9.Text = "Output Format?"
        Label9.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(187, 304)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 103)
        Button2.TabIndex = 19
        Button2.TabStop = False
        Button2.Text = "APA"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(490, 304)
        Button3.Name = "Button3"
        Button3.Size = New Size(163, 103)
        Button3.TabIndex = 20
        Button3.TabStop = False
        Button3.Text = "MLA"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(785, 304)
        Button4.Name = "Button4"
        Button4.Size = New Size(163, 103)
        Button4.TabIndex = 21
        Button4.TabStop = False
        Button4.Text = "IEEE"
        Button4.UseVisualStyleBackColor = True
        Button4.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(113, 470)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 15)
        Label10.TabIndex = 22
        Label10.Text = "* Required"
        Label10.Visible = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(381, 453)
        TextBox6.MinimumSize = New Size(0, 3)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(333, 126)
        TextBox6.TabIndex = 23
        TextBox6.Text = "Answer Here (TXT OUTPUT)"
        TextBox6.TextAlign = HorizontalAlignment.Right
        TextBox6.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1026, 591)
        Controls.Add(TextBox6)
        Controls.Add(Label10)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(AuthorsNum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ConfPapers)
        Controls.Add(Article)
        Controls.Add(Book)
        Name = "Form1"
        Text = "Citation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Book As Button
    Friend WithEvents Article As Button
    Friend WithEvents ConfPapers As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AuthorsNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
