using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using DL;
using DL.Interfaces;
using DL.TaskTypes;
using static Bogus.Faker;

namespace DL
{
    public class Board
    {


        private static Board _instance;

        private List<Task> _tasks;



        private Board()
        {
            var faker = new Faker();
            var taskBogus = new Faker<Task>()
                       .RuleFor(r => r.Description, f => f.Lorem.Paragraph())
                       .RuleFor(r => r.Estimation, f => f.Random.Double(0, 7))
                       .RuleFor(r => r.ID, f => Guid.NewGuid().ToString())
                       .RuleFor(r => r.Owner, f => new User(f.Person.FirstName, f.Person.LastName, f.Person.Avatar))
                       .RuleFor(r => r.creator, f => new User(f.Person.FirstName, f.Person.LastName, f.Person.Avatar))
                       .RuleFor(r => r.CurrStatus, f => (Status)f.Random.Int(1, 6))
                       .RuleFor(r => r.Title, f => f.Lorem.Word())
                       .RuleFor(r => r.Type, f => (TaskType)f.Random.Int(1, 5));



            //var imageBogus = new Faker<Image>()
            //    .RuleFor(r => r.Description, f => f.Lorem.Sentence())
            //    .RuleFor(r => r.ImageURL, f => f.Image.PicsumUrl(320, 240));


            var tasks = taskBogus.Generate(faker.Random.Number(50, 100));
            _tasks = tasks;

        }

        public List<Task> Tasks { get { return _tasks; } }



        public static Board GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Board();

            }
            return _instance;
        }
    }
}
