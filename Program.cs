int [] a;
a= new int[20];
int j;
j=0;
for (int i=0;i<a.Length;i++)
{
    
    
        a[i]=j;
        j++;
        Console.Write(a[i]+" ");
    
}

string DelTwo(int [] a)
{
    string res= string.Empty;
    for (int i=0; i<a.Length;i++)
    {
        if (a[i]%2==0)
        {
            res +=$"{a[i]} ";
        }
        
    }
    return res;
}
string Ev =DelTwo(a);
Console.WriteLine();
Console.WriteLine(Ev);
