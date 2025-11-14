using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101W1 - .
/// </summary>
public class F0101W1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AZAN8.
        /// </summary>
        public const string AZAN8 = "AZAN8";

        /// <summary>
        /// AZEFTB.
        /// </summary>
        public const string AZEFTB = "AZEFTB";

        /// <summary>
        /// AZABSSID.
        /// </summary>
        public const string AZABSSID = "AZABSSID";

        /// <summary>
        /// AZADLC2.
        /// </summary>
        public const string AZADLC2 = "AZADLC2";

        /// <summary>
        /// AZADLC3.
        /// </summary>
        public const string AZADLC3 = "AZADLC3";

        /// <summary>
        /// AZADLC4.
        /// </summary>
        public const string AZADLC4 = "AZADLC4";

        /// <summary>
        /// AZLNGP.
        /// </summary>
        public const string AZLNGP = "AZLNGP";

        /// <summary>
        /// AZUSER.
        /// </summary>
        public const string AZUSER = "AZUSER";

        /// <summary>
        /// AZUPMJ.
        /// </summary>
        public const string AZUPMJ = "AZUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0101W1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AZAN8", "AZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AZEFTB", "AZEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AZABSSID", "AZABSSID", JdeDataType.String, 64, true, true),
        new JdeField("AZADLC2", "AZADLC2", JdeDataType.String, 80),
        new JdeField("AZADLC3", "AZADLC3", JdeDataType.String, 80),
        new JdeField("AZADLC4", "AZADLC4", JdeDataType.String, 80),
        new JdeField("AZLNGP", "AZLNGP", JdeDataType.String, 4),
        new JdeField("AZUSER", "AZUSER", JdeDataType.String, 20),
        new JdeField("AZUPMJ", "AZUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0101W1_0", "Primary Key on AZAN8, AZEFTB, AZABSSID", new[] { "AZAN8", "AZEFTB", "AZABSSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0101W1_2", "Index on AZAN8, AZEFTB", new[] { "AZAN8", "AZEFTB" }),
        new JdeIndex("F0101W1_3", "Index on AZABSSID", new[] { "AZABSSID" }),
        new JdeIndex("F0101W1_4", "Index on AZADLC2, AZADLC3, AZADLC4", new[] { "AZADLC2", "AZADLC3", "AZADLC4" }),
        new JdeIndex("F0101W1_5", "Index on AZUSER", new[] { "AZUSER" }),
        new JdeIndex("F0101W1_6", "Index on AZAN8, AZEFTB, AZLNGP", new[] { "AZAN8", "AZEFTB", "AZLNGP" })
    };
}
