using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO
{
    [Serializable]
    public class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    class FriendDetailSearch
    {

        public static void Main()
        {
            //SearchFriend();
            //foreach(Friend friend in LoadFriends())
            //{
            //    Console.WriteLine($"Name: {friend.Name}, Email: {friend.Email}, Phone: {friend.Phone}");
            //}
            //Friend friend = new Friend { Name = "someone", Email = "t@b.c", Phone = "545454554" };
            //SaveFriend(friend);
            //SaveFriendXML(friend);
            Friend f = GetFriendXML();
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Email);
            Console.WriteLine(f.Phone);

        }
        public static void SaveFriendXML(Friend friend)
        {
            Stream stream = File.Create("C:\\Users\\Rahul Jain\\contacts.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Friend));
            xmlSerializer.Serialize(stream, friend);
            stream.Close();
        }
        public static Friend GetFriendXML()
        {
            Stream stream = File.OpenRead("C:\\Users\\Rahul Jain\\contacts.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Friend));
            Friend friend = new Friend();
            friend = (Friend)xmlSerializer.Deserialize(stream);
            stream.Close();
            return friend;
        }

        public static void SaveFriend(Friend friend)
        {
            //StreamWriter writer = new StreamWriter("C:\\Users\\Rahul Jain\\contact.dat", true);
            Stream stream = File.Create("C:\\Users\\Rahul Jain\\contacts.dat", 6);// FileMode.Append = 6
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, friend);
            stream.Close();
        }
        public static Friend GetFriend()
        {
            Stream stream = File.OpenRead("C:\\Users\\Rahul Jain\\contacts.dat");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Friend friend = new Friend();
            friend = (Friend)binaryFormatter.Deserialize(stream);
            stream.Close();
            return friend;
        }
        public static void Savefriend()
        {
            string name, email, mobile, wish = "y";
            StreamWriter writer = new StreamWriter("C:\\Users\\Rahul Jain\\contacts.txt", true);
            while (wish != "n")
            {
                Console.WriteLine("Enter Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter Email:");
                email = Console.ReadLine();
                Console.WriteLine("Enter Mobile:");
                mobile = Console.ReadLine();
                string data = string.Format($"{name}, {email}, {mobile}");
                writer.WriteLine(data);
                Console.WriteLine("Wish to Continue? y/n");
                wish = Console.ReadLine();
            }
            writer.Close();
        }
        public static void SearchFriend()
        {
            StreamReader reader = new StreamReader("C:\\Users\\Rahul Jain\\contacts.txt");
            Console.WriteLine("Enter Name to search");
            string name = Console.ReadLine();
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] lineArray = line.Split(',');
                if (lineArray[0] == name)
                {
                    Console.WriteLine($"{name} \nEmail: {lineArray[1]}\nMobile: {lineArray[2]}");
                }
            }
            reader.Close();
        }
        public static List<Friend> LoadFriends()
        {
            StreamReader reader = new StreamReader("C:\\Users\\Rahul Jain\\contacts.txt");
            List<Friend> friends = new List<Friend>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] lineArray = line.Split(',');
                Friend friend = new Friend { Name = lineArray[0], Email = lineArray[1], Phone = lineArray[2] };
                friends.Add(friend);
            }
            reader.Close();
            return friends;
        }
    }
}
