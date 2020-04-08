using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQliteDemo.Entitties {
    public class AlbumReviewer {
        public int AlbumID { get; set; }
        public int ReviewerID { get; set; }
        public Album Album { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}
