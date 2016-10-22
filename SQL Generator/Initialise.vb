﻿Friend Class Initialise

#Region "New Table Initialisers"
    Shared Sub NewTable()

        Home.CreateTable_CreateBtn.Enabled = True
        Home.CreateTable_NameFld.Text = ""
        Home.CreateTable_NameFld.Enabled = True

        NewField()

        Keys()

        Check()

        Constraints()

    End Sub
    Shared Sub NewField()

        Home.FieldDetails_ColumnNameFld.Text = ""
        Home.FieldDetails_ColumnTYpeCmbo.SelectedIndex = -1
        Home.FieldDetails_Size.Value = 0
        Home.FieldDetails_Size.Enabled = False
        Home.FieldDetails_Precision.Enabled = False
        Home.FieldDetails_Scale.Enabled = False
        Home.FieldDetails_Precision.Value = 0
        Home.FieldDetails_Scale.Value = 0
        Home.FieldDetails_DefFld.Text = ""
        Home.FieldDetails_DefValChkbx.Checked = False
        Home.FieldDetails_FormulaChkbx.Checked = False
        Home.FieldDetails_FormulaChkbx.Enabled = False

        Keys()

        Check()

        Constraints()
    End Sub
    Shared Sub ReferenceComponents()

        Home.FieldDetails_OnUpdateChkBx.Enabled = False
        Home.FieldDetails_OnUpdateCmbo.Enabled = False
        Home.FieldDetails_OnDeleteCmbo.Enabled = False
        Home.FieldDetails_OnDeleteChkbx.Enabled = False
        Home.FieldDetails_OnUpdateCmbo.SelectedIndex = -1
        Home.FieldDetails_OnDeleteCmbo.SelectedIndex = -1
        Home.FieldDetails_OnUpdateChkBx.Checked = False
        Home.FieldDetails_OnDeleteChkbx.Checked = False
        Home.FieldDetails_ReferenceFld.Text = ""
        Home.FieldDetails_ReferenceFld.Enabled = False
        Home.FieldDetails_ReferenceChkBx.Checked = False

    End Sub
    Shared Sub Keys()
        Home.FieldDetails_PrimFld.Text = ""
        Home.FieldDetails_ForeignKeyFld.Text = ""
        ReferenceComponents()
        Constraints()
    End Sub
    Shared Sub Check()
        Home.FieldDetails_CheckTypeCmbo.SelectedIndex = -1
        Home.FieldDetails_CheckPstnCmbo.SelectedIndex = -1
        Home.FieldDetails_CheckTypeCmbo.Enabled = False
        Home.FieldDetails_CheckPstnCmbo.Enabled = False
        Home.FieldDetails_CheckFld.Text = ""
        Home.FieldDetails_CheckChkbx.Checked = False
    End Sub
    Shared Sub Constraints()
        Home.FieldDetails_ConstraintGrp.Enabled = True
        Home.FieldDetails_PrimChkbx.Checked = False
        Home.FieldDetails_NotNullChkbx.Checked = False
        Home.FieldDetails_UniqueChkbx.Checked = False
    End Sub

#End Region

    Shared Sub DropTable()

        Home.TableName.Text = ""
    End Sub
    Shared Sub Database()
        Home.Database_NameFld.Text = ""
    End Sub
    Shared Sub TableUpdate()

        Home.InsertTable.Text = ""
        Home.Specify_CheckBox.Checked = False
        Home.Columns.Text = ""
        Home.DataItemsGroup.Text = "Data Items"
        Home.DataItems.Text = ""

    End Sub

#Region "Alter Table Initialisers"
    Shared Sub Rename()
        Home.NewTableName.Text = ""
    End Sub
    Shared Sub DropColumn()
        Home.Alter_Drop_Table.Text = ""
    End Sub
    Shared Sub Alter_table()
        Home.Alter_Table_Name.Text = ""

        DropColumn()
        Rename()
        NewField()

    End Sub
#End Region

End Class