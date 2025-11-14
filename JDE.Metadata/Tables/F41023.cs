using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41023 - .
/// </summary>
public class F41023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILITM.
        /// </summary>
        public const string ILITM = "ILITM";

        /// <summary>
        /// ILMCU.
        /// </summary>
        public const string ILMCU = "ILMCU";

        /// <summary>
        /// ILLOCN.
        /// </summary>
        public const string ILLOCN = "ILLOCN";

        /// <summary>
        /// ILREPT.
        /// </summary>
        public const string ILREPT = "ILREPT";

        /// <summary>
        /// ILLOCP.
        /// </summary>
        public const string ILLOCP = "ILLOCP";

        /// <summary>
        /// ILPSTH.
        /// </summary>
        public const string ILPSTH = "ILPSTH";

        /// <summary>
        /// ILVEND.
        /// </summary>
        public const string ILVEND = "ILVEND";

        /// <summary>
        /// ILUPDJ.
        /// </summary>
        public const string ILUPDJ = "ILUPDJ";

        /// <summary>
        /// ILTDAY.
        /// </summary>
        public const string ILTDAY = "ILTDAY";

        /// <summary>
        /// ILJOBN.
        /// </summary>
        public const string ILJOBN = "ILJOBN";

        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILPID.
        /// </summary>
        public const string ILPID = "ILPID";
    }

    /// <inheritdoc />
    public override string TableName => "F41023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILITM", "ILITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ILMCU", "ILMCU", JdeDataType.String, 24, true, true),
        new JdeField("ILLOCN", "ILLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ILREPT", "ILREPT", JdeDataType.String, 2),
        new JdeField("ILLOCP", "ILLOCP", JdeDataType.String, 2),
        new JdeField("ILPSTH", "ILPSTH", JdeDataType.String, 2),
        new JdeField("ILVEND", "ILVEND", JdeDataType.Numeric),
        new JdeField("ILUPDJ", "ILUPDJ", JdeDataType.Numeric),
        new JdeField("ILTDAY", "ILTDAY", JdeDataType.Numeric),
        new JdeField("ILJOBN", "ILJOBN", JdeDataType.String, 20),
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20),
        new JdeField("ILPID", "ILPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41023_0", "Primary Key on ILITM, ILMCU, ILLOCN", new[] { "ILITM", "ILMCU", "ILLOCN" }, isUnique: true, isPrimaryKey: true)
    };
}
