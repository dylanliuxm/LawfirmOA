using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.EasyUIHelper
{
    /// <summary>
    /// EasyUI.DataGrid要求必须为小写类型，因使用JS进行二次转换大小写会造成大量重复代码，故此处属性使用小写模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EasyUIDataGrid<T>
    {
        public int total { get; set; }

        public IEnumerable<T> rows { get; set; }
    }
}
