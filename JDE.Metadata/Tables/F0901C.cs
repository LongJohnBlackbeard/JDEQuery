using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0901C - .
/// </summary>
public class F0901C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMAID.
        /// </summary>
        public const string GMAID = "GMAID";

        /// <summary>
        /// GMR024.
        /// </summary>
        public const string GMR024 = "GMR024";

        /// <summary>
        /// GMR025.
        /// </summary>
        public const string GMR025 = "GMR025";

        /// <summary>
        /// GMR026.
        /// </summary>
        public const string GMR026 = "GMR026";

        /// <summary>
        /// GMR027.
        /// </summary>
        public const string GMR027 = "GMR027";

        /// <summary>
        /// GMR028.
        /// </summary>
        public const string GMR028 = "GMR028";

        /// <summary>
        /// GMR029.
        /// </summary>
        public const string GMR029 = "GMR029";

        /// <summary>
        /// GMR030.
        /// </summary>
        public const string GMR030 = "GMR030";

        /// <summary>
        /// GMR031.
        /// </summary>
        public const string GMR031 = "GMR031";

        /// <summary>
        /// GMR032.
        /// </summary>
        public const string GMR032 = "GMR032";

        /// <summary>
        /// GMR033.
        /// </summary>
        public const string GMR033 = "GMR033";

        /// <summary>
        /// GMR034.
        /// </summary>
        public const string GMR034 = "GMR034";

        /// <summary>
        /// GMR035.
        /// </summary>
        public const string GMR035 = "GMR035";

        /// <summary>
        /// GMR036.
        /// </summary>
        public const string GMR036 = "GMR036";

        /// <summary>
        /// GMR037.
        /// </summary>
        public const string GMR037 = "GMR037";

        /// <summary>
        /// GMR038.
        /// </summary>
        public const string GMR038 = "GMR038";

        /// <summary>
        /// GMR039.
        /// </summary>
        public const string GMR039 = "GMR039";

        /// <summary>
        /// GMR040.
        /// </summary>
        public const string GMR040 = "GMR040";

        /// <summary>
        /// GMR041.
        /// </summary>
        public const string GMR041 = "GMR041";

        /// <summary>
        /// GMR042.
        /// </summary>
        public const string GMR042 = "GMR042";

        /// <summary>
        /// GMR043.
        /// </summary>
        public const string GMR043 = "GMR043";
    }

    /// <inheritdoc />
    public override string TableName => "F0901C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMAID", "GMAID", JdeDataType.String, 16, true, true),
        new JdeField("GMR024", "GMR024", JdeDataType.String, 20),
        new JdeField("GMR025", "GMR025", JdeDataType.String, 20),
        new JdeField("GMR026", "GMR026", JdeDataType.String, 20),
        new JdeField("GMR027", "GMR027", JdeDataType.String, 20),
        new JdeField("GMR028", "GMR028", JdeDataType.String, 20),
        new JdeField("GMR029", "GMR029", JdeDataType.String, 20),
        new JdeField("GMR030", "GMR030", JdeDataType.String, 20),
        new JdeField("GMR031", "GMR031", JdeDataType.String, 20),
        new JdeField("GMR032", "GMR032", JdeDataType.String, 20),
        new JdeField("GMR033", "GMR033", JdeDataType.String, 20),
        new JdeField("GMR034", "GMR034", JdeDataType.String, 20),
        new JdeField("GMR035", "GMR035", JdeDataType.String, 20),
        new JdeField("GMR036", "GMR036", JdeDataType.String, 20),
        new JdeField("GMR037", "GMR037", JdeDataType.String, 20),
        new JdeField("GMR038", "GMR038", JdeDataType.String, 20),
        new JdeField("GMR039", "GMR039", JdeDataType.String, 20),
        new JdeField("GMR040", "GMR040", JdeDataType.String, 20),
        new JdeField("GMR041", "GMR041", JdeDataType.String, 20),
        new JdeField("GMR042", "GMR042", JdeDataType.String, 20),
        new JdeField("GMR043", "GMR043", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0901C_0", "Primary Key on GMAID", new[] { "GMAID" }, isUnique: true, isPrimaryKey: true)
    };
}
