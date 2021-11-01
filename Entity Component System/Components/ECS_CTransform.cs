using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public class ECS_CTransform : ECS_Component
    {
        public ECS_CTransform()
        {
            componentType = ECS_ComponentTypes.Transform;
        }
        public int x, y;
    }
}
