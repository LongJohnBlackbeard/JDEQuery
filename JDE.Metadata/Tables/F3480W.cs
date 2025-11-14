using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3480W - .
/// </summary>
public class F3480W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDJOB.
        /// </summary>
        public const string SDJOB = "SDJOB";

        /// <summary>
        /// SDITM.
        /// </summary>
        public const string SDITM = "SDITM";

        /// <summary>
        /// SDMCU.
        /// </summary>
        public const string SDMCU = "SDMCU";

        /// <summary>
        /// SDUORG.
        /// </summary>
        public const string SDUORG = "SDUORG";

        /// <summary>
        /// SDSOQS.
        /// </summary>
        public const string SDSOQS = "SDSOQS";

        /// <summary>
        /// SDQAVAL.
        /// </summary>
        public const string SDQAVAL = "SDQAVAL";

        /// <summary>
        /// SDPPDJ.
        /// </summary>
        public const string SDPPDJ = "SDPPDJ";

        /// <summary>
        /// SDSUPDMD.
        /// </summary>
        public const string SDSUPDMD = "SDSUPDMD";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F3480W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDJOB", "SDJOB", JdeDataType.String, 16, true, true),
        new JdeField("SDITM", "SDITM", JdeDataType.Numeric),
        new JdeField("SDMCU", "SDMCU", JdeDataType.String, 24),
        new JdeField("SDUORG", "SDUORG", JdeDataType.Numeric),
        new JdeField("SDSOQS", "SDSOQS", JdeDataType.Numeric),
        new JdeField("SDQAVAL", "SDQAVAL", JdeDataType.Numeric),
        new JdeField("SDPPDJ", "SDPPDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSUPDMD", "SDSUPDMD", JdeDataType.String, 2),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3480W_0", "Primary Key on SDJOB, SDPPDJ", new[] { "SDJOB", "SDPPDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3480W_2", "Index on SDJOB, SDSUPDMD, SDPPDJ", new[] { "SDJOB", "SDSUPDMD", "SDPPDJ" })
    };
}
