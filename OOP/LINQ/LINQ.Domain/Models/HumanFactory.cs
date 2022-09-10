using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Domain.Interfaces;
using LINQ.Domain.InitialData;

namespace LINQ.Domain.Models
{
    public class HumanFactory : IHumanFactory
    {
        public List<Character> Chatacters { get; set; } = new List<Character>();

        public IEnumerable<Character> Bind()
        {
            foreach(var character in CharacterInitialData.DataSeedCSV.Where(c => c.Contains("Human")))
            {
                var characterArray = character.Split(',');
                yield return new Character(characterArray[0].Trim(), characterArray[1].Trim(), int.Parse(characterArray[3]), int.Parse(characterArray[4]));
            }
        }
    }
}
