using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46UI15 - .
/// </summary>
public class F46UI15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCUKID.
        /// </summary>
        public const string RCUKID = "RCUKID";

        /// <summary>
        /// RCSHPN.
        /// </summary>
        public const string RCSHPN = "RCSHPN";

        /// <summary>
        /// RCCROS.
        /// </summary>
        public const string RCCROS = "RCCROS";

        /// <summary>
        /// RCCRID.
        /// </summary>
        public const string RCCRID = "RCCRID";

        /// <summary>
        /// RCEQTY.
        /// </summary>
        public const string RCEQTY = "RCEQTY";

        /// <summary>
        /// RCEQTYI.
        /// </summary>
        public const string RCEQTYI = "RCEQTYI";

        /// <summary>
        /// RCITM.
        /// </summary>
        public const string RCITM = "RCITM";

        /// <summary>
        /// RCUOM.
        /// </summary>
        public const string RCUOM = "RCUOM";

        /// <summary>
        /// RCNPCS.
        /// </summary>
        public const string RCNPCS = "RCNPCS";

        /// <summary>
        /// RCSTPK.
        /// </summary>
        public const string RCSTPK = "RCSTPK";

        /// <summary>
        /// RCTQTY.
        /// </summary>
        public const string RCTQTY = "RCTQTY";

        /// <summary>
        /// RCWEIT.
        /// </summary>
        public const string RCWEIT = "RCWEIT";

        /// <summary>
        /// RCGWEI.
        /// </summary>
        public const string RCGWEI = "RCGWEI";

        /// <summary>
        /// RCUWUM.
        /// </summary>
        public const string RCUWUM = "RCUWUM";

        /// <summary>
        /// RCMCU.
        /// </summary>
        public const string RCMCU = "RCMCU";

        /// <summary>
        /// RCAN8.
        /// </summary>
        public const string RCAN8 = "RCAN8";

        /// <summary>
        /// RCSHAN.
        /// </summary>
        public const string RCSHAN = "RCSHAN";

        /// <summary>
        /// RCDVAN.
        /// </summary>
        public const string RCDVAN = "RCDVAN";

        /// <summary>
        /// RCCEQT.
        /// </summary>
        public const string RCCEQT = "RCCEQT";

        /// <summary>
        /// RCCTNP.
        /// </summary>
        public const string RCCTNP = "RCCTNP";

        /// <summary>
        /// RCCTNI.
        /// </summary>
        public const string RCCTNI = "RCCTNI";

        /// <summary>
        /// RCRCMS.
        /// </summary>
        public const string RCRCMS = "RCRCMS";

        /// <summary>
        /// RCEKEY.
        /// </summary>
        public const string RCEKEY = "RCEKEY";

        /// <summary>
        /// RCURCD.
        /// </summary>
        public const string RCURCD = "RCURCD";

        /// <summary>
        /// RCURDT.
        /// </summary>
        public const string RCURDT = "RCURDT";

        /// <summary>
        /// RCURAT.
        /// </summary>
        public const string RCURAT = "RCURAT";

        /// <summary>
        /// RCURAB.
        /// </summary>
        public const string RCURAB = "RCURAB";

        /// <summary>
        /// RCURRF.
        /// </summary>
        public const string RCURRF = "RCURRF";

        /// <summary>
        /// RCC1FU.
        /// </summary>
        public const string RCC1FU = "RCC1FU";

        /// <summary>
        /// RCCFC1.
        /// </summary>
        public const string RCCFC1 = "RCCFC1";

        /// <summary>
        /// RCCFS1.
        /// </summary>
        public const string RCCFS1 = "RCCFS1";

        /// <summary>
        /// RCD1FU.
        /// </summary>
        public const string RCD1FU = "RCD1FU";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCTDAY.
        /// </summary>
        public const string RCTDAY = "RCTDAY";

        /// <summary>
        /// RCMPGP.
        /// </summary>
        public const string RCMPGP = "RCMPGP";

        /// <summary>
        /// RCTAOR.
        /// </summary>
        public const string RCTAOR = "RCTAOR";
    }

    /// <inheritdoc />
    public override string TableName => "F46UI15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCUKID", "RCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCSHPN", "RCSHPN", JdeDataType.Numeric),
        new JdeField("RCCROS", "RCCROS", JdeDataType.Numeric),
        new JdeField("RCCRID", "RCCRID", JdeDataType.Numeric),
        new JdeField("RCEQTY", "RCEQTY", JdeDataType.String, 10),
        new JdeField("RCEQTYI", "RCEQTYI", JdeDataType.String, 10),
        new JdeField("RCITM", "RCITM", JdeDataType.Numeric),
        new JdeField("RCUOM", "RCUOM", JdeDataType.String, 4),
        new JdeField("RCNPCS", "RCNPCS", JdeDataType.Numeric),
        new JdeField("RCSTPK", "RCSTPK", JdeDataType.Numeric),
        new JdeField("RCTQTY", "RCTQTY", JdeDataType.Numeric),
        new JdeField("RCWEIT", "RCWEIT", JdeDataType.Numeric),
        new JdeField("RCGWEI", "RCGWEI", JdeDataType.Numeric),
        new JdeField("RCUWUM", "RCUWUM", JdeDataType.String, 4),
        new JdeField("RCMCU", "RCMCU", JdeDataType.String, 24),
        new JdeField("RCAN8", "RCAN8", JdeDataType.Numeric),
        new JdeField("RCSHAN", "RCSHAN", JdeDataType.Numeric),
        new JdeField("RCDVAN", "RCDVAN", JdeDataType.Numeric),
        new JdeField("RCCEQT", "RCCEQT", JdeDataType.String, 50),
        new JdeField("RCCTNP", "RCCTNP", JdeDataType.String, 2),
        new JdeField("RCCTNI", "RCCTNI", JdeDataType.Numeric),
        new JdeField("RCRCMS", "RCRCMS", JdeDataType.String, 4),
        new JdeField("RCEKEY", "RCEKEY", JdeDataType.String, 8),
        new JdeField("RCURCD", "RCURCD", JdeDataType.String, 4),
        new JdeField("RCURDT", "RCURDT", JdeDataType.Numeric),
        new JdeField("RCURAT", "RCURAT", JdeDataType.Numeric),
        new JdeField("RCURAB", "RCURAB", JdeDataType.Numeric),
        new JdeField("RCURRF", "RCURRF", JdeDataType.String, 30),
        new JdeField("RCC1FU", "RCC1FU", JdeDataType.String, 2),
        new JdeField("RCCFC1", "RCCFC1", JdeDataType.String, 6),
        new JdeField("RCCFS1", "RCCFS1", JdeDataType.Numeric),
        new JdeField("RCD1FU", "RCD1FU", JdeDataType.Numeric),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCTDAY", "RCTDAY", JdeDataType.Numeric),
        new JdeField("RCMPGP", "RCMPGP", JdeDataType.String, 12),
        new JdeField("RCTAOR", "RCTAOR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46UI15_0", "Primary Key on RCUKID", new[] { "RCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46UI15_2", "Unique Index on RCSHPN, RCCROS, RCCRID, RCEQTY, RCEQTYI, RCITM, RCUOM, RCAN8, RCSHAN, RCDVAN", new[] { "RCSHPN", "RCCROS", "RCCRID", "RCEQTY", "RCEQTYI", "RCITM", "RCUOM", "RCAN8", "RCSHAN", "RCDVAN" }, isUnique: true),
        new JdeIndex("F46UI15_6", "Index on RCSHPN, RCITM, RCUOM, RCAN8, RCSHAN, RCDVAN", new[] { "RCSHPN", "RCITM", "RCUOM", "RCAN8", "RCSHAN", "RCDVAN" }),
        new JdeIndex("F46UI15_7", "Index on RCSHPN, RCCRID", new[] { "RCSHPN", "RCCRID" }),
        new JdeIndex("F46UI15_8", "Index on RCSHPN, RCCRID, RCEQTY, RCAN8, RCSHAN, RCDVAN", new[] { "RCSHPN", "RCCRID", "RCEQTY", "RCAN8", "RCSHAN", "RCDVAN" }),
        new JdeIndex("F46UI15_9", "Index on RCSHPN, RCMPGP, RCUOM, RCAN8, RCSHAN, RCDVAN", new[] { "RCSHPN", "RCMPGP", "RCUOM", "RCAN8", "RCSHAN", "RCDVAN" })
    };
}
