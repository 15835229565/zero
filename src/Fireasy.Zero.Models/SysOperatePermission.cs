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
    [EntityMapping("SysOperatePermission", Description = "����Ȩ��")]
    [MetadataType(typeof(SysOperatePermissionMetadata))]
    public partial class SysOperatePermission : LightEntity<SysOperatePermission>
    {
        /// <summary>
        /// ��ȡ������ģ��ID��
        /// </summary>

        [PropertyMapping(ColumnName = "ModuleID", Description = "ģ��ID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int ModuleID { get; set; }

        /// <summary>
        /// ��ȡ�����ò���ID��
        /// </summary>

        [PropertyMapping(ColumnName = "OperID", Description = "����ID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int OperID { get; set; }

        /// <summary>
        /// ��ȡ�����ý�ɫID��
        /// </summary>

        [PropertyMapping(ColumnName = "RoleID", Description = "��ɫID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int RoleID { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysOperate"/> ����
        /// </summary>
        public virtual SysOperate SysOperate { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysModule"/> ����
        /// </summary>
        public virtual SysModule SysModule { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysRole"/> ����
        /// </summary>
        public virtual SysRole SysRole { get; set; }

    }
	
    public class SysOperatePermissionMetadata
    {
        /// <summary>
        /// ���� ModuleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object ModuleID { get; set; }

        /// <summary>
        /// ���� OperID ����֤���ԡ�
        /// </summary>
        [Required]
        public object OperID { get; set; }

        /// <summary>
        /// ���� RoleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object RoleID { get; set; }

    }
}

