using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B60 - .
/// </summary>
public class F76B60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRCO.
        /// </summary>
        public const string PRCO = "PRCO";

        /// <summary>
        /// PRLITM.
        /// </summary>
        public const string PRLITM = "PRLITM";

        /// <summary>
        /// PRUORG.
        /// </summary>
        public const string PRUORG = "PRUORG";

        /// <summary>
        /// PRUM.
        /// </summary>
        public const string PRUM = "PRUM";

        /// <summary>
        /// PRADSB.
        /// </summary>
        public const string PRADSB = "PRADSB";

        /// <summary>
        /// PRMCU.
        /// </summary>
        public const string PRMCU = "PRMCU";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PREAP.
        /// </summary>
        public const string PREAP = "PREAP";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRCO", "PRCO", JdeDataType.String, 10, true, true),
        new JdeField("PRLITM", "PRLITM", JdeDataType.String, 50, true, true),
        new JdeField("PRUORG", "PRUORG", JdeDataType.Numeric),
        new JdeField("PRUM", "PRUM", JdeDataType.String, 4),
        new JdeField("PRADSB", "PRADSB", JdeDataType.Numeric),
        new JdeField("PRMCU", "PRMCU", JdeDataType.String, 24),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PREAP", "PREAP", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B60_0", "Primary Key on PRCO, PRLITM", new[] { "PRCO", "PRLITM" }, isUnique: true, isPrimaryKey: true)
    };
}
