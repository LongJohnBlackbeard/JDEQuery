using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C1202 - .
/// </summary>
public class F76C1202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADCO.
        /// </summary>
        public const string ADCO = "ADCO";

        /// <summary>
        /// ADAMCU.
        /// </summary>
        public const string ADAMCU = "ADAMCU";

        /// <summary>
        /// ADAOBJ.
        /// </summary>
        public const string ADAOBJ = "ADAOBJ";

        /// <summary>
        /// ADASUB.
        /// </summary>
        public const string ADASUB = "ADASUB";

        /// <summary>
        /// ADMCU.
        /// </summary>
        public const string ADMCU = "ADMCU";

        /// <summary>
        /// ADOBJ.
        /// </summary>
        public const string ADOBJ = "ADOBJ";

        /// <summary>
        /// ADSUB.
        /// </summary>
        public const string ADSUB = "ADSUB";

        /// <summary>
        /// ADMCU2.
        /// </summary>
        public const string ADMCU2 = "ADMCU2";

        /// <summary>
        /// ADDOBJ.
        /// </summary>
        public const string ADDOBJ = "ADDOBJ";

        /// <summary>
        /// ADDSUB.
        /// </summary>
        public const string ADDSUB = "ADDSUB";
    }

    /// <inheritdoc />
    public override string TableName => "F76C1202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADCO", "ADCO", JdeDataType.String, 10, true, true),
        new JdeField("ADAMCU", "ADAMCU", JdeDataType.String, 24, true, true),
        new JdeField("ADAOBJ", "ADAOBJ", JdeDataType.String, 12, true, true),
        new JdeField("ADASUB", "ADASUB", JdeDataType.String, 16, true, true),
        new JdeField("ADMCU", "ADMCU", JdeDataType.String, 24),
        new JdeField("ADOBJ", "ADOBJ", JdeDataType.String, 12),
        new JdeField("ADSUB", "ADSUB", JdeDataType.String, 16),
        new JdeField("ADMCU2", "ADMCU2", JdeDataType.String, 24),
        new JdeField("ADDOBJ", "ADDOBJ", JdeDataType.String, 12),
        new JdeField("ADDSUB", "ADDSUB", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C1202_0", "Primary Key on ADCO, ADAMCU, ADAOBJ, ADASUB", new[] { "ADCO", "ADAMCU", "ADAOBJ", "ADASUB" }, isUnique: true, isPrimaryKey: true)
    };
}
