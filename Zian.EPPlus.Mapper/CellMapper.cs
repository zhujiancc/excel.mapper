using System;
using System.Collections.Generic;

namespace Zian.EPPlus.Mapper
{
    public class CellMapper
    {
        public string DisplayName { get; set; }
        
        public object Value { get; set; }

        public int Index { get; set; }

        public Func<CellMapper,CellMapper> Format { get; set; } 
        public Func<CellMapper,CellMapper> Style { get; set; } 
        public Func<CellMapper,CellMapper> CellLayout { get; set; } 
        
        
    }
}