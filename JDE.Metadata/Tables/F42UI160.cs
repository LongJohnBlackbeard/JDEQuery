using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI160 - .
/// </summary>
public class F42UI160 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDJOBS.
        /// </summary>
        public const string ZDJOBS = "ZDJOBS";

        /// <summary>
        /// ZDCTID.
        /// </summary>
        public const string ZDCTID = "ZDCTID";

        /// <summary>
        /// ZDLNID.
        /// </summary>
        public const string ZDLNID = "ZDLNID";

        /// <summary>
        /// ZDCMLN.
        /// </summary>
        public const string ZDCMLN = "ZDCMLN";

        /// <summary>
        /// ZDSLSM.
        /// </summary>
        public const string ZDSLSM = "ZDSLSM";

        /// <summary>
        /// ZDSLCM.
        /// </summary>
        public const string ZDSLCM = "ZDSLCM";

        /// <summary>
        /// ZDFCA.
        /// </summary>
        public const string ZDFCA = "ZDFCA";

        /// <summary>
        /// ZDAPUN.
        /// </summary>
        public const string ZDAPUN = "ZDAPUN";

        /// <summary>
        /// ZDCCTY.
        /// </summary>
        public const string ZDCCTY = "ZDCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDJOBS", "ZDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDCTID", "ZDCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZDLNID", "ZDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDCMLN", "ZDCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDSLSM", "ZDSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDSLCM", "ZDSLCM", JdeDataType.Numeric),
        new JdeField("ZDFCA", "ZDFCA", JdeDataType.Numeric),
        new JdeField("ZDAPUN", "ZDAPUN", JdeDataType.Numeric),
        new JdeField("ZDCCTY", "ZDCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI160_0", "Primary Key on ZDJOBS, ZDCTID, ZDLNID, ZDCMLN, ZDSLSM", new[] { "ZDJOBS", "ZDCTID", "ZDLNID", "ZDCMLN", "ZDSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
