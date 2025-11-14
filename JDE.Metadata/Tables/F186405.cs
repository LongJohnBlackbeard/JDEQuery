using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186405 - .
/// </summary>
public class F186405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCLRSORID.
        /// </summary>
        public const string OCLRSORID = "OCLRSORID";

        /// <summary>
        /// OCSEQ.
        /// </summary>
        public const string OCSEQ = "OCSEQ";

        /// <summary>
        /// OCLRSOROP.
        /// </summary>
        public const string OCLRSOROP = "OCLRSOROP";

        /// <summary>
        /// OCLRSOP.
        /// </summary>
        public const string OCLRSOP = "OCLRSOP";

        /// <summary>
        /// OCLRSFID.
        /// </summary>
        public const string OCLRSFID = "OCLRSFID";

        /// <summary>
        /// OCVALS.
        /// </summary>
        public const string OCVALS = "OCVALS";

        /// <summary>
        /// OCLRSOCV.
        /// </summary>
        public const string OCLRSOCV = "OCLRSOCV";

        /// <summary>
        /// OCLRSCP.
        /// </summary>
        public const string OCLRSCP = "OCLRSCP";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCJOBN.
        /// </summary>
        public const string OCJOBN = "OCJOBN";

        /// <summary>
        /// OCUPMJ.
        /// </summary>
        public const string OCUPMJ = "OCUPMJ";

        /// <summary>
        /// OCTDAY.
        /// </summary>
        public const string OCTDAY = "OCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCLRSORID", "OCLRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("OCSEQ", "OCSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OCLRSOROP", "OCLRSOROP", JdeDataType.String, 10),
        new JdeField("OCLRSOP", "OCLRSOP", JdeDataType.String, 2),
        new JdeField("OCLRSFID", "OCLRSFID", JdeDataType.Numeric),
        new JdeField("OCVALS", "OCVALS", JdeDataType.String, 4),
        new JdeField("OCLRSOCV", "OCLRSOCV", JdeDataType.String, 80),
        new JdeField("OCLRSCP", "OCLRSCP", JdeDataType.String, 2),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCJOBN", "OCJOBN", JdeDataType.String, 20),
        new JdeField("OCUPMJ", "OCUPMJ", JdeDataType.Numeric),
        new JdeField("OCTDAY", "OCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186405_0", "Primary Key on OCLRSORID, OCSEQ", new[] { "OCLRSORID", "OCSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186405_3", "Index on OCLRSORID", new[] { "OCLRSORID" })
    };
}
