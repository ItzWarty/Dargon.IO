﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.IO.Drive {
   public interface IDriveNodeFactory {
      IWritableDargonNode CreateFromDirectory(string directory);
   }
}
