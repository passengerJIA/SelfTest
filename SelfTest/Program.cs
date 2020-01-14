using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SelfTest
{

    class Input
    {
        public string Address { get; set; }
        public string UniversityName { get; set; }
    }

    class Program
    {

        private static List<HiearchyMembers> input = new List<HiearchyMembers> { new HiearchyMembers { Id = 1, TeamLeaderId = 2},
                                                    new HiearchyMembers { Id = 2, TeamLeaderId = 3},
                                                    new HiearchyMembers { Id = 3, TeamLeaderId = null},
                                                    new HiearchyMembers { Id = 4, TeamLeaderId = 2},
                                                    new HiearchyMembers { Id = 5, TeamLeaderId = 3},
                                                    new HiearchyMembers { Id = 6, TeamLeaderId = 1}
                                                    };
        static void Main(string[] args)
        {
            //for(var x=0; x<100; x++)
            //{
            //    Console.WriteLine(RandomTrueFalse());
            //}
            //Console.Read();

            //var cookies = CallForAuthenticationCookie().Result;
            //var authCookie = cookies.FirstOrDefault(c=>c.Name == ".AspNet.ApplicationCookie");

            //if (true || false && false)
            //{
            //    Console.WriteLine("true || false && false");
            //}
            //if(true || false&& true)
            //{
            //    Console.WriteLine("true || false&& true");
            //}
            //if(true || true && true)
            //{
            //    Console.WriteLine("true || true && true");
            //}
            //if(true || true && false)
            //{
            //    Console.WriteLine("true || true && false");
            //}
            //Console.WriteLine(BuildQrApplicationInfo(new List<string>(), new GiftOrderTemplateSubmitInput { }));
            //Console.WriteLine(BuildQrApplicationInfo(new List<string> { "字段一"}, new GiftOrderTemplateSubmitInput { Name = "ming", Email = "email", Courses = new List<CourseDto>()}));
            //Console.WriteLine(BuildQrApplicationInfo(new List<string> { "字段一" }, new GiftOrderTemplateSubmitInput { Name = "ming", Email = "email", Courses = new List<CourseDto>() { new CourseDto { Name = "课程一" } } }));
            //var inputs = new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99" };
            //foreach(var i in inputs)
            //{
            //    Console.WriteLine(int.Parse(i));
            //    var output = int.Parse(i) + 1;
            //    var outputString = output.ToString("D2");

            //    Console.WriteLine("output: " + outputString.Substring(outputString.Length - 2, 2));
            //}
            //var inputs = new List<int>();
            //for(var i = 0; i < 100; i++)
            //{
            //    inputs.Add(DateTime.Now.Year + i);
            //}
            //foreach(var y in inputs)
            //{
            //    Console.WriteLine(y);
            //    Console.WriteLine(y.ToString().Substring(2,2));
            //}
            //var input = string.Empty;
            //input = null;
            //var prefix = string.Empty;
            //prefix = null;
            //var output = prefix + input;
            //var output2 = $"{prefix}-{input}";
            //Console.WriteLine(output);
            //Console.WriteLine(output2);
            //var address = string.Empty;
            //List<Input> sample = new List<Input>();
            //sample.Add(new Input { Address = null, UniversityName = null}); // null
            //sample.Add(new Input { Address = null, UniversityName = "" }); // null
            //sample.Add(new Input { Address = null, UniversityName = "学校" }); //学校
            //sample.Add(new Input { Address = "", UniversityName = null }); // null
            //sample.Add(new Input { Address = "", UniversityName = "" }); // null
            //sample.Add(new Input { Address = "", UniversityName = "学校" }); //学校
            //sample.Add(new Input { Address = "地址", UniversityName = null });//地址
            //sample.Add(new Input { Address = "地址", UniversityName = "" });//地址
            //sample.Add(new Input { Address = "地址", UniversityName = "学校" }); //地址-学校

            //foreach(var s in sample)
            //{
            //    if (string.IsNullOrEmpty(s.Address) && string.IsNullOrEmpty(s.UniversityName))
            //    {
            //        address = null;
            //    }
            //    else if (!string.IsNullOrEmpty(s.Address) && !string.IsNullOrEmpty(s.UniversityName))
            //    {
            //        address = $"{s.Address}-{s.UniversityName}";
            //    }
            //    else if (!string.IsNullOrEmpty(s.Address))
            //    {
            //        address = s.Address;
            //    }
            //    else if (!string.IsNullOrEmpty(s.UniversityName))
            //    {
            //        address = s.UniversityName;
            //    }
            //    if (string.IsNullOrEmpty(address))
            //    {
            //        address = null;
            //    }
            //    Console.WriteLine(address??"null");
            //}

            //List<DateTime> inputs = new List<DateTime>();
            //inputs.Add(new DateTime(2011, 1, 1)); //false
            //inputs.Add(new DateTime(2012,2,1));   //
            //inputs.Add(new DateTime(2013, 2, 2)); //true
            //inputs.Add(new DateTime(2014, 3, 14)); //true
            //inputs.Add(new DateTime(2015, 3, 15));
            //inputs.Add(new DateTime(2016, 4, 1)); //false
            //inputs.Add(new DateTime(2017, 8, 20));
            //inputs.Add(new DateTime(2018, 8, 21));//true
            //inputs.Add(new DateTime(2019, 9, 19));//true
            //inputs.Add(new DateTime(2020, 9, 20));
            //inputs.Add(new DateTime(2021, 10, 1));//false
            //foreach(var input in inputs)
            //{
            //    CheckDate(input);
            //}

            ////Console.Read();

            //var target = new List<CourseDto>() { new CourseDto { Id = 1, Name = "1"},
            //                                    new CourseDto { Id = 2, Name = "2"},
            //new CourseDto { Id = 3, Name = "3"},
            //new CourseDto { Id = 4, Name = "4"},
            //new CourseDto { Id = 5, Name = "5"},
            //new CourseDto { Id = 6, Name = "6"},};

            //var info = new List<GiftOrderTemplateSubmitInput>() {
            //    new GiftOrderTemplateSubmitInput{ Id = 1, Name = "info11"},
            //    new GiftOrderTemplateSubmitInput{ Id = 1, Name = "info12"},
            //    new GiftOrderTemplateSubmitInput{ Id = 1, Name = "info13"},
            //    new GiftOrderTemplateSubmitInput{ Id = 2, Name = "info21"}
            //};

            //var query = target.GroupJoin(info, t => t.Id, i => i.Id, (t, g) => new { Course = t, Infos = g});


            //var TeamLeaderId = input.Where(m => m.TeamLeaderId.HasValue).Select(m => m.TeamLeaderId).ToList();
            //var headId = input.Where(m => TeamLeaderId.Contains(m.Id) && !m.TeamLeaderId.HasValue).FirstOrDefault().Id;

            //var result = FindHierchyMembers(2);
            //foreach(var i in result )
            //{
            //    Console.WriteLine(i);
            //}
            //var t1 = new DerivedEntity();
            //var t2 = new DerivedEntity(5);
            //var t3 = new DerivedEntity(1, 5);
            //string test = null;
            //Console.WriteLine(test + "opps");
            //var roles1 = new List<Role> { new Role {Id = 1, Name = "AdminConfig" }, new Role { Id = 2, Name = "Editors"} };
            //var roles2 = new List<Role> { new Role {Id = 1, Name = "AdminConfig" }, new Role { Id = 3, Name = "DepartmentChiefs"}, new Role { Id = 4, Name = "Chiefs"} };

            //var group1 = new Group { Id = 1, Name = "管理员", Roles = roles1 };
            //var group2 = new Group { Id = 2, Name = "领导", Roles = roles2 };
            //decimal? v1 = 500;
            //decimal? v2 = null;
            //var result = v1??0 - v2??0;

            //var number = 1;

            //var result = info.Select(x => {
            //    var temp = number;
            //    temp = temp + 1;
            //    return new { x.Id, Name = temp }; });
            //foreach (var r in result)
            //{
            //    Console.WriteLine("ID: " +r.Id+" Name: "+r.Name);

            //}

            //Console.WriteLine(string.Join(",", "Name1", "Name2"));
            //Console.WriteLine(string.Join(",", "Name1"));



            //var list = new List<GroupByData>();
            //list.Add(new GroupByData {Admin = false, Confirmed = false });
            //var group = list.GroupBy(l => new { l.Admin, l.Confirmed }).ToList();
            Console.WriteLine(new List<SumData>().Sum(s => s.Quantity));
            Console.Read();
        }

        public static List<int> FindHierchyMembers(int leaderId)
        {

            var memberIds = input.Where(u => u.TeamLeaderId.HasValue && u.TeamLeaderId == leaderId).Select(u => u.Id).ToList();
            if (memberIds.Any())
            {
                var temp = new List<int>();
                temp.AddRange(memberIds);
                temp.ForEach(i => memberIds.AddRange(FindHierchyMembers(i)));
            }
            return memberIds;
        }

        private static void CheckDate(DateTime now)
        {
            var nowYear = now.Year;
            var nowDayOfYear = now.DayOfYear;
            var p1StartDayOfYear = new DateTime(nowYear, 2, 1).DayOfYear;
            var p1EndDayOfYear = new DateTime(nowYear, 3, 15).DayOfYear;
            var p2StartDayOfYear = new DateTime(nowYear, 8, 20).DayOfYear;
            var p2EndDayOfYear = new DateTime(nowYear, 9, 20).DayOfYear;

            if ((nowDayOfYear <= p1EndDayOfYear && nowDayOfYear >= p1StartDayOfYear) || (nowDayOfYear >= p2StartDayOfYear && nowDayOfYear <= p2EndDayOfYear))
            {
                Console.WriteLine("可以");
            }
            else
            {
                Console.WriteLine("不可以");
            }
        }

        private static string BuildQrApplicationInfo(List<string> updatedFields, GiftOrderTemplateSubmitInput model)
        {
            if (model == null)
            {
                return string.Empty;
            }
            var sb = new StringBuilder();
            var now = DateTime.Now;
            sb.Append($"{now.Year}年{now.Month}月{now.Day}日，用户最新一次通过二维码样书申请单申请样书，通过申请表信息，填充 ");
            if (updatedFields == null || !updatedFields.Any())
            {
                sb.Append(" 信息。");
            }
            else
            {
                sb.Append($"{updatedFields.Aggregate((x, y) => { return x + "," + y; })} 信息。");
            }
            sb.Append($"用户最新二维码样书申请信息，姓名：{model.Name}，邮箱：{model.Email}，院校：{model.University}，邮寄地址：{model.Address}，邮编：{model.Zipcode}，");
            var courseInfo = new StringBuilder();
            foreach (var course in model.Courses ?? new List<CourseDto>())
            {
                courseInfo.Append($"{course.Name} {course.Students}人、");
            }
            sb.Append($"课程信息：{courseInfo.ToString().TrimEnd('、')}。");
            return sb.ToString();
        }
        public static bool RandomTrueFalse()
        {
            bool[] TrueFalse = { true, false };
            var Random = new Random(DateTime.Now.Millisecond);
            var RandomNumber = Random.Next(1, 1000);
            var index = RandomNumber % 2;
            return TrueFalse[index];
        }

        public static async Task<List<Cookie>> CallForAuthenticationCookie(decimal id = 65, string domain = "http://localhost:56535")
        {
            var handler = new HttpClientHandler();
            var cookieContainer = new CookieContainer();
            handler.CookieContainer = cookieContainer;
            var client = new HttpClient(handler);

            var secret = ComputeSecretCode((long)id);
            var uri = new Uri($"{domain}/Account/Login?id=65&code={secret}");
            var message = await client.GetAsync(uri);

            return cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();

        }

        private static string ComputeSecretCode(long id)
        {
            var format = $"{id}MyFirstDreamProject";
            using (var md5 = MD5.Create())
            {
                var input = Encoding.UTF8.GetBytes(format);
                var hashed = md5.ComputeHash(input);
                var sb = new StringBuilder();
                for (var x = 0; x < hashed.Length; x++)
                {
                    sb.Append(hashed[x].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Role> Roles { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class HiearchyMembers
    {
        public int Id { get; set; }
        public int? TeamLeaderId { get; set; }
    }

    public class GiftOrderTemplateSubmitInput
    {
        public int Id { get; set; }
        public string Phone { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }


        public string University { get; set; }

        public string Employment { get; set; }

        public string Address { get; set; }

        public string Zipcode { get; set; }

        public int? TitleId { get; set; }

        public int? DutyId { get; set; }


        public IEnumerable<CourseDto> Courses { get; set; }
    }

    public class CourseDto
    {
        public int Id { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        //[Display(Name = "课程名称")]
        //[Required(ErrorMessage = "请输入课程名称")]
        public string Name { get; set; }

        /// <summary>
        /// 学生人数
        /// </summary>
        //[Display(Name = "学生人数")]
        //[Required(ErrorMessage = "请输入学生人数")]
        public int? Students { get; set; }
    }

    public enum MeetingDay
    {
        周一,
        周二,
        周三,
        周四,
        周五,
    }

    public class BaseEntity
    {
        public BaseEntity()
        {
            Console.WriteLine("Base Parameterless");
        }
        public BaseEntity(int x)
        {
            Console.WriteLine("Base x" + x);
        }
    }

    public class DerivedEntity: BaseEntity
    {
        public DerivedEntity()
        {
            Console.WriteLine("Derived Parameterless");
        }

        public DerivedEntity(int x) : base()
        {
            Console.WriteLine("Derived X" + x);
        }

        public DerivedEntity(int y, int x) : base(x)
        {
            Console.WriteLine("Derived yx Base x" + x);
        }
    }
    public class GroupByData
    {
        public bool Admin { get; set; }
        public bool Confirmed { get; set; }
    }

    public class SumData
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
