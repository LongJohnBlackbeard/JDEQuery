using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749111 - .
/// </summary>
public class F749111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGE74ACCG.
        /// </summary>
        public const string AGE74ACCG = "AGE74ACCG";

        /// <summary>
        /// AGSEQ.
        /// </summary>
        public const string AGSEQ = "AGSEQ";

        /// <summary>
        /// AGE74FACC.
        /// </summary>
        public const string AGE74FACC = "AGE74FACC";

        /// <summary>
        /// AGE74TACC.
        /// </summary>
        public const string AGE74TACC = "AGE74TACC";

        /// <summary>
        /// AGAID.
        /// </summary>
        public const string AGAID = "AGAID";

        /// <summary>
        /// AGCO.
        /// </summary>
        public const string AGCO = "AGCO";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGUPMT.
        /// </summary>
        public const string AGUPMT = "AGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGE74ACCG", "AGE74ACCG", JdeDataType.String, 30, true, true),
        new JdeField("AGSEQ", "AGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("AGE74FACC", "AGE74FACC", JdeDataType.String, 60),
        new JdeField("AGE74TACC", "AGE74TACC", JdeDataType.String, 60),
        new JdeField("AGAID", "AGAID", JdeDataType.String, 16),
        new JdeField("AGCO", "AGCO", JdeDataType.String, 10),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGUPMT", "AGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749111_0", "Primary Key on AGE74ACCG, AGSEQ", new[] { "AGE74ACCG", "AGSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
