using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0202 - .
/// </summary>
public class F75A0202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAAN8.
        /// </summary>
        public const string RAAN8 = "RAAN8";

        /// <summary>
        /// RADCT.
        /// </summary>
        public const string RADCT = "RADCT";

        /// <summary>
        /// RADOC.
        /// </summary>
        public const string RADOC = "RADOC";

        /// <summary>
        /// RAKCO.
        /// </summary>
        public const string RAKCO = "RAKCO";

        /// <summary>
        /// RASFX.
        /// </summary>
        public const string RASFX = "RASFX";

        /// <summary>
        /// RASFXE.
        /// </summary>
        public const string RASFXE = "RASFXE";

        /// <summary>
        /// RAPYID.
        /// </summary>
        public const string RAPYID = "RAPYID";

        /// <summary>
        /// RADOCO.
        /// </summary>
        public const string RADOCO = "RADOCO";

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
    }

    /// <inheritdoc />
    public override string TableName => "F75A0202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAAN8", "RAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RADCT", "RADCT", JdeDataType.String, 4, true, true),
        new JdeField("RADOC", "RADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RAKCO", "RAKCO", JdeDataType.String, 10, true, true),
        new JdeField("RASFX", "RASFX", JdeDataType.String, 6, true, true),
        new JdeField("RASFXE", "RASFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RAPYID", "RAPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RADOCO", "RADOCO", JdeDataType.Numeric),
        new JdeField("RAURDT", "RAURDT", JdeDataType.Numeric),
        new JdeField("RAURAT", "RAURAT", JdeDataType.Numeric),
        new JdeField("RAURAB", "RAURAB", JdeDataType.Numeric),
        new JdeField("RAURRF", "RAURRF", JdeDataType.String, 30),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0202_0", "Primary Key on RAAN8, RADCT, RADOC, RAKCO, RASFX, RASFXE, RAPYID", new[] { "RAAN8", "RADCT", "RADOC", "RAKCO", "RASFX", "RASFXE", "RAPYID" }, isUnique: true, isPrimaryKey: true)
    };
}
