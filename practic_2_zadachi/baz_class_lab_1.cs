using System;

public abstract class LabWorkBase
{
    protected string StudentName { get; set; }
    protected string GroupName { get; set; }

    // Конструктор
    public LabWorkBase(string studentName, string groupName)
    {
        StudentName = studentName;
        GroupName = groupName;
    }

    // Абстрактный метод для выполнения лабораторной работы
    public abstract void Execute();

    // Метод для вывода результата выполнения
    public virtual void PrintResult()
    {
        Console.WriteLine($"Лабораторная работа №1 выполнена студентом {StudentName}, группа {GroupName}");
        Console.WriteLine("Результат:");
        // В данном методе нужно вывести результат выполнения лабораторной работы
    }
}
// Вариант лабораторной работы №1.1
public class LabWorkVariant1_1 : LabWorkBase
{
    public LabWorkVariant1_1(string studentName, string groupName) : base(studentName, groupName) { }

    public override void Execute()
    {
        // Реализация выполнения для варианта 1.1
    }

    public override void PrintResult()
    {
        base.PrintResult(); // Выводит информацию о студенте и заголовок "Результат:"
                            // Выводит результат выполнения варианта 1.1
    }
}

// Вариант лабораторной работы №1.2
public class LabWorkVariant1_2 : LabWorkBase
{
    public LabWorkVariant1_2(string studentName, string groupName) : base(studentName, groupName) { }

    public override void Execute()
    {
        // Реализация выполнения для варианта 1.2
    }

    public override void PrintResult()
    {
        base.PrintResult(); // Выводит информацию о студенте и заголовок "Результат:"
                            // Выводит результат выполнения варианта 1.2
    }
}

// ... 