using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400003 - .
/// </summary>
public class F7400003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLK74LECO.
        /// </summary>
        public const string RLK74LECO = "RLK74LECO";

        /// <summary>
        /// RLDCT.
        /// </summary>
        public const string RLDCT = "RLDCT";

        /// <summary>
        /// RLK74VC.
        /// </summary>
        public const string RLK74VC = "RLK74VC";

        /// <summary>
        /// RLK74LEDT.
        /// </summary>
        public const string RLK74LEDT = "RLK74LEDT";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLUPMT.
        /// </summary>
        public const string RLUPMT = "RLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7400003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLK74LECO", "RLK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("RLDCT", "RLDCT", JdeDataType.String, 4, true, true),
        new JdeField("RLK74VC", "RLK74VC", JdeDataType.String, 6, true, true),
        new JdeField("RLK74LEDT", "RLK74LEDT", JdeDataType.String, 10),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLUPMT", "RLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400003_0", "Primary Key on RLK74LECO, RLDCT, RLK74VC", new[] { "RLK74LECO", "RLDCT", "RLK74VC" }, isUnique: true, isPrimaryKey: true)
    };
}
