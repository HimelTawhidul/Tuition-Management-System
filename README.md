NKH TUITION MANAGEMENT SYSTEM - SETUP INSTRUCTIONS


WHAT'S BEEN FIXED / ADDED:
---------------------------
1. LOGIN FORM (NEW)
   - Username + Password login screen
   - Validates credentials against UserTbl
   - Default login: admin / admin123
   - All forms' Logout buttons now redirect to this Login page

2. DASHBOARD
   - Shows Total Students, Total Users, Net Income, Total Due
   - All stats pulled live from DB
   - Logout button works

3. STUDENT MANAGEMENT
   - Shows: StudentID, Name, Class Name, Section Name, Phone,
     Date of Birth, Address, Total Fees, Paid, Due, Attendance %
   - Add / Update / Delete / Search working
   - Download CSV button exports all student data

4. CLASS & SECTION
   - Add class + section to DB
   - Delete class (checks for students first)
   - Shows ClassID, ClassName, SectionID, SectionName in the grid
   - Logout works

5. PAYMENT
   - Shows "Missing Data" if any field is empty
   - Validates that StudentID exists
   - Shows payment history: StudentID, Name, Date, TotalFees,
     Payable, Due (TotalFees - Payable)
   - Search by StudentID filters history
   - Logout works

6. ATTENDANCE
   - Loads Class/Section from DB
   - Creates session in AttendanceTbl
   - Opens per-student entry form (Present/Absent/Late)
   - Shows summary: SessionID, Date, Class, Section,
     Total Students, Present count, Absent count
   - Export button generates a CSV for each session
   - Data persists in the DB
   - Logout works

7. USER MANAGEMENT
   - Add / Update / Delete users
   - Role fixed to Admin / Teacher only
   - Shows users in grid
   - Logout works

8. TERMINAL / CONSOLE
   - Console window is hidden on startup (no black terminal)
   - Closing the app closes all windows cleanly

  SETUP STEPS

STEP 1: Create the Database
   - Open SQL Server Management Studio (SSMS)
   - Connect to (LocalDB)\MSSQLLocalDB
   - Create a new database named: NKHDB
     OR attach your existing NKHDB.mdf file
   - Run the file: NKH_Database_Setup.sql
     (This creates all tables + seeds admin user and classes)

STEP 2: Update Connection String
   - Open: NKH Tution/Function/Function.cs
   - Find the ConStr variable
   - Update the path to your NKHDB.mdf file:
     AttachDbFilename="C:\path\to\your\NKHDB.mdf"

STEP 3: Build & Run
   - Open "NKH Tution.slnx" in Visual Studio 2022+
   - Press Ctrl+Shift+B to build
   - Press F5 to run
   - Login with: admin / admin123

  DEFAULT LOGIN
  Username: admin
  Password: admin123
