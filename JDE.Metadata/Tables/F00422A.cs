using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00422A - .
/// </summary>
public class F00422A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VRBASISC.
        /// </summary>
        public const string VRBASISC = "VRBASISC";

        /// <summary>
        /// VRBASISVS.
        /// </summary>
        public const string VRBASISVS = "VRBASISVS";

        /// <summary>
        /// VRBASISVN.
        /// </summary>
        public const string VRBASISVN = "VRBASISVN";

        /// <summary>
        /// VRSEQLN.
        /// </summary>
        public const string VRSEQLN = "VRSEQLN";

        /// <summary>
        /// VRDESTC.
        /// </summary>
        public const string VRDESTC = "VRDESTC";

        /// <summary>
        /// VRDESTVS.
        /// </summary>
        public const string VRDESTVS = "VRDESTVS";

        /// <summary>
        /// VRDESTVN.
        /// </summary>
        public const string VRDESTVN = "VRDESTVN";

        /// <summary>
        /// VRASOD.
        /// </summary>
        public const string VRASOD = "VRASOD";

        /// <summary>
        /// VRBASIST.
        /// </summary>
        public const string VRBASIST = "VRBASIST";

        /// <summary>
        /// VRENFORCE.
        /// </summary>
        public const string VRENFORCE = "VRENFORCE";
    }

    /// <inheritdoc />
    public override string TableName => "F00422A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VRBASISC", "VRBASISC", JdeDataType.String, 30, true, true),
        new JdeField("VRBASISVS", "VRBASISVS", JdeDataType.String, 80, true, true),
        new JdeField("VRBASISVN", "VRBASISVN", JdeDataType.Numeric, null, true, true),
        new JdeField("VRSEQLN", "VRSEQLN", JdeDataType.Numeric),
        new JdeField("VRDESTC", "VRDESTC", JdeDataType.String, 30, true, true),
        new JdeField("VRDESTVS", "VRDESTVS", JdeDataType.String, 80, true, true),
        new JdeField("VRDESTVN", "VRDESTVN", JdeDataType.Numeric, null, true, true),
        new JdeField("VRASOD", "VRASOD", JdeDataType.Numeric, null, true, true),
        new JdeField("VRBASIST", "VRBASIST", JdeDataType.String, 30),
        new JdeField("VRENFORCE", "VRENFORCE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00422A_0", "Primary Key on VRBASISC, VRBASISVS, VRBASISVN, VRDESTC, VRDESTVS, VRDESTVN, VRASOD", new[] { "VRBASISC", "VRBASISVS", "VRBASISVN", "VRDESTC", "VRDESTVS", "VRDESTVN", "VRASOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00422A_2", "Unique Index on VRBASISC, VRBASISVS, VRBASISVN, VRSEQLN", new[] { "VRBASISC", "VRBASISVS", "VRBASISVN", "VRSEQLN" }, isUnique: true),
        new JdeIndex("F00422A_3", "Index on VRDESTC", new[] { "VRDESTC" }),
        new JdeIndex("F00422A_4", "Index on VRBASIST", new[] { "VRBASIST" })
    };
}
