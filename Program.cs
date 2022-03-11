class Program
{
    static void Main(string[] args)
    {
        KodePos table_Kodepos = new KodePos();
        Console.WriteLine("========= MEMANGGIL KODE POS =========");
        Console.WriteLine("Masukan Kode kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine("========= OUTPUT ========= ");
        table_Kodepos.getKodepos(kelurahan);
        Console.WriteLine("==== JAWABAN NO 3 ====");
        table_Kodepos.getAllkodepos();
        Console.WriteLine("========= JAWABAN NO 5 =========");
        DoorMachine pintu = new DoorMachine();
        pintu.kunci();
    }

}

class KodePos
{
    Dictionary<string, int> dic = new Dictionary<string, int>()
    {
            {"Batununggal"  ,40266},
            {"Kujangsari"   ,40287},
            {"Mengger"      ,40267},
            {"Wates        "        ,        40256},
            {"Cijaura"      ,40287},
            {"Jatisari"     ,40286},
            {"Margasari"    ,40286},
            {"Sekejati"     ,40286},
            {"Kebonwaru"    ,40272},
            {"Maleer        "       ,        40274},
            {"Samoja        "       ,        40273}
    };

    public void getKodepos(string kel)
    {
        if (dic.ContainsKey(kel))
        {
            Console.WriteLine(kel + " : " + dic[kel]);
        }
        else
        {
            Console.WriteLine(kel + " tidak ditemukan");
        }
    }

    public void getAllkodepos()
    {
        foreach (KeyValuePair<string, int> ele1 in dic)
        {
            Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
        }
    }


}

class DoorMachine
{
    enum State { TERKUNCI, TERBUKA,};
    public void kunci()
    {
        State state = State.TERKUNCI;

        String[] screenName = { "TERKUNCI", "TERBUKA" };
        do
        {
            Console.WriteLine("PINTU " + screenName[(int)state]);
            Console.WriteLine("Kode 1 : Buka Pintu\nKode 2 : Kunci Pintu");
            Console.Write("Masukan Kode : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.TERKUNCI:
                    if (command == "Buka Pintu")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.TERBUKA;
                        
                    }
                    break;
                case State.TERBUKA:
                    if (command == "Kunci Pintu")
                    {
                        Console.WriteLine("====== OUTPUT ======");
                        state = State.TERKUNCI;
                        
                    }
                    break;
            }
        } while (state != State.TERKUNCI);
    }
}