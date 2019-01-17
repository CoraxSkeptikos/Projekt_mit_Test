using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace meinUmfrageTool.Models
{
    public class FragebogenModel
    {
        public FragebogenModel()
        {
            Fragen = new List<FragenModel>();
        }

        public string Bezeichnung { get; set; }

        [UIHint("FragenModel")]
        public List<FragenModel> Fragen { get; set; }
    }
}