using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S340 - .
/// </summary>
public class F74S340 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MFDCTO.
        /// </summary>
        public const string MFDCTO = "MFDCTO";

        /// <summary>
        /// MFDOCO.
        /// </summary>
        public const string MFDOCO = "MFDOCO";

        /// <summary>
        /// MFSFXO.
        /// </summary>
        public const string MFSFXO = "MFSFXO";

        /// <summary>
        /// MFLNID.
        /// </summary>
        public const string MFLNID = "MFLNID";

        /// <summary>
        /// MFUPMJ.
        /// </summary>
        public const string MFUPMJ = "MFUPMJ";

        /// <summary>
        /// MFUPMT.
        /// </summary>
        public const string MFUPMT = "MFUPMT";

        /// <summary>
        /// MFKCOO.
        /// </summary>
        public const string MFKCOO = "MFKCOO";

        /// <summary>
        /// MFS740103.
        /// </summary>
        public const string MFS740103 = "MFS740103";

        /// <summary>
        /// MFS740100.
        /// </summary>
        public const string MFS740100 = "MFS740100";

        /// <summary>
        /// MFS740101.
        /// </summary>
        public const string MFS740101 = "MFS740101";

        /// <summary>
        /// MFUSER.
        /// </summary>
        public const string MFUSER = "MFUSER";

        /// <summary>
        /// MFPID.
        /// </summary>
        public const string MFPID = "MFPID";

        /// <summary>
        /// MFMUPM.
        /// </summary>
        public const string MFMUPM = "MFMUPM";

        /// <summary>
        /// MFMUPT.
        /// </summary>
        public const string MFMUPT = "MFMUPT";

        /// <summary>
        /// MFJOBN.
        /// </summary>
        public const string MFJOBN = "MFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74S340";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MFDCTO", "MFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MFDOCO", "MFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("MFSFXO", "MFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("MFLNID", "MFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MFUPMJ", "MFUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MFUPMT", "MFUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("MFKCOO", "MFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("MFS740103", "MFS740103", JdeDataType.String, 26),
        new JdeField("MFS740100", "MFS740100", JdeDataType.Numeric),
        new JdeField("MFS740101", "MFS740101", JdeDataType.String, 4),
        new JdeField("MFUSER", "MFUSER", JdeDataType.String, 20),
        new JdeField("MFPID", "MFPID", JdeDataType.String, 20),
        new JdeField("MFMUPM", "MFMUPM", JdeDataType.Numeric),
        new JdeField("MFMUPT", "MFMUPT", JdeDataType.Numeric),
        new JdeField("MFJOBN", "MFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S340_0", "Primary Key on MFDCTO, MFDOCO, MFSFXO, MFLNID, MFUPMJ, MFUPMT, MFKCOO", new[] { "MFDCTO", "MFDOCO", "MFSFXO", "MFLNID", "MFUPMJ", "MFUPMT", "MFKCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S340_2", "Index on MFS740103", new[] { "MFS740103" }),
        new JdeIndex("F74S340_3", "Index on MFS740100, MFS740101", new[] { "MFS740100", "MFS740101" })
    };
}
