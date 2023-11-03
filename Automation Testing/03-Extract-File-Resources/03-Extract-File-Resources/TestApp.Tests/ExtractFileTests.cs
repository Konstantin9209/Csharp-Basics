using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(null));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(string.Empty));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string result = ExtractFile.GetFile(@"C:\Folder\file.txt");
        Assert.AreEqual("File name: file\nFile extension: txt", result);
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string result = ExtractFile.GetFile(@"C:\Folder\file");
        Assert.AreEqual("File name: file", result);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string result = ExtractFile.GetFile(@"C:\Folder\my#file.name.txt");
        Assert.AreEqual("File name: my#file\nFile extension: name", result);
    }
}
