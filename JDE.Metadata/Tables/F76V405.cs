using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V405 - .
/// </summary>
public class F76V405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// POV76FOCP.
        /// </summary>
        public const string POV76FOCP = "POV76FOCP";

        /// <summary>
        /// POV76FOCD.
        /// </summary>
        public const string POV76FOCD = "POV76FOCD";

        /// <summary>
        /// POSEQ.
        /// </summary>
        public const string POSEQ = "POSEQ";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";

        /// <summary>
        /// POUPMT.
        /// </summary>
        public const string POUPMT = "POUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POV76FOCP", "POV76FOCP", JdeDataType.String, 8, true, true),
        new JdeField("POV76FOCD", "POV76FOCD", JdeDataType.String, 200),
        new JdeField("POSEQ", "POSEQ", JdeDataType.Numeric),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric),
        new JdeField("POUPMT", "POUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V405_0", "Primary Key on POV76FOCP", new[] { "POV76FOCP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76V405_2", "Index on POSEQ", new[] { "POSEQ" })
    };
}
