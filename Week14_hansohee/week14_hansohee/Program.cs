using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14_hansohee
{
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
        public double Height;

        public override string ToString()
        {
            return $"{Name}, {Phone}, {Age:000}, {Height:000.0}"; 
            // Age 3자리로 표시하되, 비어있는 자리는 0으로 채우기 Height 앞자리 3자리 뒷자리 한자리
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            NameCard nc1, nc2;

            nc1 = new NameCard()
            {
                Name = "김인하",
                Phone = "010-1234-5678",
                Age = 21,
                Height = 160.7
            };

            nc2 = new NameCard();
            nc2.Name = "이인하";
            nc2.Phone = "010-1111-2222";
            nc2.Age = 23;
            nc2.Height = 171.7;

            List<NameCard> list = new List<NameCard>();
            list.Add(nc1);
            list.Add(nc2);

            // string path = "c:\\class_a";
            string path = @"c:\class_a";

            if(false == Directory.Exists(path))  // 우선 class_a 폴더의 존재 여부 확인
            {
                Directory.CreateDirectory(path);
            }

            do
            {
                Console.WriteLine("1:이진 파일 쓰기");
                Console.WriteLine("2:이진 파일 읽기");
                Console.WriteLine("3:텍스트 파일 쓰기");
                Console.WriteLine("4:텍스트 파일 읽기");
                Console.WriteLine("5:텍스트 파일 리스트 쓰기");
                Console.WriteLine("6:텍스트 파일 리스트 읽기");
                Console.WriteLine("0:끝");

                switch (Console.ReadLine().Trim())
                {
                    case "1" :
                        var f1 = path + "\\test.dat";
                        Method1(f1, nc1);
                        Console.WriteLine(f1 + "파일 확인");
                        break;

                    case "2" :
                        var f2 = path + @"\test.dat";
                        NameCard rnc1;  
                        Method2(f2, out rnc1);
                        if (rnc1 != null)
                        {
                            Console.WriteLine(rnc1);
                        }
                        break;

                    case "3" :
                        var f3 = Path.Combine(path, "test.txt");
                        method3(f3, nc2);
                        Console.WriteLine(f3 + "파일을 확인하세요.");
                        break;

                    case "4" :
                        var f4 = Path.Combine(path, "test.txt");
                        method4(f4, out NameCard rnc2);
                        if (rnc2 != null)
                        {
                            Console.WriteLine(rnc2);
                        }
                        break;

                    case "5" :
                        var f5 = Path.Combine(path, "testlist.txt");
                        method5(f5, list);
                        Console.WriteLine(f5 + "파일을 확인하세요.");
                        break;

                    case "6" :
                        var f6 = Path.Combine(path, "testlist.txt");
                        method6(f6, out List<NameCard> rcvlist);
                        if (rcvlist != null)
                        {
                            foreach(NameCard item in rcvlist)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case "0" :
                    return;
                }
            }
            while (true);
        }

        private static void method6(string file, out List<NameCard> list)
        {
            list = null;

            if (File.Exists(file) == false)
            {
                return;
            }

            using (var fs = new FileStream(file, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    list = new List<NameCard>();

                    while (sr.EndOfStream == false)
                    {
                        string record = sr.ReadLine();
                        // record.Split(',');
                        string[] data = record.Split(',');

                        if(data.Length == 4)  // 데이터는 4개가 있을 것이니...
                        {
                            var nc = new NameCard();

                            nc.Name = data[0].Trim();
                            nc.Phone = data[1].Trim();
                            nc.Age = int.Parse(data[2].Trim());
                            double.TryParse(data[3].Trim(), out nc.Height);

                            list.Add(nc);
                        }
                    }
                }
            }
        }

        private static void method5(string file, List<NameCard> list)
        {
            // append vs. create
            using (var fs = new FileStream(file, FileMode.Append))
            {
                using (var sw = new StreamWriter(fs))
                {
                    foreach(var nc in list) 
                    {
                        sw.WriteLine(nc.ToString());
                    }
                }
            }
        }

        private static void method4(string file, out NameCard nc)
        {
            nc = null;

            if (File.Exists(file) == false)
            {
                return;
            }

            using (var sr = new StreamReader(new FileStream(file, FileMode.Open)))
            {
                nc = new NameCard();

                nc.Name = sr.ReadLine();
                nc.Phone = sr.ReadLine();
                nc.Age = int.Parse(sr.ReadLine());
                double.TryParse(sr.ReadLine(), out nc.Height);
            }
        }

        private static void method3(string file, NameCard nc)
        {
            using (var sw = new StreamWriter(new FileStream(file, FileMode.Create)))
            {
                sw.WriteLine(nc.Name);  // 문자열로 저장됨
                sw.WriteLine(nc.Phone);
                sw.WriteLine(nc.Age);
                sw.WriteLine(nc.Height);  // double -> string -> byte[]
            }
        }

        private static void Method2(string file, out NameCard nc)  // out 변수에는 반드시 값을 넣어야 함
        {
            nc = null;
            
            if(File.Exists(file) == false)
            {
                return;
            }

            using (var br = new BinaryReader(new FileStream(file, FileMode.Open)))  // read를 하려면 이 파일이 있는지 반드시 검사해야 함
            {
                nc = new NameCard();
                // 주의점 : 쓴 순서대로 읽는다.  <-- 되게 중요!!
                nc.Name = br.ReadString();
                nc.Phone = br.ReadString();
                nc.Age = br.ReadInt32();
                nc.Height = br.ReadDouble();  // bytes[] --> double

            }
        }

        private static void Method1(string file, NameCard nc)
        {
            // FileStream fs = new FileStream(file, FileMode.Create);
            // BinaryWriter bw = new BinaryWriter(fs);
            // bw.Close();  // 나중에 만든 애 먼저 닫기 
            // fs.Close();

            // BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create));
            // bw.Close();

            // using (BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create)))  // var bw = ~~ 이렇게 선언해도 ㄱㅊ
            // {
            //     // using문에 bw 선언되어 있자나요? using 문이 끝나면 Close()를 using문이 알아서 해줌
            // }

            using (var fs = new FileStream(file, FileMode.Create))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    bw.Write(nc.Name);  // string -> byte[]
                    bw.Write(nc.Phone);  // string -> byte[]
                    bw.Write(nc.Age);  // int -> byte[]
                    bw.Write(nc.Height);  // double -> byte[]
                }
            }
        }
    }
}
