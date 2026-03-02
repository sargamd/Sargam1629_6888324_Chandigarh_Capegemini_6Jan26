namespace CompressString
{
    internal class Program
    {
        public static string CompressStr(string str)
        {
            int[] arr=new int[256];
            //char[] res = new char[256];
            string res="";            
            str.ToString();
            for(int i = 0; i < str.Length; i++)
            {
                arr[str[i]]++;
            }
            int j = 0;
            
            foreach(char c in str)
            {
                //Console.WriteLine(arr[c]);
                if (arr[c] > 1)
                {
                    if (res.Contains(c)) { continue; }

                    res = res + c;
                    res = res + arr[c];
                }
                if (arr[c]==1)
                {
                    res=res+ c; 
                    
                }
            }
            //Console.WriteLine(res.Length);

            //foreach(char c in res) {Console.Write(c); }
            return res;

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(CompressStr(str));
        }
    }
}
