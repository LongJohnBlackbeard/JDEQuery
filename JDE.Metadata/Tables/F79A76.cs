using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A76 - .
/// </summary>
public class F79A76 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBMCU.
        /// </summary>
        public const string GBMCU = "GBMCU";

        /// <summary>
        /// GBBEFD.
        /// </summary>
        public const string GBBEFD = "GBBEFD";

        /// <summary>
        /// GBEEFD.
        /// </summary>
        public const string GBEEFD = "GBEEFD";

        /// <summary>
        /// GB79AGOID.
        /// </summary>
        public const string GB79AGOID = "GB79AGOID";

        /// <summary>
        /// GB79AANZ.
        /// </summary>
        public const string GB79AANZ = "GB79AANZ";

        /// <summary>
        /// GBUSER.
        /// </summary>
        public const string GBUSER = "GBUSER";

        /// <summary>
        /// GBPID.
        /// </summary>
        public const string GBPID = "GBPID";

        /// <summary>
        /// GBJOBN.
        /// </summary>
        public const string GBJOBN = "GBJOBN";

        /// <summary>
        /// GBUPMJ.
        /// </summary>
        public const string GBUPMJ = "GBUPMJ";

        /// <summary>
        /// GBUPMT.
        /// </summary>
        public const string GBUPMT = "GBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A76";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBMCU", "GBMCU", JdeDataType.String, 24, true, true),
        new JdeField("GBBEFD", "GBBEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("GBEEFD", "GBEEFD", JdeDataType.Numeric),
        new JdeField("GB79AGOID", "GB79AGOID", JdeDataType.Numeric),
        new JdeField("GB79AANZ", "GB79AANZ", JdeDataType.String, 12),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20),
        new JdeField("GBPID", "GBPID", JdeDataType.String, 20),
        new JdeField("GBJOBN", "GBJOBN", JdeDataType.String, 20),
        new JdeField("GBUPMJ", "GBUPMJ", JdeDataType.Numeric),
        new JdeField("GBUPMT", "GBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A76_0", "Primary Key on GBMCU, GBBEFD", new[] { "GBMCU", "GBBEFD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A76_2", "Index on GB79AGOID, GBMCU, GBBEFD", new[] { "GB79AGOID", "GBMCU", "GBBEFD" }),
        new JdeIndex("F79A76_3", "Index on GB79AANZ", new[] { "GB79AANZ" }),
        new JdeIndex("F79A76_4", "Index on GBMCU, GBBEFD, GBEEFD", new[] { "GBMCU", "GBBEFD", "GBEEFD" })
    };
}
