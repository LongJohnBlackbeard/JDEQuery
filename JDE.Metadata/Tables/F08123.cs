using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08123 - .
/// </summary>
public class F08123 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMALE.
        /// </summary>
        public const string AMALE = "AMALE";

        /// <summary>
        /// AMRPYR.
        /// </summary>
        public const string AMRPYR = "AMRPYR";

        /// <summary>
        /// AMTAXX.
        /// </summary>
        public const string AMTAXX = "AMTAXX";

        /// <summary>
        /// AMALEM.
        /// </summary>
        public const string AMALEM = "AMALEM";

        /// <summary>
        /// AMAMFC.
        /// </summary>
        public const string AMAMFC = "AMAMFC";

        /// <summary>
        /// AMPRRF.
        /// </summary>
        public const string AMPRRF = "AMPRRF";

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
    public override string TableName => "F08123";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMALE", "AMALE", JdeDataType.String, 20, true, true),
        new JdeField("AMRPYR", "AMRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AMTAXX", "AMTAXX", JdeDataType.String, 40, true, true),
        new JdeField("AMALEM", "AMALEM", JdeDataType.String, 20),
        new JdeField("AMAMFC", "AMAMFC", JdeDataType.Numeric),
        new JdeField("AMPRRF", "AMPRRF", JdeDataType.String, 2),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08123_0", "Primary Key on AMALE, AMRPYR, AMTAXX", new[] { "AMALE", "AMRPYR", "AMTAXX" }, isUnique: true, isPrimaryKey: true)
    };
}
