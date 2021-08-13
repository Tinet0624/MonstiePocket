using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstiePocket
{
    public class Monstie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MonstieNumber { get; set; }
        public string Icon { get; set; }
        public string Egg { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Genus { get; set; }
        public byte? MonstieRarity { get; set; }
        public string Habitat { get; set; }
        public string RiderAction1 { get; set; }
        public string RiderAction2 { get; set; }
        public string Status { get; set; }
        public string EggRarity { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
