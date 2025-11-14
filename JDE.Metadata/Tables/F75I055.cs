using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I055 - .
/// </summary>
public class F75I055 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPSFXE.
        /// </summary>
        public const string RPSFXE = "RPSFXE";

        /// <summary>
        /// RPI75TXTY.
        /// </summary>
        public const string RPI75TXTY = "RPI75TXTY";

        /// <summary>
        /// RPI75DOC.
        /// </summary>
        public const string RPI75DOC = "RPI75DOC";

        /// <summary>
        /// RPI75DCT.
        /// </summary>
        public const string RPI75DCT = "RPI75DCT";

        /// <summary>
        /// RPI75KCO.
        /// </summary>
        public const string RPI75KCO = "RPI75KCO";

        /// <summary>
        /// RPI75SFX.
        /// </summary>
        public const string RPI75SFX = "RPI75SFX";

        /// <summary>
        /// RPI75SFXE.
        /// </summary>
        public const string RPI75SFXE = "RPI75SFXE";

        /// <summary>
        /// RPI75PFLG.
        /// </summary>
        public const string RPI75PFLG = "RPI75PFLG";

        /// <summary>
        /// RPI75SRAR.
        /// </summary>
        public const string RPI75SRAR = "RPI75SRAR";

        /// <summary>
        /// RPI75SRMR.
        /// </summary>
        public const string RPI75SRMR = "RPI75SRMR";

        /// <summary>
        /// RPI75GL01.
        /// </summary>
        public const string RPI75GL01 = "RPI75GL01";

        /// <summary>
        /// RPI75SRCT.
        /// </summary>
        public const string RPI75SRCT = "RPI75SRCT";

        /// <summary>
        /// RPCRCD.
        /// </summary>
        public const string RPCRCD = "RPCRCD";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";

        /// <summary>
        /// RPURCD.
        /// </summary>
        public const string RPURCD = "RPURCD";

        /// <summary>
        /// RPURDT.
        /// </summary>
        public const string RPURDT = "RPURDT";

        /// <summary>
        /// RPURAT.
        /// </summary>
        public const string RPURAT = "RPURAT";

        /// <summary>
        /// RPURAB.
        /// </summary>
        public const string RPURAB = "RPURAB";

        /// <summary>
        /// RPURRF.
        /// </summary>
        public const string RPURRF = "RPURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F75I055";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPSFXE", "RPSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RPI75TXTY", "RPI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("RPI75DOC", "RPI75DOC", JdeDataType.Numeric),
        new JdeField("RPI75DCT", "RPI75DCT", JdeDataType.String, 4),
        new JdeField("RPI75KCO", "RPI75KCO", JdeDataType.String, 10),
        new JdeField("RPI75SFX", "RPI75SFX", JdeDataType.String, 6),
        new JdeField("RPI75SFXE", "RPI75SFXE", JdeDataType.Numeric),
        new JdeField("RPI75PFLG", "RPI75PFLG", JdeDataType.String, 2),
        new JdeField("RPI75SRAR", "RPI75SRAR", JdeDataType.Numeric),
        new JdeField("RPI75SRMR", "RPI75SRMR", JdeDataType.Numeric),
        new JdeField("RPI75GL01", "RPI75GL01", JdeDataType.String, 8),
        new JdeField("RPI75SRCT", "RPI75SRCT", JdeDataType.String, 12),
        new JdeField("RPCRCD", "RPCRCD", JdeDataType.String, 6),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPURCD", "RPURCD", JdeDataType.String, 4),
        new JdeField("RPURDT", "RPURDT", JdeDataType.Numeric),
        new JdeField("RPURAT", "RPURAT", JdeDataType.Numeric),
        new JdeField("RPURAB", "RPURAB", JdeDataType.Numeric),
        new JdeField("RPURRF", "RPURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I055_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX, RPSFXE, RPI75TXTY", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX", "RPSFXE", "RPI75TXTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I055_2", "Index on RPI75DOC, RPI75DCT, RPI75KCO, RPI75SFX, RPI75SFXE", new[] { "RPI75DOC", "RPI75DCT", "RPI75KCO", "RPI75SFX", "RPI75SFXE" })
    };
}
