using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B20 - .
/// </summary>
public class F31B20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCWCOST.
        /// </summary>
        public const string CCWCOST = "CCWCOST";

        /// <summary>
        /// CCWDSC1.
        /// </summary>
        public const string CCWDSC1 = "CCWDSC1";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCWCOST", "CCWCOST", JdeDataType.String, 24, true, true),
        new JdeField("CCWDSC1", "CCWDSC1", JdeDataType.String, 60),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B20_0", "Primary Key on CCWCOST", new[] { "CCWCOST" }, isUnique: true, isPrimaryKey: true)
    };
}
