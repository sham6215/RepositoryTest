using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Models
{
    [Table(Name = "chart")]
    public class VesselChart
    {
        [Column(Name = "vessel_chart_id")]
        public int VesselChartId { get; set; }

        [Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "prefix", CanBeNull = true)]
        public string Prefix { get; set; }

        [Column(Name = "number")]
        public string Number { get; set; }

        [Column(Name = "suffix")]
        public string Suffix { get; set; }

        [Column(Name = "international_number", CanBeNull = true)]
        public string InternationalNumber { get; set; }

        [Column(Name = "new_edition_date")]
        public string NewEditionDate { get; set; }

        [Column(Name = "publication_date")]
        public string PublicationDate { get; set; }

        [Column(Name = "title")]
        public string Title { get; set; }

        [Column(Name = "scale", CanBeNull = true)]
        public int? Scale { get; set; }

        [Column(Name = "folio", CanBeNull = true)]
        public string Folio { get; set; }
    }
}
