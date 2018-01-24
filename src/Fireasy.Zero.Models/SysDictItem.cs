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
    /// �����ֵ��� ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysDictItem", Description = "�����ֵ���")]
    [MetadataType(typeof(SysDictItemMetadata))]
    public partial class SysDictItem : LightEntity<SysDictItem>
    {
        /// <summary>
        /// ��ȡ�������ֵ���ID��
        /// </summary>

        [PropertyMapping(ColumnName = "ItemID", Description = "�ֵ���ID", GenerateType = IdentityGenerateType.AutoIncrement, IsPrimaryKey = true, IsNullable = false)]
        public virtual int ItemID { get; set; }

        /// <summary>
        /// ��ȡ���������ID��
        /// </summary>

        [PropertyMapping(ColumnName = "TypeID", Description = "���ID", IsNullable = false)]
        public virtual int TypeID { get; set; }

        /// <summary>
        /// ��ȡ�����ñ��롣
        /// </summary>

        [PropertyMapping(ColumnName = "Code", Description = "����", Length = 50, IsNullable = true)]
        public virtual string Code { get; set; }


        /// <summary>
        /// ��ȡ���������ơ�
        /// </summary>

        [PropertyMapping(ColumnName = "Name", Description = "����", Length = 100, IsNullable = true)]
        public virtual string Name { get; set; }

        /// <summary>
        /// ��ȡ������ƴ���롣
        /// </summary>

        [PropertyMapping(ColumnName = "PyCode", Description = "ƴ����", Length = 100, IsNullable = true)]
        public virtual string PyCode { get; set; }

        /// <summary>
        /// ��ȡ������ֵ��
        /// </summary>

        [PropertyMapping(ColumnName = "Value", Description = "ֵ", IsNullable = true)]
        public virtual int? Value { get; set; }

        /// <summary>
        /// ��ȡ����������
        /// </summary>

        [PropertyMapping(ColumnName = "OrderNo", Description = "����", IsNullable = true)]
        public virtual int OrderNo { get; set; }

        /// <summary>
        /// ��ȡ������״̬��
        /// </summary>

        [PropertyMapping(ColumnName = "State", Description = "״̬", IsNullable = false)]
        public virtual StateFlags State { get; set; }

        /// <summary>
        /// ��ȡ�����ù��� <see cref="SysDictType"/> ����
        /// </summary>
        public virtual SysDictType SysDictType { get; set; }

    }
	
    public class SysDictItemMetadata
    {
        /// <summary>
        /// ���� ItemID ����֤���ԡ�
        /// </summary>
        [Required]
        public object ItemID { get; set; }

        /// <summary>
        /// ���� TypeID ����֤���ԡ�
        /// </summary>
        [Required]
        public object TypeID { get; set; }

        /// <summary>
        /// ���� Code ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        public object Code { get; set; }

        /// <summary>
        /// ���� Name ����֤���ԡ�
        /// </summary>
        [StringLength(100)]
        [Required]
        public object Name { get; set; }

        /// <summary>
        /// ���� PyCode ��ƴ����
        /// </summary>
        [StringLength(100)]
        public object PyCode { get; set; }

        /// <summary>
        /// ���� Value ����֤���ԡ�
        /// </summary>
        [Required]
        public object Value { get; set; }

        /// <summary>
        /// ���� OrderNo ����֤���ԡ�
        /// </summary>
        public object OrderNo { get; set; }

        /// <summary>
        /// ���� State ����֤���ԡ�
        /// </summary>
        [Required]
        public object State { get; set; }

    }
}

