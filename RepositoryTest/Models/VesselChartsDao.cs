using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Models
{
    public class VesselChartsDao
    {
        public IEnumerable<VesselChart> getVesselBritishCharts(DataContext cntx)
        {
            string query = @"SELECT
    c.id,c.prefix,c.number,c.suffix,c.international_number,c.new_edition_date,c.publication_date,
    c.title,c.scale,c.status,c.status_date,c.cancel_date,c.next_edition_date,c.replaced_by,
    vc.id vessel_chart_id,
    vc.number_in_folio,
    vc.comment,
    vc.edited_by,
    vc.active,
    vc.delivery_state,
    vf.name AS vessel_folio,
    vf.id   AS vessel_folio_id,
    (
      SELECT MAX(n.number) || '/' || wn.publication_date || ', week ' || wn.number
      FROM british_notice AS n
        JOIN british_week_notice AS wn ON wn.id = n.week_notice_id
      WHERE n.chart_id = c.id AND n.active = 1
      GROUP BY wn.id
      ORDER BY publication_date DESC LIMIT 1
    )
            AS last_update,
    (
      SELECT COUNT(n.chart_id)
      FROM british_notice as n
        JOIN british_week_notice as wn ON wn.id = n.week_notice_id
        LEFT JOIN vessel_british_notice AS vn ON n.id = vn.notice_id
      WHERE n.chart_id = c.id 
            AND vn.applied_date IS NULL AND n.active = 1
            AND vc.id = vn.vessel_chart_id
      GROUP BY n.chart_id

    )       AS unapplied_notices
  FROM vessel_british_chart AS vc
    JOIN
    british_chart AS c ON vc.chart_id = c.id
    LEFT JOIN
    vessel_folio AS vf ON vc.vessel_folio_id = vf.id
ORDER BY prefix, CAST (number AS INTEGER)";
            var charts = cntx.ExecuteQuery<VesselChart>(query).ToList();
            return charts;
        }

        public void deleteVesselBritishCharts(DataContext cntx, VesselChart chart)
        {
            string query = $"DELETE FROM vessel_british_chart WHERE id IN ({chart.VesselChartId})";
            var charts = cntx.ExecuteCommand(query);
        }
    }
}
