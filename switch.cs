static string ReturnSeasons(DateTime data){
    string season = "";
    switch (data.Month)
    {
        case 1:
        case 2:
        case 12:
            season = "verão";
            break;
        
        case 3:
        case 4:
        case 5:
            season = "outono";
            break;

        case 6:
        case 7:
        case 8:
            season = "inverno";
            break;

        case 9:
        case 10:
        case 11:
            season = "primavera";
            break;
    }
    return season;
    
}

Console.WriteLine($"switch 1:");
Console.WriteLine(ReturnSeasons(DateTime.Now));

////////////////outra maneira de escrever o mesmo switch//////////////////

Console.WriteLine($"switch 2:");
Console.WriteLine(ReturnSeasons2(DateTime.Now));

static string ReturnSeasons2(DateTime data) => data.Month switch
{
    >= 3 and <= 6 => "outono",
    >= 6 and <= 9 => "inverno",
    >= 9 and <=12 => "primavera",
    12 or (>= 1 and < 3) => "verão",
    _ => "Erro"
};