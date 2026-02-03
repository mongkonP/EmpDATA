using EmpDATA.DATA.DBTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms.Ext.Datagridviews;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace EmpDATA
{
    public partial class frmEmp : Form
    {
        public frmEmp()
        {
            InitializeComponent();
            tblEmployeeDataGridView.SetDefaultCellStyle();
            tblShiftDataGridView.SetDefaultCellStyle();
            tblAttendanceDataGridView.SetDefaultCellStyle();
        }

        private void frmEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.tblEmployee1' table. You can move, or remove it, as needed.
            this.tblEmployee1TableAdapter.Fill(this.dB.tblEmployee1);
            // TODO: This line of code loads data into the 'dB.tblShift' table. You can move, or remove it, as needed.
            this.tblShiftTableAdapter1.Fill(this.dB.tblShift);
            // TODO: This line of code loads data into the 'dB.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.dB.tblEmployee);
            // TODO: This line of code loads data into the 'dB.tblAttendance' table. You can move, or remove it, as needed.
            this.tblAttendanceTableAdapter.Fill(this.dB.tblAttendance);


        }
        void AddTestDATA(IProgress<string> progress)
        {
            var empTA = new tblEmployeeTableAdapter();
            var shiftTA = new tblShiftTableAdapter();
            var attTA = new tblAttendanceTableAdapter();
            progress.Report("กำลังเพิ่มพนักงาน...");
            progress.Report("กำลังเพิ่มพนักงาน:EMP001");
            empTA.Insert(
         "EMP001", "มงคล", "โพธิ์ชัยหล้า",
         "โปรแกรมเมอร์", "ไอที",
         "0812345678", "mongkol@company.com", 
         new DateTime(2022, 1, 10), true
         );
            progress.Report("กำลังเพิ่มพนักงาน:EMP002");
            empTA.Insert(
                "EMP002", "สมหญิง", "ใจดี", 
                "เจ้าหน้าที่บัญชี", "บัญชี",
                "0891112233", "somying@company.com",
                new DateTime(2021, 6, 15), true
            );
            progress.Report("กำลังเพิ่มพนักงาน:EMP003");
            empTA.Insert(
                "EMP003", "อนันต์", "สุขสันต์", 
                "หัวหน้าฝ่ายผลิต", "ผลิต",
                "0829988776", "anan@company.com", 
                new DateTime(2020, 3, 1), true
            );
            progress.Report("กำลังเพิ่มพนักงาน:EMP004");
            empTA.Insert(
                "EMP004", "ปวีณา", "แสงทอง", 
                "ฝ่ายบุคคล", "HR",
                "0865554443", "paweena@company.com", 
                new DateTime(2023, 2, 20), true
            );
            progress.Report("กำลังเพิ่มพนักงาน:EMP005");
            empTA.Insert(
                "EMP005", "ธนพล", "ชัยวัฒน์", 
                "ช่างเทคนิค", "ซ่อมบำรุง",
                "0842223344", "thanapon@company.com", 
                new DateTime(2019, 11, 5), false
            );

            empTA.Fill(this.dB.tblEmployee);

            progress.Report("กำลังเพิ่มกะ...");
            shiftTA.Insert(
       new TimeSpan(7, 0, 0),
       new TimeSpan(15, 0, 0),8
   );

            shiftTA.Insert(
                new TimeSpan(7, 30, 0),
                new TimeSpan(15, 30, 0), 8
            );

            shiftTA.Insert(
                new TimeSpan(8, 0, 0),
                new TimeSpan(16, 0, 0), 8
            );

            shiftTA.Insert(
                new TimeSpan(8, 30, 0),
                new TimeSpan(16, 30, 0), 8
            );

            shiftTA.Insert(
                new TimeSpan(9, 0, 0),
                new TimeSpan(17, 0, 0), 8
            );
            shiftTA.Fill(this.dB.tblShift);
            Random random = new Random();

            for (int i = -5000; i <= 0; i++)
            {
                DateTime workDate = DateTime.Now.AddDays(i).Date;

                // ข้ามวันอาทิตย์
                if (workDate.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                progress.Report($"เพิ่มข้อมูลวันที่ {workDate}");
                for (int r = 0; r < tblEmployeeDataGridView.RowCount - 1; r++)
                {
                    int empID = Convert.ToInt32(tblEmployeeDataGridView[0, r].Value);

                    // ===== สุ่มกะ =====
                    int shiftRow = random.Next(0, tblShiftDataGridView.RowCount - 1);
                    int shiftID = Convert.ToInt32(tblShiftDataGridView[0, shiftRow].Value);

                    TimeSpan shiftStartTS = (TimeSpan)tblShiftDataGridView[1, shiftRow].Value;
                    TimeSpan shiftEndTS = (TimeSpan)tblShiftDataGridView[2, shiftRow].Value;

                    DateTime shiftStart = workDate.Date + shiftStartTS;
                    DateTime shiftEnd = workDate.Date + shiftEndTS;

                    // MessageBox.Show(empID + "\n" + shiftStartTS + " " + shiftEndTS);

                    // ===== สุ่มสถานะ =====
                    int statusRand = random.Next(100);
                    // MessageBox.Show(statusRand.ToString());
                    // ================= ขาดงาน =================
                    if (statusRand < 10)
                    {
                        attTA.Insert(
                            empID, workDate, shiftID,
                            null, null,
                            null, 0, 0, 0,
                            "Absent",null, "ขาดงาน",null
                        );
                        continue;
                    }

                    // ================= ลางาน =================
                    if (statusRand < 20)
                    {
                        attTA.Insert(
                            empID, workDate, shiftID,
                            null, null,
                            null, 0, 0, 0,
                            "Leave",
                            null, "ลางาน",
                             null
                        );
                        continue;
                    }

                    // ================= มาทำงาน =================

                    // เข้า: เร็วสุด -15 นาที / สายสุด +45 นาที
                    DateTime checkIn = shiftStart.AddMinutes(random.Next(-15, 46));

                    int lateMinutes = 0;
                    if (checkIn > shiftStart)
                        lateMinutes = (int)(checkIn - shiftStart).TotalMinutes;

                    // OT 0–120 นาที
                    int otMinutes = random.Next(0, 121);

                    DateTime checkOut = shiftEnd.AddMinutes(otMinutes);

                    int workMinutes = (int)(checkOut - checkIn).TotalMinutes;

                    attTA.Insert(
                        empID,
                        workDate,
                        shiftID,
                        checkIn,
                        checkOut,
                        workMinutes,
                        lateMinutes,
                        0,
                        otMinutes,
                        "Present",
                        null,
                        lateMinutes > 0 ? "มาสาย" : null,
                        null
                    );
                }
            }

            // TODO: This line of code loads data into the 'dB.tblAttendance' table. You can move, or remove it, as needed.
            attTA.Fill(this.dB.tblAttendance);
            progress.Report($"เสร็จสิ้นทั้งหมด");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            lblStatus.Text = "กำลังเพิ่มข้อมูล...";
            button1.Enabled = false;

            var progress = new Progress<string>(msg =>
            {
                lblStatus.Text = msg;
            });

            await Task.Run(() => AddTestDATA(progress));

            button1.Enabled = true;
            Cursor = Cursors.Default;
            MessageBox.Show("เพิ่มข้อมูลทดลองเรียบร้อยแล้ว");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime dtStart = dateTimePicker1.Value.Date;
            DateTime dtEnd = dateTimePicker2.Value.Date;

            string empIDText = txtEmpID_Find.Text.Trim();

            List<string> filters = new List<string>();

            // ===== กรองตามช่วงวันที่ =====
            filters.Add(
                $"WorkDate >= #{dtStart:yyyy-MM-dd}# AND WorkDate <= #{dtEnd:yyyy-MM-dd}#"
            );

            // ===== กรองตาม EmployeeID (ถ้ามีกรอก) =====
            if (!string.IsNullOrEmpty(empIDText))
            {
                if (int.TryParse(empIDText, out int empID))
                {
                    filters.Add($"EmployeeID = {empID}");
                }
                else
                {
                    MessageBox.Show("กรุณากรอก EmployeeID เป็นตัวเลข");
                    return;
                }
            }

            // ===== รวม filter =====
            tblAttendanceBindingSource.Filter = string.Join(" AND ", filters);
        }


        //เพิ่มข้อมูลใหม่
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            //tblAttendanceBindingSource.AddNew();
            cmbEmp.Focus();
        }
        //บันทึกข้อมูล
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblAttendanceBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dB);
            this.tblAttendanceTableAdapter.Fill(this.dB.tblAttendance);
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
        }

        private void tblAttendanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // กันคลิกหัวตาราง

            object val = tblAttendanceDataGridView[3, e.RowIndex].Value;
            if (val == null || val == DBNull.Value) return;

            int shiftID = Convert.ToInt32(val);

            tblShiftBindingSource1.Filter = $"ShiftID = {shiftID}";
        }

        private void tblEmployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblEmployeeBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dB);
            this.tblEmployeeTableAdapter.Fill(this.dB.tblEmployee);
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblShiftBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dB);
            this.tblShiftTableAdapter1.Fill(this.dB.tblShift);
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
        }
    }
}
