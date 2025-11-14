using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01315 - .
/// </summary>
public class F01315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCINDID.
        /// </summary>
        public const string CCINDID = "CCINDID";

        /// <summary>
        /// CCINDIDTY.
        /// </summary>
        public const string CCINDIDTY = "CCINDIDTY";

        /// <summary>
        /// CCCALTY.
        /// </summary>
        public const string CCCALTY = "CCCALTY";

        /// <summary>
        /// CCLINDID.
        /// </summary>
        public const string CCLINDID = "CCLINDID";

        /// <summary>
        /// CCLINDIDTY.
        /// </summary>
        public const string CCLINDIDTY = "CCLINDIDTY";

        /// <summary>
        /// CCLCALTY.
        /// </summary>
        public const string CCLCALTY = "CCLCALTY";

        /// <summary>
        /// CCLEFFDT.
        /// </summary>
        public const string CCLEFFDT = "CCLEFFDT";

        /// <summary>
        /// CCLEXPDT.
        /// </summary>
        public const string CCLEXPDT = "CCLEXPDT";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCIDAN8.
        /// </summary>
        public const string CCIDAN8 = "CCIDAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F01315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCINDID", "CCINDID", JdeDataType.String, 32, true, true),
        new JdeField("CCINDIDTY", "CCINDIDTY", JdeDataType.String, 100, true, true),
        new JdeField("CCCALTY", "CCCALTY", JdeDataType.String, 100, true, true),
        new JdeField("CCLINDID", "CCLINDID", JdeDataType.String, 32, true, true),
        new JdeField("CCLINDIDTY", "CCLINDIDTY", JdeDataType.String, 100, true, true),
        new JdeField("CCLCALTY", "CCLCALTY", JdeDataType.String, 100, true, true),
        new JdeField("CCLEFFDT", "CCLEFFDT", JdeDataType.Date, null, true, true),
        new JdeField("CCLEXPDT", "CCLEXPDT", JdeDataType.Date),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCIDAN8", "CCIDAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01315_0", "Primary Key on CCINDID, CCINDIDTY, CCCALTY, CCLINDID, CCLINDIDTY, CCLCALTY, CCLEFFDT", new[] { "CCINDID", "CCINDIDTY", "CCCALTY", "CCLINDID", "CCLINDIDTY", "CCLCALTY", "CCLEFFDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01315_2", "Index on CCINDID, CCINDIDTY, CCCALTY", new[] { "CCINDID", "CCINDIDTY", "CCCALTY" }),
        new JdeIndex("F01315_3", "Index on CCLINDID, CCLINDIDTY, CCLCALTY", new[] { "CCLINDID", "CCLINDIDTY", "CCLCALTY" })
    };
}
