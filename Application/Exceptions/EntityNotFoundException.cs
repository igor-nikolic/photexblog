using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(int id, Type type) : base($"Entity {type.Name} - Id {id} was not found.")
        {

        }
    }
}
