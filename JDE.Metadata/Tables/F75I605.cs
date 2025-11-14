using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I605 - .
/// </summary>
public class F75I605 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TACO.
        /// </summary>
        public const string TACO = "TACO";

        /// <summary>
        /// TAMCU.
        /// </summary>
        public const string TAMCU = "TAMCU";

        /// <summary>
        /// TAAN8.
        /// </summary>
        public const string TAAN8 = "TAAN8";

        /// <summary>
        /// TAI75TOTS.
        /// </summary>
        public const string TAI75TOTS = "TAI75TOTS";

        /// <summary>
        /// TAAEXP.
        /// </summary>
        public const string TAAEXP = "TAAEXP";

        /// <summary>
        /// TAYPN1.
        /// </summary>
        public const string TAYPN1 = "TAYPN1";

        /// <summary>
        /// TAI75ICC.
        /// </summary>
        public const string TAI75ICC = "TAI75ICC";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75I605";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TACO", "TACO", JdeDataType.String, 10, true, true),
        new JdeField("TAMCU", "TAMCU", JdeDataType.String, 24, true, true),
        new JdeField("TAAN8", "TAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TAI75TOTS", "TAI75TOTS", JdeDataType.Numeric),
        new JdeField("TAAEXP", "TAAEXP", JdeDataType.Numeric),
        new JdeField("TAYPN1", "TAYPN1", JdeDataType.String, 80),
        new JdeField("TAI75ICC", "TAI75ICC", JdeDataType.String, 2, true, true),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I605_0", "Primary Key on TAAN8, TACO, TAMCU, TAI75ICC", new[] { "TAAN8", "TACO", "TAMCU", "TAI75ICC" }, isUnique: true, isPrimaryKey: true)
    };
}
