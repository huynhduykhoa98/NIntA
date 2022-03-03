try
{

    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine());
    if (n < 20)
    {
        //yeu cau nhap > 20
        Console.WriteLine("Please enter N higher than 20");
    }
    else
    {

        List<int> listInt = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            listInt.Add(i);
        }
        //10 so lon nhat
        var top10 = listInt.OrderByDescending(x => x).Take(10).OrderBy(x => x).ToList();
        //10 so lon tiep theo
        var top20 = listInt.OrderByDescending(x => x).Skip(10).Take(10).OrderBy(x => x).ToList();
        //do dai cua mang
        int count = listInt.Count;
        //xac dinh vi tri o giua
        var startMiddle = count / 2 - 5;
        //khoi tao mang tam
        var templeList = new List<int>();
        //filter mang
        listInt = listInt.Where(x => top10.Contains(x) == false && top20.Contains(x) == false).ToList();

        //add cac phan tu dau tien
        templeList.AddRange(listInt.Take(startMiddle));

        //add 10 so lon nhat
        templeList.AddRange(top10);

        //add phan tu con lai
        templeList.AddRange(listInt.Skip(startMiddle).Take(listInt.Count - 1));

        //add 10 so lon tiep theo
        templeList.AddRange(top20);

        //in
        for (int i = 0; i < templeList.Count; i++)
        {
            Console.Write($"{templeList[i]}  ");
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}
