using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PupitreEPSI_BO;

namespace PupitreEPSI_DAL
{
    public class Cours_DAL
    {
        public static List<Cours_BO> GetCours()
        {
            using (var context = new Workshop4Entities)
            {
                List<Cour> ListCours = context.Cours.ToList();
                List<Cours_BO> ListCoursBO = listCours.TolistCoursBO();
            }
        }
    }
}
