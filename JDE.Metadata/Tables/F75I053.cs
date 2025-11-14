using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I053 - .
/// </summary>
public class F75I053 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RADOC.
        /// </summary>
        public const string RADOC = "RADOC";

        /// <summary>
        /// RADCT.
        /// </summary>
        public const string RADCT = "RADCT";

        /// <summary>
        /// RAKCO.
        /// </summary>
        public const string RAKCO = "RAKCO";

        /// <summary>
        /// RASFX.
        /// </summary>
        public const string RASFX = "RASFX";

        /// <summary>
        /// RAI75TXTY.
        /// </summary>
        public const string RAI75TXTY = "RAI75TXTY";

        /// <summary>
        /// RAI75DOC.
        /// </summary>
        public const string RAI75DOC = "RAI75DOC";

        /// <summary>
        /// RAI75DCT.
        /// </summary>
        public const string RAI75DCT = "RAI75DCT";

        /// <summary>
        /// RAI75KCO.
        /// </summary>
        public const string RAI75KCO = "RAI75KCO";

        /// <summary>
        /// RAI75SFX.
        /// </summary>
        public const string RAI75SFX = "RAI75SFX";

        /// <summary>
        /// RAI75SFXE.
        /// </summary>
        public const string RAI75SFXE = "RAI75SFXE";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";

        /// <summary>
        /// RAURCD.
        /// </summary>
        public const string RAURCD = "RAURCD";

        /// <summary>
        /// RAURDT.
        /// </summary>
        public const string RAURDT = "RAURDT";

        /// <summary>
        /// RAURAT.
        /// </summary>
        public const string RAURAT = "RAURAT";

        /// <summary>
        /// RAURAB.
        /// </summary>
        public const string RAURAB = "RAURAB";

        /// <summary>
        /// RAURRF.
        /// </summary>
        public const string RAURRF = "RAURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F75I053";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RADOC", "RADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RADCT", "RADCT", JdeDataType.String, 4, true, true),
        new JdeField("RAKCO", "RAKCO", JdeDataType.String, 10, true, true),
        new JdeField("RASFX", "RASFX", JdeDataType.String, 6, true, true),
        new JdeField("RAI75TXTY", "RAI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("RAI75DOC", "RAI75DOC", JdeDataType.Numeric),
        new JdeField("RAI75DCT", "RAI75DCT", JdeDataType.String, 4),
        new JdeField("RAI75KCO", "RAI75KCO", JdeDataType.String, 10),
        new JdeField("RAI75SFX", "RAI75SFX", JdeDataType.String, 6),
        new JdeField("RAI75SFXE", "RAI75SFXE", JdeDataType.Numeric),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric),
        new JdeField("RAURCD", "RAURCD", JdeDataType.String, 4),
        new JdeField("RAURDT", "RAURDT", JdeDataType.Numeric),
        new JdeField("RAURAT", "RAURAT", JdeDataType.Numeric),
        new JdeField("RAURAB", "RAURAB", JdeDataType.Numeric),
        new JdeField("RAURRF", "RAURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I053_0", "Primary Key on RADOC, RADCT, RAKCO, RASFX, RAI75TXTY", new[] { "RADOC", "RADCT", "RAKCO", "RASFX", "RAI75TXTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I053_2", "Index on RAI75DOC, RAI75DCT, RAI75KCO, RAI75SFX, RAI75SFXE", new[] { "RAI75DOC", "RAI75DCT", "RAI75KCO", "RAI75SFX", "RAI75SFXE" })
    };
}
