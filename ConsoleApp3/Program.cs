// See https://aka.ms/new-console-template for more information

Programmer p = new Programmer();
Rasch rasch = new Rasch();
Console.WriteLine("Введите фамилию программиста:");
p.Fam = Console.ReadLine();
Console.WriteLine("Введите число программ, написанных программистом:");
p.numOfProg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число языков, которыми он пишет программы:");
p.numOfLang = Convert.ToInt32(Console.ReadLine());
int Q1 = p.Quality1();
int Qp1 = rasch.Quality2(Q1, p.numOfProg);
Console.WriteLine($"Фамилия: {p.Fam}\nЧисло программ:{p.numOfProg}\nЧисло языков программирования:{p.numOfLang}\nQ = {Q1}\nQp = {Qp1}");


class Programmer 
{
    public string Fam;
    public int numOfProg;
    public int numOfLang;
    public int Q;

    public int Quality1()
    {
        Q = numOfProg * numOfLang;
        return Q;
    }
}

class Rasch 
{
    Programmer p1 = new Programmer();
    int P;
    int Qp;
    public int Quality2(int Q, int nFp) 
    {
        bool Prov = false;
        Console.WriteLine("Введите число программ программиста, которые работают правильно:");
        while (Prov == false) 
        {
            P = Convert.ToInt32(Console.ReadLine());
            if (P <= nFp) 
            { 
             Prov = true;
            }
            else 
            { 
             Prov=false;
            }
        }
        
            
        Qp = Q * P;
        return Qp;
    }
}

