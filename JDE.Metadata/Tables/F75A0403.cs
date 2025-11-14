using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0403 - .
/// </summary>
public class F75A0403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZGAUSPTCGI.
        /// </summary>
        public const string ZGAUSPTCGI = "ZGAUSPTCGI";

        /// <summary>
        /// ZGAUSPTCGD.
        /// </summary>
        public const string ZGAUSPTCGD = "ZGAUSPTCGD";

        /// <summary>
        /// ZGAUSPTDGE.
        /// </summary>
        public const string ZGAUSPTDGE = "ZGAUSPTDGE";

        /// <summary>
        /// ZGUSER.
        /// </summary>
        public const string ZGUSER = "ZGUSER";

        /// <summary>
        /// ZGPID.
        /// </summary>
        public const string ZGPID = "ZGPID";

        /// <summary>
        /// ZGUPMJ.
        /// </summary>
        public const string ZGUPMJ = "ZGUPMJ";

        /// <summary>
        /// ZGUPMT.
        /// </summary>
        public const string ZGUPMT = "ZGUPMT";

        /// <summary>
        /// ZGJOBN.
        /// </summary>
        public const string ZGJOBN = "ZGJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZGAUSPTCGI", "ZGAUSPTCGI", JdeDataType.String, 16, true, true),
        new JdeField("ZGAUSPTCGD", "ZGAUSPTCGD", JdeDataType.String, 80),
        new JdeField("ZGAUSPTDGE", "ZGAUSPTDGE", JdeDataType.String, 10),
        new JdeField("ZGUSER", "ZGUSER", JdeDataType.String, 20),
        new JdeField("ZGPID", "ZGPID", JdeDataType.String, 20),
        new JdeField("ZGUPMJ", "ZGUPMJ", JdeDataType.Numeric),
        new JdeField("ZGUPMT", "ZGUPMT", JdeDataType.Numeric),
        new JdeField("ZGJOBN", "ZGJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0403_0", "Primary Key on ZGAUSPTCGI", new[] { "ZGAUSPTCGI" }, isUnique: true, isPrimaryKey: true)
    };
}
