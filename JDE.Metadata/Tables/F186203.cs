using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186203 - .
/// </summary>
public class F186203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGLRSEGID.
        /// </summary>
        public const string SGLRSEGID = "SGLRSEGID";

        /// <summary>
        /// SGSEQ.
        /// </summary>
        public const string SGSEQ = "SGSEQ";

        /// <summary>
        /// SGAOR1.
        /// </summary>
        public const string SGAOR1 = "SGAOR1";

        /// <summary>
        /// SGLRSFID.
        /// </summary>
        public const string SGLRSFID = "SGLRSFID";

        /// <summary>
        /// SGVALS.
        /// </summary>
        public const string SGVALS = "SGVALS";

        /// <summary>
        /// SGLRSEGV.
        /// </summary>
        public const string SGLRSEGV = "SGLRSEGV";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGJOBN.
        /// </summary>
        public const string SGJOBN = "SGJOBN";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";

        /// <summary>
        /// SGTDAY.
        /// </summary>
        public const string SGTDAY = "SGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGLRSEGID", "SGLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("SGSEQ", "SGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SGAOR1", "SGAOR1", JdeDataType.String, 6),
        new JdeField("SGLRSFID", "SGLRSFID", JdeDataType.Numeric),
        new JdeField("SGVALS", "SGVALS", JdeDataType.String, 4),
        new JdeField("SGLRSEGV", "SGLRSEGV", JdeDataType.String, 80),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGJOBN", "SGJOBN", JdeDataType.String, 20),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric),
        new JdeField("SGTDAY", "SGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186203_0", "Primary Key on SGLRSEGID, SGSEQ", new[] { "SGLRSEGID", "SGSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
