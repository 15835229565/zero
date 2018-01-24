// **************************************
// ���ɣ�CodeBuilder (http://www.fireasy.cn/codebuilder)
// ��Ŀ��Fireasy Zero
// ��Ȩ��Copyright Fireasy
// ���ߣ�Huangxd
// ʱ�䣺10/12/2017 21:26:05
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
    [EntityMapping("SysOrgPermission", Description = "����Ȩ��")]
    [MetadataType(typeof(SysOrgPermissionMetadata))]
    public partial class SysOrgPermission : LightEntity<SysOrgPermission>
    {
        /// <summary>
        /// ��ȡ�����ý�ɫID��
        /// </summary>

        [PropertyMapping(ColumnName = "RoleID", Description = "��ɫID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int RoleID { get; set; }

        /// <summary>
        /// ��ȡ�����û���ID��
        /// </summary>

        [PropertyMapping(ColumnName = "OrgID", Description = "����ID", IsPrimaryKey = true, IsNullable = false)]
        public virtual int OrgID { get; set; }

    }
	
    public class SysOrgPermissionMetadata
    {
        /// <summary>
        /// ���� RoleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object RoleID { get; set; }

        /// <summary>
        /// ���� OrgID ����֤���ԡ�
        /// </summary>
        [Required]
        public object OrgID { get; set; }

    }
}

