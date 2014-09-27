<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.SplashBox = New System.Windows.Forms.PictureBox()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.jqueryButton1 = New System.Windows.Forms.RadioButton()
        Me.jqueryButton2 = New System.Windows.Forms.RadioButton()
        Me.html5addonsbutton1 = New System.Windows.Forms.RadioButton()
        Me.html5addonsbutton2 = New System.Windows.Forms.RadioButton()
        Me.html5addonsbutton3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.generatekixButton = New System.Windows.Forms.Button()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutKiXtartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspirationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.html5bpOption11 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption10 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption9 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption8 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption7 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption6 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption5 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption4 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption3 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption2 = New System.Windows.Forms.CheckBox()
        Me.html5bpOption1 = New System.Windows.Forms.CheckBox()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.settingskixButton = New System.Windows.Forms.Button()
        Me.aboutkixButton = New System.Windows.Forms.Button()
        CType(Me.SplashBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplashBox
        '
        Me.SplashBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplashBox.Image = CType(resources.GetObject("SplashBox.Image"), System.Drawing.Image)
        Me.SplashBox.Location = New System.Drawing.Point(0, 0)
        Me.SplashBox.Name = "SplashBox"
        Me.SplashBox.Size = New System.Drawing.Size(488, 103)
        Me.SplashBox.TabIndex = 0
        Me.SplashBox.TabStop = False
        '
        'versionLabel
        '
        Me.versionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.versionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionLabel.ForeColor = System.Drawing.Color.White
        Me.versionLabel.Location = New System.Drawing.Point(378, 47)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(56, 13)
        Me.versionLabel.TabIndex = 1
        Me.versionLabel.Text = "Beta 0.20"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(488, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Generate template"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.html5addonsbutton3)
        Me.GroupBox1.Controls.Add(Me.html5addonsbutton2)
        Me.GroupBox1.Controls.Add(Me.html5addonsbutton1)
        Me.GroupBox1.Location = New System.Drawing.Point(357, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HTML5 Add-ons"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.jqueryButton2)
        Me.GroupBox2.Controls.Add(Me.jqueryButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 70)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "jQuery"
        '
        'jqueryButton1
        '
        Me.jqueryButton1.AutoSize = True
        Me.jqueryButton1.Location = New System.Drawing.Point(7, 19)
        Me.jqueryButton1.Name = "jqueryButton1"
        Me.jqueryButton1.Size = New System.Drawing.Size(69, 17)
        Me.jqueryButton1.TabIndex = 0
        Me.jqueryButton1.TabStop = True
        Me.jqueryButton1.Text = "Minified"
        Me.jqueryButton1.UseVisualStyleBackColor = True
        '
        'jqueryButton2
        '
        Me.jqueryButton2.AutoSize = True
        Me.jqueryButton2.Location = New System.Drawing.Point(7, 42)
        Me.jqueryButton2.Name = "jqueryButton2"
        Me.jqueryButton2.Size = New System.Drawing.Size(99, 17)
        Me.jqueryButton2.TabIndex = 1
        Me.jqueryButton2.TabStop = True
        Me.jqueryButton2.Text = "Development"
        Me.jqueryButton2.UseVisualStyleBackColor = True
        '
        'html5addonsbutton1
        '
        Me.html5addonsbutton1.AutoSize = True
        Me.html5addonsbutton1.Location = New System.Drawing.Point(7, 19)
        Me.html5addonsbutton1.Name = "html5addonsbutton1"
        Me.html5addonsbutton1.Size = New System.Drawing.Size(80, 17)
        Me.html5addonsbutton1.TabIndex = 0
        Me.html5addonsbutton1.TabStop = True
        Me.html5addonsbutton1.Text = "Modernizr"
        Me.html5addonsbutton1.UseVisualStyleBackColor = True
        '
        'html5addonsbutton2
        '
        Me.html5addonsbutton2.AutoSize = True
        Me.html5addonsbutton2.Location = New System.Drawing.Point(7, 42)
        Me.html5addonsbutton2.Name = "html5addonsbutton2"
        Me.html5addonsbutton2.Size = New System.Drawing.Size(91, 17)
        Me.html5addonsbutton2.TabIndex = 1
        Me.html5addonsbutton2.TabStop = True
        Me.html5addonsbutton2.Text = "HTML5Shiv"
        Me.html5addonsbutton2.UseVisualStyleBackColor = True
        '
        'html5addonsbutton3
        '
        Me.html5addonsbutton3.AutoSize = True
        Me.html5addonsbutton3.Location = New System.Drawing.Point(7, 65)
        Me.html5addonsbutton3.Name = "html5addonsbutton3"
        Me.html5addonsbutton3.Size = New System.Drawing.Size(76, 17)
        Me.html5addonsbutton3.TabIndex = 2
        Me.html5addonsbutton3.Text = "Respond"
        Me.html5addonsbutton3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(357, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 152)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Versions:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "HTML5BP: 4.3.0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bootstrap: 3.2.0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "jQuery: 1.11.1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generatekixButton
        '
        Me.generatekixButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generatekixButton.Location = New System.Drawing.Point(14, 399)
        Me.generatekixButton.Name = "generatekixButton"
        Me.generatekixButton.Size = New System.Drawing.Size(337, 31)
        Me.generatekixButton.TabIndex = 8
        Me.generatekixButton.Text = "Generate!"
        Me.generatekixButton.UseVisualStyleBackColor = True
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InspirationsToolStripMenuItem, Me.AboutKiXtartToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(45, 20)
        Me.ToolStripDropDownButton1.Text = "Help"
        Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AboutKiXtartToolStripMenuItem
        '
        Me.AboutKiXtartToolStripMenuItem.Name = "AboutKiXtartToolStripMenuItem"
        Me.AboutKiXtartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutKiXtartToolStripMenuItem.Text = "About KiXtart"
        '
        'InspirationsToolStripMenuItem
        '
        Me.InspirationsToolStripMenuItem.Name = "InspirationsToolStripMenuItem"
        Me.InspirationsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InspirationsToolStripMenuItem.Text = "Inspirations"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.html5bpOption11)
        Me.GroupBox5.Controls.Add(Me.html5bpOption10)
        Me.GroupBox5.Controls.Add(Me.html5bpOption9)
        Me.GroupBox5.Controls.Add(Me.html5bpOption8)
        Me.GroupBox5.Controls.Add(Me.html5bpOption7)
        Me.GroupBox5.Controls.Add(Me.html5bpOption6)
        Me.GroupBox5.Controls.Add(Me.html5bpOption5)
        Me.GroupBox5.Controls.Add(Me.html5bpOption4)
        Me.GroupBox5.Controls.Add(Me.html5bpOption3)
        Me.GroupBox5.Controls.Add(Me.html5bpOption2)
        Me.GroupBox5.Controls.Add(Me.html5bpOption1)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(337, 232)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "HTML5 Boilerplate Options "
        '
        'html5bpOption11
        '
        Me.html5bpOption11.AutoSize = True
        Me.html5bpOption11.Location = New System.Drawing.Point(107, 197)
        Me.html5bpOption11.Name = "html5bpOption11"
        Me.html5bpOption11.Size = New System.Drawing.Size(105, 17)
        Me.html5bpOption11.TabIndex = 10
        Me.html5bpOption11.Text = "Robots.txt file"
        Me.html5bpOption11.UseVisualStyleBackColor = True
        '
        'html5bpOption10
        '
        Me.html5bpOption10.AutoSize = True
        Me.html5bpOption10.Location = New System.Drawing.Point(177, 170)
        Me.html5bpOption10.Name = "html5bpOption10"
        Me.html5bpOption10.Size = New System.Drawing.Size(100, 17)
        Me.html5bpOption10.TabIndex = 9
        Me.html5bpOption10.Text = "plugins.js file"
        Me.html5bpOption10.UseVisualStyleBackColor = True
        '
        'html5bpOption9
        '
        Me.html5bpOption9.AutoSize = True
        Me.html5bpOption9.Location = New System.Drawing.Point(177, 131)
        Me.html5bpOption9.Name = "html5bpOption9"
        Me.html5bpOption9.Size = New System.Drawing.Size(153, 30)
        Me.html5bpOption9.TabIndex = 8
        Me.html5bpOption9.Text = "Old/Obsolete browser " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "warning"
        Me.html5bpOption9.UseVisualStyleBackColor = True
        '
        'html5bpOption8
        '
        Me.html5bpOption8.AutoSize = True
        Me.html5bpOption8.Location = New System.Drawing.Point(177, 40)
        Me.html5bpOption8.Name = "html5bpOption8"
        Me.html5bpOption8.Size = New System.Drawing.Size(85, 17)
        Me.html5bpOption8.TabIndex = 7
        Me.html5bpOption8.Text = "IE Classes"
        Me.html5bpOption8.UseVisualStyleBackColor = True
        '
        'html5bpOption7
        '
        Me.html5bpOption7.AutoSize = True
        Me.html5bpOption7.Location = New System.Drawing.Point(177, 105)
        Me.html5bpOption7.Name = "html5bpOption7"
        Me.html5bpOption7.Size = New System.Drawing.Size(110, 17)
        Me.html5bpOption7.TabIndex = 6
        Me.html5bpOption7.Text = "Humans.txt file"
        Me.html5bpOption7.UseVisualStyleBackColor = True
        '
        'html5bpOption6
        '
        Me.html5bpOption6.AutoSize = True
        Me.html5bpOption6.Location = New System.Drawing.Point(177, 73)
        Me.html5bpOption6.Name = "html5bpOption6"
        Me.html5bpOption6.Size = New System.Drawing.Size(121, 17)
        Me.html5bpOption6.TabIndex = 5
        Me.html5bpOption6.Text = "Google Analytics"
        Me.html5bpOption6.UseVisualStyleBackColor = True
        '
        'html5bpOption5
        '
        Me.html5bpOption5.AutoSize = True
        Me.html5bpOption5.Location = New System.Drawing.Point(15, 170)
        Me.html5bpOption5.Name = "html5bpOption5"
        Me.html5bpOption5.Size = New System.Drawing.Size(71, 17)
        Me.html5bpOption5.TabIndex = 4
        Me.html5bpOption5.Text = "Favicon"
        Me.html5bpOption5.UseVisualStyleBackColor = True
        '
        'html5bpOption4
        '
        Me.html5bpOption4.AutoSize = True
        Me.html5bpOption4.Location = New System.Drawing.Point(15, 138)
        Me.html5bpOption4.Name = "html5bpOption4"
        Me.html5bpOption4.Size = New System.Drawing.Size(133, 17)
        Me.html5bpOption4.TabIndex = 3
        Me.html5bpOption4.Text = "Apple Touch Icons"
        Me.html5bpOption4.UseVisualStyleBackColor = True
        '
        'html5bpOption3
        '
        Me.html5bpOption3.AutoSize = True
        Me.html5bpOption3.Location = New System.Drawing.Point(15, 105)
        Me.html5bpOption3.Name = "html5bpOption3"
        Me.html5bpOption3.Size = New System.Drawing.Size(143, 17)
        Me.html5bpOption3.TabIndex = 2
        Me.html5bpOption3.Text = "Adobe Cross Domain"
        Me.html5bpOption3.UseVisualStyleBackColor = True
        '
        'html5bpOption2
        '
        Me.html5bpOption2.AutoSize = True
        Me.html5bpOption2.Location = New System.Drawing.Point(15, 73)
        Me.html5bpOption2.Name = "html5bpOption2"
        Me.html5bpOption2.Size = New System.Drawing.Size(79, 17)
        Me.html5bpOption2.TabIndex = 1
        Me.html5bpOption2.Text = "404 page"
        Me.html5bpOption2.UseVisualStyleBackColor = True
        '
        'html5bpOption1
        '
        Me.html5bpOption1.AutoSize = True
        Me.html5bpOption1.Location = New System.Drawing.Point(15, 40)
        Me.html5bpOption1.Name = "html5bpOption1"
        Me.html5bpOption1.Size = New System.Drawing.Size(102, 17)
        Me.html5bpOption1.TabIndex = 0
        Me.html5bpOption1.Text = ".htaccess file"
        Me.html5bpOption1.UseVisualStyleBackColor = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(150, 17)
        Me.ToolStripStatusLabel1.Text = "http://github.com/nedpals"
        '
        'settingskixButton
        '
        Me.settingskixButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingskixButton.Location = New System.Drawing.Point(241, 441)
        Me.settingskixButton.Name = "settingskixButton"
        Me.settingskixButton.Size = New System.Drawing.Size(110, 31)
        Me.settingskixButton.TabIndex = 10
        Me.settingskixButton.Text = "Options"
        Me.settingskixButton.UseVisualStyleBackColor = True
        '
        'aboutkixButton
        '
        Me.aboutkixButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutkixButton.Location = New System.Drawing.Point(14, 441)
        Me.aboutkixButton.Name = "aboutkixButton"
        Me.aboutkixButton.Size = New System.Drawing.Size(221, 31)
        Me.aboutkixButton.TabIndex = 11
        Me.aboutkixButton.Text = "About KiXtart Beta 0.20"
        Me.aboutkixButton.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 505)
        Me.Controls.Add(Me.aboutkixButton)
        Me.Controls.Add(Me.settingskixButton)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.generatekixButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.versionLabel)
        Me.Controls.Add(Me.SplashBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KiXtart Beta 0.20 - by nedpals"
        CType(Me.SplashBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplashBox As System.Windows.Forms.PictureBox
    Friend WithEvents versionLabel As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents html5addonsbutton3 As System.Windows.Forms.CheckBox
    Friend WithEvents html5addonsbutton2 As System.Windows.Forms.RadioButton
    Friend WithEvents html5addonsbutton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents jqueryButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents jqueryButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents generatekixButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents InspirationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutKiXtartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents html5bpOption11 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption10 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption9 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption8 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption7 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption6 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption5 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption4 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption3 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption2 As System.Windows.Forms.CheckBox
    Friend WithEvents html5bpOption1 As System.Windows.Forms.CheckBox
    Friend WithEvents settingskixButton As System.Windows.Forms.Button
    Friend WithEvents aboutkixButton As System.Windows.Forms.Button

End Class
