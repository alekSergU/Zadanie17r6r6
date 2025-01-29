Obychnyi obychnyi = new Obychnyi();
Zarplatnyi zarplatnyi = new Zarplatnyi();

Calculator.PopolnenieSnyatie(zarplatnyi, 700);  //  пополнение
Calculator.PopolnenieSnyatie(obychnyi, 1200);
Pokazer.ShowBalance(zarplatnyi);
Pokazer.ShowBalance(obychnyi);
Console.WriteLine("\n");

Calculator.CalculateInterest(zarplatnyi);   //  расчёт процентов
Calculator.CalculateInterest(obychnyi);
Pokazer.ShowInterest(zarplatnyi);
Pokazer.ShowInterest(obychnyi);
Console.WriteLine("\n");

Calculator.PopolnenieSnyatie(zarplatnyi, -700);  //  снятие
Calculator.PopolnenieSnyatie(obychnyi, -700);
Pokazer.ShowBalance(zarplatnyi);
Pokazer.ShowBalance(obychnyi);
Console.WriteLine("\n");

Calculator.CalculateInterest(zarplatnyi);   //  расчёт процентов
Calculator.CalculateInterest(obychnyi);
Pokazer.ShowInterest(zarplatnyi);
Pokazer.ShowInterest(obychnyi);