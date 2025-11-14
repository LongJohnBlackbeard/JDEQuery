using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3037 - .
/// </summary>
public class F74R3037 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARKCO.
        /// </summary>
        public const string ARKCO = "ARKCO";

        /// <summary>
        /// ARDCT.
        /// </summary>
        public const string ARDCT = "ARDCT";

        /// <summary>
        /// ARDOC.
        /// </summary>
        public const string ARDOC = "ARDOC";

        /// <summary>
        /// AROKCO.
        /// </summary>
        public const string AROKCO = "AROKCO";

        /// <summary>
        /// ARODCT.
        /// </summary>
        public const string ARODCT = "ARODCT";

        /// <summary>
        /// ARODOC.
        /// </summary>
        public const string ARODOC = "ARODOC";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

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
    public override string TableName => "F74R3037";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARKCO", "ARKCO", JdeDataType.String, 10, true, true),
        new JdeField("ARDCT", "ARDCT", JdeDataType.String, 4, true, true),
        new JdeField("ARDOC", "ARDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AROKCO", "AROKCO", JdeDataType.String, 10),
        new JdeField("ARODCT", "ARODCT", JdeDataType.String, 4),
        new JdeField("ARODOC", "ARODOC", JdeDataType.Numeric),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3037_0", "Primary Key on ARKCO, ARDCT, ARDOC", new[] { "ARKCO", "ARDCT", "ARDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R3037_2", "Index on AROKCO, ARODCT, ARODOC", new[] { "AROKCO", "ARODCT", "ARODOC" })
    };
}
