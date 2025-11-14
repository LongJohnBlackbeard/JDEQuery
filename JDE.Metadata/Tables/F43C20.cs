using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C20 - .
/// </summary>
public class F43C20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPCNTRTID.
        /// </summary>
        public const string CPCNTRTID = "CPCNTRTID";

        /// <summary>
        /// CPBLUID.
        /// </summary>
        public const string CPBLUID = "CPBLUID";

        /// <summary>
        /// CPCNTRTDID.
        /// </summary>
        public const string CPCNTRTDID = "CPCNTRTDID";

        /// <summary>
        /// CPPYE.
        /// </summary>
        public const string CPPYE = "CPPYE";

        /// <summary>
        /// CPUKID.
        /// </summary>
        public const string CPUKID = "CPUKID";

        /// <summary>
        /// CPPTC.
        /// </summary>
        public const string CPPTC = "CPPTC";

        /// <summary>
        /// CPDSTRPCNT.
        /// </summary>
        public const string CPDSTRPCNT = "CPDSTRPCNT";

        /// <summary>
        /// CPASSNG.
        /// </summary>
        public const string CPASSNG = "CPASSNG";

        /// <summary>
        /// CPCNTRTINT.
        /// </summary>
        public const string CPCNTRTINT = "CPCNTRTINT";

        /// <summary>
        /// CPCNTRTBRK.
        /// </summary>
        public const string CPCNTRTBRK = "CPCNTRTBRK";

        /// <summary>
        /// CPURCD.
        /// </summary>
        public const string CPURCD = "CPURCD";

        /// <summary>
        /// CPURDT.
        /// </summary>
        public const string CPURDT = "CPURDT";

        /// <summary>
        /// CPURAT.
        /// </summary>
        public const string CPURAT = "CPURAT";

        /// <summary>
        /// CPURAB.
        /// </summary>
        public const string CPURAB = "CPURAB";

        /// <summary>
        /// CPURRF.
        /// </summary>
        public const string CPURRF = "CPURRF";

        /// <summary>
        /// CPTORG.
        /// </summary>
        public const string CPTORG = "CPTORG";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUUPMJ.
        /// </summary>
        public const string CPUUPMJ = "CPUUPMJ";

        /// <summary>
        /// CPADVPD.
        /// </summary>
        public const string CPADVPD = "CPADVPD";

        /// <summary>
        /// CPSEQN.
        /// </summary>
        public const string CPSEQN = "CPSEQN";

        /// <summary>
        /// CPINPD.
        /// </summary>
        public const string CPINPD = "CPINPD";

        /// <summary>
        /// CPIPLN.
        /// </summary>
        public const string CPIPLN = "CPIPLN";

        /// <summary>
        /// CPFNLPD.
        /// </summary>
        public const string CPFNLPD = "CPFNLPD";

        /// <summary>
        /// CPAN8.
        /// </summary>
        public const string CPAN8 = "CPAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F43C20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPCNTRTID", "CPCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPBLUID", "CPBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCNTRTDID", "CPCNTRTDID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPPYE", "CPPYE", JdeDataType.Numeric, null, true, true),
        new JdeField("CPUKID", "CPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPPTC", "CPPTC", JdeDataType.String, 6),
        new JdeField("CPDSTRPCNT", "CPDSTRPCNT", JdeDataType.Numeric),
        new JdeField("CPASSNG", "CPASSNG", JdeDataType.String, 2),
        new JdeField("CPCNTRTINT", "CPCNTRTINT", JdeDataType.String, 2),
        new JdeField("CPCNTRTBRK", "CPCNTRTBRK", JdeDataType.String, 2),
        new JdeField("CPURCD", "CPURCD", JdeDataType.String, 4),
        new JdeField("CPURDT", "CPURDT", JdeDataType.Numeric),
        new JdeField("CPURAT", "CPURAT", JdeDataType.Numeric),
        new JdeField("CPURAB", "CPURAB", JdeDataType.Numeric),
        new JdeField("CPURRF", "CPURRF", JdeDataType.String, 30),
        new JdeField("CPTORG", "CPTORG", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUUPMJ", "CPUUPMJ", JdeDataType.Date),
        new JdeField("CPADVPD", "CPADVPD", JdeDataType.String, 2),
        new JdeField("CPSEQN", "CPSEQN", JdeDataType.Numeric),
        new JdeField("CPINPD", "CPINPD", JdeDataType.String, 2),
        new JdeField("CPIPLN", "CPIPLN", JdeDataType.Numeric),
        new JdeField("CPFNLPD", "CPFNLPD", JdeDataType.String, 2),
        new JdeField("CPAN8", "CPAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C20_0", "Primary Key on CPCNTRTID, CPBLUID, CPCNTRTDID, CPPYE, CPUKID", new[] { "CPCNTRTID", "CPBLUID", "CPCNTRTDID", "CPPYE", "CPUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C20_2", "Index on CPCNTRTID, CPCNTRTDID", new[] { "CPCNTRTID", "CPCNTRTDID" }),
        new JdeIndex("F43C20_3", "Index on CPCNTRTID, CPBLUID, CPCNTRTDID, CPUKID", new[] { "CPCNTRTID", "CPBLUID", "CPCNTRTDID", "CPUKID" })
    };
}
