using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI014 - .
/// </summary>
public class F09UI014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBAID.
        /// </summary>
        public const string GBAID = "GBAID";

        /// <summary>
        /// GBMCU.
        /// </summary>
        public const string GBMCU = "GBMCU";

        /// <summary>
        /// GBOBJ.
        /// </summary>
        public const string GBOBJ = "GBOBJ";

        /// <summary>
        /// GBSUB.
        /// </summary>
        public const string GBSUB = "GBSUB";

        /// <summary>
        /// GBCO.
        /// </summary>
        public const string GBCO = "GBCO";

        /// <summary>
        /// GBCTRY.
        /// </summary>
        public const string GBCTRY = "GBCTRY";

        /// <summary>
        /// GBFY.
        /// </summary>
        public const string GBFY = "GBFY";

        /// <summary>
        /// GBLT.
        /// </summary>
        public const string GBLT = "GBLT";

        /// <summary>
        /// GBCRCX.
        /// </summary>
        public const string GBCRCX = "GBCRCX";

        /// <summary>
        /// GBAPYN.
        /// </summary>
        public const string GBAPYN = "GBAPYN";

        /// <summary>
        /// GBUSER.
        /// </summary>
        public const string GBUSER = "GBUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBAID", "GBAID", JdeDataType.String, 16, true, true),
        new JdeField("GBMCU", "GBMCU", JdeDataType.String, 24),
        new JdeField("GBOBJ", "GBOBJ", JdeDataType.String, 12),
        new JdeField("GBSUB", "GBSUB", JdeDataType.String, 16),
        new JdeField("GBCO", "GBCO", JdeDataType.String, 10),
        new JdeField("GBCTRY", "GBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("GBFY", "GBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("GBLT", "GBLT", JdeDataType.String, 4, true, true),
        new JdeField("GBCRCX", "GBCRCX", JdeDataType.String, 6),
        new JdeField("GBAPYN", "GBAPYN", JdeDataType.Numeric),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI014_0", "Primary Key on GBAID, GBCTRY, GBFY, GBLT", new[] { "GBAID", "GBCTRY", "GBFY", "GBLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09UI014_2", "Index on GBUSER", new[] { "GBUSER" })
    };
}
