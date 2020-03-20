using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orgamizer_ADO.models
{
    class OrganizerTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Term { get; set; }

        public int CategoryId { get; set; }
    }
}
