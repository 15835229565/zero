// **************************************
// ���ɣ�CodeBuilder (http://www.fireasy.cn/codebuilder)
// ��Ŀ��Fireasy Zero
// ��Ȩ��Copyright Fireasy
// ���ߣ�Huangxd
// ʱ�䣺10/12/2017 21:26:11
// **************************************
using System;
using Fireasy.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Fireasy.Zero.Models
{
    /// <summary>
    /// ��Ա��ɫ ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysUserRole", Description = "��Ա��ɫ")]
    [MetadataType(typeof(SysUserRoleMetadata))]
    public partial class SysUserRole : LightEntity<SysUserRole>
    {
        /// <summary>
        /// ��ȡ��������ԱID��
        /// </summary>

        [PropertyMapping(ColumnName = "UserID", Description = "��ԱID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int UserID { get; set; }

        /// <summary>
        /// ��ȡ�����ý�ɫID��
        /// </summary>

        [PropertyMapping(ColumnName = "RoleID", Description = "��ɫID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int RoleID { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysUser"/> ����
        /// </summary>
        public virtual SysUser SysUser { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysRole"/> ����
        /// </summary>
        public virtual SysRole SysRole { get; set; }

    }
	
    public class SysUserRoleMetadata
    {
        /// <summary>
        /// ���� UserID ����֤���ԡ�
        /// </summary>
        [Required]
        public object UserID { get; set; }

        /// <summary>
        /// ���� RoleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object RoleID { get; set; }

    }
}

