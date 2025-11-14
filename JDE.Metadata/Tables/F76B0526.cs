using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0526 - .
/// </summary>
public class F76B0526 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMJOBS.
        /// </summary>
        public const string AMJOBS = "AMJOBS";

        /// <summary>
        /// AMAID.
        /// </summary>
        public const string AMAID = "AMAID";

        /// <summary>
        /// AMB76BLCK.
        /// </summary>
        public const string AMB76BLCK = "AMB76BLCK";

        /// <summary>
        /// AMURCD.
        /// </summary>
        public const string AMURCD = "AMURCD";

        /// <summary>
        /// AMURDT.
        /// </summary>
        public const string AMURDT = "AMURDT";

        /// <summary>
        /// AMURAB.
        /// </summary>
        public const string AMURAB = "AMURAB";

        /// <summary>
        /// AMURAT.
        /// </summary>
        public const string AMURAT = "AMURAT";

        /// <summary>
        /// AMURRF.
        /// </summary>
        public const string AMURRF = "AMURRF";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMUPMT.
        /// </summary>
        public const string AMUPMT = "AMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0526";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMJOBS", "AMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("AMAID", "AMAID", JdeDataType.String, 16, true, true),
        new JdeField("AMB76BLCK", "AMB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("AMURCD", "AMURCD", JdeDataType.String, 4),
        new JdeField("AMURDT", "AMURDT", JdeDataType.Numeric),
        new JdeField("AMURAB", "AMURAB", JdeDataType.Numeric),
        new JdeField("AMURAT", "AMURAT", JdeDataType.Numeric),
        new JdeField("AMURRF", "AMURRF", JdeDataType.String, 30),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0526_0", "Primary Key on AMJOBS, AMAID, AMB76BLCK", new[] { "AMJOBS", "AMAID", "AMB76BLCK" }, isUnique: true, isPrimaryKey: true)
    };
}
