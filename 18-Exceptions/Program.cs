using System;
using System.Collections.Generic;
// ExceptionIntro();

// try
// {
//     Find();
// }
// catch (RecordNotFoundException exception)
// {
//     System.Console.WriteLine("Record Not Found");
//     System.Console.WriteLine(exception.Message);
//     // throw;
// }

// try catch yerine Handle Exception kullan (lambda ile fonksiyon gönderildi)
HandleException(()=>
{
    Find();
});

void HandleException(Action action)
{
    try
    {
        action.Invoke();
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

Console.ReadLine();

static void Find()
{
    List<string> students = new List<string> { "Hasan", "Ali", "Engin" };

    if (!students.Contains("Ahmet"))
    {
        throw new RecordNotFoundException("Kayıt Bulunamadı!");
        // throw new RecordNotFoundException{Message = "Kayıt Bulunamadı"}; // when contructor does not exists
    }
    else
    {
        System.Console.WriteLine("Record Found");
    }
}

static void ExceptionIntro()
{
    string[] students = new string[3] { "Hasan", "Ali", "Engin" };

    try
    {
        students[3] = "Ahmet";
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Dizi boyutu aşımı hatası");  // veritabanına loglanır.
    }

    try
    {
        students[4] = "Mehmet";
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);   // veritabanına loglanır.
    }

    try
    {
        students[4] = "Mehmet";
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Hata DivideByZero");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Hata IndexOutOfRange");
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);   // veritabanına loglanır.
    }

}