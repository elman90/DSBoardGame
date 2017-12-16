using System.Collections.Generic;

namespace TEMP.Items
{
    public interface IItemValue
    {
      List<IDice> Dices { get; }
        int FixedValue { get; }
    }
}
