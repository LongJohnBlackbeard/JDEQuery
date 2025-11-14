using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI94 - .
/// </summary>
public class F74UI94 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCJOBS.
        /// </summary>
        public const string CCJOBS = "CCJOBS";

        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCE74MCUG.
        /// </summary>
        public const string CCE74MCUG = "CCE74MCUG";

        /// <summary>
        /// CCE74CSEQ.
        /// </summary>
        public const string CCE74CSEQ = "CCE74CSEQ";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI94";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCJOBS", "CCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCE74MCUG", "CCE74MCUG", JdeDataType.String, 30, true, true),
        new JdeField("CCE74CSEQ", "CCE74CSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI94_0", "Primary Key on CCJOBS, CCCO, CCE74MCUG, CCE74CSEQ", new[] { "CCJOBS", "CCCO", "CCE74MCUG", "CCE74CSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
