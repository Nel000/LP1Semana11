using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class CompareByName : IComparer<Player>
    {
        private bool orderUp;

        public CompareByName(bool orderUp)
        {
            if (!orderUp)
                this.orderUp = false;
            else
                this.orderUp = true;

        }

        public int Compare(Player x, Player y)
        {
            if (!orderUp)
                return String.Compare(x.Name, y.Name);
            else
                return String.Compare(y.Name, x.Name);
        }
    }
}