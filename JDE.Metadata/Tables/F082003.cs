using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F082003 - .
/// </summary>
public class F082003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YWSRVW.
        /// </summary>
        public const string YWSRVW = "YWSRVW";

        /// <summary>
        /// YWAN8.
        /// </summary>
        public const string YWAN8 = "YWAN8";

        /// <summary>
        /// YWALPH.
        /// </summary>
        public const string YWALPH = "YWALPH";

        /// <summary>
        /// YWHMCU.
        /// </summary>
        public const string YWHMCU = "YWHMCU";

        /// <summary>
        /// YWJBCD.
        /// </summary>
        public const string YWJBCD = "YWJBCD";

        /// <summary>
        /// YWJBST.
        /// </summary>
        public const string YWJBST = "YWJBST";

        /// <summary>
        /// YWEJPF.
        /// </summary>
        public const string YWEJPF = "YWEJPF";

        /// <summary>
        /// YWPTDT.
        /// </summary>
        public const string YWPTDT = "YWPTDT";

        /// <summary>
        /// YWUN.
        /// </summary>
        public const string YWUN = "YWUN";

        /// <summary>
        /// YWSLOC.
        /// </summary>
        public const string YWSLOC = "YWSLOC";

        /// <summary>
        /// YWPGRD.
        /// </summary>
        public const string YWPGRD = "YWPGRD";

        /// <summary>
        /// YWPGRS.
        /// </summary>
        public const string YWPGRS = "YWPGRS";

        /// <summary>
        /// YWPGSR.
        /// </summary>
        public const string YWPGSR = "YWPGSR";

        /// <summary>
        /// YWPHRT.
        /// </summary>
        public const string YWPHRT = "YWPHRT";

        /// <summary>
        /// YWFTE.
        /// </summary>
        public const string YWFTE = "YWFTE";

        /// <summary>
        /// YWSALN.
        /// </summary>
        public const string YWSALN = "YWSALN";

        /// <summary>
        /// YWNHRT.
        /// </summary>
        public const string YWNHRT = "YWNHRT";

        /// <summary>
        /// YWNTDT.
        /// </summary>
        public const string YWNTDT = "YWNTDT";

        /// <summary>
        /// YWNSDT.
        /// </summary>
        public const string YWNSDT = "YWNSDT";

        /// <summary>
        /// YWNPGD.
        /// </summary>
        public const string YWNPGD = "YWNPGD";

        /// <summary>
        /// YWNPGS.
        /// </summary>
        public const string YWNPGS = "YWNPGS";

        /// <summary>
        /// YWSDYY.
        /// </summary>
        public const string YWSDYY = "YWSDYY";

        /// <summary>
        /// YWSTDD.
        /// </summary>
        public const string YWSTDD = "YWSTDD";

        /// <summary>
        /// YWIH.
        /// </summary>
        public const string YWIH = "YWIH";

        /// <summary>
        /// YWUPMJ.
        /// </summary>
        public const string YWUPMJ = "YWUPMJ";

        /// <summary>
        /// YWUSER.
        /// </summary>
        public const string YWUSER = "YWUSER";

        /// <summary>
        /// YWPID.
        /// </summary>
        public const string YWPID = "YWPID";

        /// <summary>
        /// YWJOBN.
        /// </summary>
        public const string YWJOBN = "YWJOBN";

        /// <summary>
        /// YWTDAY.
        /// </summary>
        public const string YWTDAY = "YWTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F082003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YWSRVW", "YWSRVW", JdeDataType.String, 12, true, true),
        new JdeField("YWAN8", "YWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YWALPH", "YWALPH", JdeDataType.String, 80),
        new JdeField("YWHMCU", "YWHMCU", JdeDataType.String, 24, true, true),
        new JdeField("YWJBCD", "YWJBCD", JdeDataType.String, 12, true, true),
        new JdeField("YWJBST", "YWJBST", JdeDataType.String, 8, true, true),
        new JdeField("YWEJPF", "YWEJPF", JdeDataType.String, 2),
        new JdeField("YWPTDT", "YWPTDT", JdeDataType.Numeric, null, true, true),
        new JdeField("YWUN", "YWUN", JdeDataType.String, 12),
        new JdeField("YWSLOC", "YWSLOC", JdeDataType.String, 16),
        new JdeField("YWPGRD", "YWPGRD", JdeDataType.String, 12),
        new JdeField("YWPGRS", "YWPGRS", JdeDataType.String, 8),
        new JdeField("YWPGSR", "YWPGSR", JdeDataType.Numeric),
        new JdeField("YWPHRT", "YWPHRT", JdeDataType.Numeric),
        new JdeField("YWFTE", "YWFTE", JdeDataType.Numeric),
        new JdeField("YWSALN", "YWSALN", JdeDataType.Numeric),
        new JdeField("YWNHRT", "YWNHRT", JdeDataType.Numeric),
        new JdeField("YWNTDT", "YWNTDT", JdeDataType.Numeric),
        new JdeField("YWNSDT", "YWNSDT", JdeDataType.Numeric),
        new JdeField("YWNPGD", "YWNPGD", JdeDataType.String, 12),
        new JdeField("YWNPGS", "YWNPGS", JdeDataType.String, 8),
        new JdeField("YWSDYY", "YWSDYY", JdeDataType.Numeric),
        new JdeField("YWSTDD", "YWSTDD", JdeDataType.Numeric),
        new JdeField("YWIH", "YWIH", JdeDataType.Numeric),
        new JdeField("YWUPMJ", "YWUPMJ", JdeDataType.Numeric),
        new JdeField("YWUSER", "YWUSER", JdeDataType.String, 20),
        new JdeField("YWPID", "YWPID", JdeDataType.String, 20),
        new JdeField("YWJOBN", "YWJOBN", JdeDataType.String, 20),
        new JdeField("YWTDAY", "YWTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F082003_0", "Primary Key on YWSRVW, YWAN8, YWHMCU, YWJBCD, YWJBST, YWPTDT", new[] { "YWSRVW", "YWAN8", "YWHMCU", "YWJBCD", "YWJBST", "YWPTDT" }, isUnique: true, isPrimaryKey: true)
    };
}
