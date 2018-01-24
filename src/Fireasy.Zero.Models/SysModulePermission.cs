// **************************************
// ���ɣ�CodeBuilder (http://www.fireasy.cn/codebuilder)
// ��Ŀ��Fireasy Zero
// ��Ȩ��Copyright Fireasy
// ���ߣ�Huangxd
// ʱ�䣺10/12/2017 21:26:06
// **************************************
using System;
using Fireasy.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Fireasy.Zero.Models
{
    /// <summary>
    /// ����Ȩ�� ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysModulePermission", Description = "����Ȩ��")]
    [MetadataType(typeof(SysModulePermissionMetadata))]
    public partial class SysModulePermission : LightEntity<SysModulePermission>
    {
        /// <summary>
        /// ��ȡ�����ý�ɫID��
        /// </summary>

        [PropertyMapping(ColumnName = "RoleID", Description = "��ɫID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int RoleID { get; set; }

        /// <summary>
        /// ��ȡ������ģ��ID��
        /// </summary>

        [PropertyMapping(ColumnName = "ModuleID", Description = "ģ��ID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int ModuleID { get; set; }

    }
	
    public class SysModulePermissionMetadata
    {
        /// <summary>
        /// ���� RoleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object RoleID { get; set; }

        /// <summary>
        /// ���� ModuleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object ModuleID { get; set; }

    }
}

