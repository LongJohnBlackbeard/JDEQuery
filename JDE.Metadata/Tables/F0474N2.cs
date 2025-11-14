using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0474N2 - .
/// </summary>
public class F0474N2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDWNEN.
        /// </summary>
        public const string QDWNEN = "QDWNEN";

        /// <summary>
        /// QDWNDI.
        /// </summary>
        public const string QDWNDI = "QDWNDI";

        /// <summary>
        /// QDWNDA.
        /// </summary>
        public const string QDWNDA = "QDWNDA";

        /// <summary>
        /// QDWNCN.
        /// </summary>
        public const string QDWNCN = "QDWNCN";

        /// <summary>
        /// QDWNDP.
        /// </summary>
        public const string QDWNDP = "QDWNDP";

        /// <summary>
        /// QDWNP1.
        /// </summary>
        public const string QDWNP1 = "QDWNP1";

        /// <summary>
        /// QDWNP2.
        /// </summary>
        public const string QDWNP2 = "QDWNP2";

        /// <summary>
        /// QDWNOP.
        /// </summary>
        public const string QDWNOP = "QDWNOP";

        /// <summary>
        /// QDWNS0.
        /// </summary>
        public const string QDWNS0 = "QDWNS0";

        /// <summary>
        /// QDWNS1.
        /// </summary>
        public const string QDWNS1 = "QDWNS1";

        /// <summary>
        /// QDWNS2.
        /// </summary>
        public const string QDWNS2 = "QDWNS2";

        /// <summary>
        /// QDWNS3.
        /// </summary>
        public const string QDWNS3 = "QDWNS3";

        /// <summary>
        /// QDWNA1.
        /// </summary>
        public const string QDWNA1 = "QDWNA1";

        /// <summary>
        /// QDWNA2.
        /// </summary>
        public const string QDWNA2 = "QDWNA2";

        /// <summary>
        /// QDWNA3.
        /// </summary>
        public const string QDWNA3 = "QDWNA3";

        /// <summary>
        /// QDWNA4.
        /// </summary>
        public const string QDWNA4 = "QDWNA4";

        /// <summary>
        /// QDWNA5.
        /// </summary>
        public const string QDWNA5 = "QDWNA5";

        /// <summary>
        /// QDWNA6.
        /// </summary>
        public const string QDWNA6 = "QDWNA6";

        /// <summary>
        /// QDWNS4.
        /// </summary>
        public const string QDWNS4 = "QDWNS4";

        /// <summary>
        /// QDWNS5.
        /// </summary>
        public const string QDWNS5 = "QDWNS5";

        /// <summary>
        /// QDWNS6.
        /// </summary>
        public const string QDWNS6 = "QDWNS6";

        /// <summary>
        /// QDWNS7.
        /// </summary>
        public const string QDWNS7 = "QDWNS7";
    }

    /// <inheritdoc />
    public override string TableName => "F0474N2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDWNEN", "QDWNEN", JdeDataType.Numeric, null, true, true),
        new JdeField("QDWNDI", "QDWNDI", JdeDataType.String, 22, true, true),
        new JdeField("QDWNDA", "QDWNDA", JdeDataType.Numeric),
        new JdeField("QDWNCN", "QDWNCN", JdeDataType.Numeric),
        new JdeField("QDWNDP", "QDWNDP", JdeDataType.Numeric),
        new JdeField("QDWNP1", "QDWNP1", JdeDataType.String, 20),
        new JdeField("QDWNP2", "QDWNP2", JdeDataType.String, 20),
        new JdeField("QDWNOP", "QDWNOP", JdeDataType.String, 22),
        new JdeField("QDWNS0", "QDWNS0", JdeDataType.String, 2),
        new JdeField("QDWNS1", "QDWNS1", JdeDataType.Numeric),
        new JdeField("QDWNS2", "QDWNS2", JdeDataType.String, 40),
        new JdeField("QDWNS3", "QDWNS3", JdeDataType.String, 2),
        new JdeField("QDWNA1", "QDWNA1", JdeDataType.String, 2),
        new JdeField("QDWNA2", "QDWNA2", JdeDataType.Numeric),
        new JdeField("QDWNA3", "QDWNA3", JdeDataType.Numeric),
        new JdeField("QDWNA4", "QDWNA4", JdeDataType.Numeric),
        new JdeField("QDWNA5", "QDWNA5", JdeDataType.String, 10),
        new JdeField("QDWNA6", "QDWNA6", JdeDataType.Numeric),
        new JdeField("QDWNS4", "QDWNS4", JdeDataType.String, 8),
        new JdeField("QDWNS5", "QDWNS5", JdeDataType.String, 2),
        new JdeField("QDWNS6", "QDWNS6", JdeDataType.String, 2),
        new JdeField("QDWNS7", "QDWNS7", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0474N2_0", "Primary Key on QDWNEN, QDWNDI", new[] { "QDWNEN", "QDWNDI" }, isUnique: true, isPrimaryKey: true)
    };
}
