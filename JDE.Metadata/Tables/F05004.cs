using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05004 - .
/// </summary>
public class F05004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCDTAI.
        /// </summary>
        public const string SCDTAI = "SCDTAI";

        /// <summary>
        /// SCMEOW.
        /// </summary>
        public const string SCMEOW = "SCMEOW";

        /// <summary>
        /// SCDELPER01.
        /// </summary>
        public const string SCDELPER01 = "SCDELPER01";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F05004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCDTAI", "SCDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SCMEOW", "SCMEOW", JdeDataType.String, 2),
        new JdeField("SCDELPER01", "SCDELPER01", JdeDataType.String, 2),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05004_0", "Primary Key on SCDTAI", new[] { "SCDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
