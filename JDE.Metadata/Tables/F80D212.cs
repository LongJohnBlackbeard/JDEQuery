using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D212 - .
/// </summary>
public class F80D212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDPRDJ.
        /// </summary>
        public const string PDPRDJ = "PDPRDJ";

        /// <summary>
        /// PDMCU.
        /// </summary>
        public const string PDMCU = "PDMCU";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDPDUEAA.
        /// </summary>
        public const string PDPDUEAA = "PDPDUEAA";

        /// <summary>
        /// PDPDUECT.
        /// </summary>
        public const string PDPDUECT = "PDPDUECT";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDMKEY.
        /// </summary>
        public const string PDMKEY = "PDMKEY";

        /// <summary>
        /// PDUTIME.
        /// </summary>
        public const string PDUTIME = "PDUTIME";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDPRDJ", "PDPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDMCU", "PDMCU", JdeDataType.String, 24, true, true),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PDPDUEAA", "PDPDUEAA", JdeDataType.Numeric),
        new JdeField("PDPDUECT", "PDPDUECT", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDMKEY", "PDMKEY", JdeDataType.String, 30),
        new JdeField("PDUTIME", "PDUTIME", JdeDataType.Date),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D212_0", "Primary Key on PDPRDJ, PDMCU, PDITM", new[] { "PDPRDJ", "PDMCU", "PDITM" }, isUnique: true, isPrimaryKey: true)
    };
}
