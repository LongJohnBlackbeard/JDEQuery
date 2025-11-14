using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4209 - .
/// </summary>
public class F4209 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HOHCOD.
        /// </summary>
        public const string HOHCOD = "HOHCOD";

        /// <summary>
        /// HORPER.
        /// </summary>
        public const string HORPER = "HORPER";

        /// <summary>
        /// HOAN8.
        /// </summary>
        public const string HOAN8 = "HOAN8";

        /// <summary>
        /// HOMCU.
        /// </summary>
        public const string HOMCU = "HOMCU";

        /// <summary>
        /// HOKCOO.
        /// </summary>
        public const string HOKCOO = "HOKCOO";

        /// <summary>
        /// HODOCO.
        /// </summary>
        public const string HODOCO = "HODOCO";

        /// <summary>
        /// HODCTO.
        /// </summary>
        public const string HODCTO = "HODCTO";

        /// <summary>
        /// HOSFXO.
        /// </summary>
        public const string HOSFXO = "HOSFXO";

        /// <summary>
        /// HOLNID.
        /// </summary>
        public const string HOLNID = "HOLNID";

        /// <summary>
        /// HOITM.
        /// </summary>
        public const string HOITM = "HOITM";

        /// <summary>
        /// HOLITM.
        /// </summary>
        public const string HOLITM = "HOLITM";

        /// <summary>
        /// HOAITM.
        /// </summary>
        public const string HOAITM = "HOAITM";

        /// <summary>
        /// HOTRDJ.
        /// </summary>
        public const string HOTRDJ = "HOTRDJ";

        /// <summary>
        /// HODRQJ.
        /// </summary>
        public const string HODRQJ = "HODRQJ";

        /// <summary>
        /// HOPDDJ.
        /// </summary>
        public const string HOPDDJ = "HOPDDJ";

        /// <summary>
        /// HOCTYP.
        /// </summary>
        public const string HOCTYP = "HOCTYP";

        /// <summary>
        /// HORDC.
        /// </summary>
        public const string HORDC = "HORDC";

        /// <summary>
        /// HORDB.
        /// </summary>
        public const string HORDB = "HORDB";

        /// <summary>
        /// HORDJ.
        /// </summary>
        public const string HORDJ = "HORDJ";

        /// <summary>
        /// HORDT.
        /// </summary>
        public const string HORDT = "HORDT";

        /// <summary>
        /// HOARTG.
        /// </summary>
        public const string HOARTG = "HOARTG";

        /// <summary>
        /// HOASTS.
        /// </summary>
        public const string HOASTS = "HOASTS";

        /// <summary>
        /// HOATY.
        /// </summary>
        public const string HOATY = "HOATY";

        /// <summary>
        /// HOEDEI.
        /// </summary>
        public const string HOEDEI = "HOEDEI";

        /// <summary>
        /// HODLNID.
        /// </summary>
        public const string HODLNID = "HODLNID";

        /// <summary>
        /// HOPA8.
        /// </summary>
        public const string HOPA8 = "HOPA8";

        /// <summary>
        /// HOSHAN.
        /// </summary>
        public const string HOSHAN = "HOSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F4209";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HOHCOD", "HOHCOD", JdeDataType.String, 4, true, true),
        new JdeField("HORPER", "HORPER", JdeDataType.Numeric, null, true, true),
        new JdeField("HOAN8", "HOAN8", JdeDataType.Numeric),
        new JdeField("HOMCU", "HOMCU", JdeDataType.String, 24),
        new JdeField("HOKCOO", "HOKCOO", JdeDataType.String, 10, true, true),
        new JdeField("HODOCO", "HODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HODCTO", "HODCTO", JdeDataType.String, 4, true, true),
        new JdeField("HOSFXO", "HOSFXO", JdeDataType.String, 6, true, true),
        new JdeField("HOLNID", "HOLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("HOITM", "HOITM", JdeDataType.Numeric),
        new JdeField("HOLITM", "HOLITM", JdeDataType.String, 50),
        new JdeField("HOAITM", "HOAITM", JdeDataType.String, 50),
        new JdeField("HOTRDJ", "HOTRDJ", JdeDataType.Numeric),
        new JdeField("HODRQJ", "HODRQJ", JdeDataType.Numeric),
        new JdeField("HOPDDJ", "HOPDDJ", JdeDataType.Numeric),
        new JdeField("HOCTYP", "HOCTYP", JdeDataType.String, 4),
        new JdeField("HORDC", "HORDC", JdeDataType.String, 4),
        new JdeField("HORDB", "HORDB", JdeDataType.String, 20),
        new JdeField("HORDJ", "HORDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("HORDT", "HORDT", JdeDataType.Numeric, null, true, true),
        new JdeField("HOARTG", "HOARTG", JdeDataType.String, 24),
        new JdeField("HOASTS", "HOASTS", JdeDataType.String, 4, true, true),
        new JdeField("HOATY", "HOATY", JdeDataType.String, 2),
        new JdeField("HOEDEI", "HOEDEI", JdeDataType.String, 8),
        new JdeField("HODLNID", "HODLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("HOPA8", "HOPA8", JdeDataType.Numeric),
        new JdeField("HOSHAN", "HOSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4209_0", "Primary Key on HOHCOD, HODCTO, HODOCO, HOKCOO, HOSFXO, HOLNID, HODLNID, HORDJ, HORDT, HOASTS, HORPER", new[] { "HOHCOD", "HODCTO", "HODOCO", "HOKCOO", "HOSFXO", "HOLNID", "HODLNID", "HORDJ", "HORDT", "HOASTS", "HORPER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4209_2", "Index on HOHCOD, HODCTO, HODOCO, HOKCOO, HOSFXO, HOMCU, HOARTG, HORDJ, HORDT", new[] { "HOHCOD", "HODCTO", "HODOCO", "HOKCOO", "HOSFXO", "HOMCU", "HOARTG", "HORDJ", "HORDT" }),
        new JdeIndex("F4209_3", "Index on HOASTS, HORPER, HODCTO, HOARTG", new[] { "HOASTS", "HORPER", "HODCTO", "HOARTG" }),
        new JdeIndex("F4209_4", "Index on HODOCO, HOASTS, HOAN8, HODCTO, HOKCOO, HOSFXO, HOMCU", new[] { "HODOCO", "HOASTS", "HOAN8", "HODCTO", "HOKCOO", "HOSFXO", "HOMCU" }),
        new JdeIndex("F4209_5", "Index on HODOCO, HODCTO, HOKCOO, HOSFXO, HOLNID, HODLNID", new[] { "HODOCO", "HODCTO", "HOKCOO", "HOSFXO", "HOLNID", "HODLNID" }),
        new JdeIndex("F4209_6", "Index on HOHCOD, HODOCO, HODCTO, HOKCOO, HOSFXO, HOASTS", new[] { "HOHCOD", "HODOCO", "HODCTO", "HOKCOO", "HOSFXO", "HOASTS" }),
        new JdeIndex("F4209_7", "Index on HOHCOD, HODCTO, HODOCO, HOKCOO, HOSFXO, HOMCU, HOTRDJ, HOLNID, HODLNID", new[] { "HOHCOD", "HODCTO", "HODOCO", "HOKCOO", "HOSFXO", "HOMCU", "HOTRDJ", "HOLNID", "HODLNID" }),
        new JdeIndex("F4209_8", "Index on HOKCOO, HODCTO, HODOCO", new[] { "HOKCOO", "HODCTO", "HODOCO" })
    };
}
