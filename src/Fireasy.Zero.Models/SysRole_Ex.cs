// **************************************
// ���ɣ�CodeBuilder (http://www.fireasy.cn/codebuilder)
// ��Ŀ��Fireasy Zero
// ��Ȩ��Copyright Fireasy
// ���ߣ�Huangxd
// ʱ�䣺10/12/2017 21:26:08
// **************************************
using System;
using Fireasy.Data.Entity;

namespace Fireasy.Zero.Models
{
    /// <summary>
    /// ��ɫ ʵ���ࡣ
    /// </summary>
    public partial class SysRole
    {
        /// <summary>
        /// �Ƿ���䡣
        /// </summary>
        public bool Assign { get; set; }

        /// <summary>
        /// �������ơ�
        /// </summary>
        public string AttributeName { get; set; }
    }
}
