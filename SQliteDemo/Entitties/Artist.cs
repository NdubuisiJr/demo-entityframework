using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQliteDemo.Entitties {
    public class Artist {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StageName { get; set; }
        public virtual ArtistDetails ArtistDetails { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
