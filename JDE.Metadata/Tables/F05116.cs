using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05116 - .
/// </summary>
public class F05116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTRRTY.
        /// </summary>
        public const string LTRRTY = "LTRRTY";

        /// <summary>
        /// LTAN8.
        /// </summary>
        public const string LTAN8 = "LTAN8";

        /// <summary>
        /// LTCMPC.
        /// </summary>
        public const string LTCMPC = "LTCMPC";

        /// <summary>
        /// LTSEQ.
        /// </summary>
        public const string LTSEQ = "LTSEQ";

        /// <summary>
        /// LTSTA.
        /// </summary>
        public const string LTSTA = "LTSTA";

        /// <summary>
        /// LTSSDT.
        /// </summary>
        public const string LTSSDT = "LTSSDT";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTUPMT.
        /// </summary>
        public const string LTUPMT = "LTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTRRTY", "LTRRTY", JdeDataType.String, 4, true, true),
        new JdeField("LTAN8", "LTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LTCMPC", "LTCMPC", JdeDataType.String, 20, true, true),
        new JdeField("LTSEQ", "LTSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LTSTA", "LTSTA", JdeDataType.String, 2),
        new JdeField("LTSSDT", "LTSSDT", JdeDataType.Numeric),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTUPMT", "LTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05116_0", "Primary Key on LTRRTY, LTAN8, LTCMPC, LTSEQ", new[] { "LTRRTY", "LTAN8", "LTCMPC", "LTSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
