// See https://aka.ms/new-console-template for more information
//Bài 1
using System.Text;

string name = "Hello World";
string updateName = name.Substring(6);
Console.WriteLine("Câu 1: " + updateName);
//Bài 2
string replaceName = name.Replace("o", "f");
Console.WriteLine("Câu 2: " + replaceName);
//Bài 3
int countName = 0;

for (int i = 0; i <= name.Length - 1; i++)
{
    if (name[i] == 'l')
    {
        countName++;
    }
}
Console.WriteLine("Câu 3: " + countName);
// Bài 4:
int firstName = name.IndexOf("l");
Console.WriteLine("Câu 4: Vị trí đầu tiên của phần tử l: " + firstName);
int lastName = name.LastIndexOf("l");
Console.WriteLine("Câu 4: Vị trí cuối cùng của phần tử l: " + lastName);

//Bài 5:
string  deleteSpaceName = name.Trim().Replace(" ", "");
Console.WriteLine("Câu 5: Xoá space đầu, giữa, cuối :" + deleteSpaceName);
string deleteBetweenSpaceName  = name.Trim().Replace(" ", " ");
Console.WriteLine("Câu 5: Xoá space đầu, cuối :" + deleteBetweenSpaceName);

//Bài 7
string revertName = "";
for (int i = name.Length - 1; i >= 0; i--)
{
    revertName += name[i];
}
Console.WriteLine("Câu 7: Dao nguoc chuoi: " + revertName);

// Bài 8:
//Cách 1
string helloName = "Hello";
string helloWorld = "World";
string newName  = helloName + " " +helloWorld;
Console.WriteLine("Câu 8: Chuỗi mới: " + newName);
//Cách 2
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append(helloName + " ");
stringBuilder.Append(helloWorld);
string result = stringBuilder.ToString();
Console.WriteLine("Câu 9: Chuỗi mới: " + result);

//Bài 9: 
string s = "Tuổi của tôi là :";
int number = 25;
string kq = s + number;
Console.WriteLine("Câu 9: Nối chuỗi:" +kq);

//Bài 10
Console.WriteLine("Nhập vào 1 chuỗi: ");
string nhapchuoi = Console.ReadLine();
string kqchuoi = "";
for(int i = nhapchuoi.Length - 1; i >= 0; i--)
{
    kqchuoi += nhapchuoi[i];
}
Console.WriteLine("Chuoi dao nguoc: " + kqchuoi);
Console.WriteLine("In hoa chuỗi: " + nhapchuoi.ToUpper());
Console.WriteLine("In thường chuỗi: " + nhapchuoi.ToLower());

Dictionary<char, int> checkKytu = new Dictionary<char, int>();
foreach(char ch in kqchuoi)
{
    if (checkKytu.ContainsKey(ch))
    {
        checkKytu[ch]++;
    }
    else
    {
        checkKytu.Add(ch, 1);
    }
}

Console.WriteLine("\n Bảng tần số ký tự xuất hiện: ");
foreach (var item in checkKytu)
{
    Console.Write(item.Key + ": ");
    Console.WriteLine(new string('*', item.Value));
}
// Câu e 
Console.WriteLine("Nhập chỉ số m :");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Nhập chỉ số n :");
int n = Int32.Parse(Console.ReadLine());
if (n >= 0 && m < nhapchuoi.Length && n <= m)
{
    string substring = nhapchuoi.Substring(n, m - n + 1);
    Console.WriteLine("Chuỗi con từ vị trí " + n + " đến " + m + " là: " + substring);
}
else
{
    Console.WriteLine("Vị trí nhập không hợp lệ.");
}
// Câu 11: 
string inputString = "123";
int numberFromString = int.Parse(inputString);
Console.WriteLine("Câu 11: Chuyển đổi chuỗi sang số nguyên: " + numberFromString);
int inputNumber = 456;
string stringFromNumber = inputNumber.ToString();
Console.WriteLine("Câu 11: Chuyển đổi số nguyên sang chuỗi: " + stringFromNumber);
long stringFromLong =  long.Parse(inputString);
Console.WriteLine("Câu 11: Chuyển đổi chuỗi sang số nguyên dài: " + stringFromLong);
float floatFromString = float.Parse(inputString);
Console.WriteLine("Câu 11: Chuyển đổi chuỗi sang số thực: " + floatFromString);
float floatNumber = 789.12f;
string stringFromFloat = floatNumber.ToString();
Console.WriteLine("Câu 11: Chuyển đổi số thực sang chuỗi: " + stringFromFloat);
double doubleFromString = double.Parse(inputString);
Console.WriteLine("Câu 11: Chuyển đổi chuỗi sang số thực: " + doubleFromString);
string stringFromDouble = doubleFromString.ToString();
Console.WriteLine("Câu 11: Chuyển đổi số thực sang chuỗi: " + stringFromDouble);
short shortFromString = short.Parse(inputString);
Console.WriteLine("Câu 11: Chuyển đổi chuỗi sang số nguyên ngắn: " + shortFromString);
string stringFromShort = shortFromString.ToString();
Console.WriteLine("Câu 11: Chuyển đổi số nguyên ngắn sang chuỗi: " + stringFromShort);
DateTime date = DateTime.Now;
string dateString = date.ToString("yyyy-MM-dd");
Console.WriteLine("Câu 11: Chuyển đổi ngày giờ sang chuỗi: " + dateString);

//Bài 12:
Console.WriteLine("Nhập vào một chuỗi a: ");
string a = Console.ReadLine();
Console.WriteLine("Nhập vào một chuỗi b: ");
string b = Console.ReadLine();
if( a.Length > b.Length)
{
    Console.WriteLine("Chuỗi a dài hơn chuỗi b.");
}
else if( a.Length < b.Length)
{
    Console.WriteLine("Chuỗi b dài hơn chuỗi a.");
}
else
{
    Console.WriteLine("Chuỗi a và b có độ dài bằng nhau.");
}
//Bài 13:
if( a.IndexOf(b) != -1)
{
    Console.WriteLine("Chuỗi b là chuỗi con của chuỗi a.");
}
else
{
    Console.WriteLine("Chuỗi b không phải là chuỗi con của chuỗi a.");
}
//Cách 2:
if( a.Contains(b))
{
    Console.WriteLine("Chuỗi b là chuỗi con của chuỗi a.");
}
else
{
    Console.WriteLine("Chuỗi b không phải là chuỗi con của chuỗi a.");
}
//Câu 14
if(a.Equals(b))
{
    Console.WriteLine("Chuỗi a và b là giống nhau.");
}
else
{
    Console.WriteLine("Chuỗi a và b là khác nhau.");
}
