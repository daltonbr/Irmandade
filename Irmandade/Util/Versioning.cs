using System;
using System.Deployment.Application;

namespace Irmandade.Util
{
    public class Versioning
    {
        public static Version AssemblyVersion
        {
            get
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
        }
    }

}

