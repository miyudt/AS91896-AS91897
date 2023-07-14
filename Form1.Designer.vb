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
        nmudpizza7 = New NumericUpDown()
        lblpizza7 = New Label()
        nmudpizza6 = New NumericUpDown()
        lblpizza6 = New Label()
        nmudpizza4 = New NumericUpDown()
        lblpizza4 = New Label()
        nmudpizza2 = New NumericUpDown()
        lblpizza2 = New Label()
        nmudpizza5 = New NumericUpDown()
        lblpizza5 = New Label()
        nmudpizza3 = New NumericUpDown()
        lblpizza3 = New Label()
        nmudpizza1 = New NumericUpDown()
        lblpizza1 = New Label()
        lblgourmet = New Label()
        bggourmet = New Panel()
        nmudpizza11 = New NumericUpDown()
        lblpizza9 = New Label()
        lblpizza11 = New Label()
        lblpizza8 = New Label()
        nmudpizza9 = New NumericUpDown()
        nmudpizza8 = New NumericUpDown()
        lblpizza10 = New Label()
        nmudpizza12 = New NumericUpDown()
        nmudpizza10 = New NumericUpDown()
        lblpizza12 = New Label()
        btnrevieworder = New Button()
        btnreset = New Button()
        mmumain = New MenuStrip()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        OpenPasswordTXTToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        PrintDocument1 = New Printing.PrintDocument()
        bgdetails.SuspendLayout()
        bgregular.SuspendLayout()
        CType(nmudpizza7, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza6, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza4, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza5, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza1, ComponentModel.ISupportInitialize).BeginInit()
        bggourmet.SuspendLayout()
        CType(nmudpizza11, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza9, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza8, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza12, ComponentModel.ISupportInitialize).BeginInit()
        CType(nmudpizza10, ComponentModel.ISupportInitialize).BeginInit()
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
        bgregular.Controls.Add(nmudpizza7)
        bgregular.Controls.Add(lblpizza7)
        bgregular.Controls.Add(nmudpizza6)
        bgregular.Controls.Add(lblpizza6)
        bgregular.Controls.Add(nmudpizza4)
        bgregular.Controls.Add(lblregular)
        bgregular.Controls.Add(lblpizza4)
        bgregular.Controls.Add(nmudpizza2)
        bgregular.Controls.Add(lblpizza2)
        bgregular.Controls.Add(nmudpizza5)
        bgregular.Controls.Add(lblpizza5)
        bgregular.Controls.Add(nmudpizza3)
        bgregular.Controls.Add(lblpizza3)
        bgregular.Controls.Add(nmudpizza1)
        bgregular.Controls.Add(lblpizza1)
        bgregular.Location = New Point(493, 27)
        bgregular.Name = "bgregular"
        bgregular.Size = New Size(474, 250)
        bgregular.TabIndex = 6
        ' 
        ' nmudpizza7
        ' 
        nmudpizza7.Location = New Point(166, 206)
        nmudpizza7.Margin = New Padding(5, 4, 5, 4)
        nmudpizza7.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza7.Name = "nmudpizza7"
        nmudpizza7.ReadOnly = True
        nmudpizza7.Size = New Size(58, 29)
        nmudpizza7.TabIndex = 22
        ' 
        ' lblpizza7
        ' 
        lblpizza7.AutoSize = True
        lblpizza7.BackColor = Color.White
        lblpizza7.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza7.Location = New Point(6, 205)
        lblpizza7.Margin = New Padding(5, 0, 5, 0)
        lblpizza7.Name = "lblpizza7"
        lblpizza7.Size = New Size(90, 29)
        lblpizza7.TabIndex = 21
        lblpizza7.Text = "Veggie"
        ' 
        ' nmudpizza6
        ' 
        nmudpizza6.Location = New Point(395, 164)
        nmudpizza6.Margin = New Padding(5, 4, 5, 4)
        nmudpizza6.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza6.Name = "nmudpizza6"
        nmudpizza6.ReadOnly = True
        nmudpizza6.Size = New Size(58, 29)
        nmudpizza6.TabIndex = 20
        ' 
        ' lblpizza6
        ' 
        lblpizza6.AutoSize = True
        lblpizza6.BackColor = Color.White
        lblpizza6.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza6.Location = New Point(240, 163)
        lblpizza6.Margin = New Padding(5, 0, 5, 0)
        lblpizza6.Name = "lblpizza6"
        lblpizza6.Size = New Size(128, 29)
        lblpizza6.TabIndex = 19
        lblpizza6.Text = "Margherita"
        ' 
        ' nmudpizza4
        ' 
        nmudpizza4.Location = New Point(395, 121)
        nmudpizza4.Margin = New Padding(5, 4, 5, 4)
        nmudpizza4.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza4.Name = "nmudpizza4"
        nmudpizza4.ReadOnly = True
        nmudpizza4.Size = New Size(58, 29)
        nmudpizza4.TabIndex = 18
        ' 
        ' lblpizza4
        ' 
        lblpizza4.AutoSize = True
        lblpizza4.BackColor = Color.White
        lblpizza4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza4.Location = New Point(240, 120)
        lblpizza4.Margin = New Padding(5, 0, 5, 0)
        lblpizza4.Name = "lblpizza4"
        lblpizza4.Size = New Size(112, 29)
        lblpizza4.TabIndex = 17
        lblpizza4.Text = "Hawaiian"
        ' 
        ' nmudpizza2
        ' 
        nmudpizza2.Location = New Point(395, 79)
        nmudpizza2.Margin = New Padding(5, 4, 5, 4)
        nmudpizza2.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza2.Name = "nmudpizza2"
        nmudpizza2.ReadOnly = True
        nmudpizza2.Size = New Size(58, 29)
        nmudpizza2.TabIndex = 16
        ' 
        ' lblpizza2
        ' 
        lblpizza2.AutoSize = True
        lblpizza2.BackColor = Color.White
        lblpizza2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza2.Location = New Point(240, 78)
        lblpizza2.Margin = New Padding(5, 0, 5, 0)
        lblpizza2.Name = "lblpizza2"
        lblpizza2.Size = New Size(131, 29)
        lblpizza2.TabIndex = 15
        lblpizza2.Text = "Meatlovers"
        ' 
        ' nmudpizza5
        ' 
        nmudpizza5.Location = New Point(166, 164)
        nmudpizza5.Margin = New Padding(5, 4, 5, 4)
        nmudpizza5.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza5.Name = "nmudpizza5"
        nmudpizza5.ReadOnly = True
        nmudpizza5.Size = New Size(58, 29)
        nmudpizza5.TabIndex = 14
        ' 
        ' lblpizza5
        ' 
        lblpizza5.AutoSize = True
        lblpizza5.BackColor = Color.White
        lblpizza5.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza5.Location = New Point(6, 163)
        lblpizza5.Margin = New Padding(5, 0, 5, 0)
        lblpizza5.Name = "lblpizza5"
        lblpizza5.Size = New Size(63, 29)
        lblpizza5.TabIndex = 13
        lblpizza5.Text = "Ham"
        ' 
        ' nmudpizza3
        ' 
        nmudpizza3.Location = New Point(166, 121)
        nmudpizza3.Margin = New Padding(5, 4, 5, 4)
        nmudpizza3.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza3.Name = "nmudpizza3"
        nmudpizza3.ReadOnly = True
        nmudpizza3.Size = New Size(58, 29)
        nmudpizza3.TabIndex = 12
        ' 
        ' lblpizza3
        ' 
        lblpizza3.AutoSize = True
        lblpizza3.BackColor = Color.White
        lblpizza3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza3.Location = New Point(6, 120)
        lblpizza3.Margin = New Padding(5, 0, 5, 0)
        lblpizza3.Name = "lblpizza3"
        lblpizza3.Size = New Size(97, 29)
        lblpizza3.TabIndex = 11
        lblpizza3.Text = "Cheese"
        ' 
        ' nmudpizza1
        ' 
        nmudpizza1.Location = New Point(166, 79)
        nmudpizza1.Margin = New Padding(5, 4, 5, 4)
        nmudpizza1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza1.Name = "nmudpizza1"
        nmudpizza1.ReadOnly = True
        nmudpizza1.Size = New Size(58, 29)
        nmudpizza1.TabIndex = 10
        ' 
        ' lblpizza1
        ' 
        lblpizza1.AutoSize = True
        lblpizza1.BackColor = Color.White
        lblpizza1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza1.Location = New Point(6, 78)
        lblpizza1.Margin = New Padding(5, 0, 5, 0)
        lblpizza1.Name = "lblpizza1"
        lblpizza1.Size = New Size(126, 29)
        lblpizza1.TabIndex = 9
        lblpizza1.Text = "Pepperoni"
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
        bggourmet.Controls.Add(nmudpizza11)
        bggourmet.Controls.Add(lblpizza9)
        bggourmet.Controls.Add(lblpizza11)
        bggourmet.Controls.Add(lblpizza8)
        bggourmet.Controls.Add(nmudpizza9)
        bggourmet.Controls.Add(nmudpizza8)
        bggourmet.Controls.Add(lblpizza10)
        bggourmet.Controls.Add(nmudpizza12)
        bggourmet.Controls.Add(nmudpizza10)
        bggourmet.Controls.Add(lblpizza12)
        bggourmet.Location = New Point(493, 283)
        bggourmet.Name = "bggourmet"
        bggourmet.Size = New Size(474, 246)
        bggourmet.TabIndex = 8
        ' 
        ' nmudpizza11
        ' 
        nmudpizza11.Location = New Point(395, 118)
        nmudpizza11.Margin = New Padding(5, 4, 5, 4)
        nmudpizza11.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza11.Name = "nmudpizza11"
        nmudpizza11.ReadOnly = True
        nmudpizza11.Size = New Size(58, 29)
        nmudpizza11.TabIndex = 32
        ' 
        ' lblpizza9
        ' 
        lblpizza9.AutoSize = True
        lblpizza9.BackColor = Color.White
        lblpizza9.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza9.Location = New Point(240, 75)
        lblpizza9.Margin = New Padding(5, 0, 5, 0)
        lblpizza9.Name = "lblpizza9"
        lblpizza9.Size = New Size(142, 29)
        lblpizza9.TabIndex = 29
        lblpizza9.Text = "Beef+Onion"
        ' 
        ' lblpizza11
        ' 
        lblpizza11.AutoSize = True
        lblpizza11.BackColor = Color.White
        lblpizza11.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza11.Location = New Point(240, 117)
        lblpizza11.Margin = New Padding(5, 0, 5, 0)
        lblpizza11.Name = "lblpizza11"
        lblpizza11.Size = New Size(128, 29)
        lblpizza11.TabIndex = 31
        lblpizza11.Text = "Americano"
        ' 
        ' lblpizza8
        ' 
        lblpizza8.AutoSize = True
        lblpizza8.BackColor = Color.White
        lblpizza8.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza8.Location = New Point(6, 75)
        lblpizza8.Margin = New Padding(5, 0, 5, 0)
        lblpizza8.Name = "lblpizza8"
        lblpizza8.Size = New Size(141, 29)
        lblpizza8.TabIndex = 23
        lblpizza8.Text = "New Yorker"
        ' 
        ' nmudpizza9
        ' 
        nmudpizza9.Location = New Point(395, 76)
        nmudpizza9.Margin = New Padding(5, 4, 5, 4)
        nmudpizza9.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza9.Name = "nmudpizza9"
        nmudpizza9.ReadOnly = True
        nmudpizza9.Size = New Size(58, 29)
        nmudpizza9.TabIndex = 30
        ' 
        ' nmudpizza8
        ' 
        nmudpizza8.Location = New Point(166, 76)
        nmudpizza8.Margin = New Padding(5, 4, 5, 4)
        nmudpizza8.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza8.Name = "nmudpizza8"
        nmudpizza8.ReadOnly = True
        nmudpizza8.Size = New Size(58, 29)
        nmudpizza8.TabIndex = 24
        ' 
        ' lblpizza10
        ' 
        lblpizza10.AutoSize = True
        lblpizza10.BackColor = Color.White
        lblpizza10.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza10.Location = New Point(6, 117)
        lblpizza10.Margin = New Padding(5, 0, 5, 0)
        lblpizza10.Name = "lblpizza10"
        lblpizza10.Size = New Size(78, 29)
        lblpizza10.TabIndex = 25
        lblpizza10.Text = "Super"
        ' 
        ' nmudpizza12
        ' 
        nmudpizza12.Location = New Point(166, 161)
        nmudpizza12.Margin = New Padding(5, 4, 5, 4)
        nmudpizza12.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza12.Name = "nmudpizza12"
        nmudpizza12.ReadOnly = True
        nmudpizza12.Size = New Size(58, 29)
        nmudpizza12.TabIndex = 28
        ' 
        ' nmudpizza10
        ' 
        nmudpizza10.Location = New Point(166, 118)
        nmudpizza10.Margin = New Padding(5, 4, 5, 4)
        nmudpizza10.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nmudpizza10.Name = "nmudpizza10"
        nmudpizza10.ReadOnly = True
        nmudpizza10.Size = New Size(58, 29)
        nmudpizza10.TabIndex = 26
        ' 
        ' lblpizza12
        ' 
        lblpizza12.AutoSize = True
        lblpizza12.BackColor = Color.White
        lblpizza12.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblpizza12.Location = New Point(6, 160)
        lblpizza12.Margin = New Padding(5, 0, 5, 0)
        lblpizza12.Name = "lblpizza12"
        lblpizza12.Size = New Size(152, 29)
        lblpizza12.TabIndex = 27
        lblpizza12.Text = "Loaded BBQ"
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
        ChangePasswordToolStripMenuItem.Size = New Size(295, 22)
        ChangePasswordToolStripMenuItem.Text = "Change Password"
        ' 
        ' OpenPasswordTXTToolStripMenuItem
        ' 
        OpenPasswordTXTToolStripMenuItem.Name = "OpenPasswordTXTToolStripMenuItem"
        OpenPasswordTXTToolStripMenuItem.Size = New Size(295, 22)
        OpenPasswordTXTToolStripMenuItem.Text = "Open Password TXT (For Troubleshooting)"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(295, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' PrintDocument1
        ' 
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
        CType(nmudpizza7, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza6, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza4, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza2, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza5, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza3, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza1, ComponentModel.ISupportInitialize).EndInit()
        bggourmet.ResumeLayout(False)
        bggourmet.PerformLayout()
        CType(nmudpizza11, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza9, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza8, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza12, ComponentModel.ISupportInitialize).EndInit()
        CType(nmudpizza10, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblpizza1 As Label
    Friend WithEvents nmudpizza1 As NumericUpDown
    Friend WithEvents nmudpizza5 As NumericUpDown
    Friend WithEvents lblpizza5 As Label
    Friend WithEvents nmudpizza3 As NumericUpDown
    Friend WithEvents lblpizza3 As Label
    Friend WithEvents nmudpizza7 As NumericUpDown
    Friend WithEvents lblpizza7 As Label
    Friend WithEvents nmudpizza6 As NumericUpDown
    Friend WithEvents lblpizza6 As Label
    Friend WithEvents nmudpizza4 As NumericUpDown
    Friend WithEvents lblpizza4 As Label
    Friend WithEvents nmudpizza2 As NumericUpDown
    Friend WithEvents lblpizza2 As Label
    Friend WithEvents nmudpizza11 As NumericUpDown
    Friend WithEvents lblpizza9 As Label
    Friend WithEvents lblpizza11 As Label
    Friend WithEvents lblpizza8 As Label
    Friend WithEvents nmudpizza9 As NumericUpDown
    Friend WithEvents nmudpizza8 As NumericUpDown
    Friend WithEvents lblpizza10 As Label
    Friend WithEvents nmudpizza12 As NumericUpDown
    Friend WithEvents nmudpizza10 As NumericUpDown
    Friend WithEvents lblpizza12 As Label
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
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
