#region klasy
/*
using SecondProject;

Person bill = new Person();

bill.FirstName = "Bill";

Console.WriteLine($"{bill.FirstName} {bill.DateOfBirth}");
*/
#endregion

#region metody
/*
using SecondProject;

Person bill = new Person();

bill.FirstName = "Bill";
bill.SetDateOfBirth(new DateTime(1999, 4, 23));

bill.SayHi();
*/
#endregion

#region konstruktor
/*
using SecondProject;

Person bill = new Person("Bill", "Wick");

bill.SetDateOfBirth(new DateTime(1999, 4, 23));

bill.SayHi();

Person John = new Person(new DateTime(1990, 1, 1), "John", "Wick");

John.SayHi();
*/
#endregion

#region Właściwości klasy
/*
using SecondProject;

Person bill = new Person("Bill", "Wick");

bill.SetDateOfBirth(new DateTime(1999, 4, 23));

bill.SayHi();
bill.ContactNumber = "929999999";
Console.WriteLine(bill.ContactNumber);

Person John = new Person(new DateTime(1990, 1, 1), "John", "Wick");

John.SayHi();
*/
#endregion

#region Elementy statyczne
/*
using SecondProject;

Person bill = new Person("Bill", "Wick");

bill.SetDateOfBirth(new DateTime(1999, 4, 23));

bill.SayHi();
bill.ContactNumber = "929999999";
Console.WriteLine(bill.ContactNumber);

Person John = new Person(new DateTime(1990, 1, 1), "John", "Wick");

Console.WriteLine($"persons objects: {Person.Count}");
*/
#endregion

#region dziedziczenie
/*
using SecondProject;

ExcelFile excelFile = new ExcelFile();

excelFile.CreatedOn = DateTime.Now;
excelFile.FileName = "excel-file";

excelFile.GenerateReport();

WordDocumentFile wordDocumentFile = new WordDocumentFile();

wordDocumentFile.CreatedOn = DateTime.Now;
wordDocumentFile.FileName = "word-file";

wordDocumentFile.Print();
*/
#endregion

#region klasy abstrakcyjne

using SecondProject;

ExcelFile excelFile = new ExcelFile();

excelFile.CreatedOn = DateTime.Now;
excelFile.FileName = "excel-file";

excelFile.GenerateReport();

WordDocumentFile wordDocumentFile = new WordDocumentFile();

wordDocumentFile.CreatedOn = DateTime.Now;
wordDocumentFile.FileName = "word-file";

wordDocumentFile.Print();

#endregion