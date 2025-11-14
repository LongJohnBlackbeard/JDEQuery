using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70UI003 - .
/// </summary>
public class F70UI003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITJOBS.
        /// </summary>
        public const string ITJOBS = "ITJOBS";

        /// <summary>
        /// ITITM.
        /// </summary>
        public const string ITITM = "ITITM";

        /// <summary>
        /// ITLITM.
        /// </summary>
        public const string ITLITM = "ITLITM";

        /// <summary>
        /// ITDSC1.
        /// </summary>
        public const string ITDSC1 = "ITDSC1";

        /// <summary>
        /// ITG70CC01.
        /// </summary>
        public const string ITG70CC01 = "ITG70CC01";

        /// <summary>
        /// ITG70CC02.
        /// </summary>
        public const string ITG70CC02 = "ITG70CC02";

        /// <summary>
        /// ITCITM.
        /// </summary>
        public const string ITCITM = "ITCITM";

        /// <summary>
        /// ITMCU.
        /// </summary>
        public const string ITMCU = "ITMCU";

        /// <summary>
        /// ITDL01.
        /// </summary>
        public const string ITDL01 = "ITDL01";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";

        /// <summary>
        /// ITUPMJ.
        /// </summary>
        public const string ITUPMJ = "ITUPMJ";

        /// <summary>
        /// ITUPMT.
        /// </summary>
        public const string ITUPMT = "ITUPMT";

        /// <summary>
        /// ITDCT.
        /// </summary>
        public const string ITDCT = "ITDCT";

        /// <summary>
        /// ITUOM1.
        /// </summary>
        public const string ITUOM1 = "ITUOM1";

        /// <summary>
        /// ITUOM2.
        /// </summary>
        public const string ITUOM2 = "ITUOM2";

        /// <summary>
        /// ITCONV.
        /// </summary>
        public const string ITCONV = "ITCONV";
    }

    /// <inheritdoc />
    public override string TableName => "F70UI003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITJOBS", "ITJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ITITM", "ITITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ITLITM", "ITLITM", JdeDataType.String, 50),
        new JdeField("ITDSC1", "ITDSC1", JdeDataType.String, 60),
        new JdeField("ITG70CC01", "ITG70CC01", JdeDataType.String, 20),
        new JdeField("ITG70CC02", "ITG70CC02", JdeDataType.String, 20),
        new JdeField("ITCITM", "ITCITM", JdeDataType.String, 50),
        new JdeField("ITMCU", "ITMCU", JdeDataType.String, 24, true, true),
        new JdeField("ITDL01", "ITDL01", JdeDataType.String, 60),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20, true, true),
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20),
        new JdeField("ITUPMJ", "ITUPMJ", JdeDataType.Numeric),
        new JdeField("ITUPMT", "ITUPMT", JdeDataType.Numeric),
        new JdeField("ITDCT", "ITDCT", JdeDataType.String, 4),
        new JdeField("ITUOM1", "ITUOM1", JdeDataType.String, 4, true, true),
        new JdeField("ITUOM2", "ITUOM2", JdeDataType.String, 4, true, true),
        new JdeField("ITCONV", "ITCONV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70UI003_0", "Primary Key on ITJOBS, ITITM, ITMCU, ITUOM1, ITUOM2, ITUSER", new[] { "ITJOBS", "ITITM", "ITMCU", "ITUOM1", "ITUOM2", "ITUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
