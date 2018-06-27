using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupitreEPSI_BO;

namespace PupitreEPSI_DAL
{
    public static class Extension
    {
        public static List<Cours_BO> ToListlistCours(this List<Cour> list)
        {
            if(list == null)
            {
                return null;
            }
            List<Cours_BO> listCoursBO = new List<Cours_BO>();
            foreach(Cour crs in list)
            {
                using (var db = new Workshop4Entities())
                {
                    var bo = new Cours_BO
                    {
                        Id = crs.id,
                        Salle = crs.salle,
                        HoraireDeb = crs.heureDebut,
                        HoraireFin = crs.heureFin
                    };
                }
            }
            return listCoursBO;
        }
    }
}
