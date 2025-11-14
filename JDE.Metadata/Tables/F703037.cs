using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F703037 - .
/// </summary>
public class F703037 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CIKCO.
        /// </summary>
        public const string CIKCO = "CIKCO";

        /// <summary>
        /// CIDCT.
        /// </summary>
        public const string CIDCT = "CIDCT";

        /// <summary>
        /// CIDOC.
        /// </summary>
        public const string CIDOC = "CIDOC";

        /// <summary>
        /// CIAN8.
        /// </summary>
        public const string CIAN8 = "CIAN8";

        /// <summary>
        /// CIALPH.
        /// </summary>
        public const string CIALPH = "CIALPH";

        /// <summary>
        /// CIMLNM.
        /// </summary>
        public const string CIMLNM = "CIMLNM";

        /// <summary>
        /// CINICK.
        /// </summary>
        public const string CINICK = "CINICK";

        /// <summary>
        /// CIATTL.
        /// </summary>
        public const string CIATTL = "CIATTL";

        /// <summary>
        /// CIREM1.
        /// </summary>
        public const string CIREM1 = "CIREM1";

        /// <summary>
        /// CIFUCO.
        /// </summary>
        public const string CIFUCO = "CIFUCO";

        /// <summary>
        /// CIEMAL.
        /// </summary>
        public const string CIEMAL = "CIEMAL";

        /// <summary>
        /// CIAR1.
        /// </summary>
        public const string CIAR1 = "CIAR1";

        /// <summary>
        /// CIPH1.
        /// </summary>
        public const string CIPH1 = "CIPH1";
    }

    /// <inheritdoc />
    public override string TableName => "F703037";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CIKCO", "CIKCO", JdeDataType.String, 10, true, true),
        new JdeField("CIDCT", "CIDCT", JdeDataType.String, 4, true, true),
        new JdeField("CIDOC", "CIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CIAN8", "CIAN8", JdeDataType.Numeric),
        new JdeField("CIALPH", "CIALPH", JdeDataType.String, 80),
        new JdeField("CIMLNM", "CIMLNM", JdeDataType.String, 80),
        new JdeField("CINICK", "CINICK", JdeDataType.String, 80),
        new JdeField("CIATTL", "CIATTL", JdeDataType.String, 80),
        new JdeField("CIREM1", "CIREM1", JdeDataType.String, 80),
        new JdeField("CIFUCO", "CIFUCO", JdeDataType.String, 20),
        new JdeField("CIEMAL", "CIEMAL", JdeDataType.String, 512),
        new JdeField("CIAR1", "CIAR1", JdeDataType.String, 12),
        new JdeField("CIPH1", "CIPH1", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F703037_0", "Primary Key on CIKCO, CIDCT, CIDOC", new[] { "CIKCO", "CIDCT", "CIDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
