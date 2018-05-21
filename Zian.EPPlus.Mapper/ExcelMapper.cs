using System;
using System.Collections.Generic;

namespace Zian.EPPlus.Mapper
{
    public class ExcelMapper
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Type MapperType { get; set; }


        public Dictionary<string,CellMapper> CellMappers { get; set; }
    }
}