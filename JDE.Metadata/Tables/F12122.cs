using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12122 - .
/// </summary>
public class F12122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ELUKID.
        /// </summary>
        public const string ELUKID = "ELUKID";

        /// <summary>
        /// ELNUMB.
        /// </summary>
        public const string ELNUMB = "ELNUMB";

        /// <summary>
        /// ELSEQ.
        /// </summary>
        public const string ELSEQ = "ELSEQ";

        /// <summary>
        /// ELACTIVEYN.
        /// </summary>
        public const string ELACTIVEYN = "ELACTIVEYN";

        /// <summary>
        /// ELUSER.
        /// </summary>
        public const string ELUSER = "ELUSER";

        /// <summary>
        /// ELPID.
        /// </summary>
        public const string ELPID = "ELPID";

        /// <summary>
        /// ELMKEY.
        /// </summary>
        public const string ELMKEY = "ELMKEY";

        /// <summary>
        /// ELUPMJ.
        /// </summary>
        public const string ELUPMJ = "ELUPMJ";

        /// <summary>
        /// ELUPMT.
        /// </summary>
        public const string ELUPMT = "ELUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F12122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ELUKID", "ELUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ELNUMB", "ELNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("ELSEQ", "ELSEQ", JdeDataType.Numeric),
        new JdeField("ELACTIVEYN", "ELACTIVEYN", JdeDataType.String, 2),
        new JdeField("ELUSER", "ELUSER", JdeDataType.String, 20),
        new JdeField("ELPID", "ELPID", JdeDataType.String, 20),
        new JdeField("ELMKEY", "ELMKEY", JdeDataType.String, 30),
        new JdeField("ELUPMJ", "ELUPMJ", JdeDataType.Numeric),
        new JdeField("ELUPMT", "ELUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12122_0", "Primary Key on ELUKID, ELNUMB", new[] { "ELUKID", "ELNUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F12122_2", "Index on ELUKID, ELSEQ, ELNUMB", new[] { "ELUKID", "ELSEQ", "ELNUMB" })
    };
}
