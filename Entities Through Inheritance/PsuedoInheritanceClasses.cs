using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public abstract class PsuedoInheritance1 : DynamicEntity
    {
        public PsuedoInheritance1(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
        }

        public override void Collide()
        {
        }

        public override void Render()
        {
        }

        public override void Update()
        {
        }
    }
    public abstract class PsuedoInheritance2 : PsuedoInheritance1
    {
        public PsuedoInheritance2(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
        }

        public override void Collide()
        {
        }

        public override void Render()
        {
        }

        public override void Update()
        {
        }
    }
    public abstract class PsuedoInheritance3 : PsuedoInheritance2
    {
        public PsuedoInheritance3(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
        }

        public override void Collide()
        {
        }

        public override void Render()
        {
        }

        public override void Update()
        {
        }
    }
    public abstract class PsuedoInheritance4 : PsuedoInheritance3
    {
        public PsuedoInheritance4(int x, int y, int dx, int dy) : base(x, y, dx, dy)
        {
        }

        public override void Collide()
        {
        }

        public override void Render()
        {
        }

        public override void Update()
        {
        }
    }
}
