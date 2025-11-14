using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08381WF - .
/// </summary>
public class F08381WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCJOBS.
        /// </summary>
        public const string RCJOBS = "RCJOBS";

        /// <summary>
        /// RCAN8.
        /// </summary>
        public const string RCAN8 = "RCAN8";

        /// <summary>
        /// RCALPH.
        /// </summary>
        public const string RCALPH = "RCALPH";

        /// <summary>
        /// RCPLAN.
        /// </summary>
        public const string RCPLAN = "RCPLAN";

        /// <summary>
        /// RCAOPT.
        /// </summary>
        public const string RCAOPT = "RCAOPT";

        /// <summary>
        /// RCXDFS.
        /// </summary>
        public const string RCXDFS = "RCXDFS";

        /// <summary>
        /// RCPDBA.
        /// </summary>
        public const string RCPDBA = "RCPDBA";

        /// <summary>
        /// RCDL01.
        /// </summary>
        public const string RCDL01 = "RCDL01";

        /// <summary>
        /// RCPMT.
        /// </summary>
        public const string RCPMT = "RCPMT";

        /// <summary>
        /// RCAMTN.
        /// </summary>
        public const string RCAMTN = "RCAMTN";

        /// <summary>
        /// RCEJSD.
        /// </summary>
        public const string RCEJSD = "RCEJSD";

        /// <summary>
        /// RCEJED.
        /// </summary>
        public const string RCEJED = "RCEJED";

        /// <summary>
        /// RCNSDT.
        /// </summary>
        public const string RCNSDT = "RCNSDT";

        /// <summary>
        /// RCNTDT.
        /// </summary>
        public const string RCNTDT = "RCNTDT";
    }

    /// <inheritdoc />
    public override string TableName => "F08381WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCJOBS", "RCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RCAN8", "RCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RCALPH", "RCALPH", JdeDataType.String, 80),
        new JdeField("RCPLAN", "RCPLAN", JdeDataType.String, 16, true, true),
        new JdeField("RCAOPT", "RCAOPT", JdeDataType.String, 6, true, true),
        new JdeField("RCXDFS", "RCXDFS", JdeDataType.String, 6),
        new JdeField("RCPDBA", "RCPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("RCDL01", "RCDL01", JdeDataType.String, 60),
        new JdeField("RCPMT", "RCPMT", JdeDataType.Numeric),
        new JdeField("RCAMTN", "RCAMTN", JdeDataType.Numeric),
        new JdeField("RCEJSD", "RCEJSD", JdeDataType.Numeric, null, true, true),
        new JdeField("RCEJED", "RCEJED", JdeDataType.Numeric),
        new JdeField("RCNSDT", "RCNSDT", JdeDataType.Numeric),
        new JdeField("RCNTDT", "RCNTDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08381WF_0", "Primary Key on RCJOBS, RCAN8, RCPLAN, RCAOPT, RCPDBA, RCEJSD", new[] { "RCJOBS", "RCAN8", "RCPLAN", "RCAOPT", "RCPDBA", "RCEJSD" }, isUnique: true, isPrimaryKey: true)
    };
}
