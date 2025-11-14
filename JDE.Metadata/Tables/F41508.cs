using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41508 - .
/// </summary>
public class F41508 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCDTE.
        /// </summary>
        public const string PCDTE = "PCDTE";

        /// <summary>
        /// PCRDTM.
        /// </summary>
        public const string PCRDTM = "PCRDTM";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCTKID.
        /// </summary>
        public const string PCTKID = "PCTKID";

        /// <summary>
        /// PCTTEM.
        /// </summary>
        public const string PCTTEM = "PCTTEM";

        /// <summary>
        /// PCSTPU.
        /// </summary>
        public const string PCSTPU = "PCSTPU";

        /// <summary>
        /// PCTKDN.
        /// </summary>
        public const string PCTKDN = "PCTKDN";

        /// <summary>
        /// PCDNTP.
        /// </summary>
        public const string PCDNTP = "PCDNTP";

        /// <summary>
        /// PCDETP.
        /// </summary>
        public const string PCDETP = "PCDETP";

        /// <summary>
        /// PCDTPU.
        /// </summary>
        public const string PCDTPU = "PCDTPU";

        /// <summary>
        /// PCTEXD.
        /// </summary>
        public const string PCTEXD = "PCTEXD";

        /// <summary>
        /// PCTETM.
        /// </summary>
        public const string PCTETM = "PCTETM";

        /// <summary>
        /// PCCUTK.
        /// </summary>
        public const string PCCUTK = "PCCUTK";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F41508";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCDTE", "PCDTE", JdeDataType.Numeric, null, true, true),
        new JdeField("PCRDTM", "PCRDTM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric),
        new JdeField("PCTKID", "PCTKID", JdeDataType.String, 16, true, true),
        new JdeField("PCTTEM", "PCTTEM", JdeDataType.Numeric),
        new JdeField("PCSTPU", "PCSTPU", JdeDataType.String, 2),
        new JdeField("PCTKDN", "PCTKDN", JdeDataType.Numeric),
        new JdeField("PCDNTP", "PCDNTP", JdeDataType.String, 2),
        new JdeField("PCDETP", "PCDETP", JdeDataType.Numeric),
        new JdeField("PCDTPU", "PCDTPU", JdeDataType.String, 2),
        new JdeField("PCTEXD", "PCTEXD", JdeDataType.Numeric),
        new JdeField("PCTETM", "PCTETM", JdeDataType.Numeric),
        new JdeField("PCCUTK", "PCCUTK", JdeDataType.String, 2),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41508_0", "Primary Key on PCMCU, PCDTE, PCRDTM, PCTKID", new[] { "PCMCU", "PCDTE", "PCRDTM", "PCTKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41508_2", "Index on PCMCU, PCITM, PCTKID, PCDTE", new[] { "PCMCU", "PCITM", "PCTKID", "PCDTE" }),
        new JdeIndex("F41508_3", "Index on PCMCU, PCTKID, PCDTE", new[] { "PCMCU", "PCTKID", "PCDTE" }),
        new JdeIndex("F41508_4", "Index on PCMCU, PCITM, PCCUTK, PCTKID", new[] { "PCMCU", "PCITM", "PCCUTK", "PCTKID" }),
        new JdeIndex("F41508_5", "Index on PCMCU, PCTKID, SYS_NC00026$", new[] { "PCMCU", "PCTKID", "SYS_NC00026$" }),
        new JdeIndex("F41508_6", "Index on PCMCU, PCDTE, PCITM, SYS_NC00025$, PCRDTM, PCTKID", new[] { "PCMCU", "PCDTE", "PCITM", "SYS_NC00025$", "PCRDTM", "PCTKID" }),
        new JdeIndex("F41508_7", "Index on PCMCU, PCTKID, SYS_NC00026$, SYS_NC00027$, PCUSER", new[] { "PCMCU", "PCTKID", "SYS_NC00026$", "SYS_NC00027$", "PCUSER" })
    };
}
