using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI04 - .
/// </summary>
public class F76AUI04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCDOC.
        /// </summary>
        public const string WCDOC = "WCDOC";

        /// <summary>
        /// WCDCT.
        /// </summary>
        public const string WCDCT = "WCDCT";

        /// <summary>
        /// WCKCO.
        /// </summary>
        public const string WCKCO = "WCKCO";

        /// <summary>
        /// WCSFX.
        /// </summary>
        public const string WCSFX = "WCSFX";

        /// <summary>
        /// WCSFXE.
        /// </summary>
        public const string WCSFXE = "WCSFXE";

        /// <summary>
        /// WCAINC.
        /// </summary>
        public const string WCAINC = "WCAINC";

        /// <summary>
        /// WCAADJ.
        /// </summary>
        public const string WCAADJ = "WCAADJ";

        /// <summary>
        /// WCAADN.
        /// </summary>
        public const string WCAADN = "WCAADN";

        /// <summary>
        /// WCADGI.
        /// </summary>
        public const string WCADGI = "WCADGI";

        /// <summary>
        /// WCAPFC.
        /// </summary>
        public const string WCAPFC = "WCAPFC";

        /// <summary>
        /// WCARED.
        /// </summary>
        public const string WCARED = "WCARED";

        /// <summary>
        /// WCA001.
        /// </summary>
        public const string WCA001 = "WCA001";

        /// <summary>
        /// WCA002.
        /// </summary>
        public const string WCA002 = "WCA002";

        /// <summary>
        /// WCA003.
        /// </summary>
        public const string WCA003 = "WCA003";

        /// <summary>
        /// WCA004.
        /// </summary>
        public const string WCA004 = "WCA004";

        /// <summary>
        /// WCA005.
        /// </summary>
        public const string WCA005 = "WCA005";

        /// <summary>
        /// WCA006.
        /// </summary>
        public const string WCA006 = "WCA006";

        /// <summary>
        /// WCA007.
        /// </summary>
        public const string WCA007 = "WCA007";

        /// <summary>
        /// WCA008.
        /// </summary>
        public const string WCA008 = "WCA008";

        /// <summary>
        /// WCA009.
        /// </summary>
        public const string WCA009 = "WCA009";

        /// <summary>
        /// WCA010.
        /// </summary>
        public const string WCA010 = "WCA010";

        /// <summary>
        /// WCA011.
        /// </summary>
        public const string WCA011 = "WCA011";

        /// <summary>
        /// WCA012.
        /// </summary>
        public const string WCA012 = "WCA012";

        /// <summary>
        /// WCA013.
        /// </summary>
        public const string WCA013 = "WCA013";

        /// <summary>
        /// WCA014.
        /// </summary>
        public const string WCA014 = "WCA014";

        /// <summary>
        /// WCA015.
        /// </summary>
        public const string WCA015 = "WCA015";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURC1.
        /// </summary>
        public const string WCURC1 = "WCURC1";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCAGRP.
        /// </summary>
        public const string WCAGRP = "WCAGRP";

        /// <summary>
        /// WCVINV.
        /// </summary>
        public const string WCVINV = "WCVINV";

        /// <summary>
        /// WCPST.
        /// </summary>
        public const string WCPST = "WCPST";

        /// <summary>
        /// WCACDS.
        /// </summary>
        public const string WCACDS = "WCACDS";

        /// <summary>
        /// WCACOP.
        /// </summary>
        public const string WCACOP = "WCACOP";

        /// <summary>
        /// WCACF.
        /// </summary>
        public const string WCACF = "WCACF";

        /// <summary>
        /// WCACAI.
        /// </summary>
        public const string WCACAI = "WCACAI";

        /// <summary>
        /// WCAFCD.
        /// </summary>
        public const string WCAFCD = "WCAFCD";

        /// <summary>
        /// WCAFFE.
        /// </summary>
        public const string WCAFFE = "WCAFFE";

        /// <summary>
        /// WCAFAT.
        /// </summary>
        public const string WCAFAT = "WCAFAT";

        /// <summary>
        /// WCVR01.
        /// </summary>
        public const string WCVR01 = "WCVR01";

        /// <summary>
        /// WCALTT.
        /// </summary>
        public const string WCALTT = "WCALTT";

        /// <summary>
        /// WCALTU.
        /// </summary>
        public const string WCALTU = "WCALTU";

        /// <summary>
        /// WCALTV.
        /// </summary>
        public const string WCALTV = "WCALTV";

        /// <summary>
        /// WCADGI1.
        /// </summary>
        public const string WCADGI1 = "WCADGI1";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCDOC", "WCDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDCT", "WCDCT", JdeDataType.String, 4, true, true),
        new JdeField("WCKCO", "WCKCO", JdeDataType.String, 10, true, true),
        new JdeField("WCSFX", "WCSFX", JdeDataType.String, 6, true, true),
        new JdeField("WCSFXE", "WCSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("WCAINC", "WCAINC", JdeDataType.String, 2),
        new JdeField("WCAADJ", "WCAADJ", JdeDataType.Numeric),
        new JdeField("WCAADN", "WCAADN", JdeDataType.String, 16),
        new JdeField("WCADGI", "WCADGI", JdeDataType.String, 4),
        new JdeField("WCAPFC", "WCAPFC", JdeDataType.Numeric),
        new JdeField("WCARED", "WCARED", JdeDataType.String, 2),
        new JdeField("WCA001", "WCA001", JdeDataType.String, 6),
        new JdeField("WCA002", "WCA002", JdeDataType.String, 6),
        new JdeField("WCA003", "WCA003", JdeDataType.String, 6),
        new JdeField("WCA004", "WCA004", JdeDataType.String, 6),
        new JdeField("WCA005", "WCA005", JdeDataType.String, 6),
        new JdeField("WCA006", "WCA006", JdeDataType.String, 6),
        new JdeField("WCA007", "WCA007", JdeDataType.String, 6),
        new JdeField("WCA008", "WCA008", JdeDataType.String, 6),
        new JdeField("WCA009", "WCA009", JdeDataType.String, 6),
        new JdeField("WCA010", "WCA010", JdeDataType.String, 6),
        new JdeField("WCA011", "WCA011", JdeDataType.String, 6),
        new JdeField("WCA012", "WCA012", JdeDataType.String, 6),
        new JdeField("WCA013", "WCA013", JdeDataType.String, 6),
        new JdeField("WCA014", "WCA014", JdeDataType.String, 6),
        new JdeField("WCA015", "WCA015", JdeDataType.String, 6),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURC1", "WCURC1", JdeDataType.String, 6),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCAGRP", "WCAGRP", JdeDataType.String, 2),
        new JdeField("WCVINV", "WCVINV", JdeDataType.String, 50),
        new JdeField("WCPST", "WCPST", JdeDataType.String, 2),
        new JdeField("WCACDS", "WCACDS", JdeDataType.String, 8),
        new JdeField("WCACOP", "WCACOP", JdeDataType.String, 2),
        new JdeField("WCACF", "WCACF", JdeDataType.String, 2),
        new JdeField("WCACAI", "WCACAI", JdeDataType.String, 28),
        new JdeField("WCAFCD", "WCAFCD", JdeDataType.String, 20),
        new JdeField("WCAFFE", "WCAFFE", JdeDataType.Numeric),
        new JdeField("WCAFAT", "WCAFAT", JdeDataType.Numeric),
        new JdeField("WCVR01", "WCVR01", JdeDataType.String, 50),
        new JdeField("WCALTT", "WCALTT", JdeDataType.String, 2),
        new JdeField("WCALTU", "WCALTU", JdeDataType.String, 2),
        new JdeField("WCALTV", "WCALTV", JdeDataType.String, 2),
        new JdeField("WCADGI1", "WCADGI1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI04_0", "Primary Key on WCDOC, WCDCT, WCKCO, WCSFX, WCSFXE", new[] { "WCDOC", "WCDCT", "WCKCO", "WCSFX", "WCSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
