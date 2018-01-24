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
    /// ϵͳ��־ ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysLog", Description = "ϵͳ��־")]
    [MetadataType(typeof(SysLogMetadata))]
    public partial class SysLog : LightEntity<SysLog>
    {
        /// <summary>
        /// ��ȡ��������־ID��
        /// </summary>

        [PropertyMapping(ColumnName = "LogID", Description = "��־ID", GenerateType = IdentityGenerateType.AutoIncrement, IsPrimaryKey = true, IsNullable = false)]
        public virtual int LogID { get; set; }

        /// <summary>
        /// ��ȡ��������־���͡�
        /// </summary>

        [PropertyMapping(ColumnName = "LogType", Description = "��־����", IsNullable = false)]
        public virtual int LogType { get; set; }

        /// <summary>
        /// ��ȡ�����ñ��⡣
        /// </summary>

        [PropertyMapping(ColumnName = "Title", Description = "����", Length = 200, IsNullable = true)]
        public virtual string Title { get; set; }

        /// <summary>
        /// ��ȡ���������ݡ�
        /// </summary>

        [PropertyMapping(ColumnName = "Content", Description = "����", IsNullable = true)]
        public virtual string Content { get; set; }

        /// <summary>
        /// ��ȡ�����û���ID��
        /// </summary>

        [PropertyMapping(ColumnName = "OrgID", Description = "����ID", IsNullable = false)]
        public virtual int OrgID { get; set; }

        /// <summary>
        /// ��ȡ�����ò�����ID��
        /// </summary>

        [PropertyMapping(ColumnName = "OperateUserID", Description = "������ID", IsNullable = false)]
        public virtual int OperateUserID { get; set; }

        /// <summary>
        /// ��ȡ�����ò�����������
        /// </summary>

        [PropertyMapping(ColumnName = "OperateUserName", Description = "����������", Length = 20, IsNullable = true)]
        public virtual string OperateUserName { get; set; }

        /// <summary>
        /// ��ȡ�����ü�¼���ڡ�
        /// </summary>

        [PropertyMapping(ColumnName = "LogTime", Description = "��¼����", IsNullable = true)]
        public virtual DateTime? LogTime { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysOrg"/> ����
        /// </summary>
        public virtual SysOrg SysOrg { get; set; }

    }
	
    public class SysLogMetadata
    {
        /// <summary>
        /// ���� LogID ����֤���ԡ�
        /// </summary>
        [Required]
        public object LogID { get; set; }

        /// <summary>
        /// ���� LogType ����֤���ԡ�
        /// </summary>
        [Required]
        public object LogType { get; set; }

        /// <summary>
        /// ���� Title ����֤���ԡ�
        /// </summary>
        [StringLength(200)]
        public object Title { get; set; }

        /// <summary>
        /// ���� Content ����֤���ԡ�
        /// </summary>
        public object Content { get; set; }

        /// <summary>
        /// ���� OrgID ����֤���ԡ�
        /// </summary>
        [Required]
        public object OrgID { get; set; }

        /// <summary>
        /// ���� OperateUserID ����֤���ԡ�
        /// </summary>
        [Required]
        public object OperateUserID { get; set; }

        /// <summary>
        /// ���� OperateUserName ����֤���ԡ�
        /// </summary>
        [StringLength(20)]
        public object OperateUserName { get; set; }

        /// <summary>
        /// ���� LogTime ����֤���ԡ�
        /// </summary>
        public object LogTime { get; set; }

    }
}

