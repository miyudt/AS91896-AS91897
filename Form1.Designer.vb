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
        lbldetails = New Label()
        lblname = New Label()
        lbldelivery = New Label()
        lbladdress = New Label()
        bgdetails = New Panel()
        lblcreditcard = New Label()
        txtcreditcard = New TextBox()
        Label12 = New Label()
        chkdelivery = New CheckBox()
        txtaddress = New TextBox()
        txtphone = New TextBox()
        lblphone = New Label()
        txtname = New TextBox()
        PANELEXTENDER = New Label()
        lblregular = New Label()
        bgregular = New Panel()
        nmudveggie = New NumericUpDown()
        Label6 = New Label()
        nmudmargherita = New NumericUpDown()
        Label3 = New Label()
        nmudmhawaiian = New NumericUpDown()
        Label4 = New Label()
        nmudmeatlovers = New NumericUpDown()
        Label5 = New Label()
        nmudham = New NumericUpDown()
        Label2 = New Label()
        nmudcheese = New NumericUpDown()
        Label1 = New Label()
        nmudpepperoni = New NumericUpDown()
        lblpepperoni = New Label()
        lblgourmet = New Label()
        bggourmet = New Panel()
        numdamericano = New NumericUpDown()
        Label8 = New Label()
        Label7 = New Label()
        Label11 = New Label()
        nmudbeefonion = New NumericUpDown()
        nmudnewyorker = New NumericUpDown()
        Label10 = New Label()
        nmudloadedbbq = New NumericUpDown()
        nmudsupreme = New NumericUpDown()
        Label9 = New Label()
        btnrevieworder = New Button()
        btnreset = New Button()
        mmumain = New MenuStrip()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        OpenPasswordTXTToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        bgdetails.SuspendLayout()
        bgregular.SuspendLayout()
        CType(nmudveggie, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudmargherita, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudmhawaiian, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudmeatlovers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudham, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudcheese, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpepperoni, ComponentModel.ISupportInitialize).BeginInit()
        bggourmet.SuspendLayout()
        CType(numdamericano, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudbeefonion, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudnewyorker, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudloadedbbq, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudsupreme, ComponentModel.ISupportInitialize).BeginInit()
        mmumain.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbldetails
        ' 
        lbldetails.AutoSize = True
        lbldetails.BackColor = Color.White
        lbldetails.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lbldetails.Location = New Point(19, 33)
        lbldetails.Margin = New Padding(5, 0, 5, 0)
        lbldetails.Name = "lbldetails"
        lbldetails.Size = New Size(301, 39)
        lbldetails.TabIndex = 0
        lbldetails.Text = "Customer Details"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.BackColor = Color.White
        lblname.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblname.Location = New Point(23, 122)
        lblname.Margin = New Padding(5, 0, 5, 0)
        lblname.Name = "lblname"
        lblname.Size = New Size(84, 29)
        lblname.TabIndex = 1
        lblname.Text = "Name:"
        ' 
        ' lbldelivery
        ' 
        lbldelivery.AutoSize = True
        lbldelivery.BackColor = Color.White
        lbldelivery.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lbldelivery.Location = New Point(12, 181)
        lbldelivery.Margin = New Padding(5, 0, 5, 0)
        lbldelivery.Name = "lbldelivery"
        lbldelivery.Size = New Size(112, 29)
        lbldelivery.TabIndex = 3
        lbldelivery.Text = "Delivery?"
        ' 
        ' lbladdress
        ' 
        lbladdress.AutoSize = True
        lbladdress.BackColor = Color.White
        lbladdress.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lbladdress.Location = New Point(23, 251)
        lbladdress.Margin = New Padding(5, 0, 5, 0)
        lbladdress.Name = "lbladdress"
        lbladdress.Size = New Size(108, 29)
        lbladdress.TabIndex = 4
        lbladdress.Text = "Address:"
        lbladdress.Visible = False
        ' 
        ' bgdetails
        ' 
        bgdetails.BackColor = Color.White
        bgdetails.Controls.Add(lblcreditcard)
        bgdetails.Controls.Add(txtcreditcard)
        bgdetails.Controls.Add(Label12)
        bgdetails.Controls.Add(chkdelivery)
        bgdetails.Controls.Add(txtaddress)
        bgdetails.Controls.Add(lbldelivery)
        bgdetails.Controls.Add(txtphone)
        bgdetails.Controls.Add(lblphone)
        bgdetails.Controls.Add(txtname)
        bgdetails.Controls.Add(PANELEXTENDER)
        bgdetails.Location = New Point(11, 27)
        bgdetails.Name = "bgdetails"
        bgdetails.Size = New Size(474, 322)
        bgdetails.TabIndex = 5
        ' 
        ' lblcreditcard
        ' 
        lblcreditcard.AutoSize = True
        lblcreditcard.BackColor = Color.White
        lblcreditcard.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblcreditcard.Location = New Point(12, 262)
        lblcreditcard.Margin = New Padding(5, 0, 5, 0)
        lblcreditcard.Name = "lblcreditcard"
        lblcreditcard.Size = New Size(142, 29)
        lblcreditcard.TabIndex = 15
        lblcreditcard.Text = "Credit Card:"
        lblcreditcard.Visible = False
        ' 
        ' txtcreditcard
        ' 
        txtcreditcard.Location = New Point(232, 262)
        txtcreditcard.MaxLength = 16
        txtcreditcard.Name = "txtcreditcard"
        txtcreditcard.Size = New Size(224, 29)
        txtcreditcard.TabIndex = 14
        txtcreditcard.Visible = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(12, 165)
        Label12.Margin = New Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 29)
        Label12.TabIndex = 13
        ' 
        ' chkdelivery
        ' 
        chkdelivery.AutoSize = True
        chkdelivery.Location = New Point(232, 184)
        chkdelivery.Name = "chkdelivery"
        chkdelivery.Size = New Size(49, 28)
        chkdelivery.TabIndex = 4
        chkdelivery.Text = "$3"
        chkdelivery.UseVisualStyleBackColor = True
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(232, 222)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(224, 29)
        txtaddress.TabIndex = 3
        txtaddress.Visible = False
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(232, 140)
        txtphone.MaxLength = 11
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(224, 29)
        txtphone.TabIndex = 1
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.BackColor = Color.White
        lblphone.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblphone.Location = New Point(12, 141)
        lblphone.Margin = New Padding(5, 0, 5, 0)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(182, 29)
        lblphone.TabIndex = 2
        lblphone.Text = "Phone Number:"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(232, 98)
        txtname.Name = "txtname"
        txtname.Size = New Size(224, 29)
        txtname.TabIndex = 0
        ' 
        ' PANELEXTENDER
        ' 
        PANELEXTENDER.AutoSize = True
        PANELEXTENDER.BackColor = Color.White
        PANELEXTENDER.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        PANELEXTENDER.ForeColor = Color.White
        PANELEXTENDER.Location = New Point(12, 283)
        PANELEXTENDER.Margin = New Padding(5, 0, 5, 0)
        PANELEXTENDER.Name = "PANELEXTENDER"
        PANELEXTENDER.Size = New Size(142, 29)
        PANELEXTENDER.TabIndex = 16
        PANELEXTENDER.Text = "Credit Card:"
        ' 
        ' lblregular
        ' 
        lblregular.AutoSize = True
        lblregular.BackColor = Color.White
        lblregular.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblregular.Location = New Point(6, 6)
        lblregular.Margin = New Padding(5, 0, 5, 0)
        lblregular.Name = "lblregular"
        lblregular.Size = New Size(373, 39)
        lblregular.TabIndex = 6
        lblregular.Text = "Regular Pizza ($8.50)"
        ' 
        ' bgregular
        ' 
        bgregular.BackColor = Color.White
        bgregular.Controls.Add(nmudveggie)
        bgregular.Controls.Add(Label6)
        bgregular.Controls.Add(nmudmargherita)
        bgregular.Controls.Add(Label3)
        bgregular.Controls.Add(nmudmhawaiian)
        bgregular.Controls.Add(lblregular)
        bgregular.Controls.Add(Label4)
        bgregular.Controls.Add(nmudmeatlovers)
        bgregular.Controls.Add(Label5)
        bgregular.Controls.Add(nmudham)
        bgregular.Controls.Add(Label2)
        bgregular.Controls.Add(nmudcheese)
        bgregular.Controls.Add(Label1)
        bgregular.Controls.Add(nmudpepperoni)
        bgregular.Controls.Add(lblpepperoni)
        bgregular.Location = New Point(493, 27)
        bgregular.Name = "bgregular"
        bgregular.Size = New Size(474, 250)
        bgregular.TabIndex = 6
        ' 
        ' nmudveggie
        ' 
        nmudveggie.Location = New Point(166, 206)
        nmudveggie.Margin = New Padding(5, 4, 5, 4)
        nmudveggie.Name = "nmudveggie"
        nmudveggie.ReadOnly = True
        nmudveggie.Size = New Size(58, 29)
        nmudveggie.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(6, 205)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 29)
        Label6.TabIndex = 21
        Label6.Text = "Veggie"
        ' 
        ' nmudmargherita
        ' 
        nmudmargherita.Location = New Point(395, 164)
        nmudmargherita.Margin = New Padding(5, 4, 5, 4)
        nmudmargherita.Name = "nmudmargherita"
        nmudmargherita.ReadOnly = True
        nmudmargherita.Size = New Size(58, 29)
        nmudmargherita.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(240, 163)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 29)
        Label3.TabIndex = 19
        Label3.Text = "Margherita"
        ' 
        ' nmudmhawaiian
        ' 
        nmudmhawaiian.Location = New Point(395, 121)
        nmudmhawaiian.Margin = New Padding(5, 4, 5, 4)
        nmudmhawaiian.Name = "nmudmhawaiian"
        nmudmhawaiian.ReadOnly = True
        nmudmhawaiian.Size = New Size(58, 29)
        nmudmhawaiian.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(240, 120)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 29)
        Label4.TabIndex = 17
        Label4.Text = "Hawaiian"
        ' 
        ' nmudmeatlovers
        ' 
        nmudmeatlovers.Location = New Point(395, 79)
        nmudmeatlovers.Margin = New Padding(5, 4, 5, 4)
        nmudmeatlovers.Name = "nmudmeatlovers"
        nmudmeatlovers.ReadOnly = True
        nmudmeatlovers.Size = New Size(58, 29)
        nmudmeatlovers.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(240, 78)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 29)
        Label5.TabIndex = 15
        Label5.Text = "Meatlovers"
        ' 
        ' nmudham
        ' 
        nmudham.Location = New Point(166, 164)
        nmudham.Margin = New Padding(5, 4, 5, 4)
        nmudham.Name = "nmudham"
        nmudham.ReadOnly = True
        nmudham.Size = New Size(58, 29)
        nmudham.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 163)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 29)
        Label2.TabIndex = 13
        Label2.Text = "Ham"
        ' 
        ' nmudcheese
        ' 
        nmudcheese.Location = New Point(166, 121)
        nmudcheese.Margin = New Padding(5, 4, 5, 4)
        nmudcheese.Name = "nmudcheese"
        nmudcheese.ReadOnly = True
        nmudcheese.Size = New Size(58, 29)
        nmudcheese.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 120)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 29)
        Label1.TabIndex = 11
        Label1.Text = "Cheese"
        ' 
        ' nmudpepperoni
        ' 
        nmudpepperoni.Location = New Point(166, 79)
        nmudpepperoni.Margin = New Padding(5, 4, 5, 4)
        nmudpepperoni.Name = "nmudpepperoni"
        nmudpepperoni.ReadOnly = True
        nmudpepperoni.Size = New Size(58, 29)
        nmudpepperoni.TabIndex = 10
        ' 
        ' lblpepperoni
        ' 
        lblpepperoni.AutoSize = True
        lblpepperoni.BackColor = Color.White
        lblpepperoni.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpepperoni.Location = New Point(6, 78)
        lblpepperoni.Margin = New Padding(5, 0, 5, 0)
        lblpepperoni.Name = "lblpepperoni"
        lblpepperoni.Size = New Size(126, 29)
        lblpepperoni.TabIndex = 9
        lblpepperoni.Text = "Pepperoni"
        ' 
        ' lblgourmet
        ' 
        lblgourmet.AutoSize = True
        lblgourmet.BackColor = Color.White
        lblgourmet.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblgourmet.Location = New Point(495, 291)
        lblgourmet.Margin = New Padding(5, 0, 5, 0)
        lblgourmet.Name = "lblgourmet"
        lblgourmet.Size = New Size(408, 39)
        lblgourmet.TabIndex = 7
        lblgourmet.Text = "Gourmet Pizza ($13.50)"
        ' 
        ' bggourmet
        ' 
        bggourmet.BackColor = Color.White
        bggourmet.Controls.Add(numdamericano)
        bggourmet.Controls.Add(Label8)
        bggourmet.Controls.Add(Label7)
        bggourmet.Controls.Add(Label11)
        bggourmet.Controls.Add(nmudbeefonion)
        bggourmet.Controls.Add(nmudnewyorker)
        bggourmet.Controls.Add(Label10)
        bggourmet.Controls.Add(nmudloadedbbq)
        bggourmet.Controls.Add(nmudsupreme)
        bggourmet.Controls.Add(Label9)
        bggourmet.Location = New Point(493, 283)
        bggourmet.Name = "bggourmet"
        bggourmet.Size = New Size(474, 246)
        bggourmet.TabIndex = 8
        ' 
        ' numdamericano
        ' 
        numdamericano.Location = New Point(395, 118)
        numdamericano.Margin = New Padding(5, 4, 5, 4)
        numdamericano.Name = "numdamericano"
        numdamericano.ReadOnly = True
        numdamericano.Size = New Size(58, 29)
        numdamericano.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(240, 75)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 29)
        Label8.TabIndex = 29
        Label8.Text = "Beef+Onion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(240, 117)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 29)
        Label7.TabIndex = 31
        Label7.Text = "Americano"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(6, 75)
        Label11.Margin = New Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 29)
        Label11.TabIndex = 23
        Label11.Text = "New Yorker"
        ' 
        ' nmudbeefonion
        ' 
        nmudbeefonion.Location = New Point(395, 76)
        nmudbeefonion.Margin = New Padding(5, 4, 5, 4)
        nmudbeefonion.Name = "nmudbeefonion"
        nmudbeefonion.ReadOnly = True
        nmudbeefonion.Size = New Size(58, 29)
        nmudbeefonion.TabIndex = 30
        ' 
        ' nmudnewyorker
        ' 
        nmudnewyorker.Location = New Point(166, 76)
        nmudnewyorker.Margin = New Padding(5, 4, 5, 4)
        nmudnewyorker.Name = "nmudnewyorker"
        nmudnewyorker.ReadOnly = True
        nmudnewyorker.Size = New Size(58, 29)
        nmudnewyorker.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(6, 117)
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(112, 29)
        Label10.TabIndex = 25
        Label10.Text = "Supreme"
        ' 
        ' nmudloadedbbq
        ' 
        nmudloadedbbq.Location = New Point(166, 161)
        nmudloadedbbq.Margin = New Padding(5, 4, 5, 4)
        nmudloadedbbq.Name = "nmudloadedbbq"
        nmudloadedbbq.ReadOnly = True
        nmudloadedbbq.Size = New Size(58, 29)
        nmudloadedbbq.TabIndex = 28
        ' 
        ' nmudsupreme
        ' 
        nmudsupreme.Location = New Point(166, 118)
        nmudsupreme.Margin = New Padding(5, 4, 5, 4)
        nmudsupreme.Name = "nmudsupreme"
        nmudsupreme.ReadOnly = True
        nmudsupreme.Size = New Size(58, 29)
        nmudsupreme.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(6, 160)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(152, 29)
        Label9.TabIndex = 27
        Label9.Text = "Loaded BBQ"
        ' 
        ' btnrevieworder
        ' 
        btnrevieworder.BackColor = Color.MediumSeaGreen
        btnrevieworder.Location = New Point(11, 359)
        btnrevieworder.Name = "btnrevieworder"
        btnrevieworder.Size = New Size(474, 77)
        btnrevieworder.TabIndex = 9
        btnrevieworder.Text = "Review Order"
        btnrevieworder.UseVisualStyleBackColor = False
        ' 
        ' btnreset
        ' 
        btnreset.BackColor = Color.Tomato
        btnreset.Location = New Point(11, 444)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(474, 85)
        btnreset.TabIndex = 11
        btnreset.Text = "Reset Order"
        btnreset.UseVisualStyleBackColor = False
        ' 
        ' mmumain
        ' 
        mmumain.Items.AddRange(New ToolStripItem() {SettingsToolStripMenuItem})
        mmumain.Location = New Point(0, 0)
        mmumain.Name = "mmumain"
        mmumain.Size = New Size(974, 24)
        mmumain.TabIndex = 12
        mmumain.Text = "mmumain"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ChangePasswordToolStripMenuItem, OpenPasswordTXTToolStripMenuItem, QuitToolStripMenuItem})
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(44, 20)
        SettingsToolStripMenuItem.Text = "Misc"
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(180, 22)
        ChangePasswordToolStripMenuItem.Text = "Change Password"
        ' 
        ' OpenPasswordTXTToolStripMenuItem
        ' 
        OpenPasswordTXTToolStripMenuItem.Name = "OpenPasswordTXTToolStripMenuItem"
        OpenPasswordTXTToolStripMenuItem.Size = New Size(180, 22)
        OpenPasswordTXTToolStripMenuItem.Text = "Open Password TXT"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(180, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 539)
        Controls.Add(btnreset)
        Controls.Add(btnrevieworder)
        Controls.Add(lblgourmet)
        Controls.Add(bggourmet)
        Controls.Add(lbladdress)
        Controls.Add(lblname)
        Controls.Add(lbldetails)
        Controls.Add(bgdetails)
        Controls.Add(bgregular)
        Controls.Add(mmumain)
        Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        MainMenuStrip = mmumain
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = "Delivery?"
        bgdetails.ResumeLayout(False)
        bgdetails.PerformLayout()
        bgregular.ResumeLayout(False)
        bgregular.PerformLayout()
        CType(nmudveggie, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudmargherita, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudmhawaiian, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudmeatlovers, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudham, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudcheese, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpepperoni, ComponentModel.ISupportInitialize).EndInit()
        bggourmet.ResumeLayout(False)
        bggourmet.PerformLayout()
        CType(numdamericano, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudbeefonion, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudnewyorker, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudloadedbbq, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudsupreme, ComponentModel.ISupportInitialize).EndInit()
        mmumain.ResumeLayout(False)
        mmumain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbldetails As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lbldelivery As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents bgdetails As Panel
    Friend WithEvents chkdelivery As CheckBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblregular As Label
    Friend WithEvents bgregular As Panel
    Friend WithEvents lblgourmet As Label
    Friend WithEvents bggourmet As Panel
    Friend WithEvents lblpepperoni As Label
    Friend WithEvents nmudpepperoni As NumericUpDown
    Friend WithEvents nmudham As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nmudcheese As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nmudveggie As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nmudmargherita As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nmudmhawaiian As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nmudmeatlovers As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numdamericano As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents nmudbeefonion As NumericUpDown
    Friend WithEvents nmudnewyorker As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents nmudloadedbbq As NumericUpDown
    Friend WithEvents nmudsupreme As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents btnrevieworder As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblcreditcard As Label
    Friend WithEvents txtcreditcard As TextBox
    Friend WithEvents lblphone As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents PANELEXTENDER As Label
    Friend WithEvents mmumain As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPasswordTXTToolStripMenuItem As ToolStripMenuItem
End Class
