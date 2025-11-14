using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42216WF - .
/// </summary>
public class F42216WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBKCOO.
        /// </summary>
        public const string PBKCOO = "PBKCOO";

        /// <summary>
        /// PBDOCO.
        /// </summary>
        public const string PBDOCO = "PBDOCO";

        /// <summary>
        /// PBDCTO.
        /// </summary>
        public const string PBDCTO = "PBDCTO";

        /// <summary>
        /// PBLNID.
        /// </summary>
        public const string PBLNID = "PBLNID";

        /// <summary>
        /// PBPEID.
        /// </summary>
        public const string PBPEID = "PBPEID";

        /// <summary>
        /// PBTCID.
        /// </summary>
        public const string PBTCID = "PBTCID";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBUORG.
        /// </summary>
        public const string PBUORG = "PBUORG";

        /// <summary>
        /// PBUOM.
        /// </summary>
        public const string PBUOM = "PBUOM";

        /// <summary>
        /// PBITM.
        /// </summary>
        public const string PBITM = "PBITM";

        /// <summary>
        /// PBLITM.
        /// </summary>
        public const string PBLITM = "PBLITM";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBTDAY.
        /// </summary>
        public const string PBTDAY = "PBTDAY";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBSCHST.
        /// </summary>
        public const string PBSCHST = "PBSCHST";

        /// <summary>
        /// PBUOM4.
        /// </summary>
        public const string PBUOM4 = "PBUOM4";
    }

    /// <inheritdoc />
    public override string TableName => "F42216WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBKCOO", "PBKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PBDOCO", "PBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PBDCTO", "PBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PBLNID", "PBLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PBPEID", "PBPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("PBTCID", "PBTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20, true, true),
        new JdeField("PBUORG", "PBUORG", JdeDataType.Numeric),
        new JdeField("PBUOM", "PBUOM", JdeDataType.String, 4),
        new JdeField("PBITM", "PBITM", JdeDataType.Numeric),
        new JdeField("PBLITM", "PBLITM", JdeDataType.String, 50),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBTDAY", "PBTDAY", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBSCHST", "PBSCHST", JdeDataType.Date),
        new JdeField("PBUOM4", "PBUOM4", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42216WF_0", "Primary Key on PBKCOO, PBDOCO, PBDCTO, PBLNID, PBPEID, PBTCID, PBUSER", new[] { "PBKCOO", "PBDOCO", "PBDCTO", "PBLNID", "PBPEID", "PBTCID", "PBUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42216WF_2", "Index on PBPEID, PBTCID", new[] { "PBPEID", "PBTCID" })
    };
}
