using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A003 - .
/// </summary>
public class F76A003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGCO.
        /// </summary>
        public const string RGCO = "RGCO";

        /// <summary>
        /// RGADGI.
        /// </summary>
        public const string RGADGI = "RGADGI";

        /// <summary>
        /// RGACEM.
        /// </summary>
        public const string RGACEM = "RGACEM";

        /// <summary>
        /// RGACAI.
        /// </summary>
        public const string RGACAI = "RGACAI";

        /// <summary>
        /// RGEFTJ.
        /// </summary>
        public const string RGEFTJ = "RGEFTJ";

        /// <summary>
        /// RGEFDJ.
        /// </summary>
        public const string RGEFDJ = "RGEFDJ";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGTDAY.
        /// </summary>
        public const string RGTDAY = "RGTDAY";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGADGI1.
        /// </summary>
        public const string RGADGI1 = "RGADGI1";

        /// <summary>
        /// RGACEM1.
        /// </summary>
        public const string RGACEM1 = "RGACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGCO", "RGCO", JdeDataType.String, 10, true, true),
        new JdeField("RGADGI", "RGADGI", JdeDataType.String, 4, true, true),
        new JdeField("RGACEM", "RGACEM", JdeDataType.String, 8, true, true),
        new JdeField("RGACAI", "RGACAI", JdeDataType.String, 28, true, true),
        new JdeField("RGEFTJ", "RGEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RGEFDJ", "RGEFDJ", JdeDataType.Numeric),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGTDAY", "RGTDAY", JdeDataType.Numeric),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGADGI1", "RGADGI1", JdeDataType.String, 20, true, true),
        new JdeField("RGACEM1", "RGACEM1", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A003_0", "Primary Key on RGCO, RGADGI1, RGACEM1, RGACAI, RGEFTJ, RGADGI, RGACEM", new[] { "RGCO", "RGADGI1", "RGACEM1", "RGACAI", "RGEFTJ", "RGADGI", "RGACEM" }, isUnique: true, isPrimaryKey: true)
    };
}
