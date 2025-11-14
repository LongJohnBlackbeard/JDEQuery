using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T033 - .
/// </summary>
public class F75T033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTDCT.
        /// </summary>
        public const string DTDCT = "DTDCT";

        /// <summary>
        /// DT75TEGTT.
        /// </summary>
        public const string DT75TEGTT = "DT75TEGTT";

        /// <summary>
        /// DT75TGFC.
        /// </summary>
        public const string DT75TGFC = "DT75TGFC";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";

        /// <summary>
        /// DTYFUTDT.
        /// </summary>
        public const string DTYFUTDT = "DTYFUTDT";

        /// <summary>
        /// DTFFU4.
        /// </summary>
        public const string DTFFU4 = "DTFFU4";

        /// <summary>
        /// DTFUT3.
        /// </summary>
        public const string DTFUT3 = "DTFUT3";

        /// <summary>
        /// DTX2.
        /// </summary>
        public const string DTX2 = "DTX2";

        /// <summary>
        /// DTFUTCH1.
        /// </summary>
        public const string DTFUTCH1 = "DTFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75T033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTDCT", "DTDCT", JdeDataType.String, 4, true, true),
        new JdeField("DT75TEGTT", "DT75TEGTT", JdeDataType.String, 4),
        new JdeField("DT75TGFC", "DT75TGFC", JdeDataType.String, 4),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric),
        new JdeField("DTYFUTDT", "DTYFUTDT", JdeDataType.Numeric),
        new JdeField("DTFFU4", "DTFFU4", JdeDataType.Numeric),
        new JdeField("DTFUT3", "DTFUT3", JdeDataType.String, 60),
        new JdeField("DTX2", "DTX2", JdeDataType.String, 2),
        new JdeField("DTFUTCH1", "DTFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T033_0", "Primary Key on DTDCT", new[] { "DTDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
