using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PupitreEPSI_BO
{
    public class Cours_BO
    {
        public int Id { get; set; }
        public int Salle { get; set; }
        public TimeSpan HoraireDeb { get; set; }
        public TimeSpan HoraireFin { get; set; }
    }
}