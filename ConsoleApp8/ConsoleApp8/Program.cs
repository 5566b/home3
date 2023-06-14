//январь(зима)
//февраль(зима)
//март(весна)
//апрель(весна)
//май(весна)
//июнь(лето)
//июль(лето)
//август(лето)
//сентябрь(осень)
//октябрь(осень)
//ноябрь(осень)
//декабрь(зима)

Console.WriteLine("enter the mesec");

var input = Console.ReadLine();


switch (input)
{
    case "январь":
        Console.WriteLine("зима");
        break;

    case "февраль":
        Console.WriteLine("зима");
        break;

    case "декабрь":
        Console.WriteLine("зима");
        break;

    case "март":
        Console.WriteLine("весна");
        break;

    case "апрель":
        Console.WriteLine("весна");
        break;
             case "май":
        Console.WriteLine("весна");
        break;
    case "июнь":
        Console.WriteLine("лето");
        break;

    case "июль":
        Console.WriteLine("лето");
        break;

    case "август":
        Console.WriteLine("лето");
        break;

    case "сеньтябрь":
        Console.WriteLine("осень");
        break;

    case "октябрь":
        Console.WriteLine("осень");
        break;

    case "ноябрь":
        Console.WriteLine("осень");
        break;
}


