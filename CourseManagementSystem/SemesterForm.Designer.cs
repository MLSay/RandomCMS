﻿namespace CourseManagementSystem
{
    partial class SemesterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSemesterWeeks = new System.Windows.Forms.Label();
            this.txtSenesterStartDate = new System.Windows.Forms.TextBox();
            this.lblSemesterStartDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSemesterID = new System.Windows.Forms.TextBox();
            this.UnitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.mnuTeacherForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssessmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrolmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSemesterWeeks = new System.Windows.Forms.TextBox();
            this.lblSemesterForm = new System.Windows.Forms.Label();
            this.lblSemesterID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemesterWeeks
            // 
            this.lblSemesterWeeks.AutoSize = true;
            this.lblSemesterWeeks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSemesterWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterWeeks.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSemesterWeeks.Location = new System.Drawing.Point(112, 216);
            this.lblSemesterWeeks.Name = "lblSemesterWeeks";
            this.lblSemesterWeeks.Size = new System.Drawing.Size(150, 20);
            this.lblSemesterWeeks.TabIndex = 135;
            this.lblSemesterWeeks.Text = "Semester Weeks:";
            // 
            // txtSenesterStartDate
            // 
            this.txtSenesterStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenesterStartDate.Location = new System.Drawing.Point(276, 181);
            this.txtSenesterStartDate.Name = "txtSenesterStartDate";
            this.txtSenesterStartDate.Size = new System.Drawing.Size(217, 26);
            this.txtSenesterStartDate.TabIndex = 134;
            this.txtSenesterStartDate.Tag = "Semester Start Date";
            this.UnitToolTip.SetToolTip(this.txtSenesterStartDate, "Date format must be yyyy-mm-dd and contain only numeric characters");
            // 
            // lblSemesterStartDate
            // 
            this.lblSemesterStartDate.AutoSize = true;
            this.lblSemesterStartDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSemesterStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterStartDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSemesterStartDate.Location = new System.Drawing.Point(82, 184);
            this.lblSemesterStartDate.Name = "lblSemesterStartDate";
            this.lblSemesterStartDate.Size = new System.Drawing.Size(180, 20);
            this.lblSemesterStartDate.TabIndex = 133;
            this.lblSemesterStartDate.Text = "Semester Start Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Image = global::CourseManagementSystem.Properties.Resources.unnamed__1_5;
            this.btnSearch.Location = new System.Drawing.Point(458, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 28);
            this.btnSearch.TabIndex = 132;
            this.UnitToolTip.SetToolTip(this.btnSearch, "Press to search");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSemesterID
            // 
            this.txtSemesterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemesterID.Location = new System.Drawing.Point(276, 149);
            this.txtSemesterID.Name = "txtSemesterID";
            this.txtSemesterID.Size = new System.Drawing.Size(176, 26);
            this.txtSemesterID.TabIndex = 129;
            this.txtSemesterID.Tag = "Semester ID";
            // 
            // dgvUnit
            // 
            this.dgvUnit.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Location = new System.Drawing.Point(12, 303);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.Size = new System.Drawing.Size(642, 120);
            this.dgvUnit.TabIndex = 130;
            // 
            // mnuTeacherForm
            // 
            this.mnuTeacherForm.Name = "mnuTeacherForm";
            this.mnuTeacherForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.mnuTeacherForm.Size = new System.Drawing.Size(259, 22);
            this.mnuTeacherForm.Text = "Teacher Form";
            this.mnuTeacherForm.ToolTipText = "Go to teacher form";
            // 
            // mnuAssessmentForm
            // 
            this.mnuAssessmentForm.Name = "mnuAssessmentForm";
            this.mnuAssessmentForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuAssessmentForm.Size = new System.Drawing.Size(259, 22);
            this.mnuAssessmentForm.Text = "Assessment Form";
            this.mnuAssessmentForm.ToolTipText = "Go to assessment form";
            // 
            // mnuUnitForm
            // 
            this.mnuUnitForm.Name = "mnuUnitForm";
            this.mnuUnitForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.mnuUnitForm.Size = new System.Drawing.Size(259, 22);
            this.mnuUnitForm.Text = "Unit Form";
            this.mnuUnitForm.ToolTipText = "Go to unit form";
            // 
            // mnuCourseForm
            // 
            this.mnuCourseForm.Name = "mnuCourseForm";
            this.mnuCourseForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuCourseForm.Size = new System.Drawing.Size(259, 22);
            this.mnuCourseForm.Text = "Course Form";
            this.mnuCourseForm.ToolTipText = "Go to course form";
            // 
            // mnuEnrolmentForm
            // 
            this.mnuEnrolmentForm.Name = "mnuEnrolmentForm";
            this.mnuEnrolmentForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mnuEnrolmentForm.Size = new System.Drawing.Size(259, 22);
            this.mnuEnrolmentForm.Text = "Enrolment Form";
            this.mnuEnrolmentForm.ToolTipText = "Go to enrolment form";
            // 
            // mnuNavigate
            // 
            this.mnuNavigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnrolmentForm,
            this.mnuCourseForm,
            this.mnuUnitForm,
            this.mnuAssessmentForm,
            this.mnuTeacherForm});
            this.mnuNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNavigate.Name = "mnuNavigate";
            this.mnuNavigate.Size = new System.Drawing.Size(75, 20);
            this.mnuNavigate.Text = "Navigate";
            this.mnuNavigate.ToolTipText = "Navigate to enrolment form";
            // 
            // mnuViewAll
            // 
            this.mnuViewAll.Name = "mnuViewAll";
            this.mnuViewAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuViewAll.Size = new System.Drawing.Size(166, 22);
            this.mnuViewAll.Text = "View All";
            this.mnuViewAll.ToolTipText = "View All record";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUpdate.Size = new System.Drawing.Size(166, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.ToolTipText = "Update record";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeyDisplayString = "";
            this.mnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDelete.Size = new System.Drawing.Size(166, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.ToolTipText = "Delete  record";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAdd.Size = new System.Drawing.Size(166, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.ToolTipText = "Add a new record";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuDelete,
            this.mnuUpdate,
            this.mnuViewAll});
            this.mnuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(42, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.ToolTipText = "Press to add, delete, update or view all";
            // 
            // txtSemesterWeeks
            // 
            this.txtSemesterWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemesterWeeks.Location = new System.Drawing.Point(276, 213);
            this.txtSemesterWeeks.Name = "txtSemesterWeeks";
            this.txtSemesterWeeks.Size = new System.Drawing.Size(217, 26);
            this.txtSemesterWeeks.TabIndex = 136;
            this.txtSemesterWeeks.Tag = "Semester Weeks";
            // 
            // lblSemesterForm
            // 
            this.lblSemesterForm.AutoSize = true;
            this.lblSemesterForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSemesterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSemesterForm.Location = new System.Drawing.Point(243, 75);
            this.lblSemesterForm.Name = "lblSemesterForm";
            this.lblSemesterForm.Size = new System.Drawing.Size(250, 37);
            this.lblSemesterForm.TabIndex = 128;
            this.lblSemesterForm.Text = "Semester Form";
            this.lblSemesterForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSemesterID
            // 
            this.lblSemesterID.AutoSize = true;
            this.lblSemesterID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSemesterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSemesterID.Location = new System.Drawing.Point(147, 152);
            this.lblSemesterID.Name = "lblSemesterID";
            this.lblSemesterID.Size = new System.Drawing.Size(115, 20);
            this.lblSemesterID.TabIndex = 127;
            this.lblSemesterID.Text = "Semester ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 131;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(666, 436);
            this.Controls.Add(this.lblSemesterWeeks);
            this.Controls.Add(this.txtSenesterStartDate);
            this.Controls.Add(this.lblSemesterStartDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSemesterID);
            this.Controls.Add(this.dgvUnit);
            this.Controls.Add(this.txtSemesterWeeks);
            this.Controls.Add(this.lblSemesterForm);
            this.Controls.Add(this.lblSemesterID);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SemesterForm";
            this.Text = "SemesterForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemesterWeeks;
        private System.Windows.Forms.TextBox txtSenesterStartDate;
        private System.Windows.Forms.ToolTip UnitToolTip;
        private System.Windows.Forms.Label lblSemesterStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSemesterID;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.ToolStripMenuItem mnuTeacherForm;
        private System.Windows.Forms.ToolStripMenuItem mnuAssessmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuUnitForm;
        private System.Windows.Forms.ToolStripMenuItem mnuCourseForm;
        private System.Windows.Forms.ToolStripMenuItem mnuEnrolmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigate;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAll;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.TextBox txtSemesterWeeks;
        private System.Windows.Forms.Label lblSemesterForm;
        private System.Windows.Forms.Label lblSemesterID;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}