using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_9
{
    class Boss
    {
        public delegate void MachineStateHandler(int voltage);
        public delegate void MachineVersionHandler(int version);

        public event MachineVersionHandler onUpgrade;
        public event MachineStateHandler onTurnOn;

        public void TurnOn(int voltage)
        {
            onTurnOn(voltage);
        }

        public void Update(int version)
        {
            onUpgrade(version);
        }
    }
}
