using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B038 - .
/// </summary>
public class F76B038 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARBNNF.
        /// </summary>
        public const string ARBNNF = "ARBNNF";

        /// <summary>
        /// ARBSER.
        /// </summary>
        public const string ARBSER = "ARBSER";

        /// <summary>
        /// ARN001.
        /// </summary>
        public const string ARN001 = "ARN001";

        /// <summary>
        /// ARDCT.
        /// </summary>
        public const string ARDCT = "ARDCT";

        /// <summary>
        /// ARB76APID.
        /// </summary>
        public const string ARB76APID = "ARB76APID";

        /// <summary>
        /// ARB76URAB.
        /// </summary>
        public const string ARB76URAB = "ARB76URAB";

        /// <summary>
        /// ARB76URAT.
        /// </summary>
        public const string ARB76URAT = "ARB76URAT";

        /// <summary>
        /// ARB76URRF.
        /// </summary>
        public const string ARB76URRF = "ARB76URRF";

        /// <summary>
        /// ARB76URDT.
        /// </summary>
        public const string ARB76URDT = "ARB76URDT";

        /// <summary>
        /// ARB76URCD.
        /// </summary>
        public const string ARB76URCD = "ARB76URCD";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARUPMT.
        /// </summary>
        public const string ARUPMT = "ARUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B038";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARBNNF", "ARBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("ARBSER", "ARBSER", JdeDataType.String, 4, true, true),
        new JdeField("ARN001", "ARN001", JdeDataType.Numeric, null, true, true),
        new JdeField("ARDCT", "ARDCT", JdeDataType.String, 4, true, true),
        new JdeField("ARB76APID", "ARB76APID", JdeDataType.String, 80, true, true),
        new JdeField("ARB76URAB", "ARB76URAB", JdeDataType.Numeric),
        new JdeField("ARB76URAT", "ARB76URAT", JdeDataType.Numeric),
        new JdeField("ARB76URRF", "ARB76URRF", JdeDataType.String, 30),
        new JdeField("ARB76URDT", "ARB76URDT", JdeDataType.Numeric),
        new JdeField("ARB76URCD", "ARB76URCD", JdeDataType.String, 4),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B038_0", "Primary Key on ARBNNF, ARBSER, ARN001, ARDCT, ARB76APID", new[] { "ARBNNF", "ARBSER", "ARN001", "ARDCT", "ARB76APID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B038_2", "Index on ARB76APID", new[] { "ARB76APID" })
    };
}
