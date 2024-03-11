namespace TamagoshiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string petName;
            string errorText = "";
            Pet pet = new Pet();
            while (true)
            {
                Console.WriteLine("enter your pet's name");
                try
                {
                    petName = Console.ReadLine();
                    pet.Name = petName;
                    break;
                }
                catch (ArgumentException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            while (true)
            {
                Console.Clear();
                char borderChar = '*';
                int borderLength = 30;
                string formattedName = $"* {pet.Name} *";
                Console.WriteLine(formattedName.PadLeft(borderLength / 2 + formattedName.Length / 2, borderChar)
                    .PadRight(borderLength, borderChar));
                Console.WriteLine($"Health: {new string('+', pet.Health)}");
                Console.WriteLine($"Hunger: {new string('+', pet.Hunger)}");
                Console.WriteLine($"Fatigue: {new string('+', pet.Fatigue)}");
                Console.WriteLine($"Happiness: {new string('+', pet.Happiness)}");
                Console.WriteLine(new string(borderChar, borderLength));
                Console.WriteLine(errorText);
                if (errorText == "Your Pet is sick")
                {
                    return;
                }
                errorText = "";
                Console.WriteLine("Select action");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Sleep");
                Console.WriteLine("4. Heal");
                Console.WriteLine("Esc. exit");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Приложение завершено");
                    return;
                }
                switch (keyInfo.KeyChar)
                {
                    case '1':
                        {
                            try
                            {
                                pet.Feed();
                                break;
                            }
                            catch(ArgumentException e)
                            {
                                errorText = e.Message;
                                break;
                            }
                        }
                    case '2':
                        try
                        {
                            pet.Play();
                            break;
                        }
                        catch (ArgumentException e)
                        {
                            errorText = e.Message;
                            break;
                        }
                    case '3':
                        try
                        {
                            pet.Sleep();
                            break;
                        }
                        catch (ArgumentException e)
                        {
                            errorText = e.Message;
                            break;
                        }
                    case '4':
                        try
                        {
                            pet.Heal();
                            break;
                        }
                        catch (ArgumentException e)
                        {
                            errorText = e.Message;
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}