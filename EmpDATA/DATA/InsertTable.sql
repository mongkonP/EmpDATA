CREATE TABLE tblEmployee (
    EmployeeID      INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeCode    VARCHAR(20) NOT NULL UNIQUE,
    FirstName       NVARCHAR(100) NOT NULL,
    LastName        NVARCHAR(100) NOT NULL,
    Position        NVARCHAR(100),
    Department      NVARCHAR(100),

    Phone           VARCHAR(20),
    Email           VARCHAR(150),

    ResignDate      DATE NULL,              -- วันที่ลาออก (สำคัญมาก)
    IsActive        BIT DEFAULT 1,

);
CREATE TABLE tblShift (
    ShiftID     INT IDENTITY(1,1) PRIMARY KEY,
    StartTime   TIME NOT NULL,
    EndTime     TIME NOT NULL,
    WorkHours   DECIMAL(4,2) DEFAULT 8.00,  -- ชั่วโมงทำงานมาตรฐาน

);

CREATE TABLE tblAttendance (
    AttendanceID       INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID         INT NOT NULL,
    WorkDate           DATE NOT NULL,
    ShiftID            INT NULL,
    CheckInTime        DATETIME NULL,
    CheckOutTime       DATETIME NULL,
    WorkMinutes        INT NULL,         -- นาทีทำงานจริง
    LateMinutes        INT DEFAULT 0,     -- สาย
    EarlyLeaveMinutes INT DEFAULT 0,     -- กลับก่อน
    OTMinutes          INT DEFAULT 0,     -- OT

    WorkStatus         VARCHAR(100) NOT NULL,  -- Present/Absent/Leave/Off
    -- P = Present
    -- A = Absent
    -- L = Leave
    -- O = Off / Holiday

    Remark             NVARCHAR(200),

    ApprovedBy         NVARCHAR(100) NULL,
    ApprovedDate       DATETIME NULL,

    CONSTRAINT UQ_Attendance UNIQUE (EmployeeID, WorkDate),
    CONSTRAINT FK_Att_Emp FOREIGN KEY (EmployeeID) REFERENCES tblEmployee(EmployeeID),
    CONSTRAINT FK_Att_Shift FOREIGN KEY (ShiftID) REFERENCES tblShift(ShiftID),
    CONSTRAINT CK_Att_WorkStatus CHECK (WorkStatus IN ('Present','Absent','Leave','Off'))
);


CREATE VIEW vwAttendanceSummary
AS
SELECT
    e.EmployeeID,
    e.EmployeeCode,
    e.FirstName,
    e.LastName,
    e.Position,
    e.Department,

    a.WorkDate,

    s.StartTime   AS ShiftStart,
    s.EndTime     AS ShiftEnd,

    a.CheckInTime,
    a.CheckOutTime,

    -- ชั่วโมงทำงานจริง
    CASE 
        WHEN a.CheckInTime IS NOT NULL 
         AND a.CheckOutTime IS NOT NULL
        THEN CAST(DATEDIFF(MINUTE, a.CheckInTime, a.CheckOutTime) / 60.0 AS DECIMAL(5,2))
        ELSE 0
    END AS WorkHoursActual,

    -- สถานะ
    a.WorkStatus,

    -- มาสาย
    CASE 
        WHEN a.WorkStatus = 'Present'
         AND a.CheckInTime IS NOT NULL
         AND s.StartTime IS NOT NULL
         AND CAST(a.CheckInTime AS TIME) > s.StartTime
        THEN DATEDIFF(
                MINUTE,
                s.StartTime,
                CAST(a.CheckInTime AS TIME)
             )
        ELSE 0
    END AS LateMinutes,

    a.EarlyLeaveMinutes,
    a.OTMinutes,

    -- ข้อความสถานะอ่านง่าย
    CASE a.WorkStatus
        WHEN 'Present' THEN 'มาทำงาน'
        WHEN 'Absent'  THEN 'ขาดงาน'
        WHEN 'Leave'   THEN 'ลางาน'
        WHEN 'Off'     THEN 'หยุด'
    END AS WorkStatusText,

    a.Remark

FROM tblAttendance a
INNER JOIN tblEmployee e ON a.EmployeeID = e.EmployeeID
LEFT JOIN tblShift s ON a.ShiftID = s.ShiftID;
