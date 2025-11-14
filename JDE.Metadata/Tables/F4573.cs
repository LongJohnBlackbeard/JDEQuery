using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4573 - .
/// </summary>
public class F4573 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFDOCO.
        /// </summary>
        public const string RFDOCO = "RFDOCO";

        /// <summary>
        /// RFDCTO.
        /// </summary>
        public const string RFDCTO = "RFDCTO";

        /// <summary>
        /// RFKCOO.
        /// </summary>
        public const string RFKCOO = "RFKCOO";

        /// <summary>
        /// RFOGNO.
        /// </summary>
        public const string RFOGNO = "RFOGNO";

        /// <summary>
        /// RFLNID.
        /// </summary>
        public const string RFLNID = "RFLNID";

        /// <summary>
        /// RFLITM.
        /// </summary>
        public const string RFLITM = "RFLITM";

        /// <summary>
        /// RFSOQS.
        /// </summary>
        public const string RFSOQS = "RFSOQS";

        /// <summary>
        /// RFUOM.
        /// </summary>
        public const string RFUOM = "RFUOM";

        /// <summary>
        /// RFFGTY.
        /// </summary>
        public const string RFFGTY = "RFFGTY";

        /// <summary>
        /// RFCATLG.
        /// </summary>
        public const string RFCATLG = "RFCATLG";

        /// <summary>
        /// RFAST.
        /// </summary>
        public const string RFAST = "RFAST";
    }

    /// <inheritdoc />
    public override string TableName => "F4573";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFDOCO", "RFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RFDCTO", "RFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RFKCOO", "RFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RFOGNO", "RFOGNO", JdeDataType.Numeric, null, true, true),
        new JdeField("RFLNID", "RFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RFLITM", "RFLITM", JdeDataType.String, 50, true, true),
        new JdeField("RFSOQS", "RFSOQS", JdeDataType.Numeric),
        new JdeField("RFUOM", "RFUOM", JdeDataType.String, 4),
        new JdeField("RFFGTY", "RFFGTY", JdeDataType.String, 2),
        new JdeField("RFCATLG", "RFCATLG", JdeDataType.String, 20),
        new JdeField("RFAST", "RFAST", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4573_0", "Primary Key on RFDOCO, RFDCTO, RFKCOO, RFOGNO, RFLNID, RFLITM", new[] { "RFDOCO", "RFDCTO", "RFKCOO", "RFOGNO", "RFLNID", "RFLITM" }, isUnique: true, isPrimaryKey: true)
    };
}
