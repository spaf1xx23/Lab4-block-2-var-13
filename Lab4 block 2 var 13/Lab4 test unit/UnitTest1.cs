using Xunit;
using Lab4_block_2_var_13;

public class StudentTests
{
    [Fact]
    public void Constructor_ShouldParseDataCorrectly_AndReplaceMinusWithTwo()
    {
        string inputData = "Свідерко Ілля Дмитрович ч 23.01.2006 5 - 4 2000";

        Student testStudent = new Student(inputData);

        Assert.Equal("Свідерко", testStudent.surName);
        Assert.Equal('5', testStudent.mathematicsMark);
        Assert.Equal('2', testStudent.physicsMark);
        Assert.Equal('4', testStudent.informaticsMark);
    }

    [Fact]
    public void GetExellentStudent_WhenInformaticsIsFive_ShouldReturnTrue()
    {
        // Arrange
        string inputData = "Шевченко Тарас Григорович ч 09.03.1814 4 4 5 1500";
        Student testStudent = new Student(inputData);

        // Act
        bool isExcellent = testStudent.GetExellentStudent();

        // Assert
        Assert.True(isExcellent);
    }

    [Fact]
    public void GetExellentStudent_WhenInformaticsIsNotFive_ShouldReturnFalse()
    {
        // Arrange
        string inputData = "Косач Лариса Петрівна ж 25.02.1871 5 5 4 2000";
        Student testStudent = new Student(inputData);

        // Act
        bool isExcellent = testStudent.GetExellentStudent();

        // Assert
        Assert.False(isExcellent);
    }

    [Fact]
    public void Average_ShouldReturnCorrectAverageScore()
    {
        // Arrange (Оцінки: 5, 4, 3. Сума = 12. Середнє = 4)
        string inputData = "Франко Іван Якович ч 27.08.1856 5 4 3 2000";
        Student testStudent = new Student(inputData);

        // Act
        int calculatedAverage = testStudent.Average();

        // Assert
        Assert.Equal(4, calculatedAverage);
    }
}

