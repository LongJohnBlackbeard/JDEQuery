using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F703B11 - .
/// </summary>
public class F703B11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARDOC.
        /// </summary>
        public const string ARDOC = "ARDOC";

        /// <summary>
        /// ARKCO.
        /// </summary>
        public const string ARKCO = "ARKCO";

        /// <summary>
        /// ARDCT.
        /// </summary>
        public const string ARDCT = "ARDCT";

        /// <summary>
        /// ARK70IT.
        /// </summary>
        public const string ARK70IT = "ARK70IT";

        /// <summary>
        /// ARK70SER.
        /// </summary>
        public const string ARK70SER = "ARK70SER";

        /// <summary>
        /// ARK70ENUM.
        /// </summary>
        public const string ARK70ENUM = "ARK70ENUM";

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
        /// ARTDAY.
        /// </summary>
        public const string ARTDAY = "ARTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F703B11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARDOC", "ARDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ARKCO", "ARKCO", JdeDataType.String, 10, true, true),
        new JdeField("ARDCT", "ARDCT", JdeDataType.String, 4, true, true),
        new JdeField("ARK70IT", "ARK70IT", JdeDataType.String, 4),
        new JdeField("ARK70SER", "ARK70SER", JdeDataType.String, 40),
        new JdeField("ARK70ENUM", "ARK70ENUM", JdeDataType.String, 72),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARTDAY", "ARTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F703B11_0", "Primary Key on ARDOC, ARDCT, ARKCO", new[] { "ARDOC", "ARDCT", "ARKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
