using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G104 - .
/// </summary>
public class F40G104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADGRECID.
        /// </summary>
        public const string ADGRECID = "ADGRECID";

        /// <summary>
        /// ADRECTYP.
        /// </summary>
        public const string ADRECTYP = "ADRECTYP";

        /// <summary>
        /// ADSEQ.
        /// </summary>
        public const string ADSEQ = "ADSEQ";

        /// <summary>
        /// ADGDATECD.
        /// </summary>
        public const string ADGDATECD = "ADGDATECD";

        /// <summary>
        /// ADACTDTDSC.
        /// </summary>
        public const string ADACTDTDSC = "ADACTDTDSC";

        /// <summary>
        /// ADRECRR.
        /// </summary>
        public const string ADRECRR = "ADRECRR";

        /// <summary>
        /// ADDTERQRD.
        /// </summary>
        public const string ADDTERQRD = "ADDTERQRD";

        /// <summary>
        /// ADCNTRCLS.
        /// </summary>
        public const string ADCNTRCLS = "ADCNTRCLS";

        /// <summary>
        /// ADDTECMPL.
        /// </summary>
        public const string ADDTECMPL = "ADDTECMPL";

        /// <summary>
        /// ADPRSNRSP.
        /// </summary>
        public const string ADPRSNRSP = "ADPRSNRSP";

        /// <summary>
        /// ADDTCOMM.
        /// </summary>
        public const string ADDTCOMM = "ADDTCOMM";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADTORG.
        /// </summary>
        public const string ADTORG = "ADTORG";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUUPMJ.
        /// </summary>
        public const string ADUUPMJ = "ADUUPMJ";

        /// <summary>
        /// ADNODYAD.
        /// </summary>
        public const string ADNODYAD = "ADNODYAD";
    }

    /// <inheritdoc />
    public override string TableName => "F40G104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADGRECID", "ADGRECID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADRECTYP", "ADRECTYP", JdeDataType.String, 2, true, true),
        new JdeField("ADSEQ", "ADSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ADGDATECD", "ADGDATECD", JdeDataType.String, 12),
        new JdeField("ADACTDTDSC", "ADACTDTDSC", JdeDataType.String, 60),
        new JdeField("ADRECRR", "ADRECRR", JdeDataType.String, 2),
        new JdeField("ADDTERQRD", "ADDTERQRD", JdeDataType.Date),
        new JdeField("ADCNTRCLS", "ADCNTRCLS", JdeDataType.String, 2),
        new JdeField("ADDTECMPL", "ADDTECMPL", JdeDataType.Date),
        new JdeField("ADPRSNRSP", "ADPRSNRSP", JdeDataType.Numeric),
        new JdeField("ADDTCOMM", "ADDTCOMM", JdeDataType.String, 510),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADTORG", "ADTORG", JdeDataType.String, 20),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUUPMJ", "ADUUPMJ", JdeDataType.Date),
        new JdeField("ADNODYAD", "ADNODYAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G104_0", "Primary Key on ADGRECID, ADRECTYP, ADSEQ", new[] { "ADGRECID", "ADRECTYP", "ADSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
