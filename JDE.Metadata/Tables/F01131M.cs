using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01131M - .
/// </summary>
public class F01131M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZMPSRK.
        /// </summary>
        public const string ZMPSRK = "ZMPSRK";

        /// <summary>
        /// ZMSERK.
        /// </summary>
        public const string ZMSERK = "ZMSERK";

        /// <summary>
        /// ZMMSGP.
        /// </summary>
        public const string ZMMSGP = "ZMMSGP";

        /// <summary>
        /// ZMDTI.
        /// </summary>
        public const string ZMDTI = "ZMDTI";

        /// <summary>
        /// ZMLV.
        /// </summary>
        public const string ZMLV = "ZMLV";

        /// <summary>
        /// ZMAN8.
        /// </summary>
        public const string ZMAN8 = "ZMAN8";

        /// <summary>
        /// ZMPA8.
        /// </summary>
        public const string ZMPA8 = "ZMPA8";

        /// <summary>
        /// ZMTSV.
        /// </summary>
        public const string ZMTSV = "ZMTSV";

        /// <summary>
        /// ZMTMPI.
        /// </summary>
        public const string ZMTMPI = "ZMTMPI";

        /// <summary>
        /// ZMFRMI.
        /// </summary>
        public const string ZMFRMI = "ZMFRMI";

        /// <summary>
        /// ZMEAP.
        /// </summary>
        public const string ZMEAP = "ZMEAP";

        /// <summary>
        /// ZMVERS.
        /// </summary>
        public const string ZMVERS = "ZMVERS";

        /// <summary>
        /// ZMFCTNM.
        /// </summary>
        public const string ZMFCTNM = "ZMFCTNM";

        /// <summary>
        /// ZMLNBR.
        /// </summary>
        public const string ZMLNBR = "ZMLNBR";

        /// <summary>
        /// ZMFMNM.
        /// </summary>
        public const string ZMFMNM = "ZMFMNM";

        /// <summary>
        /// ZMPPSRK.
        /// </summary>
        public const string ZMPPSRK = "ZMPPSRK";
    }

    /// <inheritdoc />
    public override string TableName => "F01131M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZMPSRK", "ZMPSRK", JdeDataType.Numeric, null, true, true),
        new JdeField("ZMSERK", "ZMSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("ZMMSGP", "ZMMSGP", JdeDataType.String, 80),
        new JdeField("ZMDTI", "ZMDTI", JdeDataType.Numeric),
        new JdeField("ZMLV", "ZMLV", JdeDataType.Numeric),
        new JdeField("ZMAN8", "ZMAN8", JdeDataType.Numeric),
        new JdeField("ZMPA8", "ZMPA8", JdeDataType.Numeric),
        new JdeField("ZMTSV", "ZMTSV", JdeDataType.String, 2048),
        new JdeField("ZMTMPI", "ZMTMPI", JdeDataType.String, 20),
        new JdeField("ZMFRMI", "ZMFRMI", JdeDataType.Numeric),
        new JdeField("ZMEAP", "ZMEAP", JdeDataType.String, 20),
        new JdeField("ZMVERS", "ZMVERS", JdeDataType.String, 20),
        new JdeField("ZMFCTNM", "ZMFCTNM", JdeDataType.String, 64),
        new JdeField("ZMLNBR", "ZMLNBR", JdeDataType.String, 14),
        new JdeField("ZMFMNM", "ZMFMNM", JdeDataType.String, 20),
        new JdeField("ZMPPSRK", "ZMPPSRK", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01131M_0", "Primary Key on ZMPSRK, ZMSERK", new[] { "ZMPSRK", "ZMSERK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01131M_2", "Index on ZMPPSRK", new[] { "ZMPPSRK" })
    };
}
