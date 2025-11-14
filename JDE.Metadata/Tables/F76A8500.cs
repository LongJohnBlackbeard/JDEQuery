using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8500 - .
/// </summary>
public class F76A8500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFPYID.
        /// </summary>
        public const string TFPYID = "TFPYID";

        /// <summary>
        /// TFRC5.
        /// </summary>
        public const string TFRC5 = "TFRC5";

        /// <summary>
        /// TFDGJ.
        /// </summary>
        public const string TFDGJ = "TFDGJ";

        /// <summary>
        /// TFKCO.
        /// </summary>
        public const string TFKCO = "TFKCO";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFSFX.
        /// </summary>
        public const string TFSFX = "TFSFX";

        /// <summary>
        /// TFDMTJ.
        /// </summary>
        public const string TFDMTJ = "TFDMTJ";

        /// <summary>
        /// TFRREF.
        /// </summary>
        public const string TFRREF = "TFRREF";

        /// <summary>
        /// TFCRR1.
        /// </summary>
        public const string TFCRR1 = "TFCRR1";

        /// <summary>
        /// TFVINV.
        /// </summary>
        public const string TFVINV = "TFVINV";

        /// <summary>
        /// TFAG.
        /// </summary>
        public const string TFAG = "TFAG";

        /// <summary>
        /// TFAAP.
        /// </summary>
        public const string TFAAP = "TFAAP";

        /// <summary>
        /// TFPAAP.
        /// </summary>
        public const string TFPAAP = "TFPAAP";

        /// <summary>
        /// TFACR.
        /// </summary>
        public const string TFACR = "TFACR";

        /// <summary>
        /// TFFAP.
        /// </summary>
        public const string TFFAP = "TFFAP";

        /// <summary>
        /// TFPFAP.
        /// </summary>
        public const string TFPFAP = "TFPFAP";

        /// <summary>
        /// TFCRR.
        /// </summary>
        public const string TFCRR = "TFCRR";

        /// <summary>
        /// TFCRCD.
        /// </summary>
        public const string TFCRCD = "TFCRCD";

        /// <summary>
        /// TFAGL.
        /// </summary>
        public const string TFAGL = "TFAGL";

        /// <summary>
        /// TFMATH01.
        /// </summary>
        public const string TFMATH01 = "TFMATH01";

        /// <summary>
        /// TFMATH02.
        /// </summary>
        public const string TFMATH02 = "TFMATH02";

        /// <summary>
        /// TFMATH03.
        /// </summary>
        public const string TFMATH03 = "TFMATH03";

        /// <summary>
        /// TFRMK.
        /// </summary>
        public const string TFRMK = "TFRMK";

        /// <summary>
        /// TFDESC.
        /// </summary>
        public const string TFDESC = "TFDESC";

        /// <summary>
        /// TFEV01.
        /// </summary>
        public const string TFEV01 = "TFEV01";

        /// <summary>
        /// TFEV02.
        /// </summary>
        public const string TFEV02 = "TFEV02";

        /// <summary>
        /// TFEV03.
        /// </summary>
        public const string TFEV03 = "TFEV03";

        /// <summary>
        /// TFEV04.
        /// </summary>
        public const string TFEV04 = "TFEV04";

        /// <summary>
        /// TFAC01.
        /// </summary>
        public const string TFAC01 = "TFAC01";

        /// <summary>
        /// TFAC02.
        /// </summary>
        public const string TFAC02 = "TFAC02";

        /// <summary>
        /// TFAC03.
        /// </summary>
        public const string TFAC03 = "TFAC03";

        /// <summary>
        /// TFAC04.
        /// </summary>
        public const string TFAC04 = "TFAC04";

        /// <summary>
        /// TFAC05.
        /// </summary>
        public const string TFAC05 = "TFAC05";

        /// <summary>
        /// TFDATE01.
        /// </summary>
        public const string TFDATE01 = "TFDATE01";

        /// <summary>
        /// TFDATE02.
        /// </summary>
        public const string TFDATE02 = "TFDATE02";

        /// <summary>
        /// TFDATE03.
        /// </summary>
        public const string TFDATE03 = "TFDATE03";

        /// <summary>
        /// TFCTID.
        /// </summary>
        public const string TFCTID = "TFCTID";

        /// <summary>
        /// TFJOBS.
        /// </summary>
        public const string TFJOBS = "TFJOBS";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFPYID", "TFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("TFRC5", "TFRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDGJ", "TFDGJ", JdeDataType.Numeric),
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric),
        new JdeField("TFSFX", "TFSFX", JdeDataType.String, 6),
        new JdeField("TFDMTJ", "TFDMTJ", JdeDataType.Numeric),
        new JdeField("TFRREF", "TFRREF", JdeDataType.String, 50),
        new JdeField("TFCRR1", "TFCRR1", JdeDataType.Numeric),
        new JdeField("TFVINV", "TFVINV", JdeDataType.String, 50),
        new JdeField("TFAG", "TFAG", JdeDataType.Numeric),
        new JdeField("TFAAP", "TFAAP", JdeDataType.Numeric),
        new JdeField("TFPAAP", "TFPAAP", JdeDataType.Numeric),
        new JdeField("TFACR", "TFACR", JdeDataType.Numeric),
        new JdeField("TFFAP", "TFFAP", JdeDataType.Numeric),
        new JdeField("TFPFAP", "TFPFAP", JdeDataType.Numeric),
        new JdeField("TFCRR", "TFCRR", JdeDataType.Numeric),
        new JdeField("TFCRCD", "TFCRCD", JdeDataType.String, 6),
        new JdeField("TFAGL", "TFAGL", JdeDataType.Numeric),
        new JdeField("TFMATH01", "TFMATH01", JdeDataType.Numeric),
        new JdeField("TFMATH02", "TFMATH02", JdeDataType.Numeric),
        new JdeField("TFMATH03", "TFMATH03", JdeDataType.Numeric),
        new JdeField("TFRMK", "TFRMK", JdeDataType.String, 60),
        new JdeField("TFDESC", "TFDESC", JdeDataType.String, 60),
        new JdeField("TFEV01", "TFEV01", JdeDataType.String, 2),
        new JdeField("TFEV02", "TFEV02", JdeDataType.String, 2),
        new JdeField("TFEV03", "TFEV03", JdeDataType.String, 2),
        new JdeField("TFEV04", "TFEV04", JdeDataType.String, 2),
        new JdeField("TFAC01", "TFAC01", JdeDataType.String, 6),
        new JdeField("TFAC02", "TFAC02", JdeDataType.String, 6),
        new JdeField("TFAC03", "TFAC03", JdeDataType.String, 6),
        new JdeField("TFAC04", "TFAC04", JdeDataType.String, 6),
        new JdeField("TFAC05", "TFAC05", JdeDataType.String, 6),
        new JdeField("TFDATE01", "TFDATE01", JdeDataType.Numeric),
        new JdeField("TFDATE02", "TFDATE02", JdeDataType.Numeric),
        new JdeField("TFDATE03", "TFDATE03", JdeDataType.Numeric),
        new JdeField("TFCTID", "TFCTID", JdeDataType.String, 30),
        new JdeField("TFJOBS", "TFJOBS", JdeDataType.Numeric),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8500_0", "Primary Key on TFPYID, TFRC5", new[] { "TFPYID", "TFRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
