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
    /// ����ģ�� ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysModule", Description = "����ģ��")]
    [MetadataType(typeof(SysModuleMetadata))]
    public partial class SysModule : LightEntity<SysModule>
    {
        /// <summary>
        /// ��ȡ������ģ��ID��
        /// </summary>

        [PropertyMapping(ColumnName = "ModuleID", Description = "ģ��ID", GenerateType = IdentityGenerateType.AutoIncrement, IsPrimaryKey = true, IsNullable = false)]
        public virtual int ModuleID { get; set; }

        /// <summary>
        /// ��ȡ���������ơ�
        /// </summary>

        [PropertyMapping(ColumnName = "Name", Description = "����", Length = 100, IsNullable = true)]
        public virtual string Name { get; set; }

        /// <summary>
        /// ��ȡ�����ñ��롣
        /// </summary>

        [PropertyMapping(ColumnName = "Code", Description = "����", Length = 50, IsNullable = true)]
        public virtual string Code { get; set; }

        /// <summary>
        /// ��ȡ�����õ�ַ��
        /// </summary>

        [PropertyMapping(ColumnName = "Url", Description = "��ַ", Length = 100, IsNullable = true)]
        public virtual string Url { get; set; }

        /// <summary>
        /// ��ȡ�����ò�����
        /// </summary>

        [PropertyMapping(ColumnName = "Arguments", Description = "����", Length = 50, IsNullable = true)]
        public virtual string Arguments { get; set; }

        /// <summary>
        /// ��ȡ������ͼ��1��
        /// </summary>

        [PropertyMapping(ColumnName = "Icon1", Description = "ͼ��1", Length = 50, IsNullable = true)]
        public virtual string Icon1 { get; set; }

        /// <summary>
        /// ��ȡ������ͼ��2��
        /// </summary>

        [PropertyMapping(ColumnName = "Icon2", Description = "ͼ��2", Length = 50, IsNullable = true)]
        public virtual string Icon2 { get; set; }

        /// <summary>
        /// ��ȡ������ͼ��2��
        /// </summary>

        [PropertyMapping(ColumnName = "Icon3", Description = "ͼ��2", Length = 50, IsNullable = true)]
        public virtual string Icon3 { get; set; }

        /// <summary>
        /// ��ȡ������ƴ���롣
        /// </summary>

        [PropertyMapping(ColumnName = "PyCode", Description = "ƴ����", Length = 50, IsNullable = true)]
        public virtual string PyCode { get; set; }

        /// <summary>
        /// ��ȡ������״̬��
        /// </summary>

        [PropertyMapping(ColumnName = "State", Description = "״̬", IsNullable = false)]
        public virtual StateFlags State { get; set; }

        /// <summary>
        /// ��ȡ����������
        /// </summary>

        [PropertyMapping(ColumnName = "OrderNo", Description = "����", IsNullable = true)]
        public virtual int OrderNo { get; set; }

        /// <summary>
        /// ��ȡ�����ñ�ע��
        /// </summary>

        [PropertyMapping(ColumnName = "Remark", Description = "��ע", Length = 500, IsNullable = true)]
        public virtual string Remark { get; set; }

        /// <summary>
        /// ��ȡ������ <see cref="SysOperate"/> ����ʵ�弯��
        /// </summary>
        public virtual EntitySet<SysOperate> SysOperates { get; set; }

        /// <summary>
        /// ��ȡ������ <see cref="SysModulePermission"/> ����ʵ�弯��
        /// </summary>
        public virtual EntitySet<SysModulePermission> SysModulePermissions { get; set; }

        /// <summary>
        /// ��ȡ������ <see cref="SysOperatePermission"/> ����ʵ�弯��
        /// </summary>
        public virtual EntitySet<SysOperatePermission> SysOperatePermissions { get; set; }

    }
	
    public class SysModuleMetadata
    {
        /// <summary>
        /// ���� ModuleID ����֤���ԡ�
        /// </summary>
        [Required]
        public object ModuleID { get; set; }

        /// <summary>
        /// ���� Name ����֤���ԡ�
        /// </summary>
        [StringLength(100)]
        [Required]
        public object Name { get; set; }

        /// <summary>
        /// ���� Code ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Code { get; set; }

        /// <summary>
        /// ���� Url ����֤���ԡ�
        /// </summary>
        [StringLength(100)]
        public object Url { get; set; }

        /// <summary>
        /// ���� Arguments ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Arguments { get; set; }

        /// <summary>
        /// ���� Icon1 ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Icon1 { get; set; }

        /// <summary>
        /// ���� Icon2 ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Icon2 { get; set; }

        /// <summary>
        /// ���� Icon3 ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Icon3 { get; set; }

        /// <summary>
        /// ���� PyCode ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object PyCode { get; set; }

        /// <summary>
        /// ���� State ����֤���ԡ�
        /// </summary>
        [Required]
        public object State { get; set; }

        /// <summary>
        /// ���� OrderNo ����֤���ԡ�
        /// </summary>
        [Required]
        public object OrderNo { get; set; }

        /// <summary>
        /// ���� Remark ����֤���ԡ�
        /// </summary>
        [StringLength(500)]
        public object Remark { get; set; }

    }
}

