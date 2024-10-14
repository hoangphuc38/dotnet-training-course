using EFCodeFirst_Migration;

Client client = new Client();

Console.Write("Nhap ten hoc sinh can them: ");
string fullName = Console.ReadLine();
client.AddStudent(fullName);

Console.WriteLine("Danh sach tat ca hoc sinh: ");
client.GetAllStudent();
Console.WriteLine();

Console.Write("Nhap ID hoc sinh can thay doi ten: ");
string ID = Console.ReadLine();
Console.Write("Nhap ten can duoc thay doi: ");
string studentName = Console.ReadLine();
client.UpdateStudent(ID, studentName);

Console.Write("Nhap ten khoa hoc can them: ");
string title = Console.ReadLine();
Console.Write("Nhap so tin chi: ");
string credit = Console.ReadLine();
client.AddCourse(title, credit);

Console.WriteLine("Danh sach tat ca khoa hoc: ");
client.GetAllCourse();
Console.WriteLine();

Console.Write("Nhap ID hoc sinh: ");
string studentID = Console.ReadLine();
Console.Write("Nhap ID khoa hoc muon dang ky: ");
string courseID = Console.ReadLine();
client.EnrollACourse(studentID, courseID);

Console.WriteLine("Thong tin khoa hoc duoc dang ky: ");
client.GetEnrollmentInfo();

