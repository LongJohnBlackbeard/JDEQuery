using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34R014 - .
/// </summary>
public class FF34R014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTCCHN.
        /// </summary>
        public const string RTCCHN = "RTCCHN";

        /// <summary>
        /// RTLNID.
        /// </summary>
        public const string RTLNID = "RTLNID";

        /// <summary>
        /// RTRNAME.
        /// </summary>
        public const string RTRNAME = "RTRNAME";

        /// <summary>
        /// RTPRNA.
        /// </summary>
        public const string RTPRNA = "RTPRNA";

        /// <summary>
        /// RTSHFT.
        /// </summary>
        public const string RTSHFT = "RTSHFT";

        /// <summary>
        /// RTRSRTIM.
        /// </summary>
        public const string RTRSRTIM = "RTRSRTIM";

        /// <summary>
        /// RTRSATIM.
        /// </summary>
        public const string RTRSATIM = "RTRSATIM";

        /// <summary>
        /// RTRMPERU.
        /// </summary>
        public const string RTRMPERU = "RTRMPERU";

        /// <summary>
        /// RTRMAQTY.
        /// </summary>
        public const string RTRMAQTY = "RTRMAQTY";

        /// <summary>
        /// RTRMRQTY.
        /// </summary>
        public const string RTRMRQTY = "RTRMRQTY";

        /// <summary>
        /// RTREUTYP.
        /// </summary>
        public const string RTREUTYP = "RTREUTYP";

        /// <summary>
        /// RTCELLN.
        /// </summary>
        public const string RTCELLN = "RTCELLN";
    }

    /// <inheritdoc />
    public override string TableName => "FF34R014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTCCHN", "RTCCHN", JdeDataType.String, 90, true, true),
        new JdeField("RTLNID", "RTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTRNAME", "RTRNAME", JdeDataType.String, 50),
        new JdeField("RTPRNA", "RTPRNA", JdeDataType.String, 60),
        new JdeField("RTSHFT", "RTSHFT", JdeDataType.String, 2),
        new JdeField("RTRSRTIM", "RTRSRTIM", JdeDataType.Numeric),
        new JdeField("RTRSATIM", "RTRSATIM", JdeDataType.Numeric),
        new JdeField("RTRMPERU", "RTRMPERU", JdeDataType.Numeric),
        new JdeField("RTRMAQTY", "RTRMAQTY", JdeDataType.Numeric),
        new JdeField("RTRMRQTY", "RTRMRQTY", JdeDataType.Numeric),
        new JdeField("RTREUTYP", "RTREUTYP", JdeDataType.Numeric),
        new JdeField("RTCELLN", "RTCELLN", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34R014_0", "Primary Key on RTCCHN, RTLNID", new[] { "RTCCHN", "RTLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34R014_2", "Index on RTSHFT", new[] { "RTSHFT" }),
        new JdeIndex("FF34R014_3", "Index on RTSHFT, RTPRNA, RTCELLN", new[] { "RTSHFT", "RTPRNA", "RTCELLN" })
    };
}
