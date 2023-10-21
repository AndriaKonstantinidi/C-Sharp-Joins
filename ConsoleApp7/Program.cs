//List<int> ints = new List<int>()
//{
//    11,23,13124,2,33,32,22,110,101,101,11
//};

//var query = from x in ints
//            where x % 2 == 0
//            orderby x descending
//            select x;

//foreach(var item in query)
//{
//    Console.WriteLine(item);
//}


using ConsoleApp7;

List<Student> students = new List<Student>()
{
    new Student(){Name = "John", Lastname="Doe", Age=12, GroupId = 1},
    new Student(){Name = "Jane", Lastname="Doe", Age=12, GroupId = 1},
    new Student(){Name = "Jock", Lastname="Broe", Age=39, GroupId = 11},
    new Student(){Name = "Sock", Lastname="Toe", Age=26, GroupId = 12},
};

var groupQuery = from i in students
                 group i by i.GroupId;

var secQuery = from i in groupQuery
               where i.Count() > 1
               select i;

var groupIntoQuery = from i in students
                     group i by i.GroupId
                     into tmp
                     where tmp.Count() > 1
                     select tmp;

foreach(var item in groupQuery)
{
    Console.WriteLine(item.Key);
    foreach(var i in item)
    {
        Console.WriteLine($"\t{i}");
    }
}

List<Group> groups = new List<Group>()
{
    new Group(){GroupId = 1, Groupname = "SM 124"},
    new Group(){GroupId = 11, Groupname = "SE 233 8"},
    new Group(){GroupId = 12, Groupname = "WK 2344"},
    new Group(){GroupId = 19, Groupname = "JJ 1122"},
};

var joinQuery = from s in students
                join g in groups
                on s.GroupId equals g.GroupId
                select new
                {
                    saxeli = s.Name,
                    gvari = s.Lastname,
                    asaki = s.Age,
                    jgufisSaxeli = g.Groupname
                };

var groupJoinQuery = from g in groups
                     join s in students
                     on g.GroupId equals s.GroupId
                     into resI
                     select new
                     {
                         key = g.Groupname,
                         value = students
                     };


var groupJoinMethod = groups.GroupJoin(students, g => g.GroupId, s => s.GroupId, (g, s) => new
{
    Key = g.Groupname,
    Value = s
});

foreach(var item in joinQuery)
{
    Console.WriteLine($"{item.saxeli} {item.gvari} {item.asaki} {item.jgufisSaxeli}");
}

Console.WriteLine("groupJoin Query");

foreach(var item in groupJoinQuery)
{
    Console.WriteLine(item.key);
    foreach(var i in item.value)
    {
        Console.WriteLine($"\t{i}");
    }
}