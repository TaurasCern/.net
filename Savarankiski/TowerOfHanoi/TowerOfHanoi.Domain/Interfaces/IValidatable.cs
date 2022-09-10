using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Interfaces
{
    public interface IValidatable
    {
        bool IsValidPickUp(ConsoleKeyInfo choice);
        bool IsValidPlace(ConsoleKeyInfo choice);
    }
}
