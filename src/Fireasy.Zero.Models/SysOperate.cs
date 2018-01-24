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
    /// ���� ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysOperate", Description = "����")]
    [MetadataType(typeof(SysOperateMetadata))]
    public partial class SysOperate : LightEntity<SysOperate>
    {
        /// <summary>
        /// ��ȡ�����ò���ID��
        /// </summary>

        [PropertyMapping(ColumnName = "OperID", Description = "����ID", GenerateType = IdentityGenerateType.AutoIncrement, IsPrimaryKey = true, IsNullable = false)]
        public virtual int OperID { get; set; }

        /// <summary>
        /// ��ȡ������ģ��ID��
        /// </summary>

        [PropertyMapping(ColumnName = "ModuleID", Description = "ģ��ID", IsNullable = false)]
        public virtual int ModuleID { get; set; }

        /// <summary>
        /// ��ȡ�����ñ��롣
        /// </summary>

        [PropertyMapping(ColumnName = "Code", Description = "����", Length = 20, IsNullable = true)]
        public virtual string Code { get; set; }

        /// <summary>
        /// ��ȡ���������ơ�
        /// </summary>

        [PropertyMapping(ColumnName = "Name", Description = "����", Length = 20, IsNullable = true)]
        public virtual string Name { get; set; }

        /// <summary>
        /// ��ȡ������ͼ�ꡣ
        /// </summary>

        [PropertyMapping(ColumnName = "Icon", Description = "ͼ��", Length = 50, IsNullable = true)]
        public virtual string Icon { get; set; }

        /// <summary>
        /// ��ȡ������״̬��
        /// </summary>

        [PropertyMapping(ColumnName = "State", Description = "״̬", IsNullable = false)]
        public virtual StateFlags State { get; set; }

        /// <summary>
        /// ��ȡ����������
        /// </summary>

        [PropertyMapping(ColumnName = "OrderNo", Description = "����", IsNullable = false)]
        public virtual int OrderNo { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysModule"/> ����
        /// </summary>
        public virtual SysModule SysModule { get; set; }

        /// <summary>
        /// ��ȡ������ <see cref="SysOperatePermission"/> ����ʵ�弯��
        /// </summary>
        public virtual EntitySet<SysOperatePermission> SysOperatePermissions { get; set; }

    }
	
    public class SysOperateMetadata
    {
        /// <summary>
        /// ���� OperID ����֤���ԡ�
        /// </summary>
        [Required]
        public object OperID { get; set; }

        /// <summary>
        /// ���� ModuleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object ModuleID { get; set; }

        /// <summary>
        /// ���� Code ����֤���ԡ�
        /// </summary>
        [StringLength(20)]
        [Required]
        public object Code { get; set; }

        /// <summary>
        /// ���� Name ����֤���ԡ�
        /// </summary>
        [StringLength(20)]
        [Required]
        public object Name { get; set; }

        /// <summary>
        /// ���� Icon ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Icon { get; set; }

        /// <summary>
        /// ���� State ����֤���ԡ�
        /// </summary>
        [Required]
        public object State { get; set; }

    }
}

