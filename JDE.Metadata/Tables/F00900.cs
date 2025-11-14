using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00900 - .
/// </summary>
public class F00900 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRCO.
        /// </summary>
        public const string IRCO = "IRCO";

        /// <summary>
        /// IRIITY.
        /// </summary>
        public const string IRIITY = "IRIITY";

        /// <summary>
        /// IRAN8.
        /// </summary>
        public const string IRAN8 = "IRAN8";

        /// <summary>
        /// IRTAX.
        /// </summary>
        public const string IRTAX = "IRTAX";

        /// <summary>
        /// IRDI#.
        /// </summary>
        public const string IRDI_ = "IRDI#";

        /// <summary>
        /// IRDIY.
        /// </summary>
        public const string IRDIY = "IRDIY";

        /// <summary>
        /// IRIID1.
        /// </summary>
        public const string IRIID1 = "IRIID1";

        /// <summary>
        /// IRATXA.
        /// </summary>
        public const string IRATXA = "IRATXA";

        /// <summary>
        /// IRSTAM.
        /// </summary>
        public const string IRSTAM = "IRSTAM";

        /// <summary>
        /// IRATXN.
        /// </summary>
        public const string IRATXN = "IRATXN";

        /// <summary>
        /// IRIID2.
        /// </summary>
        public const string IRIID2 = "IRIID2";

        /// <summary>
        /// IRIINA.
        /// </summary>
        public const string IRIINA = "IRIINA";

        /// <summary>
        /// IRIIX8.
        /// </summary>
        public const string IRIIX8 = "IRIIX8";
    }

    /// <inheritdoc />
    public override string TableName => "F00900";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRCO", "IRCO", JdeDataType.String, 10, true, true),
        new JdeField("IRIITY", "IRIITY", JdeDataType.String, 2, true, true),
        new JdeField("IRAN8", "IRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IRTAX", "IRTAX", JdeDataType.String, 40),
        new JdeField("IRDI#", "IRDI#", JdeDataType.Numeric, null, true, true),
        new JdeField("IRDIY", "IRDIY", JdeDataType.Numeric, null, true, true),
        new JdeField("IRIID1", "IRIID1", JdeDataType.Numeric),
        new JdeField("IRATXA", "IRATXA", JdeDataType.Numeric),
        new JdeField("IRSTAM", "IRSTAM", JdeDataType.Numeric),
        new JdeField("IRATXN", "IRATXN", JdeDataType.Numeric),
        new JdeField("IRIID2", "IRIID2", JdeDataType.Numeric),
        new JdeField("IRIINA", "IRIINA", JdeDataType.Numeric),
        new JdeField("IRIIX8", "IRIIX8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00900_0", "Primary Key on IRCO, IRIITY, IRAN8, IRDI#, IRDIY", new[] { "IRCO", "IRIITY", "IRAN8", "IRDI#", "IRDIY" }, isUnique: true, isPrimaryKey: true)
    };
}
