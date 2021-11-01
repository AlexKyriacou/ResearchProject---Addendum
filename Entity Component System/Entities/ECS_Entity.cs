using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public class ECS_Entity
    {
		public List<ECS_Component> components;
		//Try Dict Later
		//public Dictionary<Type, Component> components;
		public ECS_Entity()
		{
			components = new();
		}

		public void AddComponent(ECS_Component c)
		{
			components.Add(c);
			c.entity = this;
		}
		public T GetComponent<T>(ECS_ComponentTypes type) where T : ECS_Component
		{
			foreach (ECS_Component component in components)
			{
				if(component.componentType == type)
                {
					return (T)component;
				}
			}
			return null;
		}
	}
}
