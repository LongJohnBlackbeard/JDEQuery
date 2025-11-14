using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4030 - .
/// </summary>
public class F76V4030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VWCO.
        /// </summary>
        public const string VWCO = "VWCO";

        /// <summary>
        /// VWV76VATW.
        /// </summary>
        public const string VWV76VATW = "VWV76VATW";

        /// <summary>
        /// VWEFTJ.
        /// </summary>
        public const string VWEFTJ = "VWEFTJ";

        /// <summary>
        /// VWEFDJ.
        /// </summary>
        public const string VWEFDJ = "VWEFDJ";

        /// <summary>
        /// VWV76VPER.
        /// </summary>
        public const string VWV76VPER = "VWV76VPER";

        /// <summary>
        /// VWV76VMIN.
        /// </summary>
        public const string VWV76VMIN = "VWV76VMIN";

        /// <summary>
        /// VWV76LCON.
        /// </summary>
        public const string VWV76LCON = "VWV76LCON";

        /// <summary>
        /// VWRP1.
        /// </summary>
        public const string VWRP1 = "VWRP1";

        /// <summary>
        /// VWUSER.
        /// </summary>
        public const string VWUSER = "VWUSER";

        /// <summary>
        /// VWPID.
        /// </summary>
        public const string VWPID = "VWPID";

        /// <summary>
        /// VWJOBN.
        /// </summary>
        public const string VWJOBN = "VWJOBN";

        /// <summary>
        /// VWUPMJ.
        /// </summary>
        public const string VWUPMJ = "VWUPMJ";

        /// <summary>
        /// VWUPMT.
        /// </summary>
        public const string VWUPMT = "VWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VWCO", "VWCO", JdeDataType.String, 10, true, true),
        new JdeField("VWV76VATW", "VWV76VATW", JdeDataType.String, 6, true, true),
        new JdeField("VWEFTJ", "VWEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VWEFDJ", "VWEFDJ", JdeDataType.Numeric),
        new JdeField("VWV76VPER", "VWV76VPER", JdeDataType.Numeric),
        new JdeField("VWV76VMIN", "VWV76VMIN", JdeDataType.Numeric),
        new JdeField("VWV76LCON", "VWV76LCON", JdeDataType.String, 6),
        new JdeField("VWRP1", "VWRP1", JdeDataType.String, 2),
        new JdeField("VWUSER", "VWUSER", JdeDataType.String, 20),
        new JdeField("VWPID", "VWPID", JdeDataType.String, 20),
        new JdeField("VWJOBN", "VWJOBN", JdeDataType.String, 20),
        new JdeField("VWUPMJ", "VWUPMJ", JdeDataType.Numeric),
        new JdeField("VWUPMT", "VWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4030_0", "Primary Key on VWCO, VWV76VATW, VWEFTJ", new[] { "VWCO", "VWV76VATW", "VWEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
