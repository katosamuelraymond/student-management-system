<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        GroupBox1 = New GroupBox()
        pwdvisible = New CheckBox()
        ComboBox1 = New ComboBox()
        stdpswdarea = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        stdpwd = New Label()
        stdno = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(pwdvisible)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(stdpswdarea)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(stdpwd)
        GroupBox1.Controls.Add(stdno)
        GroupBox1.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(367, 169)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(650, 372)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' pwdvisible
        ' 
        pwdvisible.AutoSize = True
        pwdvisible.Location = New Point(526, 173)
        pwdvisible.Name = "pwdvisible"
        pwdvisible.Size = New Size(15, 14)
        pwdvisible.TabIndex = 8
        pwdvisible.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Admin", "Student", "Teacher"})
        ComboBox1.Location = New Point(220, 217)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(332, 39)
        ComboBox1.TabIndex = 7
        ' 
        ' stdpswdarea
        ' 
        stdpswdarea.Location = New Point(220, 163)
        stdpswdarea.Multiline = True
        stdpswdarea.Name = "stdpswdarea"
        stdpswdarea.PasswordChar = "*"c
        stdpswdarea.Size = New Size(332, 35)
        stdpswdarea.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(220, 112)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(332, 35)
        TextBox1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(399, 285)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 42)
        Button2.TabIndex = 4
        Button2.Text = "Sign up"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(220, 285)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 42)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold)
        Label3.Location = New Point(53, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 26)
        Label3.TabIndex = 2
        Label3.Text = "Role"
        ' 
        ' stdpwd
        ' 
        stdpwd.AutoSize = True
        stdpwd.Font = New Font("Times New Roman", 18F, FontStyle.Bold)
        stdpwd.Location = New Point(53, 167)
        stdpwd.Name = "stdpwd"
        stdpwd.Size = New Size(110, 26)
        stdpwd.TabIndex = 1
        stdpwd.Text = "Password"
        ' 
        ' stdno
        ' 
        stdno.AutoSize = True
        stdno.Font = New Font("Times New Roman", 18F, FontStyle.Bold)
        stdno.Location = New Point(53, 117)
        stdno.Name = "stdno"
        stdno.Size = New Size(115, 26)
        stdno.TabIndex = 0
        stdno.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(641, 148)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(129, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(471, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 41)
        Label1.TabIndex = 2
        Label1.Text = "INCREDIBLE UNIVERSITY"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(982, 103)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 3
        Button3.Text = "dash"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1370, 749)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "loginform"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents stdpswdarea As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents stdpwd As Label
    Friend WithEvents stdno As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pwdvisible As CheckBox
    Friend WithEvents Button3 As Button

End Class
