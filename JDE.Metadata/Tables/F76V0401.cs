using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V0401 - .
/// </summary>
public class F76V0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RECO.
        /// </summary>
        public const string RECO = "RECO";

        /// <summary>
        /// REDOC.
        /// </summary>
        public const string REDOC = "REDOC";

        /// <summary>
        /// REDCT.
        /// </summary>
        public const string REDCT = "REDCT";

        /// <summary>
        /// RESFX.
        /// </summary>
        public const string RESFX = "RESFX";

        /// <summary>
        /// REAN8.
        /// </summary>
        public const string REAN8 = "REAN8";

        /// <summary>
        /// REKY.
        /// </summary>
        public const string REKY = "REKY";

        /// <summary>
        /// REAA03.
        /// </summary>
        public const string REAA03 = "REAA03";

        /// <summary>
        /// REAA10.
        /// </summary>
        public const string REAA10 = "REAA10";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REUPMJ.
        /// </summary>
        public const string REUPMJ = "REUPMJ";

        /// <summary>
        /// REUPMT.
        /// </summary>
        public const string REUPMT = "REUPMT";

        /// <summary>
        /// REJOBN.
        /// </summary>
        public const string REJOBN = "REJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76V0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RECO", "RECO", JdeDataType.String, 10, true, true),
        new JdeField("REDOC", "REDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("REDCT", "REDCT", JdeDataType.String, 4, true, true),
        new JdeField("RESFX", "RESFX", JdeDataType.String, 6, true, true),
        new JdeField("REAN8", "REAN8", JdeDataType.Numeric),
        new JdeField("REKY", "REKY", JdeDataType.String, 20),
        new JdeField("REAA03", "REAA03", JdeDataType.String, 6),
        new JdeField("REAA10", "REAA10", JdeDataType.String, 20),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REUPMJ", "REUPMJ", JdeDataType.Numeric),
        new JdeField("REUPMT", "REUPMT", JdeDataType.Numeric),
        new JdeField("REJOBN", "REJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V0401_0", "Primary Key on RECO, REDCT, REDOC, RESFX", new[] { "RECO", "REDCT", "REDOC", "RESFX" }, isUnique: true, isPrimaryKey: true)
    };
}
