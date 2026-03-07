namespace UserInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adminInput = Console.ReadLine().Split();
            var modInput = Console.ReadLine().Split();

            Admin admin = new Admin(
                adminInput[0],
                (Gender)Enum.Parse(typeof(Gender), adminInput[1]),
                int.Parse(adminInput[2])
            );

            Moderator mod = new Moderator(
                modInput[0],
                (Gender)Enum.Parse(typeof(Gender), modInput[1]),
                int.Parse(modInput[2])
            );

            Console.WriteLine($"Type of user {admin.GetUserName()} is {admin.GetUserType()}");
            Console.WriteLine($"Age of user {admin.GetUserName()} is {admin.GetAge()}");
            Console.WriteLine($"Gender of user {admin.GetUserName()} is {admin.GetGender()}");

            Console.WriteLine($"Type of user {mod.GetUserName()} is {mod.GetUserType()}");
            Console.WriteLine($"Age of user {mod.GetUserName()} is {mod.GetAge()}");
            Console.WriteLine($"Gender of user {mod.GetUserName()} is {mod.GetGender()}");
        }
    }
    
}
