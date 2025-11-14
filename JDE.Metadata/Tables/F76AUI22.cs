using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI22 - .
/// </summary>
public class F76AUI22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFSEQ.
        /// </summary>
        public const string WFSEQ = "WFSEQ";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFAC18.
        /// </summary>
        public const string WFAC18 = "WFAC18";

        /// <summary>
        /// WFDMTM.
        /// </summary>
        public const string WFDMTM = "WFDMTM";

        /// <summary>
        /// WFDL01.
        /// </summary>
        public const string WFDL01 = "WFDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFSEQ", "WFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFAC18", "WFAC18", JdeDataType.String, 6),
        new JdeField("WFDMTM", "WFDMTM", JdeDataType.Numeric),
        new JdeField("WFDL01", "WFDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI22_0", "Primary Key on WFJOBS, WFCTID, WFKCO, WFDCT, WFDOC, WFSEQ", new[] { "WFJOBS", "WFCTID", "WFKCO", "WFDCT", "WFDOC", "WFSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
