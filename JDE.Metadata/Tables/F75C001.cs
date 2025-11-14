using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C001 - .
/// </summary>
public class F75C001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRDOC0.
        /// </summary>
        public const string CRDOC0 = "CRDOC0";

        /// <summary>
        /// CRLINN.
        /// </summary>
        public const string CRLINN = "CRLINN";

        /// <summary>
        /// CRDOC.
        /// </summary>
        public const string CRDOC = "CRDOC";

        /// <summary>
        /// CRDCT.
        /// </summary>
        public const string CRDCT = "CRDCT";

        /// <summary>
        /// CRKCO.
        /// </summary>
        public const string CRKCO = "CRKCO";

        /// <summary>
        /// CRSFX.
        /// </summary>
        public const string CRSFX = "CRSFX";

        /// <summary>
        /// CRDOCO.
        /// </summary>
        public const string CRDOCO = "CRDOCO";

        /// <summary>
        /// CRDCTO.
        /// </summary>
        public const string CRDCTO = "CRDCTO";

        /// <summary>
        /// CRKCOO.
        /// </summary>
        public const string CRKCOO = "CRKCOO";

        /// <summary>
        /// CRGUI.
        /// </summary>
        public const string CRGUI = "CRGUI";

        /// <summary>
        /// CRAEXP.
        /// </summary>
        public const string CRAEXP = "CRAEXP";

        /// <summary>
        /// CRCRR.
        /// </summary>
        public const string CRCRR = "CRCRR";

        /// <summary>
        /// CRCRCD.
        /// </summary>
        public const string CRCRCD = "CRCRCD";

        /// <summary>
        /// CRCRDC.
        /// </summary>
        public const string CRCRDC = "CRCRDC";

        /// <summary>
        /// CRRCDS.
        /// </summary>
        public const string CRRCDS = "CRRCDS";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRIVD.
        /// </summary>
        public const string CRIVD = "CRIVD";

        /// <summary>
        /// CRDIVJ.
        /// </summary>
        public const string CRDIVJ = "CRDIVJ";

        /// <summary>
        /// CRC75CBNK.
        /// </summary>
        public const string CRC75CBNK = "CRC75CBNK";

        /// <summary>
        /// CRDL01.
        /// </summary>
        public const string CRDL01 = "CRDL01";

        /// <summary>
        /// CRUPRC.
        /// </summary>
        public const string CRUPRC = "CRUPRC";

        /// <summary>
        /// CRAR1.
        /// </summary>
        public const string CRAR1 = "CRAR1";

        /// <summary>
        /// CRPH1.
        /// </summary>
        public const string CRPH1 = "CRPH1";

        /// <summary>
        /// CRADD1.
        /// </summary>
        public const string CRADD1 = "CRADD1";

        /// <summary>
        /// CRC75STCI.
        /// </summary>
        public const string CRC75STCI = "CRC75STCI";
    }

    /// <inheritdoc />
    public override string TableName => "F75C001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRDOC0", "CRDOC0", JdeDataType.Numeric, null, true, true),
        new JdeField("CRLINN", "CRLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("CRDOC", "CRDOC", JdeDataType.Numeric),
        new JdeField("CRDCT", "CRDCT", JdeDataType.String, 4),
        new JdeField("CRKCO", "CRKCO", JdeDataType.String, 10),
        new JdeField("CRSFX", "CRSFX", JdeDataType.String, 6),
        new JdeField("CRDOCO", "CRDOCO", JdeDataType.Numeric),
        new JdeField("CRDCTO", "CRDCTO", JdeDataType.String, 4),
        new JdeField("CRKCOO", "CRKCOO", JdeDataType.String, 10),
        new JdeField("CRGUI", "CRGUI", JdeDataType.String, 50),
        new JdeField("CRAEXP", "CRAEXP", JdeDataType.Numeric),
        new JdeField("CRCRR", "CRCRR", JdeDataType.Numeric),
        new JdeField("CRCRCD", "CRCRCD", JdeDataType.String, 6),
        new JdeField("CRCRDC", "CRCRDC", JdeDataType.String, 6),
        new JdeField("CRRCDS", "CRRCDS", JdeDataType.String, 2),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRIVD", "CRIVD", JdeDataType.Numeric),
        new JdeField("CRDIVJ", "CRDIVJ", JdeDataType.Numeric),
        new JdeField("CRC75CBNK", "CRC75CBNK", JdeDataType.String, 100),
        new JdeField("CRDL01", "CRDL01", JdeDataType.String, 60),
        new JdeField("CRUPRC", "CRUPRC", JdeDataType.Numeric),
        new JdeField("CRAR1", "CRAR1", JdeDataType.String, 12),
        new JdeField("CRPH1", "CRPH1", JdeDataType.String, 40),
        new JdeField("CRADD1", "CRADD1", JdeDataType.String, 80),
        new JdeField("CRC75STCI", "CRC75STCI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C001_0", "Primary Key on CRDOC0, CRLINN", new[] { "CRDOC0", "CRLINN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C001_3", "Index on CRGUI", new[] { "CRGUI" }),
        new JdeIndex("F75C001_4", "Index on CRDOC, CRDCT, CRKCO", new[] { "CRDOC", "CRDCT", "CRKCO" })
    };
}
