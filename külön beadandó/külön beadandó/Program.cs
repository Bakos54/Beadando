Console.WriteLine("Adaja meg a gépek számát");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Adja mega munkák számát");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem adjon meg a fájl nevét és kiterjesztését:");
string nev = Console.ReadLine();
Kell[,] matrix = new Kell[a,b];
using (StreamReader sr = new StreamReader(nev))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        string[] sorfelbont = line.Split(',');
        matrix[Convert.ToInt16(sorfelbont[0])-1, Convert.ToInt16(sorfelbont[1])-1] = new Kell(Convert.ToInt16( sorfelbont[2]), Convert.ToInt16( sorfelbont[3]));
    }
}
bool jó = true;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
        if (i == 0)
        {
            if (matrix[i, j].bef <= matrix[i, j + 1].kezd) ;
            else jó = false;
        }
        else
        {
            if (matrix[i, j].bef <= matrix[i, j + 1].kezd)
            {

                if (matrix[i - 1, j].bef <= matrix[i, j].kezd) ;
                else jó = false;
            }
        }
    }
}
if (jó) Console.WriteLine("A megoldás helyes");
else Console.WriteLine("Helytelen a megoldás");
struct Kell
{

    public int kezd;
    public int bef;

    public Kell(int kezd, int bef)
    {
        this.bef = bef;
        this.kezd = kezd;
    }

}