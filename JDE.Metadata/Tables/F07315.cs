using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07315 - .
/// </summary>
public class F07315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSLRSEGID.
        /// </summary>
        public const string GSLRSEGID = "GSLRSEGID";

        /// <summary>
        /// GSINDID.
        /// </summary>
        public const string GSINDID = "GSINDID";

        /// <summary>
        /// GSINDIDTY.
        /// </summary>
        public const string GSINDIDTY = "GSINDIDTY";

        /// <summary>
        /// GSCALTY.
        /// </summary>
        public const string GSCALTY = "GSCALTY";

        /// <summary>
        /// GSSFP.
        /// </summary>
        public const string GSSFP = "GSSFP";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";

        /// <summary>
        /// GSMKEY.
        /// </summary>
        public const string GSMKEY = "GSMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F07315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSLRSEGID", "GSLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("GSINDID", "GSINDID", JdeDataType.String, 32, true, true),
        new JdeField("GSINDIDTY", "GSINDIDTY", JdeDataType.String, 100, true, true),
        new JdeField("GSCALTY", "GSCALTY", JdeDataType.String, 100, true, true),
        new JdeField("GSSFP", "GSSFP", JdeDataType.String, 2),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSMKEY", "GSMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07315_0", "Primary Key on GSLRSEGID, GSINDID, GSINDIDTY, GSCALTY", new[] { "GSLRSEGID", "GSINDID", "GSINDIDTY", "GSCALTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07315_2", "Index on GSINDID, GSINDIDTY, GSCALTY", new[] { "GSINDID", "GSINDIDTY", "GSCALTY" }),
        new JdeIndex("F07315_3", "Index on SYS_NC00011$", new[] { "SYS_NC00011$" })
    };
}
