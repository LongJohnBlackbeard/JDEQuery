using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F050611 - .
/// </summary>
public class F050611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// URURLKID.
        /// </summary>
        public const string URURLKID = "URURLKID";

        /// <summary>
        /// URLANG.
        /// </summary>
        public const string URLANG = "URLANG";

        /// <summary>
        /// URURLG.
        /// </summary>
        public const string URURLG = "URURLG";

        /// <summary>
        /// URURLDISP.
        /// </summary>
        public const string URURLDISP = "URURLDISP";

        /// <summary>
        /// URURLTXT.
        /// </summary>
        public const string URURLTXT = "URURLTXT";

        /// <summary>
        /// URPTURL.
        /// </summary>
        public const string URPTURL = "URPTURL";

        /// <summary>
        /// URUSER.
        /// </summary>
        public const string URUSER = "URUSER";

        /// <summary>
        /// URPID.
        /// </summary>
        public const string URPID = "URPID";

        /// <summary>
        /// URJOBN.
        /// </summary>
        public const string URJOBN = "URJOBN";

        /// <summary>
        /// URUPMJ.
        /// </summary>
        public const string URUPMJ = "URUPMJ";

        /// <summary>
        /// URUPMT.
        /// </summary>
        public const string URUPMT = "URUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F050611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("URURLKID", "URURLKID", JdeDataType.String, 24, true, true),
        new JdeField("URLANG", "URLANG", JdeDataType.String, 4, true, true),
        new JdeField("URURLG", "URURLG", JdeDataType.String, 6),
        new JdeField("URURLDISP", "URURLDISP", JdeDataType.String, 510),
        new JdeField("URURLTXT", "URURLTXT", JdeDataType.String, 300),
        new JdeField("URPTURL", "URPTURL", JdeDataType.String, 512),
        new JdeField("URUSER", "URUSER", JdeDataType.String, 20),
        new JdeField("URPID", "URPID", JdeDataType.String, 20),
        new JdeField("URJOBN", "URJOBN", JdeDataType.String, 20),
        new JdeField("URUPMJ", "URUPMJ", JdeDataType.Numeric),
        new JdeField("URUPMT", "URUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F050611_0", "Primary Key on URURLKID, URLANG", new[] { "URURLKID", "URLANG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F050611_3", "Unique Index on URLANG, URURLDISP", new[] { "URLANG", "URURLDISP" }, isUnique: true)
    };
}
