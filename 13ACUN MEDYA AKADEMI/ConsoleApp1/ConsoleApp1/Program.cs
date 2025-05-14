//#region BOXİNG & UNBOXİNG



//object yaş = 20;
//object isim = "Ahmet";
//object evlimi = true;
//object sınıfşubesi = 'A';
//object a = new B();

//Console.WriteLine((int)yaş + 45);




//class B
//{

//}

//#endregion
#region Generic

//TelefonKutusu telefonKutusu = new TelefonKutusu() { telefon = new Telefon() };
//MouseKutusu mouseKutusu = new MouseKutusu() { mouse = new Mouse() };

//sarzaletiKutusu sarzaletikutusu = new sarzaletiKutusu() { sarzaleti = new Sarzaleti() };
//htmılKutusu htmılKutusu = new htmılKutusu() { html = new Html() };

//kutu<Telefon> telefonKutusu2 = new kutu<Telefon>() { urun = new Telefon() };
//kutu<Mouse> mouseKutusu2 = new kutu<Mouse>() { urun = new Mouse() };
//kutu<Sarzaleti> sarzaletiKutusu2 = new kutu<Sarzaleti>() { urun = new Sarzaleti() };
//kutu<Html> htmılKutusu2 = new kutu<Html>() { urun = new Html() };

//Console.WriteLine();
//class TelefonKutusu
//{

//    public Telefon telefon;

//}
//class MouseKutusu
//{
//    public Mouse mouse;
//}

//class sarzaletiKutusu
//{
//    public Sarzaleti sarzaleti;
//}

//class htmılKutusu
//{
//    public Html html;
//}

//class Sarzaletikutusu
//{
//    public Sarzaleti sarzaleti;
//}



//class kutu<T>
//{
//    public T urun;
//}
//class Telefon
//{
//}
//class Html
//{
//}


//class Mouse
//{
//}
//class Sarzaleti
//{
//}
//Matematik<int> matematik = new Matematik<int>();
//matematik.DegerDondur();
//matematik.myproperty = 10;
//Console.WriteLine(matematik.DegerDondur());


//Matematik<string> matematik2 = new Matematik<string>();
//matematik2.DegerDondur();
//matematik2.myproperty = "alii k";
//Console.WriteLine(matematik2.DegerDondur());
//class Matematik<T> 
//{
//   public T myproperty {  get; set; }
//    public T DegerDondur()
//    {
//        return myproperty;
//    }


//}

//MyClass<int, string, bool, char> myClass = new MyClass<int, string, bool, char>();
//myClass.myproperty = "Ali";

//class MyClass<T1,T2,T3,T4>
//{
//    T1 field;
//    public T2 myproperty { get; set; }
//    public T3 METHOD()
//    {
//        return default;
//    }

//    public T4 METHOD2(T4 param)
//    {
//        return param; 
//    }
//}



#endregion