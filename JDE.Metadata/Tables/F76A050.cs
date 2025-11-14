using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A050 - .
/// </summary>
public class F76A050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCA013.
        /// </summary>
        public const string SCA013 = "SCA013";

        /// <summary>
        /// SCEFTJ.
        /// </summary>
        public const string SCEFTJ = "SCEFTJ";

        /// <summary>
        /// SCA76AIAL.
        /// </summary>
        public const string SCA76AIAL = "SCA76AIAL";

        /// <summary>
        /// SCA76IUPL.
        /// </summary>
        public const string SCA76IUPL = "SCA76IUPL";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCA013", "SCA013", JdeDataType.String, 6, true, true),
        new JdeField("SCEFTJ", "SCEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SCA76AIAL", "SCA76AIAL", JdeDataType.Numeric),
        new JdeField("SCA76IUPL", "SCA76IUPL", JdeDataType.Numeric),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A050_0", "Primary Key on SCA013, SCEFTJ", new[] { "SCA013", "SCEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A050_2", "Index on SCA013, SYS_NC00010$", new[] { "SCA013", "SYS_NC00010$" })
    };
}
