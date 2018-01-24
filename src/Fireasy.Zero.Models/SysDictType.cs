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
    /// �����ֵ���� ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("SysDictType", Description = "�����ֵ����")]
    [MetadataType(typeof(SysDictTypeMetadata))]
    public partial class SysDictType : LightEntity<SysDictType>
    {
        /// <summary>
        /// ��ȡ���������ID��
        /// </summary>

        [PropertyMapping(ColumnName = "TypeID", Description = "���ID", GenerateType = IdentityGenerateType.AutoIncrement, IsPrimaryKey = true, IsNullable = false)]
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
        /// ��ȡ�������Ƿ������ṹ��
        /// </summary>

        [PropertyMapping(ColumnName = "IsTree", Description = "�Ƿ������ṹ", IsNullable = false)]
        public virtual bool IsTree { get; set; }

        /// <summary>
        /// ��ȡ�����ñ��볤�ȡ�
        /// </summary>

        [PropertyMapping(ColumnName = "CodeLength", Description = "���볤��", IsNullable = true)]
        public virtual int? CodeLength { get; set; }

        /// <summary>
        /// ��ȡ������״̬��
        /// </summary>

        [PropertyMapping(ColumnName = "State", Description = "״̬", IsNullable = false)]
        public virtual StateFlags State { get; set; }

        /// <summary>
        /// ��ȡ������OrderNo�ֵ��������������
        /// </summary>

        [PropertyMapping(ColumnName = "OrderNo", Description = "�����ֶ�", IsNullable = true)]
        public virtual decimal OrderNo { get; set; }

        /// <summary>
        /// ��ȡ������ <see cref="SysDictItem"/> ����ʵ�弯��
        /// </summary>
        public virtual EntitySet<SysDictItem> SysDictItems { get; set; }

    }
	
    public class SysDictTypeMetadata
    {

        /// <summary>
        /// ���� TypeID ����֤���ԡ�
        /// </summary>
        [Required]
        public object TypeID { get; set; }

        /// <summary>
        /// �����ֶ�
        /// </summary>
        public object OrderNo { get; set; }

        /// <summary>
        /// ���� Code ����֤���ԡ�
        /// </summary>
        [StringLength(50)]
        [Required]
        public object Code { get; set; }

        /// <summary>
        /// ���� Name ����֤���ԡ�
        /// </summary>
        [Required]
        [StringLength(100)]
        public object Name { get; set; }

        /// <summary>
        /// ���� IsTree ����֤���ԡ�
        /// </summary>
        [Required]
        public object IsTree { get; set; }

        /// <summary>
        /// ���� CodeLength ����֤���ԡ�
        /// </summary>
        public object CodeLength { get; set; }

        /// <summary>
        /// ���� State ����֤���ԡ�
        /// </summary>
        [Required]
        public object State { get; set; }

    }
}

