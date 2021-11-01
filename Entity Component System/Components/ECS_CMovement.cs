using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public class ECS_CMovement : ECS_Component
    {
        public ECS_CMovement()
        {
            componentType = ECS_ComponentTypes.Movement;
        }
        public int dx, dy;
    }
}
