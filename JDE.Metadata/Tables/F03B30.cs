using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B30 - .
/// </summary>
public class F03B30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZIAIT.
        /// </summary>
        public const string ZIAIT = "ZIAIT";

        /// <summary>
        /// ZIDL01.
        /// </summary>
        public const string ZIDL01 = "ZIDL01";

        /// <summary>
        /// ZIAIPR.
        /// </summary>
        public const string ZIAIPR = "ZIAIPR";

        /// <summary>
        /// ZICLPA.
        /// </summary>
        public const string ZICLPA = "ZICLPA";

        /// <summary>
        /// ZIUSER.
        /// </summary>
        public const string ZIUSER = "ZIUSER";

        /// <summary>
        /// ZIPID.
        /// </summary>
        public const string ZIPID = "ZIPID";

        /// <summary>
        /// ZIUPMJ.
        /// </summary>
        public const string ZIUPMJ = "ZIUPMJ";

        /// <summary>
        /// ZIUPMT.
        /// </summary>
        public const string ZIUPMT = "ZIUPMT";

        /// <summary>
        /// ZIJOBN.
        /// </summary>
        public const string ZIJOBN = "ZIJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZIAIT", "ZIAIT", JdeDataType.String, 4, true, true),
        new JdeField("ZIDL01", "ZIDL01", JdeDataType.String, 60),
        new JdeField("ZIAIPR", "ZIAIPR", JdeDataType.String, 2),
        new JdeField("ZICLPA", "ZICLPA", JdeDataType.String, 2),
        new JdeField("ZIUSER", "ZIUSER", JdeDataType.String, 20),
        new JdeField("ZIPID", "ZIPID", JdeDataType.String, 20),
        new JdeField("ZIUPMJ", "ZIUPMJ", JdeDataType.Numeric),
        new JdeField("ZIUPMT", "ZIUPMT", JdeDataType.Numeric),
        new JdeField("ZIJOBN", "ZIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B30_0", "Primary Key on ZIAIT", new[] { "ZIAIT" }, isUnique: true, isPrimaryKey: true)
    };
}
