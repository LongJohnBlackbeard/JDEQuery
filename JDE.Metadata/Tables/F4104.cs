using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4104 - .
/// </summary>
public class F4104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IVAN8.
        /// </summary>
        public const string IVAN8 = "IVAN8";

        /// <summary>
        /// IVXRT.
        /// </summary>
        public const string IVXRT = "IVXRT";

        /// <summary>
        /// IVITM.
        /// </summary>
        public const string IVITM = "IVITM";

        /// <summary>
        /// IVEXDJ.
        /// </summary>
        public const string IVEXDJ = "IVEXDJ";

        /// <summary>
        /// IVEFTJ.
        /// </summary>
        public const string IVEFTJ = "IVEFTJ";

        /// <summary>
        /// IVMCU.
        /// </summary>
        public const string IVMCU = "IVMCU";

        /// <summary>
        /// IVCITM.
        /// </summary>
        public const string IVCITM = "IVCITM";

        /// <summary>
        /// IVDSC1.
        /// </summary>
        public const string IVDSC1 = "IVDSC1";

        /// <summary>
        /// IVDSC2.
        /// </summary>
        public const string IVDSC2 = "IVDSC2";

        /// <summary>
        /// IVALN.
        /// </summary>
        public const string IVALN = "IVALN";

        /// <summary>
        /// IVLITM.
        /// </summary>
        public const string IVLITM = "IVLITM";

        /// <summary>
        /// IVAITM.
        /// </summary>
        public const string IVAITM = "IVAITM";

        /// <summary>
        /// IVURCD.
        /// </summary>
        public const string IVURCD = "IVURCD";

        /// <summary>
        /// IVURDT.
        /// </summary>
        public const string IVURDT = "IVURDT";

        /// <summary>
        /// IVURAT.
        /// </summary>
        public const string IVURAT = "IVURAT";

        /// <summary>
        /// IVURAB.
        /// </summary>
        public const string IVURAB = "IVURAB";

        /// <summary>
        /// IVURRF.
        /// </summary>
        public const string IVURRF = "IVURRF";

        /// <summary>
        /// IVUSER.
        /// </summary>
        public const string IVUSER = "IVUSER";

        /// <summary>
        /// IVPID.
        /// </summary>
        public const string IVPID = "IVPID";

        /// <summary>
        /// IVJOBN.
        /// </summary>
        public const string IVJOBN = "IVJOBN";

        /// <summary>
        /// IVUPMJ.
        /// </summary>
        public const string IVUPMJ = "IVUPMJ";

        /// <summary>
        /// IVTDAY.
        /// </summary>
        public const string IVTDAY = "IVTDAY";

        /// <summary>
        /// IVRATO.
        /// </summary>
        public const string IVRATO = "IVRATO";

        /// <summary>
        /// IVAPSP.
        /// </summary>
        public const string IVAPSP = "IVAPSP";

        /// <summary>
        /// IVIDEM.
        /// </summary>
        public const string IVIDEM = "IVIDEM";

        /// <summary>
        /// IVAPSS.
        /// </summary>
        public const string IVAPSS = "IVAPSS";

        /// <summary>
        /// IVCIRV.
        /// </summary>
        public const string IVCIRV = "IVCIRV";

        /// <summary>
        /// IVADIND.
        /// </summary>
        public const string IVADIND = "IVADIND";

        /// <summary>
        /// IVBPIND.
        /// </summary>
        public const string IVBPIND = "IVBPIND";

        /// <summary>
        /// IVCARDNO.
        /// </summary>
        public const string IVCARDNO = "IVCARDNO";
    }

    /// <inheritdoc />
    public override string TableName => "F4104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IVAN8", "IVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IVXRT", "IVXRT", JdeDataType.String, 4, true, true),
        new JdeField("IVITM", "IVITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IVEXDJ", "IVEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IVEFTJ", "IVEFTJ", JdeDataType.Numeric),
        new JdeField("IVMCU", "IVMCU", JdeDataType.String, 24),
        new JdeField("IVCITM", "IVCITM", JdeDataType.String, 50, true, true),
        new JdeField("IVDSC1", "IVDSC1", JdeDataType.String, 60),
        new JdeField("IVDSC2", "IVDSC2", JdeDataType.String, 60),
        new JdeField("IVALN", "IVALN", JdeDataType.String, 60),
        new JdeField("IVLITM", "IVLITM", JdeDataType.String, 50),
        new JdeField("IVAITM", "IVAITM", JdeDataType.String, 50),
        new JdeField("IVURCD", "IVURCD", JdeDataType.String, 4),
        new JdeField("IVURDT", "IVURDT", JdeDataType.Numeric),
        new JdeField("IVURAT", "IVURAT", JdeDataType.Numeric),
        new JdeField("IVURAB", "IVURAB", JdeDataType.Numeric),
        new JdeField("IVURRF", "IVURRF", JdeDataType.String, 30),
        new JdeField("IVUSER", "IVUSER", JdeDataType.String, 20),
        new JdeField("IVPID", "IVPID", JdeDataType.String, 20),
        new JdeField("IVJOBN", "IVJOBN", JdeDataType.String, 20),
        new JdeField("IVUPMJ", "IVUPMJ", JdeDataType.Numeric),
        new JdeField("IVTDAY", "IVTDAY", JdeDataType.Numeric),
        new JdeField("IVRATO", "IVRATO", JdeDataType.Numeric),
        new JdeField("IVAPSP", "IVAPSP", JdeDataType.Numeric),
        new JdeField("IVIDEM", "IVIDEM", JdeDataType.String, 2),
        new JdeField("IVAPSS", "IVAPSS", JdeDataType.String, 2),
        new JdeField("IVCIRV", "IVCIRV", JdeDataType.String, 40, true, true),
        new JdeField("IVADIND", "IVADIND", JdeDataType.String, 2),
        new JdeField("IVBPIND", "IVBPIND", JdeDataType.String, 2),
        new JdeField("IVCARDNO", "IVCARDNO", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4104_0", "Primary Key on IVITM, IVXRT, IVAN8, IVCITM, IVEXDJ, IVCIRV", new[] { "IVITM", "IVXRT", "IVAN8", "IVCITM", "IVEXDJ", "IVCIRV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4104_10", "Index on IVITM, IVAN8", new[] { "IVITM", "IVAN8" }),
        new JdeIndex("F4104_11", "Index on IVCITM, IVXRT, IVAN8", new[] { "IVCITM", "IVXRT", "IVAN8" }),
        new JdeIndex("F4104_12", "Index on IVCITM, IVCIRV, IVXRT, IVAN8", new[] { "IVCITM", "IVCIRV", "IVXRT", "IVAN8" }),
        new JdeIndex("F4104_9", "Index on IVITM, IVXRT, IVAN8, IVEXDJ", new[] { "IVITM", "IVXRT", "IVAN8", "IVEXDJ" })
    };
}
