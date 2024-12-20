using System;
using System.Collections.Generic;

public class Program
{
    public string s;
    public int index = 0;
    List<string> directorios = new List<string> { "home", "var", "etc"};
    List<string> extensiones = new List<string> { "txt", "docx", "exe", "rar", "zip" };

    public bool file()
    {
        if (path() && extension() && index == s.Length)
        {
            return true;
        }
        else if (path() && index == s.Length)
        {
            return true;
        }
        return false;
    }

    public bool path()
    {
        if (dir() && path_es())
        {
            return true;
        }
        return false;
    }

    public bool path_es()
    {
        if(s[index]=='.') return true;
        if(s[index]!='/') return false;
        index++; 
        if (dir() && path_es())
        {
            return true;
        }
        return false;
    }

    public bool dir()
    {
        string p = "";
        while (index<s.Length && s[index]!='.' && s[index] != '/')
        {
            p += s[index];
            index++;
        }   
        if (directorios.Contains(p))
        {
            return true;
        }
        return false;
    }

    public bool extension()
    {
        if(s[index]!='.') return false;
        index++;
        string p="";
        while (index < s.Length)
        {
            p += s[index];
            index++;
        }
        if (extensiones.Contains(p))
        {
            return true;
        }
        return false;
    }

    public void valido(string entrada)
    {
        s = entrada; 
        index = 0;   
        if (file())
        {
            Console.WriteLine("Es válido");
        }
        else
        {
            Console.WriteLine("No es válido");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena:");
        string s = Console.ReadLine();
        Program p = new Program();
        p.valido(s);
    }
}