// See https://aka.ms/new-console-template for more information
using DateOnlyAndTimeOnly;

Console.WriteLine("DateOnly Examples!");

DateOnlyExamples.DateOnlyExample();

DateOnlyExamples.DateOnlyFromDateTimeExample();

Console.WriteLine("TimeOnly Examples!");

TimeOnlyExamples.TimeOnlyExample();

TimeOnlyExamples.TimeOnlyFromDateTimeExample();

Console.WriteLine("Combine DateOnly and TimeOnly Examples!");

DateOnly dateOnly = new DateOnly(2020, 12, 25);
TimeOnly timeOnly = new TimeOnly(12, 30, 45);
DateTime combinedDateTime = dateOnly.ToDateTime(timeOnly);

Console.WriteLine($"Combined DateTime :  {combinedDateTime}");

Console.Read();
