namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;int output=0;
            Console.Write("Enter binary number: ");
            num = Console.ReadLine();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '1' || num[i] == '0')
                {
                    continue;
                }
                else { output = -1;break; }
            }
            if (output == -1) { Console.Write(output); return; }
            string s="11111"; int j = (s.Length) - 1; int temp = 0;
            foreach (char i in s)
            {

                temp = temp + Convert.ToInt32(i - '0') * Convert.ToInt32(Math.Pow(2, j));

                j--;
            }
            //Console.Write(temp);

            j = (num.Length) - 1; int sum = 0;
            
            foreach(char i in num)
            {
                
                sum = sum + Convert.ToInt32(i-'0')*Convert.ToInt32(Math.Pow(2,j));
                
                j--;
            }
            if (temp < sum) { output = -2;Console.Write(output); return; }
            Console.Write(sum);
            
        }
    }
}
