using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08465 - .
/// </summary>
public class F08465 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VQPSTCAT.
        /// </summary>
        public const string VQPSTCAT = "VQPSTCAT";

        /// <summary>
        /// VQWZSTP.
        /// </summary>
        public const string VQWZSTP = "VQWZSTP";

        /// <summary>
        /// VQDATAI.
        /// </summary>
        public const string VQDATAI = "VQDATAI";

        /// <summary>
        /// VQRECAPP.
        /// </summary>
        public const string VQRECAPP = "VQRECAPP";

        /// <summary>
        /// VQMANHD.
        /// </summary>
        public const string VQMANHD = "VQMANHD";

        /// <summary>
        /// VQPID.
        /// </summary>
        public const string VQPID = "VQPID";

        /// <summary>
        /// VQUSER.
        /// </summary>
        public const string VQUSER = "VQUSER";

        /// <summary>
        /// VQMKEY.
        /// </summary>
        public const string VQMKEY = "VQMKEY";

        /// <summary>
        /// VQUPMJ.
        /// </summary>
        public const string VQUPMJ = "VQUPMJ";

        /// <summary>
        /// VQUPMT.
        /// </summary>
        public const string VQUPMT = "VQUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08465";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VQPSTCAT", "VQPSTCAT", JdeDataType.String, 20, true, true),
        new JdeField("VQWZSTP", "VQWZSTP", JdeDataType.String, 20, true, true),
        new JdeField("VQDATAI", "VQDATAI", JdeDataType.String, 20, true, true),
        new JdeField("VQRECAPP", "VQRECAPP", JdeDataType.String, 2),
        new JdeField("VQMANHD", "VQMANHD", JdeDataType.String, 2),
        new JdeField("VQPID", "VQPID", JdeDataType.String, 20),
        new JdeField("VQUSER", "VQUSER", JdeDataType.String, 20),
        new JdeField("VQMKEY", "VQMKEY", JdeDataType.String, 30),
        new JdeField("VQUPMJ", "VQUPMJ", JdeDataType.Numeric),
        new JdeField("VQUPMT", "VQUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08465_0", "Primary Key on VQPSTCAT, VQWZSTP, VQDATAI", new[] { "VQPSTCAT", "VQWZSTP", "VQDATAI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08465_2", "Index on VQPSTCAT, VQDATAI", new[] { "VQPSTCAT", "VQDATAI" })
    };
}
