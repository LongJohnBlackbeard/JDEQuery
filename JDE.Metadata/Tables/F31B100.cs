using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B100 - .
/// </summary>
public class F31B100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCWVID.
        /// </summary>
        public const string BCWVID = "BCWVID";

        /// <summary>
        /// BCUKID.
        /// </summary>
        public const string BCUKID = "BCUKID";

        /// <summary>
        /// BCVARID.
        /// </summary>
        public const string BCVARID = "BCVARID";

        /// <summary>
        /// BCVINTAG.
        /// </summary>
        public const string BCVINTAG = "BCVINTAG";

        /// <summary>
        /// BCGOAID.
        /// </summary>
        public const string BCGOAID = "BCGOAID";

        /// <summary>
        /// BCCMATYPE.
        /// </summary>
        public const string BCCMATYPE = "BCCMATYPE";

        /// <summary>
        /// BCSRCETYPE.
        /// </summary>
        public const string BCSRCETYPE = "BCSRCETYPE";

        /// <summary>
        /// BCSRCEID.
        /// </summary>
        public const string BCSRCEID = "BCSRCEID";

        /// <summary>
        /// BCPERCT.
        /// </summary>
        public const string BCPERCT = "BCPERCT";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCUPMT.
        /// </summary>
        public const string BCUPMT = "BCUPMT";

        /// <summary>
        /// BCHARPER.
        /// </summary>
        public const string BCHARPER = "BCHARPER";

        /// <summary>
        /// BCHARSFX.
        /// </summary>
        public const string BCHARSFX = "BCHARSFX";

        /// <summary>
        /// BCAPPID.
        /// </summary>
        public const string BCAPPID = "BCAPPID";

        /// <summary>
        /// BCGROWAREA.
        /// </summary>
        public const string BCGROWAREA = "BCGROWAREA";

        /// <summary>
        /// BCGROWER.
        /// </summary>
        public const string BCGROWER = "BCGROWER";

        /// <summary>
        /// BCBLUID.
        /// </summary>
        public const string BCBLUID = "BCBLUID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCWVID", "BCWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCUKID", "BCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCVARID", "BCVARID", JdeDataType.Numeric),
        new JdeField("BCVINTAG", "BCVINTAG", JdeDataType.Numeric),
        new JdeField("BCGOAID", "BCGOAID", JdeDataType.Numeric),
        new JdeField("BCCMATYPE", "BCCMATYPE", JdeDataType.String, 8),
        new JdeField("BCSRCETYPE", "BCSRCETYPE", JdeDataType.String, 6),
        new JdeField("BCSRCEID", "BCSRCEID", JdeDataType.Numeric),
        new JdeField("BCPERCT", "BCPERCT", JdeDataType.Numeric),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCUPMT", "BCUPMT", JdeDataType.Numeric),
        new JdeField("BCHARPER", "BCHARPER", JdeDataType.String, 12),
        new JdeField("BCHARSFX", "BCHARSFX", JdeDataType.String, 20),
        new JdeField("BCAPPID", "BCAPPID", JdeDataType.Numeric),
        new JdeField("BCGROWAREA", "BCGROWAREA", JdeDataType.Numeric),
        new JdeField("BCGROWER", "BCGROWER", JdeDataType.Numeric),
        new JdeField("BCBLUID", "BCBLUID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B100_0", "Primary Key on BCWVID, BCUKID", new[] { "BCWVID", "BCUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
