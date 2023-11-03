using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(100m, new List<int> { 7, 8 }, new List<string> { "10" }));
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(100m, new List<int> { 7, 8 }, new List<string> { "no number", "Hit it again, Gabsy!" }));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        string result = DrumSet.Drum(100m, new List<int> { 7, 8 }, new List<string> { "5", "Hit it again, Gabsy!" });
        Assert.AreEqual("2 3\nGabsy has 100.00lv.", result);
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        string result = DrumSet.Drum(24m, new List<int> { 7, 8 }, new List<string> { "10", "Hit it again, Gabsy!" });
        Assert.AreEqual("7\nGabsy has 3.00lv.", result);
    }


    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        string result = DrumSet.Drum(5m, new List<int> { 7, 8 }, new List<string> { "10", "Hit it again, Gabsy!" });
        Assert.AreEqual("\nGabsy has 5.00lv.", result);
    }
}
