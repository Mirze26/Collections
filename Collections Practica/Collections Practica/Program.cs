


using Collections_Practica.Models;
using System.Collections;

#region Operator Overloading Employee


//Employee employee1 = new Employee();

//employee1.Name = "Qemdulla";
//employee1.Age = 25;
//employee1.Id = 1;


//Employee employee2 = new Employee();

//employee2.Name = "Qemlo";
//employee2.Age = 26;
//employee2.Id = 2;


//var result = employee1 < employee2;

//Console.WriteLine(result);

#endregion

#region Hashtable

//Hashtable datas = new Hashtable();

//datas.Add(1, "Masan");
//datas.Add(2, "Qemlo");
//datas.Add(3, "Qemdulla");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}


#endregion

#region Hashset

//HashSet<int> datas = new HashSet<int>();

//datas.Add(1);
//datas.Add(1);
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

#endregion

#region SortedList

//SortedList datas = new SortedList();

//datas.Add(6, "Masan");

//datas.Add(4, "Hamca");

//datas.Add(2, "Qemlo");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}




//SortedList<int,string> datas = new SortedList<int,string>();

//datas.Add(2, "Eynulla");
//datas.Add(3, "Ehedulla");
//datas.Add(4, "Yedulla");

//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}



#endregion

#region ArrayList
//ArrayList datas = new ArrayList();

//datas.Add("Salam");
//datas.Add(655);
//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}
#endregion

#region List

//List<int> datas = new List<int>();

//datas.Add(30);
//datas.Add(20);
//datas.Add(10);

//datas.Sort();
//datas.Reverse();
//Console.WriteLine(datas[0]);
//datas.Remove(20);
//datas.Clear();
//datas.RemoveAll(m => m > 30);
//var res = datas.Contains(30);
//Console.WriteLine(res);



//List<string> names = new List<string>(){"Qemdulla", "Qemlo", "Masan", "Hamca"};

//var result = names.FindAll(m => m == "Qemdulla").Count;
//Console.WriteLine(result);



//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}



//foreach (var item in names)
//{
//	if (item == "Masan")
//	{
//		Console.WriteLine(item);
//	}
//}


//List<int> numbers = new List<int>() { 1, 2, 3, 4, };

//Console.WriteLine(numbers.FindAll(m=>m%2==0).Sum(m=>m));

#endregion

#region StackList

//Stack<string> stack = new Stack<string>();

//stack.Push("Salam");
//stack.Push("Eleykum");

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

#endregion

#region QueueList

//Queue<int> queue = new Queue<int>();

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

#endregion

#region DictionaryList

//Dictionary<string,string> datas = new Dictionary<string,string>();

//datas.Add("Admin", "Mirze");
//datas.Add("Member", "Hacker");
//datas.Add("SuperAdmin", "Anar");

//foreach (KeyValuePair<string,string>  item in datas)
//{
//	if (item.Key =="Admin")
//	{
//		Console.WriteLine(item.Value);
//	}
//}

#endregion

#region Student


//static void AddStudent (Student student)
//{
//    List<Student> students = new List<Student>();
//    students.Add(student);
//}


//static void AddStudent(Student student)
//{
//    List<Student> students = new List<Student>();
//    students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName + " " + item.Age);
//    }

//}


//Console.WriteLine("Add full name");
//string fulname = Console.ReadLine();
//Console.WriteLine("Add address");
//string address = Console.ReadLine();
//Console.WriteLine("Add age");
//int age = Convert.ToInt32(Console.ReadLine());

//Student student = new Student
//{
//    Id =1,
//    FullName = fulname,
//    Address = address,
//    Age = age 
//};






//Student stu1 = new Student
//{
//    Id = 1,
//    FullName = "Mirze Beshirzade",
//    Age = 26,
//    Address = "BulBule",
//};


//AddStudent(stu1);

//GetAllStudents();


//Console.WriteLine(GetStudentsSum());

//static int GetStudentsSum()
//{
//    var students = GetAllStudents();

//    return students.Sum(x => x.Age);

//}


//Console.WriteLine(GetSameNameCount());

//static int GetSameNameCount()
//{
//    string text = "Eli Kazimov";
//    var result = GetAllStudents();
//    return result.FindAll(m => m.FullName.Contains(text)).Count;

//}





//static List<Student> GetAllStudents()
//{
//    List<Student> students = new List<Student>();

//    Student stu1 = new Student
//    {
//        Id = 1,
//        FullName = "Mirze Beshirzade",
//        Age = 26,
//        Address = "BulBule",
//    };



//    Student stu2 = new Student
//    {
//        Id = 2,
//        FullName = " Heyder Aliyev",
//        Age = 30,
//        Address = "BulBule",
//    };




//    Student stu3 = new Student
//    {
//        Id = 3,
//        FullName = "Eli Kazimov",
//        Age = 23,
//        Address = "BulBule",
//    };




//    Student stu4 = new Student
//    {
//        Id = 4,
//        FullName = "Hemid Heyderzade",
//        Age = 29,
//        Address = "BulBule",
//    };






//    Student stu5 = new Student
//    {
//        Id = 5,
//        FullName = "Hemze Elizade",
//        Age = 25,
//        Address = "BulBule",
//    };

//    students.Add(stu1);
//    students.Add(stu2);
//    students.Add(stu3);
//    students.Add(stu4);
//    students.Add(stu5);


//    return students;





//}
#endregion