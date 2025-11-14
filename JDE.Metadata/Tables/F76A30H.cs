using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A30H - .
/// </summary>
public class F76A30H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V6EDUS.
        /// </summary>
        public const string V6EDUS = "V6EDUS";

        /// <summary>
        /// V6EDBT.
        /// </summary>
        public const string V6EDBT = "V6EDBT";

        /// <summary>
        /// V6EDTN.
        /// </summary>
        public const string V6EDTN = "V6EDTN";

        /// <summary>
        /// V6ACAI.
        /// </summary>
        public const string V6ACAI = "V6ACAI";

        /// <summary>
        /// V6AFCD.
        /// </summary>
        public const string V6AFCD = "V6AFCD";

        /// <summary>
        /// V6AFFE.
        /// </summary>
        public const string V6AFFE = "V6AFFE";

        /// <summary>
        /// V6AFAT.
        /// </summary>
        public const string V6AFAT = "V6AFAT";

        /// <summary>
        /// V6VR01.
        /// </summary>
        public const string V6VR01 = "V6VR01";

        /// <summary>
        /// V6ALTT.
        /// </summary>
        public const string V6ALTT = "V6ALTT";

        /// <summary>
        /// V6ALTU.
        /// </summary>
        public const string V6ALTU = "V6ALTU";

        /// <summary>
        /// V6ALTV.
        /// </summary>
        public const string V6ALTV = "V6ALTV";
    }

    /// <inheritdoc />
    public override string TableName => "F76A30H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V6EDUS", "V6EDUS", JdeDataType.String, 20, true, true),
        new JdeField("V6EDBT", "V6EDBT", JdeDataType.String, 30, true, true),
        new JdeField("V6EDTN", "V6EDTN", JdeDataType.String, 44, true, true),
        new JdeField("V6ACAI", "V6ACAI", JdeDataType.String, 28),
        new JdeField("V6AFCD", "V6AFCD", JdeDataType.String, 20),
        new JdeField("V6AFFE", "V6AFFE", JdeDataType.Numeric),
        new JdeField("V6AFAT", "V6AFAT", JdeDataType.Numeric),
        new JdeField("V6VR01", "V6VR01", JdeDataType.String, 50),
        new JdeField("V6ALTT", "V6ALTT", JdeDataType.String, 2),
        new JdeField("V6ALTU", "V6ALTU", JdeDataType.String, 2),
        new JdeField("V6ALTV", "V6ALTV", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A30H_0", "Primary Key on V6EDUS, V6EDBT, V6EDTN", new[] { "V6EDUS", "V6EDBT", "V6EDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
