using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonbiniBrazor.Shared
{
    public class BaseItem
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品リンク
        /// </summary>
        public string Namelink { get; set; }

        /// <summary>
        /// 値段
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        public string Area { get; set; }
    }
}
