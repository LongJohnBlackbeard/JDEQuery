using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B311 - .
/// </summary>
public class F31B311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCWLOTN.
        /// </summary>
        public const string LCWLOTN = "LCWLOTN";

        /// <summary>
        /// LCVARID.
        /// </summary>
        public const string LCVARID = "LCVARID";

        /// <summary>
        /// LCVINTAG.
        /// </summary>
        public const string LCVINTAG = "LCVINTAG";

        /// <summary>
        /// LCGOAID.
        /// </summary>
        public const string LCGOAID = "LCGOAID";

        /// <summary>
        /// LCCMATYPE.
        /// </summary>
        public const string LCCMATYPE = "LCCMATYPE";

        /// <summary>
        /// LCSRCETYPE.
        /// </summary>
        public const string LCSRCETYPE = "LCSRCETYPE";

        /// <summary>
        /// LCSRCEID.
        /// </summary>
        public const string LCSRCEID = "LCSRCEID";

        /// <summary>
        /// LCPERCT.
        /// </summary>
        public const string LCPERCT = "LCPERCT";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCHARPER.
        /// </summary>
        public const string LCHARPER = "LCHARPER";

        /// <summary>
        /// LCAPPID.
        /// </summary>
        public const string LCAPPID = "LCAPPID";

        /// <summary>
        /// LCGROWAREA.
        /// </summary>
        public const string LCGROWAREA = "LCGROWAREA";

        /// <summary>
        /// LCGROWER.
        /// </summary>
        public const string LCGROWER = "LCGROWER";

        /// <summary>
        /// LCHARSFX.
        /// </summary>
        public const string LCHARSFX = "LCHARSFX";

        /// <summary>
        /// LCBLUID.
        /// </summary>
        public const string LCBLUID = "LCBLUID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCWLOTN", "LCWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LCVARID", "LCVARID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCVINTAG", "LCVINTAG", JdeDataType.Numeric),
        new JdeField("LCGOAID", "LCGOAID", JdeDataType.Numeric),
        new JdeField("LCCMATYPE", "LCCMATYPE", JdeDataType.String, 8, true, true),
        new JdeField("LCSRCETYPE", "LCSRCETYPE", JdeDataType.String, 6, true, true),
        new JdeField("LCSRCEID", "LCSRCEID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCPERCT", "LCPERCT", JdeDataType.Numeric),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCHARPER", "LCHARPER", JdeDataType.String, 12, true, true),
        new JdeField("LCAPPID", "LCAPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCGROWAREA", "LCGROWAREA", JdeDataType.Numeric),
        new JdeField("LCGROWER", "LCGROWER", JdeDataType.Numeric),
        new JdeField("LCHARSFX", "LCHARSFX", JdeDataType.String, 20),
        new JdeField("LCBLUID", "LCBLUID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B311_0", "Primary Key on LCMCU, LCWLOTN, LCHARPER, LCVARID, LCAPPID, LCCMATYPE, LCSRCETYPE, LCSRCEID", new[] { "LCMCU", "LCWLOTN", "LCHARPER", "LCVARID", "LCAPPID", "LCCMATYPE", "LCSRCETYPE", "LCSRCEID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B311_2", "Index on LCMCU, LCWLOTN, LCVARID", new[] { "LCMCU", "LCWLOTN", "LCVARID" }),
        new JdeIndex("F31B311_3", "Index on LCMCU, LCWLOTN, LCHARPER", new[] { "LCMCU", "LCWLOTN", "LCHARPER" }),
        new JdeIndex("F31B311_4", "Index on LCMCU, LCWLOTN, LCAPPID, LCVARID, LCHARPER", new[] { "LCMCU", "LCWLOTN", "LCAPPID", "LCVARID", "LCHARPER" }),
        new JdeIndex("F31B311_5", "Index on LCMCU, LCWLOTN, LCVARID, LCHARPER", new[] { "LCMCU", "LCWLOTN", "LCVARID", "LCHARPER" }),
        new JdeIndex("F31B311_6", "Index on LCAPPID", new[] { "LCAPPID" }),
        new JdeIndex("F31B311_7", "Index on LCVARID", new[] { "LCVARID" }),
        new JdeIndex("F31B311_8", "Index on LCGROWAREA", new[] { "LCGROWAREA" }),
        new JdeIndex("F31B311_9", "Index on LCMCU, LCWLOTN, LCBLUID, LCHARPER, LCHARSFX", new[] { "LCMCU", "LCWLOTN", "LCBLUID", "LCHARPER", "LCHARSFX" })
    };
}
