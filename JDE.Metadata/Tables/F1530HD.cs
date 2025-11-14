using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1530HD - .
/// </summary>
public class F1530HD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDEPCL.
        /// </summary>
        public const string HDEPCL = "HDEPCL";

        /// <summary>
        /// HDLNGP.
        /// </summary>
        public const string HDLNGP = "HDLNGP";

        /// <summary>
        /// HDDL01.
        /// </summary>
        public const string HDDL01 = "HDDL01";

        /// <summary>
        /// HDUSER.
        /// </summary>
        public const string HDUSER = "HDUSER";

        /// <summary>
        /// HDPID.
        /// </summary>
        public const string HDPID = "HDPID";

        /// <summary>
        /// HDMKEY.
        /// </summary>
        public const string HDMKEY = "HDMKEY";

        /// <summary>
        /// HDUPMJ.
        /// </summary>
        public const string HDUPMJ = "HDUPMJ";

        /// <summary>
        /// HDUPMT.
        /// </summary>
        public const string HDUPMT = "HDUPMT";

        /// <summary>
        /// HDTORG.
        /// </summary>
        public const string HDTORG = "HDTORG";

        /// <summary>
        /// HDENTJ.
        /// </summary>
        public const string HDENTJ = "HDENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1530HD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDEPCL", "HDEPCL", JdeDataType.String, 8, true, true),
        new JdeField("HDLNGP", "HDLNGP", JdeDataType.String, 4, true, true),
        new JdeField("HDDL01", "HDDL01", JdeDataType.String, 60),
        new JdeField("HDUSER", "HDUSER", JdeDataType.String, 20),
        new JdeField("HDPID", "HDPID", JdeDataType.String, 20),
        new JdeField("HDMKEY", "HDMKEY", JdeDataType.String, 30),
        new JdeField("HDUPMJ", "HDUPMJ", JdeDataType.Numeric),
        new JdeField("HDUPMT", "HDUPMT", JdeDataType.Numeric),
        new JdeField("HDTORG", "HDTORG", JdeDataType.String, 20),
        new JdeField("HDENTJ", "HDENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1530HD_0", "Primary Key on HDEPCL, HDLNGP", new[] { "HDEPCL", "HDLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
