using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F092181 - .
/// </summary>
public class F092181 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRN001.
        /// </summary>
        public const string LRN001 = "LRN001";

        /// <summary>
        /// LROBJ.
        /// </summary>
        public const string LROBJ = "LROBJ";

        /// <summary>
        /// LRSUB.
        /// </summary>
        public const string LRSUB = "LRSUB";

        /// <summary>
        /// LRMCU.
        /// </summary>
        public const string LRMCU = "LRMCU";

        /// <summary>
        /// LRMDL1.
        /// </summary>
        public const string LRMDL1 = "LRMDL1";

        /// <summary>
        /// LRAID.
        /// </summary>
        public const string LRAID = "LRAID";

        /// <summary>
        /// LRDL01.
        /// </summary>
        public const string LRDL01 = "LRDL01";

        /// <summary>
        /// LRLDA.
        /// </summary>
        public const string LRLDA = "LRLDA";

        /// <summary>
        /// LRPEC.
        /// </summary>
        public const string LRPEC = "LRPEC";

        /// <summary>
        /// LRALA.
        /// </summary>
        public const string LRALA = "LRALA";

        /// <summary>
        /// LRAAD.
        /// </summary>
        public const string LRAAD = "LRAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F092181";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRN001", "LRN001", JdeDataType.Numeric, null, true, true),
        new JdeField("LROBJ", "LROBJ", JdeDataType.String, 12, true, true),
        new JdeField("LRSUB", "LRSUB", JdeDataType.String, 16, true, true),
        new JdeField("LRMCU", "LRMCU", JdeDataType.String, 24, true, true),
        new JdeField("LRMDL1", "LRMDL1", JdeDataType.String, 60),
        new JdeField("LRAID", "LRAID", JdeDataType.String, 16),
        new JdeField("LRDL01", "LRDL01", JdeDataType.String, 60),
        new JdeField("LRLDA", "LRLDA", JdeDataType.String, 2),
        new JdeField("LRPEC", "LRPEC", JdeDataType.String, 2),
        new JdeField("LRALA", "LRALA", JdeDataType.String, 20),
        new JdeField("LRAAD", "LRAAD", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F092181_0", "Primary Key on LRN001, LROBJ, LRSUB, LRMCU", new[] { "LRN001", "LROBJ", "LRSUB", "LRMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F092181_2", "Index on LRN001, LRMCU", new[] { "LRN001", "LRMCU" })
    };
}
