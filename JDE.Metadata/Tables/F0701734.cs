using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701734 - .
/// </summary>
public class F0701734 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y3AN8.
        /// </summary>
        public const string Y3AN8 = "Y3AN8";

        /// <summary>
        /// Y3DTEY.
        /// </summary>
        public const string Y3DTEY = "Y3DTEY";

        /// <summary>
        /// Y3TARA.
        /// </summary>
        public const string Y3TARA = "Y3TARA";

        /// <summary>
        /// Y3PTAX.
        /// </summary>
        public const string Y3PTAX = "Y3PTAX";

        /// <summary>
        /// Y3G301.
        /// </summary>
        public const string Y3G301 = "Y3G301";

        /// <summary>
        /// Y3G101.
        /// </summary>
        public const string Y3G101 = "Y3G101";

        /// <summary>
        /// Y3PHRW.
        /// </summary>
        public const string Y3PHRW = "Y3PHRW";

        /// <summary>
        /// Y3HMCO.
        /// </summary>
        public const string Y3HMCO = "Y3HMCO";

        /// <summary>
        /// Y3TAXX.
        /// </summary>
        public const string Y3TAXX = "Y3TAXX";

        /// <summary>
        /// Y3MATH01.
        /// </summary>
        public const string Y3MATH01 = "Y3MATH01";

        /// <summary>
        /// Y3MATH02.
        /// </summary>
        public const string Y3MATH02 = "Y3MATH02";

        /// <summary>
        /// Y3MATH03.
        /// </summary>
        public const string Y3MATH03 = "Y3MATH03";

        /// <summary>
        /// Y3MATH04.
        /// </summary>
        public const string Y3MATH04 = "Y3MATH04";

        /// <summary>
        /// Y3MATH05.
        /// </summary>
        public const string Y3MATH05 = "Y3MATH05";

        /// <summary>
        /// Y3TAXM01.
        /// </summary>
        public const string Y3TAXM01 = "Y3TAXM01";

        /// <summary>
        /// Y3TAXM02.
        /// </summary>
        public const string Y3TAXM02 = "Y3TAXM02";

        /// <summary>
        /// Y3UPMJ.
        /// </summary>
        public const string Y3UPMJ = "Y3UPMJ";

        /// <summary>
        /// Y3UPMT.
        /// </summary>
        public const string Y3UPMT = "Y3UPMT";

        /// <summary>
        /// Y3PID.
        /// </summary>
        public const string Y3PID = "Y3PID";

        /// <summary>
        /// Y3JOBN.
        /// </summary>
        public const string Y3JOBN = "Y3JOBN";

        /// <summary>
        /// Y3USER.
        /// </summary>
        public const string Y3USER = "Y3USER";
    }

    /// <inheritdoc />
    public override string TableName => "F0701734";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y3AN8", "Y3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3DTEY", "Y3DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3TARA", "Y3TARA", JdeDataType.String, 20, true, true),
        new JdeField("Y3PTAX", "Y3PTAX", JdeDataType.String, 4, true, true),
        new JdeField("Y3G301", "Y3G301", JdeDataType.Numeric),
        new JdeField("Y3G101", "Y3G101", JdeDataType.Numeric),
        new JdeField("Y3PHRW", "Y3PHRW", JdeDataType.Numeric),
        new JdeField("Y3HMCO", "Y3HMCO", JdeDataType.String, 10),
        new JdeField("Y3TAXX", "Y3TAXX", JdeDataType.String, 40),
        new JdeField("Y3MATH01", "Y3MATH01", JdeDataType.Numeric),
        new JdeField("Y3MATH02", "Y3MATH02", JdeDataType.Numeric),
        new JdeField("Y3MATH03", "Y3MATH03", JdeDataType.Numeric),
        new JdeField("Y3MATH04", "Y3MATH04", JdeDataType.Numeric),
        new JdeField("Y3MATH05", "Y3MATH05", JdeDataType.Numeric),
        new JdeField("Y3TAXM01", "Y3TAXM01", JdeDataType.String, 2),
        new JdeField("Y3TAXM02", "Y3TAXM02", JdeDataType.String, 2),
        new JdeField("Y3UPMJ", "Y3UPMJ", JdeDataType.Numeric),
        new JdeField("Y3UPMT", "Y3UPMT", JdeDataType.Numeric),
        new JdeField("Y3PID", "Y3PID", JdeDataType.String, 20),
        new JdeField("Y3JOBN", "Y3JOBN", JdeDataType.String, 20),
        new JdeField("Y3USER", "Y3USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701734_0", "Primary Key on Y3AN8, Y3DTEY, Y3TARA, Y3PTAX", new[] { "Y3AN8", "Y3DTEY", "Y3TARA", "Y3PTAX" }, isUnique: true, isPrimaryKey: true)
    };
}
