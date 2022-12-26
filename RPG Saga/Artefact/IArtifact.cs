using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artefact
{
    using Class;
    public interface IArtefact
    {
        string Name { get; set; }
        float UpCharacteristic(IPlayers Player, float Characteristic);

    }
}
