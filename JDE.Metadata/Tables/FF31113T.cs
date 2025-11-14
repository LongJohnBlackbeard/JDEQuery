using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31113T - .
/// </summary>
public class FF31113T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDUKID.
        /// </summary>
        public const string LDUKID = "LDUKID";

        /// <summary>
        /// LDLEANUNIT.
        /// </summary>
        public const string LDLEANUNIT = "LDLEANUNIT";

        /// <summary>
        /// LDLEANAMT.
        /// </summary>
        public const string LDLEANAMT = "LDLEANAMT";

        /// <summary>
        /// LDHRSWRK.
        /// </summary>
        public const string LDHRSWRK = "LDHRSWRK";

        /// <summary>
        /// LDAMTGPAY.
        /// </summary>
        public const string LDAMTGPAY = "LDAMTGPAY";
    }

    /// <inheritdoc />
    public override string TableName => "FF31113T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDUKID", "LDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDLEANUNIT", "LDLEANUNIT", JdeDataType.Numeric),
        new JdeField("LDLEANAMT", "LDLEANAMT", JdeDataType.Numeric),
        new JdeField("LDHRSWRK", "LDHRSWRK", JdeDataType.Numeric),
        new JdeField("LDAMTGPAY", "LDAMTGPAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31113T_0", "Primary Key on LDUKID", new[] { "LDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
