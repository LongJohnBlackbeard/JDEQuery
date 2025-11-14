using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P9100 - .
/// </summary>
public class F74P9100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDKCO.
        /// </summary>
        public const string CDKCO = "CDKCO";

        /// <summary>
        /// CDP74DTCD.
        /// </summary>
        public const string CDP74DTCD = "CDP74DTCD";

        /// <summary>
        /// CDP74DOCD.
        /// </summary>
        public const string CDP74DOCD = "CDP74DOCD";

        /// <summary>
        /// CDP74DPCD.
        /// </summary>
        public const string CDP74DPCD = "CDP74DPCD";

        /// <summary>
        /// CDDCT.
        /// </summary>
        public const string CDDCT = "CDDCT";

        /// <summary>
        /// CDDOC.
        /// </summary>
        public const string CDDOC = "CDDOC";

        /// <summary>
        /// CDDGJ.
        /// </summary>
        public const string CDDGJ = "CDDGJ";

        /// <summary>
        /// CDJELN.
        /// </summary>
        public const string CDJELN = "CDJELN";

        /// <summary>
        /// CDLT.
        /// </summary>
        public const string CDLT = "CDLT";

        /// <summary>
        /// CDVOD.
        /// </summary>
        public const string CDVOD = "CDVOD";

        /// <summary>
        /// CDVDGJ.
        /// </summary>
        public const string CDVDGJ = "CDVDGJ";

        /// <summary>
        /// CDAID.
        /// </summary>
        public const string CDAID = "CDAID";

        /// <summary>
        /// CDICUT.
        /// </summary>
        public const string CDICUT = "CDICUT";

        /// <summary>
        /// CDICU.
        /// </summary>
        public const string CDICU = "CDICU";

        /// <summary>
        /// CDPYID.
        /// </summary>
        public const string CDPYID = "CDPYID";

        /// <summary>
        /// CDPAAP.
        /// </summary>
        public const string CDPAAP = "CDPAAP";

        /// <summary>
        /// CDSY.
        /// </summary>
        public const string CDSY = "CDSY";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P9100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDKCO", "CDKCO", JdeDataType.String, 10, true, true),
        new JdeField("CDP74DTCD", "CDP74DTCD", JdeDataType.String, 4, true, true),
        new JdeField("CDP74DOCD", "CDP74DOCD", JdeDataType.Numeric, null, true, true),
        new JdeField("CDP74DPCD", "CDP74DPCD", JdeDataType.Numeric),
        new JdeField("CDDCT", "CDDCT", JdeDataType.String, 4),
        new JdeField("CDDOC", "CDDOC", JdeDataType.Numeric),
        new JdeField("CDDGJ", "CDDGJ", JdeDataType.Numeric),
        new JdeField("CDJELN", "CDJELN", JdeDataType.Numeric),
        new JdeField("CDLT", "CDLT", JdeDataType.String, 4),
        new JdeField("CDVOD", "CDVOD", JdeDataType.String, 2),
        new JdeField("CDVDGJ", "CDVDGJ", JdeDataType.Numeric),
        new JdeField("CDAID", "CDAID", JdeDataType.String, 16),
        new JdeField("CDICUT", "CDICUT", JdeDataType.String, 4),
        new JdeField("CDICU", "CDICU", JdeDataType.Numeric),
        new JdeField("CDPYID", "CDPYID", JdeDataType.Numeric),
        new JdeField("CDPAAP", "CDPAAP", JdeDataType.Numeric),
        new JdeField("CDSY", "CDSY", JdeDataType.String, 8),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P9100_0", "Primary Key on CDKCO, CDP74DTCD, CDP74DOCD", new[] { "CDKCO", "CDP74DTCD", "CDP74DOCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74P9100_2", "Index on CDKCO, CDDCT, CDDOC, CDDGJ, CDJELN, CDLT, CDVOD", new[] { "CDKCO", "CDDCT", "CDDOC", "CDDGJ", "CDJELN", "CDLT", "CDVOD" })
    };
}
