using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34007 - .
/// </summary>
public class F34007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHMCU.
        /// </summary>
        public const string FHMCU = "FHMCU";

        /// <summary>
        /// FHITM.
        /// </summary>
        public const string FHITM = "FHITM";

        /// <summary>
        /// FHAN8.
        /// </summary>
        public const string FHAN8 = "FHAN8";

        /// <summary>
        /// FHTYPF.
        /// </summary>
        public const string FHTYPF = "FHTYPF";

        /// <summary>
        /// FHEFFF.
        /// </summary>
        public const string FHEFFF = "FHEFFF";

        /// <summary>
        /// FHEFFT.
        /// </summary>
        public const string FHEFFT = "FHEFFT";

        /// <summary>
        /// FHUPRC.
        /// </summary>
        public const string FHUPRC = "FHUPRC";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";

        /// <summary>
        /// FHTDAY.
        /// </summary>
        public const string FHTDAY = "FHTDAY";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F34007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHMCU", "FHMCU", JdeDataType.String, 24, true, true),
        new JdeField("FHITM", "FHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FHAN8", "FHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("FHTYPF", "FHTYPF", JdeDataType.String, 4, true, true),
        new JdeField("FHEFFF", "FHEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("FHEFFT", "FHEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("FHUPRC", "FHUPRC", JdeDataType.Numeric),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHTDAY", "FHTDAY", JdeDataType.Numeric),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34007_0", "Primary Key on FHMCU, FHITM, FHAN8, FHTYPF, FHEFFF, FHEFFT", new[] { "FHMCU", "FHITM", "FHAN8", "FHTYPF", "FHEFFF", "FHEFFT" }, isUnique: true, isPrimaryKey: true)
    };
}
