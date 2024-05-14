using System;
using System.IO;

#region Task 1: Check if file exists
Console.WriteLine("Task 1:");
string file = "file.txt";
try
{
    if (File.Exists(file))
    {
        Console.WriteLine("Fayl tapıldı");
    }
    else
    {
        Console.WriteLine("Fayl movcud deyil");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 2: Delete file if exists
Console.WriteLine("Task 2:");
string testfile = "test.txt";
try
{
    if (File.Exists(testfile))
    {
        File.Delete(testfile);
        Console.WriteLine("Fayl silindi");
    }
    else
    {
        Console.WriteLine("Fayl tapılmadı");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 3: Copy existing file
Console.WriteLine("Task 3:");
string sourceFile = "existingFile.txt";
string destinationFile = "copyOfFile.txt";
try
{
    if (File.Exists(sourceFile))
    {
        File.Copy(sourceFile, destinationFile);
        Console.WriteLine("Fayl kopyalandı");
    }
    else
    {
        Console.WriteLine("Fayl movcud deyil");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 4: Rename existing file
Console.WriteLine("Task 4:");
string oldFileName = "oldName.txt";
string newFileName = "newName.txt";
try
{
    if (File.Exists(oldFileName))
    {
        File.Move(oldFileName, newFileName);
        Console.WriteLine("Fayl adı deyishdirildi");
    }
    else
    {
        Console.WriteLine("Fayl movcud deyil");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 5: Get file size
Console.WriteLine("Task 5:");
string fileToCheck = "fileToCheck.txt";
try
{
    if (File.Exists(fileToCheck))
    {
        long fileSizeInBytes = new FileInfo(fileToCheck).Length;
        Console.WriteLine("File olchusu: " + fileSizeInBytes + " bytes");
    }
    else
    {
        Console.WriteLine("Fayl movcud deyil");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 6: List all files in Downloads folder
Console.WriteLine("Task 6:");
string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
try
{
    string[] filesInDownloads = Directory.GetFiles(downloadFolderPath);
    foreach (string filePath in filesInDownloads)
    {
        Console.WriteLine(filePath);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 7: Get file creation date
Console.WriteLine("Task 7:");
string fileToCheckCreationDate = "fileToCheckCreationDate.txt";
try
{
    if (File.Exists(fileToCheckCreationDate))
    {
        DateTime creationDate = File.GetCreationTime(fileToCheckCreationDate);
        Console.WriteLine("File yaradilma tarixi: " + creationDate);
    }
    else
    {
        Console.WriteLine("Fayl movcud deyil");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Task 8: List only "*.txt" files in a folder
Console.WriteLine("Task 8:");
string folderPath = Directory.GetCurrentDirectory();
try
{
    if (Directory.Exists(folderPath))
    {
        string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");
        foreach (string txtFile in txtFiles)
        {
            Console.WriteLine(txtFile);
        }
    }
    else
    {
        Console.WriteLine("Folder movcud deyil");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
